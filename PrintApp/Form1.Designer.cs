namespace PrintApp
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxBoss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPrintA4 = new System.Windows.Forms.Button();
            this.buttonPrintA3 = new System.Windows.Forms.Button();
            this.labelPathToDB = new System.Windows.Forms.Label();
            this.labelDictQweweCount = new System.Windows.Forms.Label();
            this.labelCountOfTechs = new System.Windows.Forms.Label();
            this.textBoxFam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountOfActs = new System.Windows.Forms.Label();
            this.buttonNull = new System.Windows.Forms.Button();
            this.buttonPageSetup = new System.Windows.Forms.Button();
            this.buttonA5 = new System.Windows.Forms.Button();
            this.tableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewListOfDetails = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDuble = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Print = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStripDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenInNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьИзБуфераОбменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.buttonThesaurus = new System.Windows.Forms.Button();
            this.FreeTech = new System.Windows.Forms.Button();
            this.makeDetail = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.UnknownDet = new System.Windows.Forms.Button();
            this.SelfLockingNut = new System.Windows.Forms.Button();
            this.buttonBolt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxShifr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.dlgPageSetup = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.БазаtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личманДмитрийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfDetails)).BeginInit();
            this.contextMenuStripDataGrid.SuspendLayout();
            this.panelChoose.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage);
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Location = new System.Drawing.Point(1070, 4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(108, 34);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Печать без предпросмотра";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Visible = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBoss);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPrintA4);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPrintA3);
            this.splitContainer1.Panel1.Controls.Add(this.labelPathToDB);
            this.splitContainer1.Panel1.Controls.Add(this.labelDictQweweCount);
            this.splitContainer1.Panel1.Controls.Add(this.labelCountOfTechs);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxFam);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelCountOfActs);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNull);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPageSetup);
            this.splitContainer1.Panel1.Controls.Add(this.buttonA5);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPrint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelAll);
            this.splitContainer1.Size = new System.Drawing.Size(1768, 634);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBoxBoss
            // 
            this.textBoxBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBoss.Location = new System.Drawing.Point(798, 19);
            this.textBoxBoss.Name = "textBoxBoss";
            this.textBoxBoss.Size = new System.Drawing.Size(124, 22);
            this.textBoxBoss.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(705, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Нач. группы";
            // 
            // buttonPrintA4
            // 
            this.buttonPrintA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonPrintA4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintA4.Location = new System.Drawing.Point(189, 3);
            this.buttonPrintA4.Name = "buttonPrintA4";
            this.buttonPrintA4.Size = new System.Drawing.Size(87, 40);
            this.buttonPrintA4.TabIndex = 11;
            this.buttonPrintA4.Text = "Печать А4\r\n(ландшафт)";
            this.buttonPrintA4.UseVisualStyleBackColor = false;
            this.buttonPrintA4.Click += new System.EventHandler(this.buttonPrintA4_Click);
            // 
            // buttonPrintA3
            // 
            this.buttonPrintA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonPrintA3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrintA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintA3.Location = new System.Drawing.Point(282, 3);
            this.buttonPrintA3.Name = "buttonPrintA3";
            this.buttonPrintA3.Size = new System.Drawing.Size(89, 40);
            this.buttonPrintA3.TabIndex = 10;
            this.buttonPrintA3.Text = "Печать А3";
            this.buttonPrintA3.UseVisualStyleBackColor = false;
            this.buttonPrintA3.Click += new System.EventHandler(this.buttonPrintA3_Click);
            // 
            // labelPathToDB
            // 
            this.labelPathToDB.AutoSize = true;
            this.labelPathToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathToDB.Location = new System.Drawing.Point(500, 2);
            this.labelPathToDB.Name = "labelPathToDB";
            this.labelPathToDB.Size = new System.Drawing.Size(75, 13);
            this.labelPathToDB.TabIndex = 9;
            this.labelPathToDB.Text = "База данных:";
            // 
            // labelDictQweweCount
            // 
            this.labelDictQweweCount.AutoSize = true;
            this.labelDictQweweCount.Location = new System.Drawing.Point(1184, 17);
            this.labelDictQweweCount.Name = "labelDictQweweCount";
            this.labelDictQweweCount.Size = new System.Drawing.Size(91, 13);
            this.labelDictQweweCount.TabIndex = 8;
            this.labelDictQweweCount.Text = "dictQwewe.Count";
            // 
            // labelCountOfTechs
            // 
            this.labelCountOfTechs.AutoSize = true;
            this.labelCountOfTechs.Location = new System.Drawing.Point(1184, 4);
            this.labelCountOfTechs.Name = "labelCountOfTechs";
            this.labelCountOfTechs.Size = new System.Drawing.Size(85, 13);
            this.labelCountOfTechs.TabIndex = 7;
            this.labelCountOfTechs.Text = "CounterOfTechs";
            // 
            // textBoxFam
            // 
            this.textBoxFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFam.Location = new System.Drawing.Point(575, 19);
            this.textBoxFam.Name = "textBoxFam";
            this.textBoxFam.Size = new System.Drawing.Size(124, 22);
            this.textBoxFam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(500, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Технолог";
            // 
            // labelCountOfActs
            // 
            this.labelCountOfActs.AutoSize = true;
            this.labelCountOfActs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountOfActs.Location = new System.Drawing.Point(950, 22);
            this.labelCountOfActs.Name = "labelCountOfActs";
            this.labelCountOfActs.Size = new System.Drawing.Size(92, 16);
            this.labelCountOfActs.TabIndex = 4;
            this.labelCountOfActs.Text = "Кол-во д/а - 0";
            // 
            // buttonNull
            // 
            this.buttonNull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonNull.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNull.Location = new System.Drawing.Point(407, 3);
            this.buttonNull.Name = "buttonNull";
            this.buttonNull.Size = new System.Drawing.Size(87, 40);
            this.buttonNull.TabIndex = 3;
            this.buttonNull.Text = "Обнулить";
            this.buttonNull.UseVisualStyleBackColor = false;
            this.buttonNull.Click += new System.EventHandler(this.buttonNull_Click);
            // 
            // buttonPageSetup
            // 
            this.buttonPageSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonPageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPageSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPageSetup.Location = new System.Drawing.Point(3, 3);
            this.buttonPageSetup.Name = "buttonPageSetup";
            this.buttonPageSetup.Size = new System.Drawing.Size(87, 40);
            this.buttonPageSetup.TabIndex = 2;
            this.buttonPageSetup.Text = "Настройка печати";
            this.buttonPageSetup.UseVisualStyleBackColor = false;
            this.buttonPageSetup.Click += new System.EventHandler(this.buttonPageSetup_Click);
            // 
            // buttonA5
            // 
            this.buttonA5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonA5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonA5.Location = new System.Drawing.Point(96, 3);
            this.buttonA5.Name = "buttonA5";
            this.buttonA5.Size = new System.Drawing.Size(87, 40);
            this.buttonA5.TabIndex = 1;
            this.buttonA5.Text = "Печать А5";
            this.buttonA5.UseVisualStyleBackColor = false;
            this.buttonA5.Click += new System.EventHandler(this.buttonA5_Click);
            // 
            // tableLayoutPanelAll
            // 
            this.tableLayoutPanelAll.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAll.ColumnCount = 3;
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelAll.Controls.Add(this.dataGridViewListOfDetails, 2, 0);
            this.tableLayoutPanelAll.Controls.Add(this.panelChoose, 0, 0);
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            this.tableLayoutPanelAll.RowCount = 1;
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAll.Size = new System.Drawing.Size(1766, 570);
            this.tableLayoutPanelAll.TabIndex = 3;
            // 
            // dataGridViewListOfDetails
            // 
            this.dataGridViewListOfDetails.AllowUserToAddRows = false;
            this.dataGridViewListOfDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOfDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListOfDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ColumnAct,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ColumnDuble,
            this.Print});
            this.dataGridViewListOfDetails.ContextMenuStrip = this.contextMenuStripDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListOfDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListOfDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListOfDetails.Location = new System.Drawing.Point(683, 4);
            this.dataGridViewListOfDetails.Name = "dataGridViewListOfDetails";
            this.dataGridViewListOfDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListOfDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListOfDetails.Size = new System.Drawing.Size(1079, 562);
            this.dataGridViewListOfDetails.TabIndex = 0;
            this.dataGridViewListOfDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOfDetails_CellClick);
            this.dataGridViewListOfDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOfDetails_CellDoubleClick);
            this.dataGridViewListOfDetails.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewListOfDetails_RowsAdded);
            this.dataGridViewListOfDetails.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewListOfDetails_RowsRemoved);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Number.DividerWidth = 1;
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 60;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 77;
            // 
            // ColumnAct
            // 
            this.ColumnAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAct.HeaderText = "Дод. акт";
            this.ColumnAct.MinimumWidth = 50;
            this.ColumnAct.Name = "ColumnAct";
            this.ColumnAct.ReadOnly = true;
            this.ColumnAct.Width = 86;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Деталь";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "Наименование";
            this.Column6.MinimumWidth = 150;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Двигатель";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 102;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.FillWeight = 90F;
            this.Column3.HeaderText = "Шифр затрат";
            this.Column3.MinimumWidth = 90;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Удалить";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 69;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Редактировать";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 134;
            // 
            // ColumnDuble
            // 
            this.ColumnDuble.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnDuble.HeaderText = "Дублировать";
            this.ColumnDuble.Name = "ColumnDuble";
            this.ColumnDuble.ReadOnly = true;
            this.ColumnDuble.Width = 101;
            // 
            // Print
            // 
            this.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Print.HeaderText = "Печатать";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Print.Width = 96;
            // 
            // contextMenuStripDataGrid
            // 
            this.contextMenuStripDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenInNewWindow,
            this.скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem,
            this.вставитьИзБуфераОбменаToolStripMenuItem});
            this.contextMenuStripDataGrid.Name = "contextMenuStripDataGrid";
            this.contextMenuStripDataGrid.Size = new System.Drawing.Size(377, 70);
            // 
            // toolStripMenuItemOpenInNewWindow
            // 
            this.toolStripMenuItemOpenInNewWindow.Name = "toolStripMenuItemOpenInNewWindow";
            this.toolStripMenuItemOpenInNewWindow.Size = new System.Drawing.Size(376, 22);
            this.toolStripMenuItemOpenInNewWindow.Text = "Открыть выделенные операции в новом окне";
            this.toolStripMenuItemOpenInNewWindow.Click += new System.EventHandler(this.toolStripMenuItemOpenInNewWindow_Click);
            // 
            // скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem
            // 
            this.скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem.Name = "скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem";
            this.скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem.Size = new System.Drawing.Size(376, 22);
            this.скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem.Text = "Скопировать выделенные технологии в буфер обмена";
            this.скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemCopyToMappedMemory_Click);
            // 
            // вставитьИзБуфераОбменаToolStripMenuItem
            // 
            this.вставитьИзБуфераОбменаToolStripMenuItem.Name = "вставитьИзБуфераОбменаToolStripMenuItem";
            this.вставитьИзБуфераОбменаToolStripMenuItem.Size = new System.Drawing.Size(376, 22);
            this.вставитьИзБуфераОбменаToolStripMenuItem.Text = "Вставить из буфера обмена";
            this.вставитьИзБуфераОбменаToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemPasteFromMappedMemory_Click);
            // 
            // panelChoose
            // 
            this.panelChoose.AutoSize = true;
            this.panelChoose.Controls.Add(this.buttonThesaurus);
            this.panelChoose.Controls.Add(this.FreeTech);
            this.panelChoose.Controls.Add(this.makeDetail);
            this.panelChoose.Controls.Add(this.buttonStatistics);
            this.panelChoose.Controls.Add(this.UnknownDet);
            this.panelChoose.Controls.Add(this.SelfLockingNut);
            this.panelChoose.Controls.Add(this.buttonBolt);
            this.panelChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChoose.Location = new System.Drawing.Point(1, 1);
            this.panelChoose.Margin = new System.Windows.Forms.Padding(0);
            this.panelChoose.Name = "panelChoose";
            this.panelChoose.Size = new System.Drawing.Size(94, 568);
            this.panelChoose.TabIndex = 7;
            // 
            // buttonThesaurus
            // 
            this.buttonThesaurus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThesaurus.Location = new System.Drawing.Point(4, 306);
            this.buttonThesaurus.Name = "buttonThesaurus";
            this.buttonThesaurus.Size = new System.Drawing.Size(87, 29);
            this.buttonThesaurus.TabIndex = 8;
            this.buttonThesaurus.Text = "Справочник";
            this.buttonThesaurus.UseVisualStyleBackColor = true;
            this.buttonThesaurus.Click += new System.EventHandler(this.buttonThesaurus_Click);
            // 
            // FreeTech
            // 
            this.FreeTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FreeTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FreeTech.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreeTech.Location = new System.Drawing.Point(3, 160);
            this.FreeTech.Margin = new System.Windows.Forms.Padding(0);
            this.FreeTech.Name = "FreeTech";
            this.FreeTech.Size = new System.Drawing.Size(86, 42);
            this.FreeTech.TabIndex = 4;
            this.FreeTech.Text = "Своя технология";
            this.FreeTech.UseVisualStyleBackColor = false;
            this.FreeTech.Click += new System.EventHandler(this.FreeTech_Click);
            // 
            // makeDetail
            // 
            this.makeDetail.BackColor = System.Drawing.Color.White;
            this.makeDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.makeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeDetail.Location = new System.Drawing.Point(3, 206);
            this.makeDetail.Name = "makeDetail";
            this.makeDetail.Size = new System.Drawing.Size(87, 42);
            this.makeDetail.TabIndex = 5;
            this.makeDetail.Text = "Создать деталь";
            this.makeDetail.UseVisualStyleBackColor = false;
            this.makeDetail.Click += new System.EventHandler(this.makeDetail_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistics.Location = new System.Drawing.Point(4, 262);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(86, 37);
            this.buttonStatistics.TabIndex = 6;
            this.buttonStatistics.Text = "Статистика";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistycs_Click);
            // 
            // UnknownDet
            // 
            this.UnknownDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.UnknownDet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnknownDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnknownDet.Location = new System.Drawing.Point(2, 112);
            this.UnknownDet.Name = "UnknownDet";
            this.UnknownDet.Size = new System.Drawing.Size(87, 42);
            this.UnknownDet.TabIndex = 3;
            this.UnknownDet.Text = "Шифровая деталь";
            this.UnknownDet.UseVisualStyleBackColor = false;
            this.UnknownDet.Click += new System.EventHandler(this.UnknownDet_Click);
            // 
            // SelfLockingNut
            // 
            this.SelfLockingNut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SelfLockingNut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelfLockingNut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelfLockingNut.Location = new System.Drawing.Point(2, 49);
            this.SelfLockingNut.Name = "SelfLockingNut";
            this.SelfLockingNut.Size = new System.Drawing.Size(87, 57);
            this.SelfLockingNut.TabIndex = 2;
            this.SelfLockingNut.Text = "Самоконтрящаяся гайка";
            this.SelfLockingNut.UseVisualStyleBackColor = false;
            this.SelfLockingNut.Click += new System.EventHandler(this.SelfLockingNut_Click);
            // 
            // buttonBolt
            // 
            this.buttonBolt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonBolt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBolt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonBolt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBolt.Location = new System.Drawing.Point(2, 3);
            this.buttonBolt.Name = "buttonBolt";
            this.buttonBolt.Size = new System.Drawing.Size(87, 40);
            this.buttonBolt.TabIndex = 1;
            this.buttonBolt.Text = "Простая слесарка";
            this.buttonBolt.UseVisualStyleBackColor = false;
            this.buttonBolt.Click += new System.EventHandler(this.buttonBolt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(99, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(577, 562);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxShifr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxEngine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 44);
            this.panel1.TabIndex = 0;
            // 
            // textBoxShifr
            // 
            this.textBoxShifr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShifr.Location = new System.Drawing.Point(290, 7);
            this.textBoxShifr.Name = "textBoxShifr";
            this.textBoxShifr.Size = new System.Drawing.Size(69, 22);
            this.textBoxShifr.TabIndex = 9;
            this.textBoxShifr.TextChanged += new System.EventHandler(this.textBoxShifr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Двигатель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(248, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ш. з.";
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEngine.Location = new System.Drawing.Point(92, 9);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(151, 22);
            this.textBoxEngine.TabIndex = 7;
            this.textBoxEngine.TextChanged += new System.EventHandler(this.textBoxEngine_TextChanged);
            // 
            // dlgPrintPreview
            // 
            this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.ClientSize = new System.Drawing.Size(394, 294);
            this.dlgPrintPreview.Document = this.printDocument;
            this.dlgPrintPreview.Enabled = true;
            this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
            this.dlgPrintPreview.Name = "dlgPrintPreview";
            this.dlgPrintPreview.Visible = false;
            // 
            // dlgPageSetup
            // 
            this.dlgPageSetup.Document = this.printDocument;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1768, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.печатьStripMenuItem,
            this.toolStripSeparator3,
            this.БазаtoolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(272, 40);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(272, 40);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(272, 40);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // печатьStripMenuItem
            // 
            this.печатьStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.печатьStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьStripMenuItem.Image")));
            this.печатьStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.печатьStripMenuItem.Name = "печатьStripMenuItem";
            this.печатьStripMenuItem.Size = new System.Drawing.Size(272, 40);
            this.печатьStripMenuItem.Text = "Печать...";
            this.печатьStripMenuItem.Click += new System.EventHandler(this.печатьStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(269, 6);
            // 
            // БазаtoolStripMenuItem
            // 
            this.БазаtoolStripMenuItem.Name = "БазаtoolStripMenuItem";
            this.БазаtoolStripMenuItem.Size = new System.Drawing.Size(272, 40);
            this.БазаtoolStripMenuItem.Text = "Указать путь к базе данных...";
            this.БазаtoolStripMenuItem.Click += new System.EventHandler(this.БазаtoolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.личманДмитрийToolStripMenuItem});
            this.обАвтореToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // личманДмитрийToolStripMenuItem
            // 
            this.личманДмитрийToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.личманДмитрийToolStripMenuItem.Name = "личманДмитрийToolStripMenuItem";
            this.личманДмитрийToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.личманДмитрийToolStripMenuItem.Text = "Личман Дмитрий";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "*.dat|*.dat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1768, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Генератор техпроцессов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanelAll.ResumeLayout(false);
            this.tableLayoutPanelAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfDetails)).EndInit();
            this.contextMenuStripDataGrid.ResumeLayout(false);
            this.panelChoose.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonA5;
        private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
        private System.Windows.Forms.PageSetupDialog dlgPageSetup;
        private System.Windows.Forms.Button buttonPageSetup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAll;
        private System.Windows.Forms.Button buttonBolt;
        private System.Windows.Forms.TextBox textBoxShifr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Button buttonNull;
        private System.Windows.Forms.DataGridView dataGridViewListOfDetails;
        private System.Windows.Forms.Button SelfLockingNut;
        private System.Windows.Forms.Button UnknownDet;
        private System.Windows.Forms.Label labelCountOfActs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.ToolStripMenuItem личманДмитрийToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelDictQweweCount;
        private System.Windows.Forms.Label labelCountOfTechs;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem печатьStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem БазаtoolStripMenuItem;
        private System.Windows.Forms.Label labelPathToDB;
        private System.Windows.Forms.Button makeDetail;
        private System.Windows.Forms.Button FreeTech;
        private System.Windows.Forms.Button buttonPrintA3;
        private System.Windows.Forms.Button buttonThesaurus;
        private System.Windows.Forms.Button buttonPrintA4;
        private System.Windows.Forms.TextBox textBoxBoss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDuble;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Print;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenInNewWindow;
        private System.Windows.Forms.ToolStripMenuItem скопироватьВыделенныеТехнологииВБуферОбменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьИзБуфераОбменаToolStripMenuItem;
    }
}

