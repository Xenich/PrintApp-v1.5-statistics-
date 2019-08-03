using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintApp
{
    public partial class FreeTechnologyUserControl : UserControl
    {
        private BaseTechnology tech;
        private LinkedList<OperForFreeTechUserControl> LLOfOperations;      // связный список в котором будет хранится очерёдность всех операций-юзерконтролов
            
            //конструктор для вновь создаваемой технологии
        public FreeTechnologyUserControl()    
        {
            InitializeComponent();
            LLOfOperations = new LinkedList<OperForFreeTechUserControl>();
            OperForFreeTechUserControl oper1 = new OperForFreeTechUserControl(10);  // первая операция
            this.Controls.Add(oper1);
            oper1.Left = 5;
            LLOfOperations.AddFirst(oper1);
            
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FreeTechnologyUserControl_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FreeTechnologyUserControl_ControlRemoved);
        }

            //конструктор для редактируемой технологии
        public FreeTechnologyUserControl(BaseTechnology tech)
        {
            InitializeComponent();
            this.tech = tech;
            LLOfOperations = new LinkedList<OperForFreeTechUserControl>();
            LinkedListNode<OperForFreeTechUserControl> prevNode = null;
            for (int i = 0; i < tech.listOfOperations.Count; i++)
            {
                OperForFreeTechUserControl operationUC;
                if (i != 0)
                {
                    operationUC = new OperForFreeTechUserControl(prevNode.Value.Top + prevNode.Value.Height + 5, prevNode.Value);
                    LLOfOperations.AddAfter(prevNode, operationUC);
                    operationUC.SetNameOfOper(tech.listOfOperations[i].name);
                    operationUC.SetTextOfOper(tech.listOfOperations[i].text);
                    operationUC.SetOsnastka(tech.listOfOperations[i].osnastka);
                }
                else    // первая операция
                {
                    operationUC = new OperForFreeTechUserControl(10);
                    LLOfOperations.AddFirst(operationUC);
                    operationUC.SetNameOfOper(tech.listOfOperations[i].name);
                    operationUC.SetTextOfOper(tech.listOfOperations[i].text);
                    operationUC.SetOsnastka(tech.listOfOperations[i].osnastka);
                }
                this.Controls.Add(operationUC);
                prevNode = LLOfOperations.Find(operationUC);
            }
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FreeTechnologyUserControl_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FreeTechnologyUserControl_ControlRemoved);
        }


            // добавление юзерконтрола операции
        private void FreeTechnologyUserControl_ControlAdded(object sender, ControlEventArgs e)
        {
                // операция, после которой вставляем новую
            LinkedListNode<OperForFreeTechUserControl> prevNode = LLOfOperations.Find((OperForFreeTechUserControl)e.Control.Tag);
                // вставка операции в LL
            LLOfOperations.AddAfter(prevNode, (OperForFreeTechUserControl)e.Control);
                // перерисовка всех контролов
            for (LinkedListNode<OperForFreeTechUserControl> node = prevNode.Next; node != null; node = node.Next)
            {
                node.Value.Top = node.Previous.Value.Top + node.Previous.Value.Height + 5;
                node.Value.Left = 5;
            }
            
        }
            // удаление юзерконтрола операции
        private void FreeTechnologyUserControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            // удаляем из списка
            LLOfOperations.Remove((OperForFreeTechUserControl)e.Control);
            //((OperForFreeTechUserControl)e.Control).Delete();
            ((OperForFreeTechUserControl)e.Control).Dispose();
            e.Control.Dispose();
                // перерисовка
            for (LinkedListNode<OperForFreeTechUserControl> oper = LLOfOperations.First; oper != null; oper = oper.Next)
            {
                if (oper == LLOfOperations.First)
                    oper.Value.Top = 10;
                else
                    oper.Value.Top = oper.Previous.Value.Top + oper.Previous.Value.Height + 5;
            }
            if (LLOfOperations.Count == 0)
            {
                OperForFreeTechUserControl oper1 = new OperForFreeTechUserControl(10);
                this.ControlAdded -= new System.Windows.Forms.ControlEventHandler(this.FreeTechnologyUserControl_ControlAdded);
                this.Controls.Add(oper1);
                this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FreeTechnologyUserControl_ControlAdded);
                LLOfOperations.AddFirst(oper1);
            }
        }

            // создать технологию из имеющихся OperForFreeTechUserControl
        public Technology MakeTechnology(string name, string num, string act, string engine, string shifr)
        {
            List<Operation> listOfOperations = new List<Operation>();
            for (LinkedListNode<OperForFreeTechUserControl> oper = LLOfOperations.First; oper != null; oper = oper.Next)
            {
                listOfOperations.Add(new Operation(oper.Value.GetNameOfOper(), oper.Value.GetTextOfOper(), oper.Value.GetOsnastka()));
            }
            Technology tech = new Technology(name, num, act, engine, shifr, listOfOperations);
            return tech;

            /*          вариант с наследованием
             * Technology tech = (Technology)MakeBaseTechnology(name, num);
            tech.act = act;
            tech.engine = engine;
            tech.shifr = shifr;
            return tech;*/
        }

            // создать базовую технологию из имеющихся OperForFreeTechUserControl
        public BaseTechnology MakeBaseTechnology(string name, string num)
        {
            List<Operation> listOfOperations = new List<Operation>();
            for (LinkedListNode<OperForFreeTechUserControl> oper = LLOfOperations.First; oper != null; oper = oper.Next)
            {
                listOfOperations.Add(new Operation(oper.Value.GetNameOfOper(), oper.Value.GetTextOfOper(), oper.Value.GetOsnastka()));
            }
            BaseTechnology tech = new BaseTechnology(name, num, listOfOperations);
            return tech;
        }

        /* public void Dispose()                 // реализовано в дизайнере
        {    }*/
    }
}
