using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PrintApp
{
    class DrawShablons
    {
        private static int str = 10;
        private static Font f = new Font("Arial", 12);
        private static Font f1 = new Font("Arial", 10);
        private static int U = 25;
        private static int D = 800;
        private static int L = 15;
        private static int R = 550;
                
                // шапка 
        public static void DrawTextInShablon(Graphics g, string name, string num, string act, string engine, string shifr, int shiftX, int shiftY)
        {
            g.DrawString(name, Globals.simpleFont, Brushes.Black, Globals.namePositionX, Globals.namePositionY );
            g.DrawString(num, Globals.simpleFont, Brushes.Black, Globals.numPositionX , Globals.numPositionY );
            g.DrawString(act, Globals.simpleFont, Brushes.Black, Globals.actPositionX , Globals.actPositionY );
            g.DrawString(engine, Globals.simpleFont, Brushes.Black, Globals.enginePositionX, Globals.enginePositionY);
            g.DrawString(shifr, Globals.simpleFont, Brushes.Black, Globals.shifrPositionX , Globals.shifrPositionY );
        }
                // тут ничего не трогать
        public static void DrawShablon(Graphics g, int shiftX, int shiftY, string fam, string boss)
        {
            Pen pen = new Pen(Color.Black, 2);
            Pen pen1 = new Pen(Color.Black, 1);
                    //рамка
            if (fam!="")
                g.DrawImage(Image.FromFile("Sign.bmp"), 47 + shiftX, 743 + shiftY);           // подпись
            if (boss!="")
                g.DrawImage(Image.FromFile("BossSign.bmp"), 240 + shiftX, 743 + shiftY);      // подпись начальника группы
            g.DrawLine(pen, L + shiftX, U + shiftY, R + shiftX, U + shiftY);
            g.DrawLine(pen, L + shiftX, D + shiftY, R + shiftX, D + shiftY);
            g.DrawLine(pen, L + shiftX, U + shiftY, L + shiftX, D + shiftY);
            g.DrawLine(pen, R + shiftX, U + shiftY, R + shiftX, D + shiftY);

            str = U - 20 + shiftY;
            g.DrawString("Форма 75-039", f, Brushes.Black, 420 + shiftX, str);
            str = U + 1 + shiftY;
            g.DrawString("МАРШРУТНЫЙ ТЕХНОЛОГИЧЕСКИЙ ПРОЦЕСС РЕМОНТА", f, Brushes.Black, 50 + shiftX, str);
            str += 18;
            g.DrawString("Детали\n(Сб.единицы)", f, Brushes.Black, 20 + shiftX, str);
            g.DrawString("Наименование", f, Brushes.Black, 150 + shiftX, str);
            Globals.namePositionY = str;
            g.DrawLine(pen, L + shiftX, str, R + shiftX, str);
            int v2 = 140, v2u = str, v3u = str;
            Globals.actPositionX = v2 + shiftX;
            Globals.enginePositionX = v2 + shiftX;
            str += 20;
            g.DrawString("Обозначение", f, Brushes.Black, 150 + shiftX, str);
            Globals.numPositionY = str;
            g.DrawLine(pen, 140 + shiftX, str, R + shiftX, str);
            str += 20;
            int v4u = str;
            g.DrawString("Согласно\nдоделочному\nакту", f, Brushes.Black, 20 + shiftX, str);
            g.DrawString("Шифр затрат", f, Brushes.Black, 285 + shiftX, str + 20);
            Globals.actPositionY = str;
            Globals.shifrPositionY = str;
            int v3 = 280, v4 = 420;
            Globals.shifrPositionX = v4 + shiftX;
            Globals.namePositionX = v3 + shiftX;
            Globals.numPositionX = v3 + shiftX;
            g.DrawLine(pen, L + shiftX, str, R + shiftX, str);
            str += 60;
            g.DrawString("Двигатель\n      №", f, Brushes.Black, 20 + shiftX, str + 10);
            g.DrawString("Деталь\n(Сб. единица) №", f, Brushes.Black, 285 + shiftX, str + 10);
            Globals.enginePositionY = str;
            g.DrawLine(pen, L + shiftX, str, R + shiftX, str);
            str += 60;
            int v2d = str, v3d = str, v4d = str;
            g.DrawLine(pen, L + shiftX, str, R + shiftX, str);
            g.DrawLine(pen, v2 + shiftX, v2u, v2 + shiftX, v2d);
            g.DrawLine(pen, v3 + shiftX, v3u, v3 + shiftX, v3d);
            g.DrawLine(pen, v4 + shiftX, v4u, v4 + shiftX, v4d);
                // тонкие линии
            g.DrawLine(pen1, v2 + shiftX, v2u + 60, v3 + shiftX, v2u + 60);
            g.DrawLine(pen1, v2 + shiftX, v2u + 80, v3 + shiftX, v2u + 80);
            g.DrawLine(pen1, v2 + shiftX, v2u + 120, v3 + shiftX, v2u + 120);
            g.DrawLine(pen1, v2 + shiftX, v2u + 140, v3 + shiftX, v2u + 140);
            g.DrawLine(pen1, v4 + shiftX, v4u + 20, R + shiftX, v4u + 20);
            g.DrawLine(pen1, v4 + shiftX, v4u + 40, R + shiftX, v4u + 40);
            g.DrawLine(pen1, v4 + shiftX, v4u + 80, R + shiftX, v4u + 80);
            g.DrawLine(pen1, v4 + shiftX, v4u + 100, R + shiftX, v4u + 100);
                //НИЗ шапка
            str = D - 100+shiftY;
            g.DrawString("© ГП \"Ивченко-Прогресс\", " + DateTime.Now.Year + "\t\t   Контролировать все операции", f1, Brushes.Black, 20 + shiftX, str);

            str += 20;
            int u2u = str;
            g.DrawString("Технолог", f1, Brushes.Black, 20 + shiftX, str);
            g.DrawString("Руководитель техн. группы", f1, Brushes.Black, 195 + shiftX, str);
            g.DrawString("Согласовано", f1, Brushes.Black, 382 + shiftX, str);
            g.DrawLine(pen, R + shiftX, str, L + shiftX, str);
            str += 20;
            g.DrawString("Фамилия", f1, Brushes.Black, 20 + shiftX, str);
            g.DrawString("Фамилия", f1, Brushes.Black, 195 + shiftX, str);
            g.DrawString("Фамилия", f1, Brushes.Black, 382 + shiftX, str);
            g.DrawString(fam, f1, Brushes.Black, 87 + shiftX, str);
            g.DrawString(boss, f1, Brushes.Black, 272 + shiftX, str);
            int u1u = str;
            g.DrawLine(pen, R + shiftX, str, L + shiftX, str);
            str += 20;
            g.DrawString("Подпись", f1, Brushes.Black, 20 + shiftX, str);
            g.DrawString("Подпись", f1, Brushes.Black, 195 + shiftX, str);
            g.DrawString("Подпись", f1, Brushes.Black, 382 + shiftX, str);
            g.DrawLine(pen1, R + shiftX, str, L + shiftX, str);

            str += 20;
            g.DrawString("Дата", f1, Brushes.Black, 20 + shiftX, str);
            g.DrawString("Дата", f1, Brushes.Black, 195 + shiftX, str);
            g.DrawString("Дата", f1, Brushes.Black, 382 + shiftX, str);
            if (fam != "")
                g.DrawString(DateTime.Now.ToShortDateString(), f1, Brushes.Black, 87 + shiftX, str);
            if (boss != "")
                g.DrawString(DateTime.Now.ToShortDateString(), f1, Brushes.Black, 272 + shiftX, str);
            g.DrawLine(pen1, R + shiftX, str, L + shiftX, str);
            g.DrawLine(pen, 190 + shiftX, u2u, 190 + shiftX, D + shiftY);
            g.DrawLine(pen, 380 + shiftX, u2u, 380 + shiftX, D + shiftY);
            g.DrawLine(pen, 85 + shiftX, u1u, 85 + shiftX, D + shiftY);
            g.DrawLine(pen, 460 + shiftX, u1u, 460 + shiftX, D + shiftY);
            g.DrawLine(pen, 270 + shiftX, u1u, 270 + shiftX, D + shiftY);
        }
    }
}