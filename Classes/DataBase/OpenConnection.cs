using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FusionSystem.Classes.DataBase
{
    internal class OpenConnection
    {
        // Validar a conexão
        // Validar a conexão
        public static SQLiteConnection OpenConn()
        {
            try
            {
                SQLiteConnection conn = DataString.ConnString();
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
