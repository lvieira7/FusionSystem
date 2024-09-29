using FusionSystem.Classes.Fields;
using System.Data.Entity;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices.Marshalling;
using System.Data.SqlClient;

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
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            #region Verifica se os campos est�o preenchidos

            bool isValid = !string.IsNullOrEmpty(txtUsuarioLogin.Text); //boolean recebe valor do m�todo ( se sim, ent�o n�o)

            Empty.IsEmpty(txtUsuarioLogin, lbUsuarioLogin);
            Empty.IsEmpty(txtSenhaLogin, lbSenhaLogin);

            // Abre o formul�rio se o campo n�o estiver vazio


            if (!isValid) // sa�da negativa == sem string nos campos
            {
                MessageBox.Show("Os seguintes campos precisam serem preenchidos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

            #region Validar Login com Banco

            using (SQLiteCommand query = new ())
            {
                // query SQL

                query.CommandText = "SELECT COUNT(*) FROM Login WHERE Nome_Admin=@Usuario AND Senha_Admin=@Senha";
                query.Parameters.AddWithValue("@Usuario", txtUsuarioLogin.Text);
                query.Parameters.AddWithValue("@Senha", txtSenhaLogin.Text);

                // Conex�o BD
                SQLiteConnection connection = Classes.DataBase.OpenConnection.OpenConn();

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
                        MessageBox.Show("Usu�rio ou senha inv�lido");
                    }

                    FusionSystem.Classes.DataBase.CloseConnection.CloseConn(connection);
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
            #region Campo s� cont�m string

            OnlyString str = new();


            if (!OnlyString.IsOnlyString(txtUsuarioLogin.Text)) //positivo em caso de n�mero (se n�o, ent�o sim)
            {
                txtUsuarioLogin.BackColor = Color.Red;
            }
            else
            {
                txtUsuarioLogin.BackColor = Color.White;
            }
            #endregion
        }
    }
}
