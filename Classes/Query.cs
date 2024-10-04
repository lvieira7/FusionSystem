using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class Query
    {
        // Inserir Clientes
        public static void Insert(TextBox nome, MaskedTextBox tel, MaskedTextBox cpf, TextBox end)
        {
            using (var cmd = DataConn.OpenConn().CreateCommand())
            {
                //INSERT INTO Cliente (Nome_Cli, Tel_Cli, Cpf_Cli, End_Cli)
                //VALUES(@Nome, @Tel, @Cpf, @End);
                cmd.CommandText = @"
                    INSERT INTO Cliente(Nome_Cli, Tel_Cli, Cpf_Cli, End_Cli)
                    VALUES(@nome, @tel, @cpf, @end);
                ";
                cmd.Parameters.AddWithValue("@nome", nome.Text);
                cmd.Parameters.AddWithValue("@tel", tel.Text);
                cmd.Parameters.AddWithValue("@cpf", cpf.Text);
                cmd.Parameters.AddWithValue("@end", end.Text);

                cmd.ExecuteNonQuery();
 
            }
        }

        // Inserir Produtos
        public static void Insert(TextBox nome, TextBox desc, ComboBox tam, TextBox cor, ComboBox cat, TextBox preco, TextBox qntd)
        {
            using (var cmd = DataConn.OpenConn().CreateCommand())
            {
                cmd.CommandText = @"
            INSERT INTO Produtos(Nome_Prod, Descricao_Prod, Tamanho_Prod, Cor_Prod, Categoria_Prod, Preco_Prod, Quantidade_Prod)
            VALUES(@nome, @desc, @tam, @cor, @cat, @preco, @qntd);
        ";
                cmd.Parameters.AddWithValue("@nome", nome.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@tam", tam.Text);
                cmd.Parameters.AddWithValue("@cor", cor.Text);
                cmd.Parameters.AddWithValue("@cat", cat.Text);
                cmd.Parameters.AddWithValue("@preco", preco.Text);
                cmd.Parameters.AddWithValue("@qntd", qntd.Text);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
