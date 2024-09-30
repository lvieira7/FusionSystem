using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class DataConn
    {
        public static SQLiteConnection ConnString()
        {
            string _connString = "Data Source=C:\\FusionSystemDB\\Corpore.db;Version=3;"; // String de conexão com BD
            SQLiteConnection conn = new(_connString); //cria conexão utilziando a string como parâmetro de conexão
            return conn; // método retorna a conexão com string
        }

        public static SQLiteConnection OpenConn()
        {
            try
            {
                SQLiteConnection conn = DataConn.ConnString(); // atribui o ConnString ao conn
                conn.Open(); // abre conexão
                return conn; // retorna conexão aberta
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // captura o erro e mostra no MenssageBox
                return null;
            }
        }

        public static bool CloseConn(SQLiteConnection conn) // fecha conexão
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
