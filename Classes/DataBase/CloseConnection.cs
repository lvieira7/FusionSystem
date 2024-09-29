using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes.DataBase
{
    internal class CloseConnection
    {
        // Fechar conexão
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
