using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class Data
    {
        public static SQLiteConnection ConnString()
        {
            string _connString = "Data Source=C:\\Users\\lviei\\OneDrive\\Área de Trabalho\\DB\\PDV.db;Version=3;";
            SQLiteConnection conn = new(_connString);
            return conn;
        }

        public static SQLiteConnection OpenConn()
        {
            try
            {
                SQLiteConnection conn = Data.ConnString();
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static bool CloseConn(SQLiteConnection conn)
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
