    /// юзерконтрол самоконтрящейся гайки
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
    public partial class SelfLockingNutUserControl : UserControl, IReNulUserControl
    {
        private string name;
        private string num;
        private string act;
        private string engine;
        private string shifr;
        private string pokritie;
        private string M1max = "";
        private string M1min = "";

        Dictionary<string, int> OSTtoType;    // словарь ОСТ-Тип

        public SelfLockingNutUserControl()
        {
            InitializeComponent();
        }

        private void SelfLockingNutUserControl_Load(object sender, EventArgs e)
        {
            OSTtoType = Globals.OSTtoTypeNut;
            comboBoxGOST.Items.AddRange(OSTtoType.Keys.ToArray());
            textBoxType.Focus();
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGOST.SelectedIndex != -1)
            {
                textBoxDetNum.Text = textBoxType.Text + " ОСТ " + comboBoxGOST.SelectedItem.ToString();
                if ((textBoxType.Text.Contains("3")) || (textBoxType.Text.Contains("6") && (textBoxPokritie.Text == "Кадмирование")& (comboBoxGOST.SelectedItem.ToString().Contains("1 33059") || comboBoxGOST.SelectedItem.ToString().Contains("1 33235"))))
                {
                    checkBoxObjatie.Checked = false;
                }
                else
                    checkBoxObjatie.Checked = true;
            }
            else
                textBoxDetNum.Text = textBoxType.Text;
        }

        private void comboBoxGOST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGOST.SelectedIndex != -1)
            {
                textBoxDetNum.Text = textBoxType.Text + " ОСТ " + comboBoxGOST.SelectedItem.ToString();
                if ((textBoxType.Text.Contains("3")) || (comboBoxGOST.SelectedItem.ToString().Contains("1 33260")) ||
                    (comboBoxGOST.SelectedItem.ToString().Contains("1 33260")) || (comboBoxGOST.SelectedItem.ToString().Contains("1 33244")) ||
                    (comboBoxGOST.SelectedItem.ToString().Contains("1 33245")) || (comboBoxGOST.SelectedItem.ToString().Contains("1 33246")) ||
                    (comboBoxGOST.SelectedItem.ToString().Contains("1 33247")) || (comboBoxGOST.SelectedItem.ToString().Contains("1 33264")) ||
                    (textBoxType.Text.Contains("6") & (comboBoxGOST.SelectedItem.ToString().Contains("1 33059") || comboBoxGOST.SelectedItem.ToString().Contains("1 33235")) && (textBoxPokritie.Text == "Кадмирование")))
                {
                    checkBoxObjatie.Checked = false;
                }
                else
                    checkBoxObjatie.Checked = true;
            }
            else
                textBoxDetNum.Text = textBoxType.Text;
        }

        private void textBoxDetNum_TextChanged(object sender, EventArgs e)
        {
            textBoxPokritie.Text = "";
            if (textBoxDetNum.Text.Contains("ср") || textBoxDetNum.Text.Contains("СР") || textBoxDetNum.Text.Contains("Ср"))
            {
                textBoxPokritie.Text = "Серебрение";
            }
            if (textBoxDetNum.Text.Contains("кд") || textBoxDetNum.Text.Contains("КД") || textBoxDetNum.Text.Contains("Кд"))
                textBoxPokritie.Text = "Кадмирование";
            if (textBoxDetNum.Text.Contains("м") || textBoxDetNum.Text.Contains("М"))
                textBoxPokritie.Text = "Меднение";
            if (textBoxDetNum.Text.Contains("ц") || textBoxDetNum.Text.Contains("Ц"))
                textBoxPokritie.Text = "Цинкование";
            if (textBoxDetNum.Text.Contains("х") || textBoxDetNum.Text.Contains("Х"))
                textBoxPokritie.Text = "Хромирование";
            if (textBoxDetNum.Text.Contains("хп") || textBoxDetNum.Text.Contains("ХП") || textBoxDetNum.Text.Contains("Хп") || textBoxDetNum.Text.Contains("ХимПас") || textBoxDetNum.Text.Contains("химпас") || textBoxDetNum.Text.Contains("Хим.Пас.") || textBoxDetNum.Text.Contains("Х.П.") || textBoxDetNum.Text.Contains("Х.п.") || textBoxDetNum.Text.Contains("х.п.") || textBoxDetNum.Text.Contains("хим.пас.") || textBoxDetNum.Text.Contains("хим пас") || textBoxDetNum.Text.Contains("ХИМ.ПАС."))
                textBoxPokritie.Text = "";
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
                // узнаём диаметр резьбы
            char[] arr = textBoxType.Text.ToCharArray();
            string diam = "";
            int DIAM = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= '9' & arr[i] >= '0')
                {
                    diam = diam + arr[i];
                }
                else break;
            }
            try { DIAM = Convert.ToInt32(diam); }
            catch 
            {
                MessageBox.Show("Неправильно введен диаметр");
                return;
            }
                // шапка
            name = "Гайка самоконтрящаяся";
            num = textBoxDetNum.Text;
            act = textBoxAct.Text;
            engine = Globals.engine;
            shifr = Globals.shifr;
            pokritie = textBoxPokritie.Text;
                // пошёл техпроцесс
            List<Operation> listOfOperations = new List<Operation>();
            listOfOperations.Add(new Operation("Контрольная"));
            listOfOperations.Add(new Operation("Удаление нагара (при необх.)"));
            listOfOperations.Add(new Operation("Слесарная", new string[] { "ИОТ-36.255-2014" }, new string[] { "Надфиль", "80№4", "Шлиф. шкурка", "14AF1000/5C1" }));
                    // распокрытие или обдувка
            if (textBoxPokritie.Text.Contains("Кадмирование") || textBoxPokritie.Text.Contains("Цинкование"))
                listOfOperations.Add(new Operation("Обдувка"));
            else
                listOfOperations.Add(new Operation("Распокрыть"));
                    // считываем моменты соответственно ОСТу и диаметру резьбы            
            if (comboBoxGOST.SelectedIndex != -1)
            {
                string qweryMoment = "SELECT Max, Min FROM Moments WHERE ((TypeOfNut=" + OSTtoType[comboBoxGOST.SelectedItem.ToString()] + ")AND(Diametr=" + DIAM.ToString() + "))";
                OleDbConnection connection = new OleDbConnection(Globals.connectionString);
                OleDbCommand cmdMoment= new OleDbCommand(qweryMoment, connection);
                    connection.Open();
                    OleDbDataReader datareader = cmdMoment.ExecuteReader();
                    if(datareader.Read())
                    {
                        M1max = datareader[0].ToString();
                        M1min = datareader[1].ToString();
                    }
                    datareader.Close();
                    connection.Close();
             }
                    // проверяем, нужно ли обжатие
            if (checkBoxObjatie.Checked)
            {
                string[] sles = new[] { "ИОТ-36.255-2014", "1. Контроль контрящих свойств", "    М1 нав. наиб.= " + M1max + " кгс*см", "    М1 отв. наим.= " + M1min + " кгс*см", "2. Обжатие (при необх.)", "3. Контроль контрящих свойств (при необх.)" };
                listOfOperations.Add(new Operation("Слесарная", sles));

                M1max="";
                M1min = "";
            }
            else
            {
                string[] kontr = new[] { "1. Контроль контрящих свойств", "    М1 нав. наиб.= " + M1max + " кгс*см", "    М1 отв. наим.= " + M1min + " кгс*см" };
                listOfOperations.Add(new Operation("Контрольная", kontr));
            }
            listOfOperations.Add(new Operation("Подготовка под ЛЮМ1-ОВ"));
            listOfOperations.Add(new Operation("Моечная"));
            listOfOperations.Add(new Operation("Контрольная ЛЮМ1-ОВ"));
            if (pokritie != "")
            {
                listOfOperations.Add(new Operation(pokritie));
            }
            listOfOperations.Add(new Operation("Маркировка"));
            listOfOperations.Add(new Operation("Контрольная"));
                // сформировали ТП, отправляем в класс технологии
            Technology tech = new Technology(name, num, act, engine, shifr, listOfOperations);
            Globals.AddTechnology(tech);
            ReNulUserControl();                // обнуляем юзерконтрол        
        }

        public void ReNulUserControl()
        {
            textBoxType.Text = "";
            textBoxDetNum.Text = "";
            textBoxAct.Text = "";
            textBoxPokritie.Text = "";
            checkBoxObjatie.Checked = true;
            comboBoxGOST.SelectedIndex = -1;
            textBoxType.Focus();
        }
    }
}
