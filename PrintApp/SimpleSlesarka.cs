using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PrintApp
{
   /* 
    * class SimpleSlesarka
    {
        public string name;
        public string num;
        public string act;
        public string engine;
        public string shifr;
        public bool nagar;
        public bool zabityKontrovki;
        public string pokritie;
        Font simpleFont = new Font("Arial", 12);
        Font underlinedFont = new Font("Arial", 12, style: FontStyle.Underline);
        Font boldedFont = new Font("Arial", 12, FontStyle.Bold);
        

        public SimpleSlesarka(string Name,string Num,string Act,string Engine,string Shifr,bool Nagar,bool ZabityKontrovki, string Pokritie)
        {
            name = Name;
            num = Num;
            act = Act;
            engine = Engine;
            shifr = Shifr;
            nagar = Nagar;
            zabityKontrovki = ZabityKontrovki;
            pokritie = Pokritie;
        }

        public void Draw(Graphics g)
        {
            DrawShablons.DrawTextInShablon(g, name, num, act, engine, shifr);   // выводим текст в шапку
            int countOfRaws = 7;        // 3 на дефектация и 3 на слесарку и 1 на контрольную
            int countOfOperations = 3;  // дефектация, слесарка и контрольная
            int positionY = 210;        // текущаая позиция строки текста по вертикали
            int numberOfOperation = 5;
            if (nagar)
            { 
                countOfRaws++; 
                countOfOperations++; 
            }
            if (zabityKontrovki)
            {
                countOfRaws += 2; 
                countOfOperations++; 
            }
            if (pokritie != "")
            {
                countOfRaws++;
                countOfOperations++;
            }

            int probel = ((40 - countOfRaws) / countOfOperations )*16;
            /*if (probel > 130)
                probel =130;        // слишком большой пробел не нужен */

                //собственно техпроцесс
    /*        
    g.DrawString("Оп."+numberOfOperation.ToString()+" Дефектация", underlinedFont, Brushes.Black, 20, positionY);       // Дефектация
            positionY += 20;
            g.DrawString("Визуальный контроль на соответствие чертежу и \nотсутствие внешних дефектов.", simpleFont, Brushes.Black, 20, positionY);
            positionY += probel;
            numberOfOperation += 5;
            if (nagar)                  // Удаление нагара
            {
                g.DrawString("Оп." + numberOfOperation.ToString() + " Удаление нагара", underlinedFont, Brushes.Black, 20, positionY);
                positionY += probel;
                numberOfOperation += 5;
            }
            if (zabityKontrovki)        // Координатно-расточная
            {
                g.DrawString("Оп." + numberOfOperation.ToString() + " Координатно-расточная", underlinedFont, Brushes.Black, 20, positionY);
                positionY += 20;
                g.DrawString("Высверлить остатки контровочной проволоки.", simpleFont, Brushes.Black, 20, positionY);
                positionY += probel;
                numberOfOperation += 5;
            }
            g.DrawString("Оп." + numberOfOperation.ToString() + " Слесарная", underlinedFont, Brushes.Black, 20, positionY);        // Слесарная
            g.DrawString("ИОТ-36.255-2014\nНадфиль\n80№4\nШлиф. шкурка\n14AF1000/5C1", simpleFont, Brushes.Black, 400, positionY);
            positionY += 20;
            g.DrawString("1.Удалить налёт, коррозию. \n2. Зачистить забоины, заусенцы", simpleFont, Brushes.Black, 20, positionY);
            positionY += probel;
            numberOfOperation += 5;
            if (pokritie != "")                                                                                                     // Покрытие
            {
                g.DrawString("Оп." + numberOfOperation.ToString() + " "+pokritie, underlinedFont, Brushes.Black, 20, positionY);
                positionY += probel;
                numberOfOperation += 5;
            }
            g.DrawString("Оп." + numberOfOperation.ToString() + " Контрольная", underlinedFont, Brushes.Black, 20, positionY);      // Контрольная
        }     
    }*/
}