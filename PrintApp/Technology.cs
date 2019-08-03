#define D2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrintApp
{
    [Serializable]
    public class Technology : BaseTechnology
    {
        //public string name;
        //public string num;
        public string act;
        public string engine;
        public string shifr;
        //public List<Operation> listOfOperations;
        private Font simpleFont = new Font("Arial", 12);            // шрифт для небольших техпроцессов
        private Font smallSimpleFont = new Font("Arial", 10);       // маленький шрифт, которым будет выводится большой техпроцесс
        private Font underlinedFont = new Font("Arial", 12, style: FontStyle.Underline);        // подчёркнутый  шрифт для небольших техпроцессов
        private Font smallUnderlinedFont = new Font("Arial", 11, style: FontStyle.Underline);   // подчёркнутый  шрифт для больших техпроцессов
        private Font boldedFont = new Font("Arial", 12, FontStyle.Bold);
        private int high;           // высота строки
        private int prob;           //  пробел между СТРОКАМИ
        private int probel;         // пробел между ОПЕРАЦИЯМИ

        public Technology()
        { }

        /// <summary>
        /// Класс технологии - общий для всех типов деталей
        /// </summary>       
        public Technology(string Name, string Num, string Act, string Engine, string Shifr, List<Operation> ListOfOperations)
        {
            name = Name;
            num = Num;
            act = Act;
            engine = Engine;
            shifr = Shifr;
            listOfOperations = ListOfOperations;
        }
        // вывод всей формы с техпроцессом на печать
        public void Draw(Graphics g, int shiftX, int shiftY, string fam, string boss)
        {
            Dictionary<Operation, List<string>> dicOper_Convertedstrings;        // словарь операция-> пребразованный список переходов
            DrawShablons.DrawShablon(g, shiftX, shiftY, fam, boss);        // шапка
            DrawShablons.DrawTextInShablon(g, name, num, act, engine, shifr, shiftX, shiftY);   // выводим текст в шапку
            int countOfRaws = 0;        // количество всех строк
            int countOfOperations = listOfOperations.Count;  // количество операций
            int positionY = 210;        // текущая позиция строки текста по вертикали
            int numberOfOperation = 5;  // счётчик операций через 5
            Font curentFont = simpleFont;                 // текущий основной шрифт
            Font curentUnderlinedFont = underlinedFont;           // текущий подчёркнутый шрифт
                                                                  // преобразуем строки для умещения их на экран
            dicOper_Convertedstrings = StringConversion(g, shiftX, curentFont);
                // выбираем шрифт техпроцесса в зависимости от его величины
            for (int i = 0; i < countOfOperations; i++)
            {
                if (listOfOperations[i].text != null)
                    countOfRaws += dicOper_Convertedstrings[listOfOperations[i]].Count;     // количество строчек в операции 
                countOfRaws++;                                          // плюс название операции
            }
            if (countOfRaws < 24)       // небольшой техпроцесс
            {
                high = 18;
                prob = 20;
                curentFont = simpleFont;
                curentUnderlinedFont = underlinedFont;
                probel = Convert.ToInt32(((24 - (double)countOfRaws) / (double)countOfOperations) * high + 20);
            }
            else        // большой техпроцесс (меньше шрифт, чтоб всё уместилось)
            {
                high = 14;
                prob = 15;
                curentFont = smallSimpleFont;
                curentUnderlinedFont = smallUnderlinedFont;
                probel = Convert.ToInt32(((33 - (double)countOfRaws) / (double)countOfOperations) * high + 18);
                    // Опять делаем преобразование строк для умещения их на экран
                dicOper_Convertedstrings = StringConversion(g, shiftX, curentFont);
            }
                // вывод техпроцесса на печать
            foreach (Operation operation in listOfOperations)
            {
                g.DrawString("Оп." + numberOfOperation.ToString() + " " + operation.name, curentUnderlinedFont, Brushes.Black, 20 + shiftX, positionY + shiftY);       // наименование операции

                if (operation.osnastka != null)
                {
                    int positionY1 = positionY;
                    foreach (string str in operation.osnastka)
                    {
                        g.DrawString(str, curentFont, Brushes.Black, 430 + shiftX, positionY1 + shiftY);        // оснастка просто выводится без проверки на выход за пределы границ
                        positionY1 += prob;
                    }
                }
                if (operation.text != null)
                {
                    foreach (string str in dicOper_Convertedstrings[operation])
                    {
                        positionY += prob;
                        SpecialDraw.CheckTolerances(str, curentFont, g, 20 + shiftX, positionY + shiftY);
                    }
                }
                positionY += probel;
                numberOfOperation += 5;
            }
        }

        /// <summary>
        /// Преобразовывает переходы операции для умещения их на экран
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="shiftX">начальный сдвиг по Х</param>
        /// <param name="curentFont">текущий шрифт</param>
        private Dictionary<Operation, List<string>> StringConversion(Graphics g, int shiftX, Font curentFont)
        {
            Dictionary<Operation, List<string>> dicOper_Convertedstrings = new Dictionary<Operation, List<string>>();        // словарь операция-> пребразованный список переходов
            foreach (Operation operation in listOfOperations)
            {
                int stringNumber = 0;                           // номер строки
                int currentLength;                              // длина текущей строки
                List<string> stringsList = new List<string>();      // список с преобразованными строками

                if (operation.text != null)
                {
                    foreach (string str in operation.text)
                    {       // рассчитываем длину строки
                        if (operation.osnastka != null && operation.osnastka.Length > stringNumber)     // если на этой строке должна отрисовываться оснастка
                            currentLength = 430 + shiftX - 20 - shiftX - 10;
                        else                                                                             // если на этой строке НЕ должна отрисовываться оснастка
                            currentLength = 550 - 20 - 5;
                        if (g.MeasureString(str, curentFont, 999, StringFormat.GenericTypographic).Width < currentLength)       // если строка вмещается в поля, то ничего не надо делать
                        {
                            stringsList.Add(str);
                            stringNumber++;
                        }
                        else             // если строка не вмещается в поля - разбиваем её на несколько строк
                        {
                            string[] words = str.Split(' ');                        // разбиваем на слова пробелами. будем поочередно добавлять каждое слово, пока они будут вмещаться в поля
                            string temporaryString = "";
                            StringBuilder strBuilder = new StringBuilder();
                            for (int i=0; i< words.Length; i++)
                            {


                                strBuilder.Append(words[i] + " ");
                                if (g.MeasureString(strBuilder.ToString(), curentFont, 999, StringFormat.GenericTypographic).Width < currentLength)
                                    temporaryString = strBuilder.ToString();
                                else
                                {
                                    stringsList.Add(temporaryString);
                                    stringNumber++;
                                    strBuilder.Clear();
                                    if (g.MeasureString(words[i], curentFont, 999, StringFormat.GenericTypographic).Width > currentLength)
                                    {
                                        MessageBox.Show("Слишком длинное слово в операции");
                                        stringsList.Add(words[i]);
                                        stringNumber++;
                                        i++;
                                    }
                                    i--;
                                    // пересчитываем длину строки для СЛЕДУЮЩЕЙ строки
                                    if (operation.osnastka != null && operation.osnastka.Length > stringNumber)     // если на этой же строке должна отрисовываться оснастка
                                        currentLength = 430 + shiftX - 20 - shiftX - 10;
                                    else                                                                             // если на этой строке НЕ должна отрисовываться оснастка
                                        currentLength = 550 - 20 - 5;
                                }
                            }
                            stringsList.Add(temporaryString);
                        }
                    }
                    dicOper_Convertedstrings.Add(operation, stringsList);
                }
            }
            return dicOper_Convertedstrings;
        }

        public Technology Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            // XmlSerializer xmlSer = new XmlSerializer(typeof(Technology));
            // xmlSer.Serialize(ms, this);
            ms.Position = 0;
            Technology deserializedTechnology = (Technology)bf.Deserialize(ms);
            // Technology deserializedTechnology = (Technology)xmlSer.Deserialize(ms);
            ms.Close();
            return deserializedTechnology;
        }
    }
}