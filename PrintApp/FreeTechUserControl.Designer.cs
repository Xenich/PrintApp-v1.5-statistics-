namespace PrintApp
{
    partial class FreeTechUserControl
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
            this.panelTech = new System.Windows.Forms.Panel();
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxFree = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDetNum = new System.Windows.Forms.TextBox();
            this.textBoxAct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDouble = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxFree.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTech
            // 
            this.panelTech.AutoScroll = true;
            this.panelTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTech.Location = new System.Drawing.Point(3, 133);
            this.panelTech.MinimumSize = new System.Drawing.Size(450, 160);
            this.panelTech.Name = "panelTech";
            this.panelTech.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panelTech.Size = new System.Drawing.Size(450, 160);
            this.panelTech.TabIndex = 4;
            // 
            // buttonMake
            // 
            this.buttonMake.AutoSize = true;
            this.buttonMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(100)))));
            this.buttonMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMake.Location = new System.Drawing.Point(3, 3);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(73, 26);
            this.buttonMake.TabIndex = 5;
            this.buttonMake.Text = "Создать";
            this.buttonMake.UseVisualStyleBackColor = false;
            this.buttonMake.SizeChanged += new System.EventHandler(this.buttonMake_SizeChanged);
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(100)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(82, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 26);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить в базу";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTech, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 332);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxFree);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 124);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxFree
            // 
            this.groupBoxFree.AutoSize = true;
            this.groupBoxFree.Controls.Add(this.label2);
            this.groupBoxFree.Controls.Add(this.label1);
            this.groupBoxFree.Controls.Add(this.textBoxName);
            this.groupBoxFree.Controls.Add(this.textBoxDetNum);
            this.groupBoxFree.Controls.Add(this.textBoxAct);
            this.groupBoxFree.Controls.Add(this.label3);
            this.groupBoxFree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxFree.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFree.Name = "groupBoxFree";
            this.groupBoxFree.Size = new System.Drawing.Size(450, 124);
            this.groupBoxFree.TabIndex = 23;
            this.groupBoxFree.TabStop = false;
            this.groupBoxFree.Text = "Свободная технология";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Доделочный акт №";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(143, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxDetNum
            // 
            this.textBoxDetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDetNum.Location = new System.Drawing.Point(143, 54);
            this.textBoxDetNum.Name = "textBoxDetNum";
            this.textBoxDetNum.Size = new System.Drawing.Size(188, 22);
            this.textBoxDetNum.TabIndex = 2;
            // 
            // textBoxAct
            // 
            this.textBoxAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAct.Location = new System.Drawing.Point(143, 82);
            this.textBoxAct.Name = "textBoxAct";
            this.textBoxAct.Size = new System.Drawing.Size(188, 22);
            this.textBoxAct.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Обозначение";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonMake);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Controls.Add(this.buttonDouble);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 298);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(452, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonDouble
            // 
            this.buttonDouble.AutoSize = true;
            this.buttonDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(100)))));
            this.buttonDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDouble.Location = new System.Drawing.Point(215, 3);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(105, 26);
            this.buttonDouble.TabIndex = 7;
            this.buttonDouble.Text = "Дублировать";
            this.buttonDouble.UseVisualStyleBackColor = false;
            this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
            // 
            // FreeTechUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FreeTechUserControl";
            this.Size = new System.Drawing.Size(456, 332);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxFree.ResumeLayout(false);
            this.groupBoxFree.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTech;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxFree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDetNum;
        private System.Windows.Forms.TextBox textBoxAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDouble;

        //private TechForFreeTechUserControl techForFreeTechUserControl1;

    }
}
