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
    public partial class OperForFreeTechUserControl : UserControl, IDisposable
    {
        ContextMenuStrip contextMenuStripPhrases;
        ContextMenuStrip contextMenuStripOsnastka;
        
        public OperForFreeTechUserControl(int top)      // конструктор для первой операции
        {
            InitializeComponent();
            contextMenuStripPhrases = new ContextMenuStrip();
            contextMenuStripOsnastka = new ContextMenuStrip();
            this.Top = top;
        }

        public OperForFreeTechUserControl(int top, OperForFreeTechUserControl prevOperation):this(top)   // конструктор для последующих операций; prevOperation - предыдущая операция, из которой вызывается конструктор данной операции
        {            
            this.Tag = prevOperation;
        }
        
        private void OperForFreeTechUserControl_Load(object sender, EventArgs e)
        {
            textBoxTextOfOper.ContextMenuStrip = contextMenuStripPhrases;
            textBoxOsnastka.ContextMenuStrip = contextMenuStripOsnastka;
            comboBoxName.Items.AddRange(Globals.namesOfOperation.Values.ToArray());
            Globals.ContextMenuLoad(contextMenuStripPhrases, Globals.dictStandartPhrases, textBoxTextOfOper);
            Globals.ContextMenuLoad(contextMenuStripOsnastka, Globals.dictOsnastka, textBoxOsnastka);

        }
          
        public void SetNameOfOper(string name)
        {
            comboBoxName.Text = name;
        }
        public void SetTextOfOper(string[] text)
        {
            textBoxTextOfOper.Lines = text;
        }
        public void SetOsnastka(string[] osnastka)
        {
            textBoxOsnastka.Lines = osnastka;
        }
        public string GetNameOfOper()
        {
            return comboBoxName.Text;
        }
        public string[] GetTextOfOper()
        {
            return textBoxTextOfOper.Lines;
        }
        public string[] GetOsnastka()
        {
            return textBoxOsnastka.Lines;
        }

            // Добавить операцию
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OperForFreeTechUserControl o = new OperForFreeTechUserControl(this.Top + this.Height, this);
            this.Parent.Controls.Add(o);
            o.SetFocusOnComboBox();
        }
            // удалить операцию
        private void buttonDel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);            
        }      
        private void contextMenuStripPhrases_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBoxTextOfOper.AppendText(e.ClickedItem.Text);
        }
        public void Delete()
        {
            //Globals.UnsucscribeToolStripMenuItem(contextMenuStripPhrases);
            //Globals.UnsucscribeToolStripMenuItem(contextMenuStripOsnastka);
            contextMenuStripPhrases.Dispose();
            contextMenuStripOsnastka.Dispose();         
        }

        /*public void Dispose()     // реализовано в дизайнере
        {
            contextMenuStripPhrases.Dispose();
            contextMenuStripOsnastka.Dispose();
        }*/

        public void SetFocusOnComboBox()
        {
            comboBoxName.Focus();
        }
    }
}