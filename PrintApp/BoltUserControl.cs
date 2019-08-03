    /// юзерконтрол простой слесарки
    /// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintApp
{
    public partial class BoltUserControl : UserControl, IReNulUserControl
    {
        private bool nagar;
        private bool zabityKontrovki;
        private string pokritie;
        private string name;
        private string num;
        private string act;
        private string engine;
        private string shifr;
        private string control;
        private bool magnit;
        private bool LUM;

        public BoltUserControl()
        {
            InitializeComponent();
        }

        private void buttonMake_Click(object sender, EventArgs e)       // добавление в список на печать доделочного акта
        {
            nagar = checkBoxNagar.Checked;
            zabityKontrovki = checkBoxKontr.Checked;
            name = textBoxName.Text;
            control = textBoxControl.Text;
            magnit = checkBoxMagnit.Checked;
            LUM = checkBoxLUM.Checked;
            num = textBoxDetNum.Text;
            string ch;
            if (name != "")
            {
                ch = name[0].ToString().ToUpper();
                name = name.Remove(0, 1);
                name = name.Insert(0, ch);
            }

            if (num.Contains("ост"))
            {
                num = num.Replace("ост", "ОСТ");
            }

            act = textBoxAct.Text;
            pokritie = textBoxPokritie.Text;
            engine = Globals.engine;
            shifr = Globals.shifr;
            List<Operation> listOfOperations = new List<Operation>();
            listOfOperations.Add(new Operation("Дефектация", new string[] { "Визуальный контроль на соответствие чертежу","и отсутствие внешних дефектов" }));
            if (nagar || LUM)
            {
                listOfOperations.Add(new Operation("Удаление нагара"));
            }
            if (zabityKontrovki)
            {
                listOfOperations.Add(new Operation("Координатно-расточная", new string[] { "Высверлить остатки контровочной проволоки." }));
            }

            // формируем слесарку, ЛЮМ, магнитный
            Globals.FormSlesarkaMagnitLum(listOfOperations, textBoxMyText, LUM, magnit, name);

            if (pokritie != "")
            {
                listOfOperations.Add(new Operation(pokritie));
            }
            listOfOperations.Add(new Operation("Контрольная", new string[] { control }));
                 // сформировали ТП, отправляем в класс технологии
            Technology tech = new Technology(name, num, act, engine, shifr, listOfOperations);
            Globals.AddTechnology(tech);
                // обнуляем юзерконтрол
            ReNulUserControl();
        }

        private void textBoxDetNum_TextChanged(object sender, EventArgs e)
        {
                // для деталей Н14-002-...6-13   - ЛЮМ
            if ((textBoxDetNum.Text.Contains("Н14-002") || textBoxDetNum.Text.Contains("н14-002")) && textBoxDetNum.Text.Contains("6-13"))
            {
                checkBoxNagar.Checked = true;
                checkBoxLUM.Checked = true;
                //textBoxMyText.AppendText(Environment.NewLine + "3. Подготовка под ЛЮМ1-ОВ" + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Оп.17 Контрольная ЛЮМ1-ОВ");
            }
            // для деталей Н14-001
            if (textBoxDetNum.Text.Contains("Н14-001") || textBoxDetNum.Text.Contains("н14-001"))
            {
                textBoxPokritie.Text = "Серебрение";
                checkBoxNagar.Checked = true;
            }
            if (textBoxDetNum.Text.Contains("ср") || textBoxDetNum.Text.Contains("СР") || textBoxDetNum.Text.Contains("Ср"))
            {
                textBoxPokritie.Text = "Серебрение";
                checkBoxNagar.Checked = true;
            }
            if (textBoxDetNum.Text.Contains("х") || textBoxDetNum.Text.Contains("Х"))
                textBoxPokritie.Text = "Хромирование";
            if (textBoxDetNum.Text.Contains("м") || textBoxDetNum.Text.Contains("М"))
                textBoxPokritie.Text = "Меднение";
            if (textBoxDetNum.Text.Contains("ц") || textBoxDetNum.Text.Contains("Ц"))
                textBoxPokritie.Text = "Цинкование";
            if (textBoxDetNum.Text.Contains("кд") || textBoxDetNum.Text.Contains("КД") || textBoxDetNum.Text.Contains("Кд"))
                textBoxPokritie.Text = "Кадмирование";
            if (textBoxDetNum.Text.Contains("н.кд") || textBoxDetNum.Text.Contains("Н.кд") || textBoxDetNum.Text.Contains("нкд") || textBoxDetNum.Text.Contains("Н.КД") || textBoxDetNum.Text.Contains("НКД"))
                textBoxPokritie.Text = "Никель-Кадмирование";
            if (textBoxDetNum.Text.Contains("хп") || textBoxDetNum.Text.Contains("ХП") || textBoxDetNum.Text.Contains("Хп") || textBoxDetNum.Text.Contains("ХимПас") || textBoxDetNum.Text.Contains("химпас") || textBoxDetNum.Text.Contains("Хим.Пас.") || textBoxDetNum.Text.Contains("Х.П.") || textBoxDetNum.Text.Contains("Х.п.") || textBoxDetNum.Text.Contains("х.п.") || textBoxDetNum.Text.Contains("хим.пас.") || textBoxDetNum.Text.Contains("хим пас") || textBoxDetNum.Text.Contains("ХИМ.ПАС."))
                textBoxPokritie.Text = "";
        }

        public void ReNulUserControl()
        {
            checkBoxNagar.Checked = false;
            checkBoxKontr.Checked = false;
            checkBoxMagnit.Checked = false;
            checkBoxLUM.Checked = false;
            textBoxName.Text = "";
            textBoxDetNum.Text = "";
            textBoxAct.Text = "";
            textBoxPokritie.Text = "";
            textBoxMyText.Text = "1. Удалить налёт, коррозию." + Environment.NewLine + "2. Зачистить забоины, заусенцы.";
            textBoxControl.Text = "";
            textBoxName.Focus();
        }

        private void BoltUserControl_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }

        private void textBoxPokritie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
