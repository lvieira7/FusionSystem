using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class Query
    {
        public static void Insert(TextBox nome, MaskedTextBox tel, MaskedTextBox cpf, TextBox end)
        {
            using (var cmd = DataConn.OpenConn().CreateCommand())
            {
                //INSERT INTO Cliente (Nome_Cli, Tel_Cli, Cpf_Cli, End_Cli)
                //VALUES(@Nome, @Tel, @Cpf, @End);
                cmd.CommandText = @"
                    INSERT INTO Cliente(Nome_Cli, Tel_Cli, Cpf_Cli, End_Cli)
                    VALUES(@Nome, @Tel, @Cpf, @End);
                ";
                cmd.Parameters.AddWithValue("@Nome", nome.Text);
                cmd.Parameters.AddWithValue("@Tel", tel.Text);
                cmd.Parameters.AddWithValue("@Cpf", cpf.Text);
                cmd.Parameters.AddWithValue("@End", end.Text);

                cmd.ExecuteNonQuery();
 
            }
        }
    }
}
