using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Serialization;
using System.IO;

namespace PrintApp
{
    partial class UnknownDetailUserControl : UserControl// AbstractControl, IReNulUserControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDet = new System.Windows.Forms.ComboBox();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTech = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UpdateInBaseBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMake
            // 
            this.buttonMake.AutoSize = true;
            this.buttonMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMake.Location = new System.Drawing.Point(3, 3);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(81, 26);
            this.buttonMake.TabIndex = 5;
            this.buttonMake.Text = "Добавить";
            this.buttonMake.UseVisualStyleBackColor = false;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(224, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 26);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить из базы";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(144, 61);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 22);
            this.textBoxName.TabIndex = 22;
            // 
            // comboBoxDet
            // 
            this.comboBoxDet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDet.DisplayMember = "GOST";
            this.comboBoxDet.DropDownHeight = 250;
            this.comboBoxDet.DropDownWidth = 100;
            this.comboBoxDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDet.FormattingEnabled = true;
            this.comboBoxDet.IntegralHeight = false;
            this.comboBoxDet.Location = new System.Drawing.Point(144, 27);
            this.comboBoxDet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxDet.Name = "comboBoxDet";
            this.comboBoxDet.Size = new System.Drawing.Size(188, 24);
            this.comboBoxDet.TabIndex = 1;
            this.comboBoxDet.ValueMember = "GOST";
            this.comboBoxDet.SelectedIndexChanged += new System.EventHandler(this.comboBoxDet_SelectedIndexChanged);
            // 
            // textBoxAct
            // 
            this.textBoxAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAct.Location = new System.Drawing.Point(144, 93);
            this.textBoxAct.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(188, 22);
            this.textBoxAct.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Номер детали";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Доделочный акт №";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAct);
            this.groupBox1.Controls.Add(this.comboBoxDet);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 124);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифровая деталь";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(234, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 19);
            this.button1.TabIndex = 31;
            this.button1.Text = "Перенос базы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelTech
            // 
            this.panelTech.AutoScroll = true;
            this.panelTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTech.Location = new System.Drawing.Point(3, 133);
            this.panelTech.Name = "panelTech";
            this.panelTech.Size = new System.Drawing.Size(355, 174);
            this.panelTech.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTech, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 346);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonMake);
            this.flowLayoutPanel1.Controls.Add(this.UpdateInBaseBtn);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 312);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UpdateInBaseBtn
            // 
            this.UpdateInBaseBtn.AutoSize = true;
            this.UpdateInBaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.UpdateInBaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateInBaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateInBaseBtn.Location = new System.Drawing.Point(90, 3);
            this.UpdateInBaseBtn.Name = "UpdateInBaseBtn";
            this.UpdateInBaseBtn.Size = new System.Drawing.Size(128, 26);
            this.UpdateInBaseBtn.TabIndex = 6;
            this.UpdateInBaseBtn.Text = "Обновить в базе";
            this.UpdateInBaseBtn.UseVisualStyleBackColor = false;
            this.UpdateInBaseBtn.Click += new System.EventHandler(this.UpdateInBaseBtn_Click);
            // 
            // UnknownDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnknownDetailUserControl";
            this.Size = new System.Drawing.Size(361, 346);
            this.Load += new System.EventHandler(this.UnknownDetailUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        // перенесённыый код

        private string name;
        private string num;
        private string act;
        private string engine;
        private string shifr;
        private Button buttonMake;
        private Button buttonDelete;
        private TextBox textBoxName;
        private ComboBox comboBoxDet;
        private TextBox textBoxAct;
        private Label label3;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private Panel panelTech;
        private TableLayoutPanel tableLayoutPanel1;
        FreeTechnologyUserControl ftuc;
        private Button button1;
        private Button UpdateInBaseBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Dictionary<string, BaseTechnology> numberToBaseTech;    // словарь: номер детали - техпроцесс ремонта, 
        
        public UnknownDetailUserControl()
        {
            InitializeComponent();
            numberToBaseTech = Globals.numberToBaseTech;
        }

        private void UnknownDetailUserControl_Load(object sender, EventArgs e)
        {
            foreach (string number in numberToBaseTech.Keys)
            {
                comboBoxDet.Items.Add(number);
            }
        }

        private void comboBoxDet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDet.SelectedIndex != -1)
            {
                BaseTechnology technology = numberToBaseTech[comboBoxDet.SelectedItem.ToString()];
                ftuc = new FreeTechnologyUserControl(technology);
                panelTech.Controls.Clear();
                panelTech.Controls.Add(ftuc);
                textBoxName.Text = technology.name;
                buttonDelete.Enabled = true;
            }
            else
                buttonDelete.Enabled = false;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            if (comboBoxDet.SelectedIndex != -1)
            {
                    // шапка
                name = textBoxName.Text;
                num = comboBoxDet.SelectedItem.ToString();
                act = textBoxAct.Text;
                engine = Globals.engine;
                shifr  = Globals.shifr;
                Technology tech = ftuc.MakeTechnology(name,num,act,engine,shifr);
                Globals.AddTechnology(tech);
                ReNulUserControl();
            }
            else
            {
                MessageBox.Show("Не выбрана деталь");
                buttonDelete.Enabled = false;
            }
        }
        // обновить деталь в базе
        private void UpdateInBaseBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxDet.SelectedIndex != -1)
            {

                string selectedNum = comboBoxDet.SelectedItem.ToString();
                DialogResult result= DialogResult.No;
                OleDbConnection connection = new OleDbConnection(Globals.connectionString);
                string queryExist = "SELECT Number FROM Technology WHERE Number = '" + selectedNum +"'";
                OleDbCommand commandExist = new OleDbCommand(queryExist, connection);
                connection.Open();
                OleDbDataReader datareaderExist = commandExist.ExecuteReader();
                if (datareaderExist.Read())     // если хоть что-то пришло в ответ
                {
                    result = MessageBox.Show("Вы действительно хотите обновить деталь в базе данных?","?",MessageBoxButtons.YesNo);
                }
                connection.Close();
                if (result == DialogResult.Yes)
                {
                    BaseTechnology tech = ftuc.MakeBaseTechnology(textBoxName.Text, selectedNum);
                    if (tech.ApdateInDB())
                    {
                        numberToBaseTech[selectedNum] = tech;
                        ReNulUserControl();
                    }
                }
            }
        }

        // удалить деталь из базы
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxDet.SelectedIndex != -1)
            {
                string selectedDet = comboBoxDet.SelectedItem.ToString();
                DialogResult DR = MessageBox.Show("Удалить все записи о детали " + selectedDet + " " + textBoxName.Text + " из базы данных?", "УДАЛЕНИЕ ДЕТАЛИ");
                if (DR == DialogResult.OK)
                {
                    OleDbConnection connection = new OleDbConnection(Globals.connectionString);
                    string queryDel = "DELETE FROM Technology WHERE Number=" + "'"+selectedDet+"'";
                    OleDbCommand commandDel = new OleDbCommand(queryDel, connection);
                    connection.Open();
                    try
                    {
                        commandDel.ExecuteNonQuery();
                        connection.Close();
                        comboBoxDet.Items.Remove(comboBoxDet.SelectedItem);
                        numberToBaseTech.Remove(selectedDet);
                        // обнуляем юзерконтрол
                        ReNulUserControl();
                        MessageBox.Show("Запись в базе удалена");
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
            else
            {
                MessageBox.Show("Не выбрана деталь");
                buttonDelete.Enabled = false;
            }
        }
        
        public void ReNulUserControl()
        {
            textBoxAct.Text = "";
            textBoxName.Text = "";
            comboBoxDet.Focus();
            comboBoxDet.SelectedIndex = -1;
            panelTech.Controls.Clear();
            ftuc.Dispose();
        }

            // перенос базы данных из старого формата в новый
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + @"D:\_ЛИЧМАН ДМИТРИЙ\7 Разное\C#\Л.Р\PrintApp v1.3\PrintApp\bin\Debug" + "\\DataBase.mdb";
            string name;
            //string num;
            bool nagar;
            bool zabityKontrovki;
            bool deformedPlaces;
            bool magnit;
            bool LUM;
            bool pritirka;
            bool gidro;
            string pokritie;
            int ID;
            Dictionary<string, object[]> numberToSignature = new Dictionary<string, object[]>();
            string query = "SELECT Number, Name, Nagar, Kontrovki, Gidro, Deform, Magnit, LUM, Pritirka, Cover.ShortName, Details.ID, CoverForDetail, Slesarka FROM Details LEFT JOIN Cover ON Details.Cover = Cover.ID ORDER BY Number;";
            // object[] - str Number,str Name, bool Nagar, bool Kontrovki, bool Gidro, bool Deform, bool Magnit, bool LUM, bool Pritirka, str Cover.ShortName, int Details.ID, string CoverForDetail, string Slesarka
            //                  0        1           2               3           4           5           6           7           8                  9                  10                 11                   12

            OleDbConnection connection = new OleDbConnection(connectionString);
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
            foreach (string num in numberToSignature.Keys)
            {
                
                if (((numberToSignature[num])[0]) != DBNull.Value)
                    name = (string)((numberToSignature[num])[0]);
                else
                    name = "";
                nagar = (bool)((numberToSignature[num])[1]);
                zabityKontrovki = (bool)((numberToSignature[num])[2]);
                gidro = (bool)((numberToSignature[num])[3]);
                deformedPlaces = (bool)((numberToSignature[num])[4]);
                magnit = (bool)((numberToSignature[num])[5]);
                LUM = (bool)((numberToSignature[num])[6]);
                pritirka = (bool)((numberToSignature[num])[7]);
                // свой текст в слесарке
                string myText;
                if (((numberToSignature[num])[11]) != DBNull.Value)
                    myText = "1. Удалить налёт, коррозию." + Environment.NewLine + "2. Зачистить забоины, заусенцы." + Environment.NewLine + (string)((numberToSignature[num])[11]);
                else
                    myText = "1. Удалить налёт, коррозию." + Environment.NewLine + "2. Зачистить забоины, заусенцы.";
                // покрытие для конкретной детали

                if (((numberToSignature[num])[8]) != DBNull.Value)
                    pokritie = (string)((numberToSignature[num])[8]) + " " + ((numberToSignature[num])[10]).ToString();
                else
                    pokritie = "";
                ID = (int)((numberToSignature[num])[9]);

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
                List<string> sles = new List<string>() { "ИОТ-36.255-2014" };
                List<string> my_Text = myText.Split(new char[]{'\r','\n'}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();   // считываем отдельно строки с текстбокса со своим текстом слесарки
                string[] slesOsnastka = new string[] { "Надфиль", "80№4", "Шлиф. шкурка", "14AF1000/5C1" };
                slesarka.osnastka = slesOsnastka;
                if (LUM)
                {
                    sles.AddRange(my_Text);
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
                        sles.AddRange(my_Text);
                        string[] slesText = sles.ToArray();
                        slesarka.text = slesText;
                        listOfOperations.Add(slesarka);
                        listOfOperations.Add(new Operation("Моечная"));
                        listOfOperations.Add(new Operation("Контроль магнитопорошковый"));
                    }
                    else
                    {
                        sles.AddRange(my_Text);
                        string[] slesText = sles.ToArray();
                        slesarka.text = slesText;
                        listOfOperations.Add(slesarka);
                    }
                }

                if (pritirka)
                {
                    List<string> kalibr = new List<string>();
                    List<string> pritir = new List<string>();
                    string otpechatok = "";
                    string width = "";
                    query = "SELECT Type, Kalibr, Otpechatok, Width, Shifr FROM Pritir INNER JOIN (Shtuzer INNER JOIN Cone ON Shtuzer.ConeID = Cone.ID) ON Pritir.ID = Cone.Type WHERE Shtuzer.DetailID=" + ID.ToString();
                    connection = new OleDbConnection(connectionString);
                    cmd = new OleDbCommand(query, connection);
                    connection.Open();
                    datareader = cmd.ExecuteReader();
                    while (datareader.Read())
                    {
                        if (!kalibr.Contains(datareader[1].ToString()))
                            kalibr.Add(datareader[1].ToString());
                        if (!otpechatok.Contains(datareader[2].ToString()))
                            otpechatok += datareader[2].ToString() + "; ";
                        if (!width.Contains(datareader[3].ToString()))
                            width += datareader[3].ToString() + "; ";
                        if (!pritir.Contains(datareader[4].ToString()))
                            pritir.Add(datareader[4].ToString());
                    }
                    datareader.Close();
                    connection.Close();

                    string[] oper = new string[] { };

                    List<string> osnastka = new List<string>();
                    osnastka.Add("Установка"); osnastka.Add("У6872-1334"); osnastka.Add("Притир");
                    foreach (string s in pritir)
                        osnastka.Add(s);
                    osnastka.Add("Калибр");
                    foreach (string s in kalibr)
                        osnastka.Add(s);
                    osnastka.Add("Шкурка шлиф."); osnastka.Add("14AF1000/5C1"); osnastka.Add("Эталон"); osnastka.Add("У6367-00-9270"); osnastka.Add("Лазурь железная");
                    string[] _osnastka = osnastka.ToArray();

                    listOfOperations.Add(new Operation("Слесарная", new string[] {"ИОТ-36.256-2014",
                                                                                            "1. Притереть конусную поверхность.",
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

                if (gidro)
                {
                    listOfOperations.Add(new Operation("Испытание на герметичность (ц.64)"));
                }
                if (pokritie != "")
                {
                    listOfOperations.Add(new Operation("Покрытие", new string[] { pokritie }));
                }
                listOfOperations.Add(new Operation("Контрольная"));
                    // сформировали ТП, отправляем в класс технологии
                BaseTechnology bte = new BaseTechnology(name, num, listOfOperations);
                numberToBaseTech.Add(num, bte);
            }

            foreach (string num in numberToBaseTech.Keys)
            {
                numberToBaseTech[num].SaveToDB();
            }
        }
    }
}