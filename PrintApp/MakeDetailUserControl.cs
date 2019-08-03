using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PrintApp
{
    public partial class MakeDetailUserControl : UserControl
    {
        ContextMenuStrip contextMenuStripPhrases;   // стандартные фразы
        private string name;
        private string num;
        private string act;
        private bool nagar;
        private bool deformedPlaces;
        private bool magnit;
        private bool LUM;
        private bool pritirka;
        private bool gidro;
        private string myTextSles;            // свой текст в слесарке
        private string myTextKontrol;         
        //private int ID;                     // ID детали в базе
        //private int pokritieID;             // ID покрытия в базе
        //private int[] coneID;               // массив с ID конуса в базе (будем заносить в таблицу Shtuzer)
        private ComboBox[] comboShtuzer;      // массив комбобоксов штуцеров
        private Dictionary<string, int> CoverToID   = new Dictionary<string, int>();      // словарь покрытие - ID
        //private Dictionary<string, int> ShtuzerToID = new Dictionary<string, int>();      // словарь КонусШтуцера - ID
        private Dictionary<Cone, int> coneToID = new Dictionary<Cone, int>();             // словарь КонусШтуцера - ID
        private int shtuzNum;                 // количество штуцеров, если они есть
        private TextBox textBoxEngine;
        private TextBox textBoxShifr;

        public MakeDetailUserControl(TextBox textBoxEngine,TextBox textBoxShifr)
        {
            InitializeComponent();
            contextMenuStripPhrases = new ContextMenuStrip();
            textBoxMyTextSles.ContextMenuStrip = contextMenuStripPhrases;
            this.textBoxEngine = textBoxEngine;
            this.textBoxShifr = textBoxShifr;
        }

        private void MakeDetailUserControl_Load(object sender, EventArgs e)
        {
            Globals.ContextMenuLoad(contextMenuStripPhrases, Globals.dictStandartPhrases, textBoxMyTextSles);
            textBoxEngine.Enabled = true;
            textBoxShifr.Enabled = true;
            string query  = "SELECT ID, ShortName FROM Cover ORDER BY ID";
            OleDbConnection connection = new OleDbConnection(Globals.connectionString);
            OleDbCommand cmd  = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader datareader  = cmd.ExecuteReader();
            while (datareader.Read())
            {
                CoverToID.Add(datareader[1].ToString(), (int)datareader[0]);     // заполняем словарь (покрытие, ID) 
            }
            datareader.Close();
            connection.Close();

            comboBoxCover.Items.AddRange(CoverToID.Keys.ToArray());
            comboBoxCover.SelectedIndex = 0;
            comboShtuzer    = new ComboBox[1];  // создаём первый комбобокс с штуцером. потом по необходимости будут создаваться остальные
            comboShtuzer[0] = new ComboBox();
            panelShtuzers.Controls.Add(comboShtuzer[0]);
            comboShtuzer[0].Items.AddRange(Globals.coneToConeObject.Keys.ToArray());
                        
            comboShtuzer[0].Width = 317;
            comboShtuzer[0].DropDownWidth = 570;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            num = textBoxDetNum.Text;
            if (name == "" || num == "")
            {
                MessageBox.Show("Введите номер и наименование детали");
                return;
            }
            List<Operation> listOfOperations = GetListOfOperations();
            BaseTechnology tech = new BaseTechnology(name, num, listOfOperations);
            tech.SaveToDB();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            num = textBoxDetNum.Text;
            act = textBoxAct.Text;
            if (name == "" || num == "")
            {
                MessageBox.Show("Введите номер и наименование детали");
                return;
            }
            List<Operation> listOfOperations = GetListOfOperations();
            Technology tech = new Technology(name, num, act, Globals.TxtBoxEngine.Text, Globals.TxtBoxShifr.Text, listOfOperations);
            Globals.AddTechnology(tech);
        }

        private List<Operation> GetListOfOperations()
        {
            myTextSles = textBoxMyTextSles.Text;
            myTextKontrol = textBoxControl.Text;
            nagar = checkBoxNagar.Checked;
            deformedPlaces = checkBoxDeform.Checked;
            magnit = checkBoxMagnit.Checked;
            LUM = checkBoxLUM.Checked;
            pritirka = checkBoxPritirka.Checked;
            gidro = checkBoxGidro.Checked;
            //pokritieID = (CoverToID[comboBoxCover.SelectedItem.ToString()] == 1) ? 0 : CoverToID[comboBoxCover.SelectedItem.ToString()];      // если "без покрытия", то записываем ноль в поле *Покрытие* в базе
            // пошёл техпроцесс
            List<Operation> listOfOperations = new List<Operation>();
            listOfOperations.Add(new Operation("Дефектация", new string[] { "Визуальный контроль на соответствие чертежу", "и отсутствие внешних дефектов" }));
            if (nagar)
            {
                listOfOperations.Add(new Operation("Удаление нагара"));
            }
            if (LUM && (comboBoxCover.SelectedItem.ToString().Contains("Ср") || comboBoxCover.SelectedItem.ToString().Contains("ср") || comboBoxCover.SelectedItem.ToString().Contains("еребрение")))
            {
                listOfOperations.Add(new Operation("Распокрытие"));
            }

            if (deformedPlaces)
            {
                listOfOperations.Add(new Operation("Фрезерная", new string[] { "ИОТ-36.258-2014", "Вырезать деформированные места согласно чертежу." }));
            }

            Globals.FormSlesarkaMagnitLum(listOfOperations, textBoxMyTextSles, LUM, magnit, name);            // формируем слесарку, ЛЮМ, магнитный

            if (pritirka)
            {
                string otpechatok = "";
                string width = "";

                List<string> osnastka = new List<string>();
                osnastka.Add("Установка"); osnastka.Add("У6872-1334");
                for (int i = 0; i < panelShtuzers.Controls.Count; i++)
                {
                    if (((ComboBox)panelShtuzers.Controls[i]).SelectedItem != null)
                    {
                        Cone cone = Globals.coneToConeObject[((ComboBox)panelShtuzers.Controls[i]).SelectedItem.ToString()];
                        string pritir = cone.pritir;
                        string kalibr = cone.kalibr;
                        if (!osnastka.Contains(pritir))
                        {
                            osnastka.Add("Притир");
                            osnastka.Add(pritir);
                        }
                        if (!osnastka.Contains(kalibr))
                        {
                            osnastka.Add("Калибр");
                            osnastka.Add(kalibr);
                            otpechatok += cone.otpechatok + "; ";
                            width += (cone.width == "" ? "--" : cone.width) + "; ";
                        }
                    }
                }
                osnastka.Add("Шкурка шлиф."); osnastka.Add("14AF1000/5C1"); osnastka.Add("Эталон"); osnastka.Add("У6367-00-9270"); osnastka.Add("Лазурь железная");
                listOfOperations.Add(new Operation("Притирка конуса", new string[] {"ИОТ-36.256-2014",
                                                                                            "1. Притереть конусную поверхность",
                                                                                            "2. Выполнить проверку конусной поверхности:",
                                                                                            "а) равномерно, по всей окружности калибра нанести слой краски для калибров до просвечивания металла;",
                                                                                            "Толщину нанесённого слоя определять путём сопоставления цветов краски на калибре и эталоне.",
                                                                                            "Приготовление и нанесение - по инструкции 26/75Т.",
                                                                                            "б) сохраняя соосность пары конус штуцера - калибр, провернуть калибр вокруг его оси на угол 5°...10° 2...3 раза, прижимая калибр к конусу штуцера",
                                                                                            "Т.Т.: отпечаток должен быть в виде кольца без разрыва, иметь равномерную ширину, располагаться в пределах пояса контакта, огранчиченного разностью размеров от торца: "
                                                                                            + otpechatok, "Ширина отпечатка: " + width }
                                                                    , osnastka.ToArray()));
            }
            if (gidro)
                listOfOperations.Add(new Operation("Гидроиспытание"));
            if (comboBoxCover.SelectedIndex != 0)     // нулевой индекс - Без покрытия
                listOfOperations.Add(new Operation("Покрытие", new string[] { comboBoxCover.SelectedItem.ToString() }));
            listOfOperations.Add(new Operation("Контрольная", new string[] { myTextKontrol }));
            return listOfOperations;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            shtuzNum = (int)numericUpDown1.Value;
            comboShtuzer = new ComboBox[shtuzNum];
            panelShtuzers.Controls.Clear();
            for (int i = 0; i < shtuzNum; i++)
            {
                comboShtuzer[i] = new ComboBox();
                panelShtuzers.Controls.Add(comboShtuzer[i]);
                comboShtuzer[i].Items.AddRange(Globals.coneToConeObject.Keys.ToArray());

                comboShtuzer[i].Width = 317; 
                comboShtuzer[i].DropDownWidth = 570;
                if (i != 0)
                    comboShtuzer[i].Top = comboShtuzer[i - 1].Top + comboShtuzer[i - 1].Height+5;
                panelDown.Top = groupBoxPritirka.Top + groupBoxPritirka.Height + 10;
            }
        }

        private void MakeDetailUserControl_VisibleChanged(object sender, EventArgs e)
        {
            textBoxEngine.Enabled = true;
            textBoxShifr.Enabled = true;
        }

        private void checkBoxPritirka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPritirka.Checked)            
                groupBoxPritirka.Enabled = true;            
            else
                groupBoxPritirka.Enabled = false;
        }
    }
}
