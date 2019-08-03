using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.OleDb;
using System.Xml.Serialization;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;

namespace PrintApp
{
    public partial class Form1 : Form
    {
        int counter = 0;
        private int indexSelected;      // выбраный номер технологии в словаре при нажатии грида
        private enum format {A3,A4,A5};
        private format f;
        private List<Technology> techListToPrint;

        public Form1()
        {
            Constructor();
        }
        public Form1(TechList Tlist)
        {
            Constructor();
            foreach (Technology tech in Tlist.list)
            {
                Globals.AddTechnology(tech);
            }
        }

        private void Constructor()
        {
            InitializeComponent();
            Globals.Grid = dataGridViewListOfDetails;       // инициализация системного грида
            Globals.TxtBoxEngine = textBoxEngine;
            Globals.TxtBoxShifr = textBoxShifr;
            Globals.labelCountOfActs = labelCountOfActs;
            labelPathToDB.Text = "База данных:  " + Globals.pathToBD;
                // загружаем словарь с конусами
            Globals.coneToConeObject = Cone.LoadConesFromDB();
                // загружаем стандартные фразы, наименования операций, оснастку
            DictionariesLoad();
        }




        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //dlgPageSetup.PageSettings.Landscape = false;
            //dlgPageSetup.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A5", (int)(100 * 149 / 25.4), (int)(100 * 210 / 25.4));
            //System.Drawing.Printing.PaperSize ps = new System.Drawing.Printing.PaperSize("A5", (int)(100 * 149 / 25.4), (int)(100 * 210 / 25.4));      
            //printDocument.Print();        //вызывает наступление события PrintPage у printDocument. Сначала вызывает единственный раз OnBeginPrint, потом - OnPrintPage для каждой страницы.
        }

            /// печать 
        private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics; 
            //Technology[] tech = Globals.dictQwewe.Values.ToArray();     // получаем все техпроцессы из словаря и впихиваем их в массив
            int count = Globals.dictQwewe.Count;

            if (f == format.A5)
            {
                DrawAndCheckEmpty(g, count, 0, 0);
                if (counter < count)
                {
                    e.HasMorePages = true;          // после завершения метода OnPrintPage он вызовется ещё раз автоматически
                    return;
                }
                e.HasMorePages = false;             // после завершения метода OnPrintPage он не будет вызываться
                counter = 0;
            }

            if (f == format.A4)
            {
                for (int i = 1; i < 3; i++)
                {
                    switch (i)
                    {
                        case 1:
                            DrawAndCheckEmpty(g, count, 0, 0);
                            break;
                        case 2:
                            DrawAndCheckEmpty(g, count, 580, 0);
                            break;
                    }               
                }
                if (counter < count)
                {
                    e.HasMorePages = true;      // после завершения метода OnPrintPage он вызовется ещё раз автоматически
                    return;
                }
                e.HasMorePages = false;         // после завершения метода OnPrintPage он не будет вызываться
                counter = 0;
            }

