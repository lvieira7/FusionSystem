using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FusionSystem.Classes
{
    internal class DataBase
    {
        public static void CreateData()
        {
            try
            {
                // Verifica se o arquivo de banco de dados já existe antes de criar
                if (!System.IO.File.Exists(@"C:\FusionSystemDB\Corpore.db"))
                {
                    SQLiteConnection.CreateFile(@"C:\FusionSystemDB\Corpore.db"); // Cria o arquivo do BD
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CreateTable()
        {
            try
            {
                // Abrir conexão com o banco de dados
                using (var cmd = DataConn.OpenConn().CreateCommand())
                {
                    // Cria e executa o comando SQL
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clientes(id int, Nome Varchar(50), email VarChar(80))";
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
