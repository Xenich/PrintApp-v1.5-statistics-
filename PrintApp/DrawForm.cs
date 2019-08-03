using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintApp
{
    partial class DrawForm : Form
    {
        Technology tech;
        Graphics g;
        string fam;
        string boss;

        public DrawForm(Technology tech, string fam, string boss)
        {
            InitializeComponent();
            this.tech = tech;
            g = panelDraw.CreateGraphics();
            this.Text = tech.num + " " + tech.name + "    Предпросмотр";
            this.fam = fam;
            this.boss = boss;
            //g = pictureBox1.CreateGraphics();

        }

        private void DrawForm_Load(object sender, EventArgs e)
        {
            //Graphics g = panelDraw.CreateGraphics();
            //g.Clear(Color.White);

        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            tech.Draw(g, 0, 0,fam, boss);
        }
    }
}