            if (f == format.A3)
            {
                for (int i = 1; i < 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            DrawAndCheckEmpty(g, count, 0, 0);
                            break;
                        case 2:
                            DrawAndCheckEmpty(g, count, 0, 820);
                            break;
                        case 3:
                            DrawAndCheckEmpty(g, count, 580, 0);
                            break;
                        case 4:
                            DrawAndCheckEmpty(g, count, 580, 820);
                            break;
                    }                        
                }
                if (counter < count)
                {
                    e.HasMorePages = true;      // после завершения метода OnPrintPage он вызовется ещё раз автоматически
                    return;
                }
                e.HasMorePages = false;     // после завершения метода OnPrintPage он не будет вызываться
                counter = 0;
            }

          /*  Предыдущий работающий вариант         
            if (f == format.A5)
            {
                if (counter < tech.Length)
                {
                    tech[counter].Draw(g,0,0);
                    counter++;
                    if (counter < tech.Length)
                    {
                        e.HasMorePages = true;      // после завершения метода OnPrintPage он вызовется ещё раз автоматически
                        return;
                    }
                }
                e.HasMorePages = false;     // после завершения метода OnPrintPage он не будет вызываться
                counter = 0;
            }

            if (f == format.A4)
            {
                for (int i = 1; i < 3; i++)
                {
                    if (counter < tech.Length)
                    {
                        switch (i)
                        {
                            case 1:
                                tech[counter].Draw(g, 0, 0);
                                counter++;
                                break;
                            case 2:
                                tech[counter].Draw(g, 600, 0);
                                counter++;
                                break;                           
                        }
                    }
                }
                if (counter < tech.Length)
                {
                    e.HasMorePages = true;      // после завершения метода OnPrintPage он вызовется ещё раз автоматически
                    return;
                }
                e.HasMorePages = false;         // после завершения метода OnPrintPage он не будет вызываться
                counter = 0;
            }

            if (f == format.A3)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (counter < tech.Length)
                    {
                        switch (i)
                        {
                            case 1:                              
                                tech[counter].Draw(g,0,0);
                                counter++;
                                break;
                            case 2:
                                tech[counter].Draw(g, 0, 820);
                                counter++;
                                break;
                            case 3:
                                tech[counter].Draw(g, 590, 0);
                                counter++;
                                break;
                            case 4:
                                tech[counter].Draw(g, 590, 820);
                                counter++;
                                break;                                                               
                        }
                    }      
                 }      
                 if (counter < tech.Length)
                 {
                     e.HasMorePages = true;      // после завершения метода OnPrintPage он вызовется ещё раз автоматически
                     return;
                 }                                   
                 e.HasMorePages = false;     // после завершения метода OnPrintPage он не будет вызываться
                 counter = 0;
             
            }
             */
        }

        private void DrawAndCheckEmpty(Graphics g, int count, int x, int y)
        {
                 // проходим непечатаемые листы
            while (counter < count && !(bool)dataGridViewListOfDetails["Print", counter].Value)      // если отжат чекбокс печати
            {
                counter++;
            }
            if (counter < count)
            {
                Technology tech = Globals.dictQwewe[(int)dataGridViewListOfDetails[0, counter].Value];
                tech.Draw(g, x, y, textBoxFam.Text, textBoxBoss.Text);
                if (!printDocument.PrintController.IsPreview)
                {
                    techListToPrint.Add(tech);
                }
                counter++;
            }
            // проходим непечатаемые листы
            while (counter < count && !(bool)dataGridViewListOfDetails["Print", counter].Value)      // если отжат чекбокс печати
            {
                counter++;
            }
        }

            //preview - дублирует кнопкe меню печать
        private void buttonA5_Click(object sender, EventArgs e)
        {
            f = format.A5;
            dlgPrintPreview.ShowDialog();
        }
        private void buttonPrintA4_Click(object sender, EventArgs e)
        {
            f = format.A4;
            dlgPrintPreview.ShowDialog();
        }
        private void buttonPrintA3_Click(object sender, EventArgs e)
        {
            f = format.A3;
            dlgPrintPreview.ShowDialog();
        }
        private void buttonPageSetup_Click(object sender, EventArgs e)
        {
            try
            {
                dlgPageSetup.ShowDialog();
            }
            catch { MessageBox.Show("Нет принтера :-("); }
        }

        private void buttonBolt_Click(object sender, EventArgs e)
        {
            RemoveMainControl();
            tableLayoutPanel2.Controls.Add(new BoltUserControl(), 0, 1);
        }

        private void SelfLockingNut_Click(object sender, EventArgs e)
        {
            RemoveMainControl();
            tableLayoutPanel2.Controls.Add(new SelfLockingNutUserControl(), 0, 1);
        }

        private void UnknownDet_Click(object sender, EventArgs e)
        {
            RemoveMainControl();
            UnknownDetailUserControl ADUC = new UnknownDetailUserControl();
            ADUC.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Add(ADUC, 0, 1);
        }

        private void FreeTech_Click(object sender, EventArgs e)
        {
            RemoveMainControl();
            FreeTechUserControl FTUC = new FreeTechUserControl();
            FTUC.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Add(FTUC, 0, 1);
        }
            // Внесение в базу новой детали
        private void makeDetail_Click(object sender, EventArgs e)
        {
            RemoveMainControl();
            tableLayoutPanel2.Controls.Add(new MakeDetailUserControl(textBoxEngine, textBoxShifr), 0, 1);
        }
            // кнопка тезауруса
        private void buttonThesaurus_Click(object sender, EventArgs e)
        {
            RemoveMainControl();
            ThesaurusUserControl TUC = new ThesaurusUserControl();
            TUC.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Add(TUC, 0, 1);
        }
        private void textBoxEngine_TextChanged(object sender, EventArgs e)
        {
            Globals.engine = textBoxEngine.Text;
        }
        private void textBoxShifr_TextChanged(object sender, EventArgs e)
        {
            Globals.shifr = textBoxShifr.Text;
        }
            // обнуление списка
        private void buttonNull_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить все техпроцессы?", "Удаление техпроцессов",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Globals.dictQwewe.Clear();
                Globals.counterOfTechs = 0;
                dataGridViewListOfDetails.Rows.Clear();
                labelCountOfActs.Text = "Кол-во д/а - " + Globals.dictQwewe.Count.ToString();
                сохранитьToolStripMenuItem.Enabled = false;       // делаем невидимым менюайтем с простым сохранением 
                Globals.fileName = "";
                this.Text = "Генератор техпроцессов";
            }
        }
            // клик по гриду
        private void dataGridViewListOfDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            if (e.RowIndex > -1)
            {
                indexSelected = (int)dataGridViewListOfDetails["Number", e.RowIndex].Value;
                if (dataGridViewListOfDetails.Columns[e.ColumnIndex].HeaderText == "Удалить")     // если нажата кнопка *Удалить*
                {
                    dataGridViewListOfDetails.Rows.RemoveAt(e.RowIndex);
                    Globals.dictQwewe.Remove(indexSelected);
                }
                if (dataGridViewListOfDetails.Columns[e.ColumnIndex].HeaderText == "Редактировать")     // если нажата кнопка *Редактировать*
                {
                    DataGridViewRow DGVR = dataGridViewListOfDetails.Rows[e.RowIndex];          // целая строка, которую будем передавать в конструктор юзерконтрола-редактора технологии
                    RemoveMainControl();
                    FreeTechUserControl FTUC = new FreeTechUserControl(Globals.dictQwewe[indexSelected], indexSelected, DGVR);
                    FTUC.Dock = DockStyle.Fill;
                    tableLayoutPanel2.Controls.Add(FTUC, 0, 1);
                }
                if (dataGridViewListOfDetails.Columns[e.ColumnIndex].HeaderText == "Печатать")     // если нажата кнопка *Печатать*
                {
                    bool val = (bool)((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value;
                    ((DataGridView)sender)[e.ColumnIndex, e.RowIndex].Value = !val;
                }
                if (dataGridViewListOfDetails.Columns[e.ColumnIndex].HeaderText == "Дублировать")     // если нажата кнопка *Дублировать*
                {
                    Technology tecnologyToClone = Globals.dictQwewe[indexSelected];
                    Globals.AddTechnology(tecnologyToClone.Clone());
                }

            }
            Globals.labelCountOfActs.Text = "Кол-во д/а - " + Globals.dictQwewe.Count;
        }

        // даблклик по гриду
        private void dataGridViewListOfDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)   // если нажат заголовок
                return;
            if (e.RowIndex > -1)
            {
                string header = dataGridViewListOfDetails.Columns[e.ColumnIndex].HeaderText;
                if (header != "Удалить" && header != "Редактировать" && header != "Печатать" && header != "Дублировать")     // если НЕ нажата кнопка *Удалить* или кнопка *Редактировать* или "Печать" или "Дублировать"
                {
                    DrawForm df = new DrawForm(((Globals.dictQwewe[indexSelected])),textBoxFam.Text, textBoxBoss.Text);
                    df.Show();
                }
            }
        }

            //статистика
        private void buttonStatistycs_Click(object sender, EventArgs e)             // вывод статистики
        {
            string str = "";
            OleDbConnection connection = new OleDbConnection(Globals.connectionString);
            string query = "SELECT ID, Number, Name, Data, Engine, Shifr FROM Statistics";
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                str += datareader[0].ToString() + ": " +
                    datareader[1].ToString() + " - " +
                    datareader[2].ToString() + " " +
                    datareader[3].ToString() + ";  двигатель: " +
                    datareader[4].ToString() + ",  шифр затрат:" +
                    datareader[5].ToString() + Environment.NewLine;
            }
            datareader.Close();
            connection.Close();

            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Dock = DockStyle.Fill;
            textBox.Text = str;

            RemoveMainControl();
            tableLayoutPanel2.Controls.Add(textBox, 0, 1);
        }

        // сохранение списка доделок в файл
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            Globals.fileName = saveFileDialog1.FileName;
            if (Globals.fileName == "")
            {
                MessageBox.Show("Файл не выбран!");
                return;
            }
            if (Globals.fileName.Substring(Globals.fileName.Length-4, 4) != ".dat")
            {
                Globals.fileName += ".dat";
            }
            FileStream fs = new FileStream(Globals.fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Globals.dictQwewe);
            fs.Close();
            сохранитьToolStripMenuItem.Enabled = true;       // делаем видимым менюайтем с простым сохранением 
            this.Text = "Печать техпроцессов ремонта" + " - " + Globals.fileName;
        }
            // сохранение в раннее сохранённый или открытый файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Globals.fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Globals.dictQwewe);
            fs.Close();
            сохранитьToolStripMenuItem.Enabled = true;       // делаем видимым менюайтем с простым сохранением 
        }
            // открытие файла с сохранённым списком доделок
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "*.dat|*.dat";
            OFD.ShowDialog();
            Globals.fileName = OFD.FileName;
            if (Globals.fileName == "")
            {
                MessageBox.Show("Файл не выбран!");
                return;
            }
            FileStream fs = new FileStream(Globals.fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                Globals.dictQwewe.Clear();
                Globals.Grid.Rows.Clear();
                Globals.counterOfTechs = 0;
                Globals.AddTechnology((Dictionary<int, Technology>)bf.Deserialize(fs));
                            /*Globals.dictQwewe = (Dictionary<int, Technology>)bf.Deserialize(fs);
                            Globals.Grid.Rows.Clear();
                            foreach (int key in Globals.dictQwewe.Keys)
                            {
                                Globals.Grid.Rows.Add(key, Globals.dictQwewe[key].act, Globals.dictQwewe[key].num, Globals.dictQwewe[key].name, Globals.dictQwewe[key].engine, Globals.dictQwewe[key].shifr, "Удалить", "Редактировать");
                            }      
                            labelCountOfActs.Text = "Количество доделочных актов - " + Globals.dictQwewe.Count;
                            Globals.counterOfTechs = Globals.dictQwewe.Keys.Max()+1;*/
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            fs.Close();
            сохранитьToolStripMenuItem.Enabled = true;       // делаем видимым менюайтем с простым сохранением    
            this.Text = "Печать техпроцессов ремонта" + " - " + Globals.fileName;
        }
            // добавление технологии в грид
        private void dataGridViewListOfDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            labelCountOfTechs.Text = "CountOfTechs " + Globals.counterOfTechs.ToString();
            labelDictQweweCount.Text = "DictQweweCount " + Globals.dictQwewe.Count.ToString();
        }
            // удаление технологии из грида
        private void dataGridViewListOfDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelCountOfTechs.Text = "CountOfTechs " + Globals.counterOfTechs.ToString();
            labelDictQweweCount.Text = "DictQweweCount " + Globals.dictQwewe.Count.ToString();
        }
            // Меню печати - дублирует кнопку Preview
        private void печатьStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgPrintPreview.ShowDialog();
        }           
            // указание пути к базе данных
        private void БазаtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "*.mdb|*.mdb";
            OFD.ShowDialog();
            string dataBaseFileName;
            dataBaseFileName =OFD.FileName;
            if (dataBaseFileName != "")
            {
                Globals.pathToBD = dataBaseFileName;
                Globals.connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + Globals.pathToBD;
                labelPathToDB.Text = "База данных:  " + Globals.pathToBD;
            }
        }

            // загружаем технологии из базы, стандартные фразы, наименования покрытий, оснастку и наименования операций, список ОСТов на самоконтрящиеся гайки
        private static void DictionariesLoad()
        {
            Dictionary<string, BaseTechnology> numberToBaseTech = new Dictionary<string,BaseTechnology>();
            Dictionary<int, Node> standartPhrases = new Dictionary<int,Node>();
            Dictionary<int, string> namesOfOperations = new Dictionary<int, string>();
            Dictionary<int, Node> osnastka = new Dictionary<int, Node>();
            List<string> cover = new List<string>();
            Dictionary<string, int> OSTtoTypeNut = new Dictionary<string, int>();     // словарь ОСТ самоконтр. гайки - Тип


            OleDbConnection connection = new OleDbConnection(Globals.connectionString);
            string queryPhrases = "SELECT ID, ParentID, Text FROM StandartPhrases";
            string queryNames = "SELECT ID, Name FROM OperationNames";
            string queryOsnastka = "SELECT ID, ParentID, Text FROM Osnastka";
            string queryCover = "SELECT ShortName FROM Cover";
            string queryTechs = "SELECT Number, Tech FROM Technology ORDER BY Number;";
            string queryNut = "SELECT GOST, TypeOfNut FROM GostNut";

            OleDbCommand commandPhrases = new OleDbCommand(queryPhrases, connection);
            OleDbCommand commandNames = new OleDbCommand(queryNames, connection);
            OleDbCommand commandOsnastka = new OleDbCommand(queryOsnastka, connection);
            OleDbCommand commandCover = new OleDbCommand(queryCover, connection);
            OleDbCommand commandTechs = new OleDbCommand(queryTechs, connection);
            OleDbCommand commandNut = new OleDbCommand(queryNut, connection);

            connection.Open();
                OleDbDataReader datareaderPhrases = commandPhrases.ExecuteReader();
                while (datareaderPhrases.Read())
                {
                    standartPhrases.Add((int)datareaderPhrases[0], new Node((int)datareaderPhrases[1], datareaderPhrases[2].ToString()));
                }
                datareaderPhrases.Close();

                OleDbDataReader datareaderNames = commandNames.ExecuteReader();
                while (datareaderNames.Read())
                {
                    namesOfOperations.Add((int)datareaderNames[0], datareaderNames[1].ToString());
                }
                datareaderNames.Close();

                OleDbDataReader datareaderOsnastka = commandOsnastka.ExecuteReader();
                while (datareaderOsnastka.Read())
                {
                    osnastka.Add((int)datareaderOsnastka[0], new Node((int)datareaderOsnastka[1], datareaderOsnastka[2].ToString()));
                }
                datareaderOsnastka.Close();

                OleDbDataReader datareaderCover = commandCover.ExecuteReader();
                while (datareaderCover.Read())
                {
                    cover.Add((string)datareaderCover[0]);
                }
                datareaderCover.Close();

                OleDbDataReader datareaderNut = commandNut.ExecuteReader();
                while (datareaderNut.Read())
                {
                    OSTtoTypeNut.Add(datareaderNut[0].ToString(), (int)datareaderNut[1]);     // заполняем словарь (ОСТ, Тип)         
                }
                datareaderNut.Close();


            try
                {
                    OleDbDataReader datareader = commandTechs.ExecuteReader();
                    while (datareader.Read())
                    {
                        MemoryStream ms = new MemoryStream();
                        byte[] buf = Encoding.UTF8.GetBytes(datareader[1].ToString());
                        ms.Write(buf, 0, buf.Length);
                        ms.Position = 0;
                        XmlSerializer xmlSer = new XmlSerializer(typeof(BaseTechnology));
                        StreamReader reader = new StreamReader(ms);
                        numberToBaseTech.Add(datareader[0].ToString(), (BaseTechnology)xmlSer.Deserialize(reader));     // добавляем в словарь технологию ремонта детали с номером datareader[0]
                        //comboBoxDet.Items.Add(datareader[0]);
                    }
                    datareader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            connection.Close();

            cover.Sort();
                // заполняем родительские айди для каждой фразы в словаре фраз
            foreach (int key in standartPhrases.Keys)
            {
                if (standartPhrases[key].parentID!=0)
                    standartPhrases[key].parent = standartPhrases[standartPhrases[key].parentID];
            }
                // добавляем покрытия в словарь со стандартными фразами
            int coverParent = standartPhrases.Keys.Max()+1;
            standartPhrases.Add(coverParent, new Node(0, "Покрытие"));
            int counter = coverParent;
            foreach (string covr in cover)
            {
                counter++;
                standartPhrases.Add(counter, new Node(coverParent, covr));
            }

                // заполняем родительские айди для каждой оснастки в словаре оснастки
            foreach (int key in osnastka.Keys)
            {
                if (osnastka[key].parentID!=0)
                    osnastka[key].parent = osnastka[osnastka[key].parentID];
            }
            // добавляем конуса в словарь оснастки
            int konusParent = osnastka.Keys.Max() + 1;
            osnastka.Add(konusParent, new Node(0, "Притирка конусов"));
            counter = konusParent;
            foreach (string coneText in Globals.coneToConeObject.Keys)
            {
                counter++;
                osnastka.Add(counter, new Node(konusParent, "Тип: " + Globals.coneToConeObject[coneText].description + "; Резьба: " + Globals.coneToConeObject[coneText].rezba));  //"Тип: " + description + "; Резьба:" + rezba
                counter++;
                osnastka.Add(counter, new Node(counter - 1, "Притир" + Environment.NewLine + Globals.coneToConeObject[coneText].pritir + Environment.NewLine + "Калибр" + Environment.NewLine + Globals.coneToConeObject[coneText].kalibr + Environment.NewLine));
                counter++;
                osnastka.Add(counter, new Node(counter - 2, "Пределы расположения отпечатка: " + Globals.coneToConeObject[coneText].otpechatok));
                counter++;
                osnastka.Add(counter, new Node(counter - 3, "Ширина отпечатка: " + Globals.coneToConeObject[coneText].width));
            }    
                
            Globals.dictStandartPhrases = standartPhrases;
            Globals.namesOfOperation = namesOfOperations;
            Globals.dictOsnastka = osnastka;
            Globals.cover = cover;
            Globals.numberToBaseTech = numberToBaseTech;
            Globals.OSTtoTypeNut = OSTtoTypeNut;
        }

        private void RemoveMainControl()
        {
            Control control = tableLayoutPanel2.GetControlFromPosition(0, 1);
            tableLayoutPanel2.Controls.Remove(control);
            if (control != null)
                control.Dispose();
        }
            

                // Начало печати
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!printDocument.PrintController.IsPreview)
            {
                techListToPrint = new List<Technology>();
            }
        }

                // Конец печати
        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!printDocument.PrintController.IsPreview)
            {
                OleDbConnection connection = new OleDbConnection(Globals.connectionString);
                connection.Open();
                foreach (Technology tech in techListToPrint)
                {
                    string queryInsert = "INSERT INTO Statistics ([Number], Name, Data, Engine, Shifr) VALUES ('" + tech.num + "','" + tech.name + "','" + DateTime.Now + "','" + tech.engine + "','" + tech.shifr+"')";
                    OleDbCommand commandIns = new OleDbCommand(queryInsert, connection);
                    try
                    {
                        commandIns.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                connection.Close();
                techListToPrint = null;
            }
        }

            // передача списка выделенных в системном гриде техпроцессов в новое окно
        private void toolStripMenuItemOpenInNewWindow_Click(object sender, EventArgs e)
        {
            WriteIntoMappedMemory();
            Process process = new Process();
            process.StartInfo.FileName = "PrintApp";
            process.StartInfo.Arguments = "TRUE";
            process.Start();
        }
            // копирование выделенных техпроцессов в разделяемую память
        private void ToolStripMenuItemCopyToMappedMemory_Click(object sender, EventArgs e)
        {
            WriteIntoMappedMemory();
        }   
        
            // вставка техпроцессов из разделяемой памяти в системный грид
        private void ToolStripMenuItemPasteFromMappedMemory_Click(object sender, EventArgs e)
        {
            int size;   // размер передаваемого сообщения   
            byte[] byteArray;
                // считываем размер сообщения
            using (MemoryMappedViewAccessor reader = Globals.sharedMemory.CreateViewAccessor(0, 4, MemoryMappedFileAccess.Read))
            {
                size = reader.ReadInt32(0);
                reader.Dispose();
            }
                // считываем сообщение
            using (MemoryMappedViewAccessor reader = Globals.sharedMemory.CreateViewAccessor(4, size, MemoryMappedFileAccess.Read))
            {
                byteArray = new byte[size];
                reader.ReadArray<byte>(0, byteArray, 0, size);
                reader.Dispose();
            }
            XmlSerializer xmlSer = new XmlSerializer(typeof(TechList));
            MemoryStream stream = new MemoryStream(byteArray);
            TechList Tlist = (TechList)(xmlSer.Deserialize(stream));
            foreach (Technology tech in Tlist.list)
            {
                Globals.AddTechnology(tech);
            }
        }

            // запись списка техпроцессов в разделяемую память
        private void WriteIntoMappedMemory()
        {
            DataGridViewSelectedRowCollection Collection = dataGridViewListOfDetails.SelectedRows;

            TechList list = new TechList();
            for (int i = Collection.Count - 1; i >= 0; i--)      // в коллекции строки находятся в обратном порядке
            {
                DataGridViewRow row = Collection[i];
                int index = (int)dataGridViewListOfDetails["Number", row.Index].Value;
                list.Add(Globals.dictQwewe[index]);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(TechList));
                xmlSer.Serialize(ms, list);
                ms.Position = 0;
                byte[] byteArray = ms.ToArray();
                int size = byteArray.Length;
                if (size >= 1000000)
                {
                    MessageBox.Show("Слишком большой объём передаваемых данных!");
                    return;
                }
                    //Создание участка разделяемой памяти. Первый параметр - название участка, второй - длина участка памяти в байтах: тип byte занимает 1 байт плюс четыре байта для одного объекта типа Integer (для передачи длины сообщения)
                using (MemoryMappedViewAccessor writer = Globals.sharedMemory.CreateViewAccessor(0, size + 4))                //Создаем объект для записи в разделяемый участок памяти
                {
                    writer.Write(0, size);       // сначала записываем в разделяемую память, начиная с нулевой позиции, размер сообщения
                    writer.WriteArray<byte>(4, byteArray, 0, size);     //записываем в разделяемую память, начиная с четвёртой позиции, сообщение
                    writer.Flush();
                }
            }
        }        
    }

    [Serializable]
    public class TechList
    {
        public TechList()       // пустой конструктор для сериализации
        {}
        public List<Technology> list = new List<Technology>();
        public void Add(Technology t)
        {
            list.Add(t);
        }
    }
}