namespace PrintApp
{
    partial class MakeDetailUserControl
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
            contextMenuStripPhrases.Dispose();
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDetNum = new System.Windows.Forms.TextBox();
            this.checkBoxPritirka = new System.Windows.Forms.CheckBox();
            this.checkBoxDeform = new System.Windows.Forms.CheckBox();
            this.buttonMake = new System.Windows.Forms.Button();
            this.checkBoxGidro = new System.Windows.Forms.CheckBox();
            this.checkBoxLUM = new System.Windows.Forms.CheckBox();
            this.checkBoxNagar = new System.Windows.Forms.CheckBox();
            this.checkBoxMagnit = new System.Windows.Forms.CheckBox();
            this.comboBoxCover = new System.Windows.Forms.ComboBox();
            this.groupBoxPritirka = new System.Windows.Forms.GroupBox();
            this.panelShtuzers = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TEST = new System.Windows.Forms.TextBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxControl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMyTextSles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.groupBoxPritirka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Обозначение";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(141, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 22);
            this.textBoxName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Наименование";
            // 
            // textBoxDetNum
            // 
            this.textBoxDetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDetNum.Location = new System.Drawing.Point(141, 31);
            this.textBoxDetNum.Name = "textBoxDetNum";
            this.textBoxDetNum.Size = new System.Drawing.Size(194, 22);
            this.textBoxDetNum.TabIndex = 24;
            // 
            // checkBoxPritirka
            // 
            this.checkBoxPritirka.AutoSize = true;
            this.checkBoxPritirka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPritirka.Location = new System.Drawing.Point(6, 296);
            this.checkBoxPritirka.Name = "checkBoxPritirka";
            this.checkBoxPritirka.Size = new System.Drawing.Size(148, 20);
            this.checkBoxPritirka.TabIndex = 47;
            this.checkBoxPritirka.Text = "Притирка конусов";
            this.checkBoxPritirka.UseVisualStyleBackColor = true;
            this.checkBoxPritirka.CheckedChanged += new System.EventHandler(this.checkBoxPritirka_CheckedChanged);
            // 
            // checkBoxDeform
            // 
            this.checkBoxDeform.AutoSize = true;
            this.checkBoxDeform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDeform.Location = new System.Drawing.Point(6, 119);
            this.checkBoxDeform.Name = "checkBoxDeform";
            this.checkBoxDeform.Size = new System.Drawing.Size(244, 20);
            this.checkBoxDeform.TabIndex = 43;
            this.checkBoxDeform.Text = "Вырезка деформированных мест";
            this.checkBoxDeform.UseVisualStyleBackColor = true;
            // 
            // buttonMake
            // 
            this.buttonMake.AutoSize = true;
            this.buttonMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMake.Location = new System.Drawing.Point(3, 124);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(159, 30);
            this.buttonMake.TabIndex = 57;
            this.buttonMake.Text = "Добавить в базу";
            this.buttonMake.UseVisualStyleBackColor = false;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // checkBoxGidro
            // 
            this.checkBoxGidro.AutoSize = true;
            this.checkBoxGidro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGidro.Location = new System.Drawing.Point(0, 3);
            this.checkBoxGidro.Name = "checkBoxGidro";
            this.checkBoxGidro.Size = new System.Drawing.Size(221, 20);
            this.checkBoxGidro.TabIndex = 50;
            this.checkBoxGidro.Text = "Испытание на герметичность";
            this.checkBoxGidro.UseVisualStyleBackColor = true;
            // 
            // checkBoxLUM
            // 
            this.checkBoxLUM.AutoSize = true;
            this.checkBoxLUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLUM.Location = new System.Drawing.Point(6, 270);
            this.checkBoxLUM.Name = "checkBoxLUM";
            this.checkBoxLUM.Size = new System.Drawing.Size(153, 20);
            this.checkBoxLUM.TabIndex = 46;
            this.checkBoxLUM.Text = "Контроль ЛЮМ1-ОВ";
            this.checkBoxLUM.UseVisualStyleBackColor = true;
            // 
            // checkBoxNagar
            // 
            this.checkBoxNagar.AutoSize = true;
            this.checkBoxNagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNagar.Location = new System.Drawing.Point(6, 93);
            this.checkBoxNagar.Name = "checkBoxNagar";
            this.checkBoxNagar.Size = new System.Drawing.Size(141, 20);
            this.checkBoxNagar.TabIndex = 42;
            this.checkBoxNagar.Text = "Удаление нагара";
            this.checkBoxNagar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagnit
            // 
            this.checkBoxMagnit.AutoSize = true;
            this.checkBoxMagnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMagnit.Location = new System.Drawing.Point(6, 244);
            this.checkBoxMagnit.Name = "checkBoxMagnit";
            this.checkBoxMagnit.Size = new System.Drawing.Size(228, 20);
            this.checkBoxMagnit.TabIndex = 45;
            this.checkBoxMagnit.Text = "Магнитопорошковый контроль";
            this.checkBoxMagnit.UseVisualStyleBackColor = true;
            // 
            // comboBoxCover
            // 
            this.comboBoxCover.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCover.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCover.DropDownHeight = 200;
            this.comboBoxCover.FormattingEnabled = true;
            this.comboBoxCover.IntegralHeight = false;
            this.comboBoxCover.Location = new System.Drawing.Point(107, 29);
            this.comboBoxCover.Name = "comboBoxCover";
            this.comboBoxCover.Size = new System.Drawing.Size(222, 21);
            this.comboBoxCover.TabIndex = 52;
            // 
            // groupBoxPritirka
            // 
            this.groupBoxPritirka.AutoSize = true;
            this.groupBoxPritirka.Controls.Add(this.panelShtuzers);
            this.groupBoxPritirka.Controls.Add(this.numericUpDown1);
            this.groupBoxPritirka.Controls.Add(this.label1);
            this.groupBoxPritirka.Enabled = false;
            this.groupBoxPritirka.Location = new System.Drawing.Point(6, 322);
            this.groupBoxPritirka.Name = "groupBoxPritirka";
            this.groupBoxPritirka.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxPritirka.Size = new System.Drawing.Size(329, 93);
            this.groupBoxPritirka.TabIndex = 48;
            this.groupBoxPritirka.TabStop = false;
            this.groupBoxPritirka.Text = "Притирка конусов";
            // 
            // panelShtuzers
            // 
            this.panelShtuzers.AutoSize = true;
            this.panelShtuzers.Location = new System.Drawing.Point(6, 49);
            this.panelShtuzers.Margin = new System.Windows.Forms.Padding(0);
            this.panelShtuzers.Name = "panelShtuzers";
            this.panelShtuzers.Size = new System.Drawing.Size(317, 31);
            this.panelShtuzers.TabIndex = 56;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(171, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown1.TabIndex = 55;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Количество конусов";
            // 
            // TEST
            // 
            this.TEST.Enabled = false;
            this.TEST.Location = new System.Drawing.Point(277, 244);
            this.TEST.Multiline = true;
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(58, 57);
            this.TEST.TabIndex = 55;
            this.TEST.Visible = false;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.buttonAdd);
            this.panelDown.Controls.Add(this.textBoxControl);
            this.panelDown.Controls.Add(this.label6);
            this.panelDown.Controls.Add(this.label4);
            this.panelDown.Controls.Add(this.checkBoxGidro);
            this.panelDown.Controls.Add(this.buttonMake);
            this.panelDown.Controls.Add(this.comboBoxCover);
            this.panelDown.Location = new System.Drawing.Point(6, 421);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(329, 160);
            this.panelDown.TabIndex = 49;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(164, 124);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 30);
            this.buttonAdd.TabIndex = 58;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxControl
            // 
            this.textBoxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControl.Location = new System.Drawing.Point(107, 59);
            this.textBoxControl.Multiline = true;
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxControl.Size = new System.Drawing.Size(222, 59);
            this.textBoxControl.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 35);
            this.label6.TabIndex = 55;
            this.label6.Text = "Контрольная";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Покрытие";
            // 
            // textBoxMyTextSles
            // 
            this.textBoxMyTextSles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMyTextSles.Location = new System.Drawing.Point(107, 145);
            this.textBoxMyTextSles.Multiline = true;
            this.textBoxMyTextSles.Name = "textBoxMyTextSles";
            this.textBoxMyTextSles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMyTextSles.Size = new System.Drawing.Size(228, 85);
            this.textBoxMyTextSles.TabIndex = 44;
            this.textBoxMyTextSles.Text = "1. Удалить налёт, коррозию.\r\n2. Зачистить забоины, заусенцы.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 85);
            this.label5.TabIndex = 58;
            this.label5.Text = "Свой текст в слесарке";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "№ додел. акта";
            // 
            // textBoxAct
            // 
            this.textBoxAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAct.Location = new System.Drawing.Point(141, 58);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(194, 22);
            this.textBoxAct.TabIndex = 25;
            // 
            // MakeDetailUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAct);
            this.Controls.Add(this.textBoxMyTextSles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.checkBoxPritirka);
            this.Controls.Add(this.groupBoxPritirka);
            this.Controls.Add(this.checkBoxDeform);
            this.Controls.Add(this.checkBoxLUM);
            this.Controls.Add(this.checkBoxNagar);
            this.Controls.Add(this.checkBoxMagnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDetNum);
            this.Name = "MakeDetailUserControl";
            this.Size = new System.Drawing.Size(338, 584);
            this.Load += new System.EventHandler(this.MakeDetailUserControl_Load);
            this.VisibleChanged += new System.EventHandler(this.MakeDetailUserControl_VisibleChanged);
            this.groupBoxPritirka.ResumeLayout(false);
            this.groupBoxPritirka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDetNum;
        private System.Windows.Forms.CheckBox checkBoxPritirka;
        private System.Windows.Forms.CheckBox checkBoxDeform;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.CheckBox checkBoxGidro;
        private System.Windows.Forms.CheckBox checkBoxLUM;
        private System.Windows.Forms.CheckBox checkBoxNagar;
        private System.Windows.Forms.CheckBox checkBoxMagnit;
        private System.Windows.Forms.ComboBox comboBoxCover;
        private System.Windows.Forms.GroupBox groupBoxPritirka;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TEST;
        private System.Windows.Forms.Panel panelShtuzers;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMyTextSles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAct;
    }
}
