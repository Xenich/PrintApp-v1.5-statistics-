    /// юзерконтрол шифровой детали
    /// 
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
    public partial class UnknownDetailUserControl 
    {
        /*
        private string name;
        private string num;
        private string act;
        private string engine;
        private string shifr;
        private bool nagar;
        private bool zabityKontrovki;
        private bool deformedPlaces;
        private bool magnit;
        private bool LUM;
        private bool pritirka;
        private bool gidro;
        private string pokritie;
        private int ID;


        private Dictionary<string, object[]> numberToSignature;    // словарь: номер детали - сигнатура ремонта, 
        // object[] - str Number,str Name, bool Nagar, bool Kontrovki, bool Gidro, bool Deform, bool Magnit, bool LUM, bool Pritirka, str Cover.ShortName, int Details.ID, string CoverForDetail, string Slesarka
        //                  0        1           2               3           4           5           6           7           8                  9                  10                 11                   12

        public UnknownDetailUserControl()
        {
            InitializeComponent();
        }

        private void UnknownDetailUserControl_Load(object sender, EventArgs e)
        {
            numberToSignature=new Dictionary<string, object[]>();
            string query = "SELECT Number, Name, Nagar, Kontrovki, Gidro, Deform, Magnit, LUM, Pritirka, Cover.ShortName, Details.ID, CoverForDetail, Slesarka FROM Details LEFT JOIN Cover ON Details.Cover = Cover.ID ORDER BY Number;";
            try
            {
                OleDbConnection connection = new OleDbConnection(Globals.connectionString);
                OleDbCommand cmd = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader datareader = cmd.ExecuteReader();

                while (datareader.Read())
                {
                    comboBoxDet.Items.Add(datareader[0]);
                    object[] signatureOfRepair = new object[] { datareader[1], datareader[2], datareader[3], datareader[4], datareader[5], datareader[6], datareader[7], datareader[8], datareader[9], datareader[10], datareader[11], datareader[12] };
                    numberToSignature.Add(datareader[0].ToString(), signatureOfRepair);     // добавляем в словарь сигнатуру ремонта детали с номером datareader[0]
                }
                datareader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDet.SelectedIndex != -1)
            {
                if (((numberToSignature[comboBoxDet.SelectedItem.ToString()])[0])!= DBNull.Value)
                    textBoxName.Text =      (string)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[0]);
                else
                    textBoxName.Text ="";
                checkBoxNagar.Checked =     (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[1]);
                checkBoxKontr.Checked =     (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[2]);
                checkBoxGidro.Checked =     (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[3]);
                checkBoxDeform.Checked =    (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[4]);
                checkBoxMagnit.Checked =    (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[5]);
                checkBoxLUM.Checked =       (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[6]);
                checkBoxPritirka.Checked =  (bool)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[7]);
                    // свой текст в слесарке
                if (((numberToSignature[comboBoxDet.SelectedItem.ToString()])[11]) != DBNull.Value)
                    textBoxMyText.Text = "1. Удалить налёт, коррозию." + Environment.NewLine + "2. Зачистить забоины, заусенцы." + Environment.NewLine + (string)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[11]);                                    
                else
                    textBoxMyText.Text = "1. Удалить налёт, коррозию." + Environment.NewLine + "2. Зачистить забоины, заусенцы.";
                    // покрытие для конкретной детали
                if (((numberToSignature[comboBoxDet.SelectedItem.ToString()])[8])!=DBNull.Value)
                    textBoxPokritie.Text =  (string)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[8]) +" "+ ((numberToSignature[comboBoxDet.SelectedItem.ToString()])[10]).ToString();
                else
                    textBoxPokritie.Text ="";
                ID =(int)((numberToSignature[comboBoxDet.SelectedItem.ToString()])[9]);
            }
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            if (comboBoxDet.SelectedIndex != -1)
            {
                    // шапка
                name =              textBoxName.Text;
                num =               comboBoxDet.SelectedItem.ToString();
                act =               textBoxAct.Text;
                engine =            Globals.engine;
                shifr =             Globals.shifr;
                nagar =             checkBoxNagar.Checked;
                zabityKontrovki =   checkBoxKontr.Checked;
                deformedPlaces =    checkBoxDeform.Checked;
                magnit =            checkBoxMagnit.Checked;
                LUM =               checkBoxLUM.Checked;
                pritirka =          checkBoxPritirka.Checked;
                gidro =             checkBoxGidro.Checked;
                pokritie =          textBoxPokritie.Text;

                    // пошёл техпроцесс
                List<Operation> listOfOperations = new List<Operation>();

                listOfOperations.Add(new Operation("Дефектация", new string[] { "Визуальный контроль на соответствие чертежу", "и отсутствие внешних дефектов" }));
                if (nagar)
                {
                    listOfOperations.Add(new Operation("Удаление нагара"));
                }
                if (zabityKontrovki)
                {
                    listOfOperations.Add(new Operation("Координатно-расточная", new string[] { "ИОТ-36.262-2014", "Высверлить остатки контровочной проволоки." }));
                }
                if (deformedPlaces)
                {
                    listOfOperations.Add(new Operation("Фрезерная", new string[] { "ИОТ-36.258-2014", "Вырезать деформированные места согласно чертежу." }));
                }

                        // формируем слесарку
                Operation slesarka = new Operation("Слесарная");
                List<string> sles = new List<string>() { "ИОТ-36.255-2014"};
                List<string> myText = textBoxMyText.Text.Split(new char[] { '\n' }).ToList<string>();   // считываем отдельно строки с текстбокса со своим текстом слесарки
                string[] slesOsnastka = new string[] { "Надфиль", "80№4", "Шлиф. шкурка", "14AF1000/5C1" };   
                slesarka.osnastka = slesOsnastka;        
                if (LUM)
                {
                    sles.AddRange(myText);
                    if (name.Contains("Болт"))
                        sles.Add("3. Подготовка под ЛЮМ1-ОВ");

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

                if (pritirka)
                {
                    List<string> kalibr =   new List<string>();
                    List<string> pritir =   new List<string>();
                    string otpechatok =     "";
                    string width =          "";
                    string query = "SELECT Type, Kalibr, Otpechatok, Width, Shifr FROM Pritir INNER JOIN (Shtuzer INNER JOIN Cone ON Shtuzer.ConeID = Cone.ID) ON Pritir.ID = Cone.Type WHERE Shtuzer.DetailID=" + ID.ToString();
                    OleDbConnection connection = new OleDbConnection(Globals.connectionString);
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    connection.Open();
                    OleDbDataReader datareader = cmd.ExecuteReader();
                    while (datareader.Read())
                    {
                        if (!kalibr.Contains(datareader[1].ToString()))
                            kalibr.Add(datareader[1].ToString());
                        if (!otpechatok.Contains(datareader[2].ToString()))
                            otpechatok+=datareader[2].ToString()+"; ";
                        if (!width.Contains(datareader[3].ToString()))
                            width+=datareader[3].ToString()+"; ";
                        if (!pritir.Contains(datareader[4].ToString()))
                            pritir.Add(datareader[4].ToString());
                    }                  
                    datareader.Close();
                    connection.Close();

                    string[] oper = new string[] { };

                    List<string> osnastka=new List<string>();
                    osnastka.Add("Установка"); osnastka.Add("У6872-1334"); osnastka.Add("Притир");
                    foreach (string s in pritir)
                        osnastka.Add(s);
                    osnastka.Add("Калибр");
                    foreach (string s in kalibr)
                        osnastka.Add(s);
                    osnastka.Add("Шкурка шлиф."); osnastka.Add("14AF1000/5C1"); osnastka.Add("Эталон"); osnastka.Add("У6367-00-9270"); osnastka.Add("Лазурь железная");
                    string[] _osnastka = osnastka.ToArray();

                    listOfOperations.Add(new Operation("Притирка конуса", new string[] {"ИОТ-36.256-2014",
                                                                                            "1. Притереть конусную поверхность",
                                                                                            "2. Выполнить проверку конусной поверхности:",
                                                                                            "а) равномерно, по всей окружности калибра нанести",
                                                                                            "слой краски для калибров до просвечивания металла;",
                                                                                            "Толщину нанесённого слоя определять путём",
                                                                                            "сопоставления цветов краски на калибре и эталоне.",
                                                                                            "Приготовление и нанесение - по инструкции 26/75Т",
                                                                                            "б) сохраняя соосность пары конус штуцера - калибр,",
                                                                                            "провернуть калибр вокруг его оси на угол 5°...10°",
                                                                                            "2...3 раза, прижимая калибр к конусу штуцера",
                                                                                            "Т.Т.: отпечаток должен быть в виде кольца без",
                                                                                            "разрыва, иметь равномерную ширину, располагаться",
                                                                                            "в пределах пояса контакта, огранчиченного разностью",
                                                                                            "размеров от торца:  "+ otpechatok, "Ширина отпечатка:  "+ width}
                                                         , _osnastka)); 
                }

                if (gidro && checkBoxUR.Checked)
                {
                    listOfOperations.Add(new Operation("Испытание на герметичность (ц.64)"));
                }
                if (pokritie != "")
                {
                    listOfOperations.Add(new Operation("Покрытие",new string[] {pokritie}));
                }
                listOfOperations.Add(new Operation("Контрольная"));
                     // сформировали ТП, отправляем в класс технологии
                Technology tech = new Technology(name, num, act, engine, shifr, listOfOperations);
                Globals.AddTechnology(tech);
                    // обнуляем юзерконтрол
                textBoxAct.Text = "";
                textBoxName.Text ="";
                checkBoxNagar.Checked =false;
                checkBoxKontr.Checked = false;
                checkBoxGidro.Checked = false;
                checkBoxDeform.Checked = false;
                checkBoxMagnit.Checked = false;
                checkBoxLUM.Checked = false;
                checkBoxPritirka.Checked = false;
                textBoxPokritie.Text = "";
                textBoxMyText.Text = "1. Удалить налёт, коррозию." + Environment.NewLine + "2. Зачистить забоины, заусенцы.";
                comboBoxDet.SelectedIndex = -1;
                comboBoxDet.Focus();
            }
            else
            { MessageBox.Show("Не выбрана деталь"); }
        }
         * */
    }
}
