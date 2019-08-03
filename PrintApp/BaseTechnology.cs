using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PrintApp
{
    [Serializable]
    public class BaseTechnology
    {
        public string name;
        public string num;
        public List<Operation> listOfOperations;


        public BaseTechnology()
        { }

        public BaseTechnology(string Name, string Num, List<Operation> ListOfOperations)
        {
            name = Name;
            num = Num;
            listOfOperations = ListOfOperations;
        }

        public void SaveToDB()
        {
            string serializedTechnology = SerializeThisTechnology();

            OleDbConnection connection = new OleDbConnection(Globals.connectionString);
            string queryInsert = "INSERT INTO Technology (Name, [Number], Tech) VALUES ('" + name + "','" + num + "','" + serializedTechnology + "')";
            OleDbCommand commandIns = new OleDbCommand(queryInsert, connection);
            connection.Open();
            try
            {
                commandIns.ExecuteNonQuery();
                Globals.numberToBaseTech.Add(num, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        
        public bool ApdateInDB()
        {
            string serializedTechnology = SerializeThisTechnology();

            OleDbConnection connection = new OleDbConnection(Globals.connectionString);
            string queryApdate = "UPDATE Technology SET Name='" + name + "',Tech='" + serializedTechnology + "' WHERE [Number] = '" + num + "'";

            OleDbCommand commandApd = new OleDbCommand(queryApdate, connection);
            connection.Open();
            try
            {
                commandApd.ExecuteNonQuery();
                MessageBox.Show("Технология в базе изменена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
        string SerializeThisTechnology()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(BaseTechnology));
            MemoryStream ms = new MemoryStream();
            xmlSer.Serialize(ms, this);
            ms.Position = 0;
            StreamReader reader = new StreamReader(ms);
            string serializedTechnology = reader.ReadToEnd();
            reader.Close();
            ms.Close();
            return serializedTechnology;
        }
    }
}
