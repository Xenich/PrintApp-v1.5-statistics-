using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace PrintApp
{
    class SpecialDraw
    {

        /// <summary>
        /// Метод, печатающий верхнее и нижнее значения поля допуска в строке вида: "блаблабла_+-верх^+-низ_блаблабла"
        /// </summary>
        /// <param name="text">текст для проверки</param>
        /// <param name="f">основной шрифт</param>
        /// <param name="g">поверхность для печати</param>
        /// <param name="x">начальная позиция печати по абсциссе</param>
        /// <param name="y">начальная позиция печати по ординате</param>
        public static void CheckTolerances(string text, Font f, Graphics g, int x, int y)
        {
            if (f.Size < 5)
            {
                MessageBox.Show("Слишком маленький шрифт!");
                return;
            }
            Font smallFont = new Font("Arial", f.Size - 4);
            int highPosition = y - 2;
            int lowPosition = y + (int)(f.Size / 2) + 2;
            float stringLength = 0;   // суммарная длина уже напечатанной строки - будет накапливаться
            int prev = -1;     // конец предыдущей обработанной части строки

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '^')
                {
                    int startLeftTolerance = i;
                    int endRightTolerance = i;
                    int k = i - 1;   // начинаем парсить влево с предыдущего от шапочки символа

                    // парсим влево от шапочки
                    while (k > prev)
                    {
                        if (text[k] == ' ' || text[k] == '.' || text[k] == ';' || text[k] == ':')     // наткнулись на пробел и остальные - верхнего значения поля допуска нет
                            break;
                        if (text[k] == '+' || text[k] == '-')       // нашли верхнее значение поля допуска
                        {
                            startLeftTolerance = k;
                            break;
                        }
                        k--;        // парсим строку влево  
                    }
                    // печатаем текст слева и верхнее значение поля допуска
                    string str = CheckSpecialSymbols(text.Substring(prev + 1, startLeftTolerance - prev - 1));
                    string leftTolerance = text.Substring(startLeftTolerance, i - startLeftTolerance);
                    g.DrawString(str, f, Brushes.Black, x + stringLength, y, StringFormat.GenericTypographic);      // stringLength лишний????
                    stringLength += g.MeasureString(str, f, 999, StringFormat.GenericTypographic).Width;
                    g.DrawString(leftTolerance, smallFont, Brushes.Black, x + stringLength, highPosition, StringFormat.GenericTypographic);
                        // ищем нижнее значение поля допуска
                    k = i + 1;           // начинаем парсить вправо со следующего от шапочки символа
                        // сразу за шапочкой должен идти + или -, иначе нет нижнего значения поля допуска
                    if (k >= text.Length || (text[k] != '+' && text[k] != '-'))
                    {
                        prev = i;              // нижнего значения поля допуска нет
                    }
                    else
                    {
                        // парсим вправо
                        while (k < text.Length && text[k] != '^')
                        {
                            if (text[k] == ' ' || text[k] == '.' || text[k] == ';' || text[k] == ':')     // наткнулись на пробел и т.д. - конечный символ нижнего значения поля допуска
                            {
                                //endRightTolerance--;
                                //prev--;
                                break;
                            }
                            endRightTolerance = k;
                            prev = k;
                            k++;        // парсим строку вправо
                        }
                    }
                    // печатаем нижнее значение поля допуска
                    string rightTolerance = text.Substring(i + 1, endRightTolerance - i);
                    i = endRightTolerance;
                    g.DrawString(rightTolerance, smallFont, Brushes.Black, x + stringLength, lowPosition, StringFormat.GenericTypographic);

                    float leftTolLength = g.MeasureString(leftTolerance, smallFont, 999, StringFormat.GenericTypographic).Width;
                    float rightTolLength = g.MeasureString(rightTolerance, smallFont, 999, StringFormat.GenericTypographic).Width;
                    float minFromLeftAndRightTolerances = (leftTolLength > rightTolLength) ? leftTolLength : rightTolLength;
                    stringLength += minFromLeftAndRightTolerances;
                }
            }
            // печатаем остаток текста
            if (prev < text.Length)
            {
                string txt = CheckSpecialSymbols(text.Substring(prev + 1, text.Length - prev - 1));
                g.DrawString(txt, f, Brushes.Black, x + stringLength, y, StringFormat.GenericTypographic);
            }
        }

        /// <summary>
        /// Метод, замещающий в строке text "%%d" на значек Ø и "+-" на значек ±
        /// </summary>
        /// <param name="text">исходный текст</param>
        /// <returns>Возвращает новую строку с заменами</returns>
        private static string CheckSpecialSymbols(string text)
        {
            int diam = 216;
            int plmin = 177;
            string newText = text.Replace("%%d", ((char)diam).ToString());
            return newText.Replace("+-", ((char)plmin).ToString());
        }
    }
}
