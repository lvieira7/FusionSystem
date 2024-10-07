using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FusionSystem.Classes
{
    internal class DataList
    {
        public static void DefaultClientView(ListView list)
        {
            // Limpa itens existentes antes de adicionar novos
            list.Items.Clear();

            var conn = DataConn.OpenConn();

            try
            {
                string query = @"SELECT * FROM Cliente";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Cria um novo item com o Nome_Cli
                                ListViewItem item = new ListViewItem(reader["Nome_Cli"].ToString());

                                // Adiciona os subitens (Telefone, CPF e Endereço)
                                item.SubItems.Add(reader["Tel_Cli"].ToString());
                                item.SubItems.Add(reader["Cpf_Cli"].ToString());
                                item.SubItems.Add(reader["End_Cli"].ToString());

                                // Adiciona o item ao ListView
                                list.Items.Add(item);
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                DataConn.CloseConn(conn);
            }
            // Atualiza a interface
            list.Refresh();

        }
        public static void ClientViewParameter(ListView list, TextBox name)
        {
            // Limpa itens existentes antes de adicionar novos
            list.Items.Clear();

            var conn = DataConn.OpenConn();

            try
            {
                // Obtendo informações e exibindo no ListView
                string query = @$"SELECT * FROM Cliente WHERE Nome_Cli LIKE '%{name.Text}%';";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Cria um novo item com o Nome_Cli
                                ListViewItem item = new ListViewItem(reader["Nome_Cli"].ToString());

                                // Adiciona os subitens (Telefone, CPF e Endereço)
                                item.SubItems.Add(reader["Tel_Cli"].ToString());
                                item.SubItems.Add(reader["Cpf_Cli"].ToString());
                                item.SubItems.Add(reader["End_Cli"].ToString());

                                // Adiciona o item ao ListView
                                list.Items.Add(item);
                            }
                        }
                        else
                        {
                            // Exibe uma mensagem caso não haja resultados
                            MessageBox.Show("Nenhum cliente encontrado com esse nome.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostra uma mensagem com o erro
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                // Fecha a conexão
                DataConn.CloseConn(conn);
            }

            // Atualiza a interface
            list.Refresh();
        }

    }
}

