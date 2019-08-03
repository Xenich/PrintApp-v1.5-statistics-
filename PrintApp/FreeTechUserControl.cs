using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace PrintApp
{
    partial class FreeTechUserControl : UserControl//,IDisposable
    {
        private bool isOld = false;
        private int index;
        private DataGridViewRow DGVR;
        FreeTechnologyUserControl ftuc;     // юзерконтрол с технологией    

            //конструктор для вновь создаваемой технологии
        public FreeTechUserControl()    
        {
            InitializeComponent();
            ftuc = new FreeTechnologyUserControl();
            panelTech.Controls.Add(ftuc);
        }

            //конструктор для редактируемой технологии
        public FreeTechUserControl(Technology tech, int index, DataGridViewRow DGVR)
        {   
            InitializeComponent();
            isOld = true;
            this.index = index;
            this.DGVR = DGVR;
            buttonMake.Text = "Сохранить изменения";
            textBoxName.Text = tech.name;
            textBoxAct.Text = tech.act;
            textBoxDetNum.Text = tech.num;
            Globals.TxtBoxEngine.Text = tech.engine;
            Globals.TxtBoxShifr.Text = tech.shifr;
            ftuc = new FreeTechnologyUserControl(tech);
            panelTech.Controls.Add(ftuc);
        }      

        private void buttonMake_Click(object sender, EventArgs e)
        {
            Technology tech = ftuc.MakeTechnology(textBoxName.Text, textBoxDetNum.Text, textBoxAct.Text, Globals.TxtBoxEngine.Text, Globals.TxtBoxShifr.Text);
            if (isOld)      // если редактирование имеющегося ТП
            {
                Globals.dictQwewe[index] = tech;
                DGVR.Cells[0].Value = index;
                DGVR.Cells[1].Value = textBoxAct.Text;
                DGVR.Cells[2].Value = textBoxDetNum.Text;
                DGVR.Cells[3].Value = textBoxName.Text;
                DGVR.Cells[4].Value = Globals.TxtBoxEngine.Text;
                DGVR.Cells[5].Value = Globals.TxtBoxShifr.Text;
                //DGVR.Cells[6].Value = "Удалить";
                //DGVR.Cells[7].Value = "Редактировать";
            }
            else        // если создание нового ТП
                Globals.AddTechnology(tech);
            RenullControl();
        }

            // Кнопка *Дублировать*
        private void buttonDouble_Click(object sender, EventArgs e)
        {
            Technology tech = ftuc.MakeTechnology(textBoxName.Text, textBoxDetNum.Text, textBoxAct.Text, Globals.TxtBoxEngine.Text, Globals.TxtBoxShifr.Text);
            Globals.AddTechnology(tech);
            RenullControl();
        }

        private void RenullControl()
        {
            isOld = false;
            panelTech.Controls.Clear();
            ftuc.Dispose();
            ftuc = new FreeTechnologyUserControl();
            panelTech.Controls.Add(ftuc);
        }


        private void buttonMake_SizeChanged(object sender, EventArgs e)
        {
            buttonDouble.Left = buttonMake.Left + buttonMake.Width + 10;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxDetNum.Text == "")
            {
                MessageBox.Show("Введите номер и наименование детали");
                return;
            }
            BaseTechnology tech = ftuc.MakeBaseTechnology(textBoxName.Text, textBoxDetNum.Text);
            tech.SaveToDB();
        }
    }
}