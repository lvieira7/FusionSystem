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
                string cmd = @"
                    CREATE TABLE IF NOT EXISTS ""Cliente"" (
                        ""ID_Cli"" INTEGER NOT NULL UNIQUE,
                        ""Nome_Cli"" TEXT,
                        ""Tel_Cli"" TEXT UNIQUE,
                        ""CPF_Cli"" TEXT UNIQUE,
                        ""End_Cli"" TEXT,
                        PRIMARY KEY(""ID_Cli"")
                    );
                ";

                // Abrir conexão com o banco de dados
                using (var conn = DataConn.OpenConn())
                {
                    // Abre a conexão
                    conn.Open();

                    // Cria e executa o comando SQL
                    using (SQLiteCommand command = new(cmd, conn))
                    {
                        command.ExecuteNonQuery();  // Executa o comando de criação da tabela
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
