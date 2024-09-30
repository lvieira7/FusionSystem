using FusionSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionSystem
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            Program.Default(this);
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteCommand cmd = new())
                {

                    // Associa a conexão ao comando
                    cmd.Connection = Classes.DataConn.OpenConn();

                    cmd.CommandText = "INSERT INTO Usuario(Nome_Usuario, Tel_Usuario, Cpf_Usuario, Endereco_Usuario) " +
                                      "VALUES (@Nome, @Tel, @Cpf, @Endereco)";
                    cmd.Parameters.AddWithValue("@Nome", txtNomeAdd.Text);
                    cmd.Parameters.AddWithValue("@Tel", txtTelAdd.Text);
                    cmd.Parameters.AddWithValue("@Cpf", txtCpfAdd.Text);
                    cmd.Parameters.AddWithValue("@Endereco", txtEndAdd.Text);

                    // Executa o comando
                    cmd.ExecuteNonQuery();

                    Classes.DataConn.CloseConn(cmd.Connection);

                    MessageBox.Show("Dados inseridos com sucesso! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
