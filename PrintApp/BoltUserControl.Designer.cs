namespace PrintApp
{
    partial class BoltUserControl
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
            this.checkBoxNagar = new System.Windows.Forms.CheckBox();
            this.checkBoxKontr = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDetNum = new System.Windows.Forms.TextBox();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPokritie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMyText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLUM = new System.Windows.Forms.CheckBox();
            this.checkBoxMagnit = new System.Windows.Forms.CheckBox();
            this.textBoxControl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMake
            // 
            this.buttonMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(100)))));
            this.buttonMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMake.Location = new System.Drawing.Point(7, 395);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(80, 23);
            this.buttonMake.TabIndex = 3;
            this.buttonMake.Text = "Добавить";
            this.buttonMake.UseVisualStyleBackColor = false;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // checkBoxNagar
            // 
            this.checkBoxNagar.AutoSize = true;
            this.checkBoxNagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNagar.Location = new System.Drawing.Point(10, 116);
            this.checkBoxNagar.Name = "checkBoxNagar";
            this.checkBoxNagar.Size = new System.Drawing.Size(141, 20);
            this.checkBoxNagar.TabIndex = 6;
            this.checkBoxNagar.Text = "Удаление нагара";
            this.checkBoxNagar.UseVisualStyleBackColor = true;
            // 
            // checkBoxKontr
            // 
            this.checkBoxKontr.AutoSize = true;
            this.checkBoxKontr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxKontr.Location = new System.Drawing.Point(10, 142);
            this.checkBoxKontr.Name = "checkBoxKontr";
            this.checkBoxKontr.Size = new System.Drawing.Size(353, 20);
            this.checkBoxKontr.TabIndex = 7;
            this.checkBoxKontr.Text = "Удаление проволоки из контровочных отверстий";
            this.checkBoxKontr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Обозначение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Доделочный акт №";
            // 
            // textBoxDetNum
            // 
            this.textBoxDetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDetNum.Location = new System.Drawing.Point(144, 60);
            this.textBoxDetNum.Name = "textBoxDetNum";
            this.textBoxDetNum.Size = new System.Drawing.Size(188, 22);
            this.textBoxDetNum.TabIndex = 1;
            this.textBoxDetNum.TextChanged += new System.EventHandler(this.textBoxDetNum_TextChanged);
            // 
            // textBoxAct
            // 
            this.textBoxAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAct.Location = new System.Drawing.Point(144, 88);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(188, 22);
            this.textBoxAct.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(144, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Покрытие";
            // 
            // textBoxPokritie
            // 
            this.textBoxPokritie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPokritie.Location = new System.Drawing.Point(114, 288);
            this.textBoxPokritie.Name = "textBoxPokritie";
            this.textBoxPokritie.Size = new System.Drawing.Size(218, 22);
            this.textBoxPokritie.TabIndex = 5;
            this.textBoxPokritie.TextChanged += new System.EventHandler(this.textBoxPokritie_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Свой текст в слесарке";
            // 
            // textBoxMyText
            // 
            this.textBoxMyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMyText.Location = new System.Drawing.Point(114, 223);
            this.textBoxMyText.Multiline = true;
            this.textBoxMyText.Name = "textBoxMyText";
            this.textBoxMyText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMyText.Size = new System.Drawing.Size(218, 59);
            this.textBoxMyText.TabIndex = 4;
            this.textBoxMyText.Text = "1. Удалить налёт, коррозию.\r\n2. Зачистить забоины, заусенцы.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkBoxLUM);
            this.groupBox1.Controls.Add(this.checkBoxMagnit);
            this.groupBox1.Controls.Add(this.textBoxControl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMyText);
            this.groupBox1.Controls.Add(this.checkBoxKontr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBoxNagar);
            this.groupBox1.Controls.Add(this.textBoxPokritie);
            this.groupBox1.Controls.Add(this.buttonMake);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxAct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDetNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 429);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простая слесарка";
            // 
            // checkBoxLUM
            // 
            this.checkBoxLUM.AutoSize = true;
            this.checkBoxLUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLUM.Location = new System.Drawing.Point(10, 194);
            this.checkBoxLUM.Name = "checkBoxLUM";
            this.checkBoxLUM.Size = new System.Drawing.Size(153, 20);
            this.checkBoxLUM.TabIndex = 48;
            this.checkBoxLUM.Text = "Контроль ЛЮМ1-ОВ";
            this.checkBoxLUM.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagnit
            // 
            this.checkBoxMagnit.AutoSize = true;
            this.checkBoxMagnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMagnit.Location = new System.Drawing.Point(10, 168);
            this.checkBoxMagnit.Name = "checkBoxMagnit";
            this.checkBoxMagnit.Size = new System.Drawing.Size(228, 20);
            this.checkBoxMagnit.TabIndex = 47;
            this.checkBoxMagnit.Text = "Магнитопорошковый контроль";
            this.checkBoxMagnit.UseVisualStyleBackColor = true;
            // 
            // textBoxControl
            // 
            this.textBoxControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControl.Location = new System.Drawing.Point(114, 316);
            this.textBoxControl.Multiline = true;
            this.textBoxControl.Name = "textBoxControl";
            this.textBoxControl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxControl.Size = new System.Drawing.Size(218, 59);
            this.textBoxControl.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 35);
            this.label6.TabIndex = 45;
            this.label6.Text = "Контрольная";
            // 
            // BoltUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "BoltUserControl";
            this.Size = new System.Drawing.Size(366, 429);
            this.Load += new System.EventHandler(this.BoltUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.CheckBox checkBoxNagar;
        private System.Windows.Forms.CheckBox checkBoxKontr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDetNum;
        private System.Windows.Forms.TextBox textBoxAct;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPokritie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMyText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxLUM;
        private System.Windows.Forms.CheckBox checkBoxMagnit;
    }
}
