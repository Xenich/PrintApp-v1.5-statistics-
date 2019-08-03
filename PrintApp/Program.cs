using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace PrintApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
       /* static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }*/

        static void Main(string[] str)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globals.sharedMemory = MemoryMappedFile.CreateOrOpen("Bufer", 1000000);
            if (str.Length != 0 && str[0]=="TRUE")    // если в параметрах было что-то передано - значит в разделяемой памяти находятся техпроцессы
            {
                int size;   // размер передаваемого сообщения              
                byte[] byteArray;
                     // считываем размер сообщения
                using (MemoryMappedViewAccessor reader = Globals.sharedMemory.CreateViewAccessor(0, 4))
                {
                    size = reader.ReadInt32(0);
                    reader.Dispose();
                }
                    // считываем сообщение
                using (MemoryMappedViewAccessor reader = Globals.sharedMemory.CreateViewAccessor(4, size))
                {
                    byteArray = new byte[size];
                    reader.ReadArray<byte>(0, byteArray, 0, size);
                    reader.Dispose();
                }
                XmlSerializer xmlSer = new XmlSerializer(typeof(TechList));
                MemoryStream stream = new MemoryStream(byteArray);
                TechList Tlist = (TechList)(xmlSer.Deserialize(stream));
                Application.Run(new Form1(Tlist));
                return;
            }
            Application.Run(new Form1());
        }
    }
}
