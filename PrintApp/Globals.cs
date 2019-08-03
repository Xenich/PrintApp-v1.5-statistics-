using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Data.OleDb;
using System.Threading;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;

namespace PrintApp
{
    class Globals
    {
        public static string pathToBD=Application.StartupPath +"\\DataBase.mdb";
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + pathToBD;
        //public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.mdb";
        public static int namePositionX;
        public static int namePositionY;
        public static int numPositionX;
        public static int numPositionY;
        public static int actPositionX;
        public static int actPositionY;
        public static int shifrPositionX;
        public static int shifrPositionY;
        public static int enginePositionX;
        public static int enginePositionY;
                // шрифты
        public static Font simpleFont =     new Font("Arial", 12);
        public static Font underlinedFont = new Font("Arial", 12, FontStyle.Underline);
        public static Font boldedFont =     new Font("Arial", 12, FontStyle.Bold);
                // шапка
        //public static int countOfActs=0;
        public static string engine;
        public static string shifr;
                                                  // Словарь с доделочными актами
        public static Dictionary<int, Technology> dictQwewe = new Dictionary<int, Technology>();    
        public static int counterOfTechs=0;       // будет использоваться в качестве ключа в словаре
            // словарь: номер детали - техпроцесс ремонта,   
        public static Dictionary<string, BaseTechnology> numberToBaseTech;       
            // словарь со стандартными фразами
        public static Dictionary<int, Node> dictStandartPhrases;
            // словарь с оснасткой
        public static Dictionary<int, Node> dictOsnastka;
            // список со стандартными наименованиями операций
        public static Dictionary<int, string> namesOfOperation;
            // словарь с конусами
        public static Dictionary<string, Cone> coneToConeObject;
            // Список с покрытиями
        public static List<string> cover;
            // словарь ОСТ самоконтр. гайки - Тип
        public static Dictionary<string, int> OSTtoTypeNut = new Dictionary<string, int>();
                                   // контролы
        public static DataGridView Grid;          // dataGridViewListOfDetails - список технологий на форме, инициализируется в Form1
        public static TextBox TxtBoxEngine;
        public static TextBox TxtBoxShifr;
        public static Label labelCountOfActs;
        public static string fileName="";               // имя файла сохранения
        public static MemoryMappedFile sharedMemory;    // участок разделяемой памяти

            // метод, добавляющий технологию в грид и словарь технологий
        public static void AddTechnology(Technology tech)
        {
            dictQwewe.Add(Globals.counterOfTechs, tech);
            Grid.Rows.Add(Globals.counterOfTechs,tech.act, tech.num, tech.name, tech.engine, tech.shifr, "Удалить", "Редактировать","Дублировать", true);        
            labelCountOfActs.Text = "Кол-во д/а - " + Globals.dictQwewe.Count;
            counterOfTechs++;
        }
            // метод, добавляющий список технологй в грид и словарь технологий
        public static void AddTechnology(Dictionary<int, Technology> dict)
        {
            ICollection<int> keys = dict.Keys;
            foreach (int key in keys)
            {
                AddTechnology(dict[key]);
            }
        }

        /// <summary>
        /// Метод, формирует слесарную операцию, контроль ЛЮМ1-ОВ или магнитный контроль
        /// </summary>
        /// <param name="listOfOperations">Список операций в технологии</param>
        /// <param name="textBoxMyText">свой текст в слесарке</param>
        /// <param name="LUM">наличие ЛЮМа</param>
        /// <param name="magnit">наличие магнитного контроля</param>
        /// <param name="name">имя детали</param>
        public static void FormSlesarkaMagnitLum(List<Operation> listOfOperations, TextBox textBoxMyText, bool LUM, bool magnit, string name)
        {
            Operation slesarka = new Operation("Слесарная");
            List<string> sles = new List<string>() { "ИОТ-36.255-2014" };
            List<string> myText = textBoxMyText.Lines.ToList<string>();   // считываем отдельно строки с текстбокса со своим текстом слесарки
            string[] slesOsnastka = new string[] { "Надфиль", "80№4", "Шлиф. шкурка", "14AF1000/5C1" };
            slesarka.osnastka = slesOsnastka;
            if (LUM)
            {
                sles.AddRange(myText);
                if (name.Contains("Болт") || name.Contains("Винт"))
                    sles.Add("Подготовка под ЛЮМ1-ОВ");

                string[] slesText = sles.ToArray();
                slesarka.text = slesText;
                listOfOperations.Add(slesarka); //new Operation("Слесарная", new string[] { "ИОТ-36.255-2014", "1. Удалить налёт, коррозию.", "2. Зачистить забоины, заусенцы", "3. Подготовка под ЛЮМ1-ОВ" }, new string[] { "Надфиль", "80№4", "Шлиф. шкурка", "14AF1000/5C1" }));
                listOfOperations.Add(new Operation("Моечная"));
                listOfOperations.Add(new Operation("Контрольная ЛЮМ1-ОВ"));
            }
            else
            {
                if (magnit)
                {
                    sles.AddRange(myText);
                    string[] slesText = sles.ToArray();
                    slesarka.text = slesText;
                    listOfOperations.Add(slesarka);
                    listOfOperations.Add(new Operation("Моечная"));
                    listOfOperations.Add(new Operation("Контроль магнитопорошковый"));
                }
                else
                {
                    sles.AddRange(myText);
                    string[] slesText = sles.ToArray();
                    slesarka.text = slesText;
                    listOfOperations.Add(slesarka);
                }
            }
        }

