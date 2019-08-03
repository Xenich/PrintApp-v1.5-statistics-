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
    public partial class ThesaurusUserControl : UserControl
    {
        // словарь с тринодами тезауруса
        static Dictionary<int, TreeNode> dictTree;
        public ThesaurusUserControl()
        {
            InitializeComponent();
            dictTree= new Dictionary<int, TreeNode>();
                // загружаем словарь с нодами тривьюва тезауруса
            ThesaurusLoad();
            LoadInTreeView(treeView);
            foreach (TreeNode tn in treeView.Nodes)
            {
                recurs(tn);
            }
        }

        private void ThesaurusUserControl_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

            // загрузка нодов в дерево TreeView tv
        private static void LoadInTreeView(TreeView tv)
        {           
            ICollection<int> keys = Globals.dictStandartPhrases.Keys;
            foreach (int key in keys)
            {
                int parentID = Globals.dictStandartPhrases[key].parentID;
                if (parentID == 0)
                    tv.Nodes.Add(dictTree[key]);
                else
                    dictTree[parentID].Nodes.Add(dictTree[key]);
            }           
        }
            // рекурсивное заполнение детей контекстменюшками
        private void recurs(TreeNode tn)
        {
            if (tn.GetNodeCount(false) > 0)
            {
                tn.ContextMenuStrip = CMSParent;
                foreach (TreeNode child in tn.Nodes)
                {
                    recurs(child);
                }
            }
            else
                tn.ContextMenuStrip = CMSLastNode;
        }

        // загружаем ноды тезауруса
        private static void ThesaurusLoad()
        {
            ICollection<int> keys = Globals.dictStandartPhrases.Keys;

            foreach (int key in keys)
            {
                dictTree.Add(key, new TreeNode((Globals.dictStandartPhrases[key]).text));
            }
        }
    }
}
