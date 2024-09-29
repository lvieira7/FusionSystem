using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FusionSystem.Classes.DataBase
{
    internal class DataString
    {
        public static SQLiteConnection ConnString()
        {
            string _connString = "Data Source=C:\\Users\\lviei\\OneDrive\\Área de Trabalho\\DB\\PDV.db;Version=3;";
            SQLiteConnection conn = new(_connString);
            return conn;
        }
    }
}