        //*************************************************************************************************************************************************************************************

            // загрузка контекстменюшек в ContextMenuStrip cms, который привязан к текстбоксу textBox из определённого словаря со структурой: int,Node
        public static void ContextMenuLoad(ContextMenuStrip cms, Dictionary<int, Node> dic, TextBox textBox)
        {
            ICollection<int> keys = dic.Keys;
            List<ToolStripMenuItem> parentToolStripMenuItems = new List<ToolStripMenuItem>();   // список с родительскими айтемами
            Dictionary<int, List<ToolStripMenuItem>> dictStripMenuItems = new Dictionary<int, List<ToolStripMenuItem>>();           // словарь: айтем- его дочерние айтемы
            Dictionary<int, ToolStripMenuItem> dictIntStripMenuItems = new Dictionary<int, ToolStripMenuItem>();                    // словарь: айди-айтем

            foreach (int key in keys)
            {
                int parentID = dic[key].parentID;
                ToolStripMenuItem item = new ToolStripMenuItem(dic[key].text, null, null, key.ToString());
                dictStripMenuItems.Add(key, new List<ToolStripMenuItem>());
                dictIntStripMenuItems.Add(key, item);
                if (parentID == 0)
                    parentToolStripMenuItems.Add(item);
            }

            foreach (int key in keys)
            {
                int parentID = dic[key].parentID;
                if (dic[key].parentID != 0)
                    dictStripMenuItems[parentID].Add(dictIntStripMenuItems[key]);
            }
            cms.Items.AddRange(parentToolStripMenuItems.ToArray());
            foreach (int key in dictStripMenuItems.Keys)
            {
                if (dictStripMenuItems[key].Count != 0)
                {
                    dictIntStripMenuItems[key].DropDownItems.AddRange(dictStripMenuItems[key].ToArray());
                }
            }

            foreach (ToolStripMenuItem i in cms.Items)
            {
                recurs(i, textBox);
            }
                //предыдущий работающий вариант
            /*      
              ICollection<int> keys = dic.Keys;
            Dictionary<int, ToolStripMenuItem> dictStripMenuItems = new Dictionary<int, ToolStripMenuItem>();
            foreach (int key in keys)
            {
                dictStripMenuItems.Add(key, new ToolStripMenuItem(dic[key].text, null, null, key.ToString()));
            }

            foreach (int key in keys)
            {
                int parentID = dic[key].parentID;
                if (parentID == 0)
                    cms.Items.Add(dictStripMenuItems[key]);
                else
                    dictStripMenuItems[parentID].DropDownItems.Add(dictStripMenuItems[key]);
            }
            foreach (ToolStripMenuItem i in cms.Items)
            {
                recurs(i, textBox);
            }
             */
        }

        // рекурсивное заполнение айтемов событиями
        private static void recurs(ToolStripMenuItem i, TextBox textBox)
        {
            if (!i.HasDropDownItems)
            {
                i.Tag = textBox;
                i.Click += new EventHandler(click);
            }
            else
            {
                foreach (ToolStripMenuItem t in i.DropDownItems)
                {
                    recurs(t, textBox);
                }
            }
        }

        private static void click(object sender, EventArgs e)
        {           
            TextBox senderBox = (TextBox)(((ToolStripMenuItem)sender).Tag);
            senderBox.AppendText(((ToolStripMenuItem)sender).Text);
            senderBox.Focus();
        }
    }
}