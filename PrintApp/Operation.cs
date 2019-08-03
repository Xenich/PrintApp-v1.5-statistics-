using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintApp
{
    /// <summary>
    /// Класс операции, представляет собой отдельную операцию
    /// string[] text - массив строк с переходами
    /// string[] osnastka - массив строк с оснасткой
    /// string name - наименование операции
    /// </summary>
    [Serializable]
    public class Operation
    {
        public string[] text;
        public string[] osnastka;
        public string name;
            // беспараметрический кнструктор - необходим для XML-сериализации
        public Operation()
        { }

        /// <summary>
        /// Класс операции, представляет собой отдельную операцию
        /// </summary>
        public Operation(string Name, string[] Text, string[] Osnastka)
        {
            text = Text;
            osnastka = Osnastka;
            name = Name;
        }
        /// <summary>
        /// Класс операции, представляет собой отдельную операцию
        /// </summary>
        public Operation(string Name, string[] Text)
        {
            text = Text;
            name = Name;
        }
        /// <summary>
        /// Класс операции, представляет собой отдельную операцию
        /// </summary>
        public Operation(string Name)
        {
            name = Name;
        }
    }
}
