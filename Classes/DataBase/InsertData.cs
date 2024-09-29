using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes.DataBase
{
    internal class InsertData
    {
        public static void Add(string nome, string tel, string cpf, string endereco)
        {
            try
            {
                using (SQLiteCommand cmd = new())
                {
                    cmd.CommandText = "INSERT INTO Usuario(Nome_Usuario, Tel_Usuario, Cpf_Usuario, Endereco_Usuario) " +
                                      "VALUES (@Nome, @Tel, @Cpf, @Endereco)";
                    cmd.Parameters.AddWithValue("@Nome",nome );
                    cmd.Parameters.AddWithValue("@Tel", tel);
                    cmd.Parameters.AddWithValue("@Cpf", cpf);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
