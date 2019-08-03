namespace PrintApp
{
    partial class SelfLockingNutUserControl
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
            this.textBoxPokritie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.buttonMake = new System.Windows.Forms.Button();
            this.comboBoxGOST = new System.Windows.Forms.ComboBox();
            this.checkBoxObjatie = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDetNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPokritie
            // 
            this.textBoxPokritie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPokritie.Location = new System.Drawing.Point(146, 108);
            this.textBoxPokritie.Name = "textBoxPokritie";
            this.textBoxPokritie.Size = new System.Drawing.Size(232, 22);
            this.textBoxPokritie.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Покрытие";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Типоразмер с покрытием";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Доделочный акт №";
            // 
            // textBoxType
            // 
            this.textBoxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(146, 34);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(43, 22);
            this.textBoxType.TabIndex = 0;
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // textBoxAct
            // 
            this.textBoxAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAct.Location = new System.Drawing.Point(146, 73);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(232, 22);
            this.textBoxAct.TabIndex = 2;
            // 
            // buttonMake
            // 
            this.buttonMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(0)))));
            this.buttonMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMake.Location = new System.Drawing.Point(8, 206);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(80, 23);
            this.buttonMake.TabIndex = 3;
            this.buttonMake.Text = "Добавить";
            this.buttonMake.UseVisualStyleBackColor = false;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // comboBoxGOST
            // 
            this.comboBoxGOST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGOST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGOST.DisplayMember = "GOST";
            this.comboBoxGOST.DropDownHeight = 250;
            this.comboBoxGOST.DropDownWidth = 100;
            this.comboBoxGOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGOST.FormattingEnabled = true;
            this.comboBoxGOST.IntegralHeight = false;
            this.comboBoxGOST.Location = new System.Drawing.Point(231, 34);
            this.comboBoxGOST.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxGOST.Name = "comboBoxGOST";
            this.comboBoxGOST.Size = new System.Drawing.Size(147, 24);
            this.comboBoxGOST.TabIndex = 1;
            this.comboBoxGOST.ValueMember = "GOST";
            this.comboBoxGOST.SelectedIndexChanged += new System.EventHandler(this.comboBoxGOST_SelectedIndexChanged);
            // 
            // checkBoxObjatie
            // 
            this.checkBoxObjatie.AutoSize = true;
            this.checkBoxObjatie.Checked = true;
            this.checkBoxObjatie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxObjatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxObjatie.Location = new System.Drawing.Point(8, 142);
            this.checkBoxObjatie.Name = "checkBoxObjatie";
            this.checkBoxObjatie.Size = new System.Drawing.Size(85, 20);
            this.checkBoxObjatie.TabIndex = 30;
            this.checkBoxObjatie.Text = "Обжатие";
            this.checkBoxObjatie.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Полный номер";
            // 
            // textBoxDetNum
            // 
            this.textBoxDetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDetNum.Location = new System.Drawing.Point(146, 170);
            this.textBoxDetNum.Name = "textBoxDetNum";
            this.textBoxDetNum.Size = new System.Drawing.Size(232, 22);
            this.textBoxDetNum.TabIndex = 31;
            this.textBoxDetNum.TextChanged += new System.EventHandler(this.textBoxDetNum_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "ОСТ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonMake);
            this.groupBox1.Controls.Add(this.textBoxDetNum);
            this.groupBox1.Controls.Add(this.textBoxAct);
            this.groupBox1.Controls.Add(this.checkBoxObjatie);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Controls.Add(this.comboBoxGOST);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPokritie);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 247);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Самоконтрящаяся гайка";
            // 
            // SelfLockingNutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SelfLockingNutUserControl";
            this.Size = new System.Drawing.Size(384, 247);
            this.Load += new System.EventHandler(this.SelfLockingNutUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPokritie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxAct;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.ComboBox comboBoxGOST;
        private System.Windows.Forms.CheckBox checkBoxObjatie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDetNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
