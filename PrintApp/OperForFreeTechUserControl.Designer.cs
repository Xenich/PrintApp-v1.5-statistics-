namespace PrintApp
{
    partial class OperForFreeTechUserControl
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
            contextMenuStripOsnastka.Dispose();
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTextOfOper = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOsnastka = new System.Windows.Forms.TextBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonAdd.Location = new System.Drawing.Point(413, 96);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 50);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить\r\nоперацию";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTextOfOper
            // 
            this.textBoxTextOfOper.AutoCompleteCustomSource.AddRange(new string[] {
            "точить",
            "фрезеровать",
            "сверлить",
            "удалить",
            "заусенцы",
            "притупить",
            "острые",
            "кромки"});
            this.textBoxTextOfOper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTextOfOper.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxTextOfOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTextOfOper.Location = new System.Drawing.Point(2, 30);
            this.textBoxTextOfOper.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTextOfOper.Multiline = true;
            this.textBoxTextOfOper.Name = "textBoxTextOfOper";
            this.textBoxTextOfOper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTextOfOper.Size = new System.Drawing.Size(295, 116);
            this.textBoxTextOfOper.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonDel.Location = new System.Drawing.Point(413, 32);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(85, 50);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить\r\nоперацию";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оснастка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOsnastka
            // 
            this.textBoxOsnastka.Location = new System.Drawing.Point(302, 31);
            this.textBoxOsnastka.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.textBoxOsnastka.MaximumSize = new System.Drawing.Size(0, 150);
            this.textBoxOsnastka.Multiline = true;
            this.textBoxOsnastka.Name = "textBoxOsnastka";
            this.textBoxOsnastka.Size = new System.Drawing.Size(106, 115);
            this.textBoxOsnastka.TabIndex = 2;
            // 
            // comboBoxName
            // 
            this.comboBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(1, 2);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxName.MaxDropDownItems = 30;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(296, 24);
            this.comboBoxName.TabIndex = 0;
            // 
            // OperForFreeTechUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBoxTextOfOper);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOsnastka);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OperForFreeTechUserControl";
            this.Size = new System.Drawing.Size(504, 150);
            this.Load += new System.EventHandler(this.OperForFreeTechUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTextOfOper;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOsnastka;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}
