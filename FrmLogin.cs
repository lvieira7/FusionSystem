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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            lbErrorUser.Hide();
            lbErrorPassword.Hide();
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
                // query SQL

                query.CommandText = "SELECT COUNT(*) FROM Login WHERE Nome_Admin=@Usuario AND Senha_Admin=@Senha";
                query.Parameters.AddWithValue("@Usuario", txtUsuarioLogin.Text);
                query.Parameters.AddWithValue("@Senha", txtSenhaLogin.Text);

                // Conexão BD
                SQLiteConnection connection = Classes.Data.OpenConn();

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

                    FusionSystem.Classes.Data.CloseConn(connection);
                }
                else
                {
                    MessageBox.Show("Falha ao conectar ao banco de dados.");
                }
            }

            #endregion
        }
    }
}
