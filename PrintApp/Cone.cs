using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace PrintApp
{
    class Cone
    {
        public int coneID;
        public string description;
        public string rezba;
        public string kalibr;
        public string otpechatok;
        public string width;
        public string text;
        public string pritir;

        public Cone(int coneID, string description, string rezba, string kalibr, string otpechatok, string width, string pritir)
        {
            this.coneID = coneID;
            this.description = description;
            this.rezba = rezba;
            this.kalibr = kalibr;
            this.otpechatok = otpechatok;
            this.width = width;
            this.pritir = pritir;
            this.text = "Тип: " + description + "; Резьба:" + rezba + "; Калибр: " + kalibr + "; Отпечаток: " + otpechatok + "; Ширина отпечатка: " + width;
        }

        public static Dictionary<string, Cone> LoadConesFromDB()
        {
            Dictionary<string, Cone> coneToConeObject = new Dictionary<string, Cone>();      // словарь КонусШтуцера - ID
            string query = "SELECT Cone.ID, Description, Rezba, Kalibr, Otpechatok, Width, Shifr FROM Cone,Pritir WHERE Pritir.ID=Cone.Type ORDER BY Cone.ID";      // 0 - ID, 1 - Description, 2 - Rezba, 3 - Kalibr, 4 - Otpechatok, 5 - Width
            OleDbConnection connection = new OleDbConnection(Globals.connectionString);
            OleDbCommand cmd = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                Cone cone = new Cone((int)datareader[0], datareader[1].ToString(), datareader[2].ToString(), datareader[3].ToString(), datareader[4].ToString(), datareader[5].ToString(), datareader[6].ToString());
                coneToConeObject.Add(cone.text, cone);
            }
            datareader.Close();
            connection.Close();
            return coneToConeObject;
        }
    }
}    
