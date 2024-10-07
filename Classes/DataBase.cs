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
                // Verifica se o diretório banco de dados já existe antes de criar
                if (!System.IO.Directory.Exists(@"C:\FusionSystemDB"))
                {
                    System.IO.Directory.CreateDirectory(@"C:\FusionSystemDB");
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
                    // Cria a tabela Cliente
                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Cliente (
                        ID_Cli INTEGER NOT NULL UNIQUE,
                        Nome_Cli TEXT,
                        Tel_Cli TEXT UNIQUE,
                        Cpf_Cli TEXT UNIQUE,
                        End_Cli TEXT,
                        PRIMARY KEY(ID_Cli AUTOINCREMENT)
                    );
                ";
                    cmd.ExecuteNonQuery();

                    // Cria a talela Produtos
                    cmd.CommandText = @"
                      CREATE TABLE IF NOT EXISTS Produtos (
	                        ID_Prod	INTEGER NOT NULL UNIQUE,
	                        Nome_Prod	TEXT NOT NULL,
	                        Descricao_Prod	TEXT NOT NULL,
	                        Tamanho_Prod	TEXT NOT NULL,
	                        Cor_Prod	TEXT NOT NULL,
	                        Preco_Prod	REAL NOT NULL,
	                        Quantidade_Prod	INTEGER NOT NULL,
	                        Categoria_Prod	TEXT NOT NULL,
	                        PRIMARY KEY(ID_Prod AUTOINCREMENT)
                        );
                ";
                    cmd.ExecuteNonQuery();
                        // Cria a tabela Login
                        cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Login (
                        User TEXT,
                        Password TEXT
                    );
                ";
                        cmd.ExecuteNonQuery();

                        // Insere valores na tabela Login
                        cmd.CommandText = @"
                    INSERT INTO Login (User, Password)
                    VALUES ('admin', 'admin');
                ";
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
