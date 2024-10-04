using System.Data.Entity;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices.Marshalling;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;

namespace FusionSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {


            InitializeComponent();

            //default setting form
            Program.Default(this, 300, 300);

            lbErrorUser.Hide();
            lbErrorPassword.Hide();

            btnAcessar.Enabled = false;

            // CRIAR BD PRIMEIRO ACESSO
            Classes.DataBase.CreateData();
            Classes.DataBase.CreateTable();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            #region Campo vazio

            if (Classes.Field.IsEmpty(txtUsuarioLogin, lbUsuarioLogin))
            {
                MessageBox.Show($"Preencha o campo {lbUsuarioLogin.Text}", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuarioLogin.Focus(); // Foca no campo vazio
                return; // Para o processamento se o campo estiver vazio
            }

            if (Classes.Field.IsEmpty(txtSenhaLogin, lbSenhaLogin))
            {
                MessageBox.Show($"Preencha o campo {lbSenhaLogin.Text}", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenhaLogin.Focus(); // Foca no campo vazio
                return; // Para o processamento se o campo estiver vazio
            }

            #endregion

            
            #region Validar Login com Banco

            using (SQLiteCommand query = new())
            {
                // query 

                query.CommandText = "SELECT COUNT(*) FROM Login WHERE User=@Usuario AND Password=@Senha";
                query.Parameters.AddWithValue("@Usuario", txtUsuarioLogin.Text);
                query.Parameters.AddWithValue("@Senha", txtSenhaLogin.Text);

                // Conexão BD
                SQLiteConnection connection = Classes.DataConn.OpenConn();

                if (connection != null)
                {
                    query.Connection = connection; //classe OpenConnection

                    int result = Convert.ToInt32(query.ExecuteScalar());

                    if (result > 0)
                    {
                        FrmHome frm = new();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválido", "Usuário Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    FusionSystem.Classes.DataConn.CloseConn(connection);
                }
                else
                {
                    MessageBox.Show("Falha ao conectar ao banco de dados.");
                }
            }

            #endregion
            
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {
            if(!Classes.Field.IsOnlyString(txtUsuarioLogin, lbErrorUser) || txtUsuarioLogin.Text.Length == 0) // campo vazio ou sem string desabilita button
            {
                btnAcessar.Enabled = false;
            }
            else
            {
                btnAcessar.Enabled = true;
            }

        }
    }
}
