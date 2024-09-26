using FusionSystem.Classes;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace FusionSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            DefaultForm.Default(this);


            InitializeComponent();

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            #region Verifica se os campos est�o preenchidos

            bool isValid = !string.IsNullOrEmpty(txtUsuarioLogin.Text); //boolean recebe valor do m�todo ( se sim, ent�o n�o)

            Empty.IsEmpty(txtUsuarioLogin, lbUsuarioLogin);
            Empty.IsEmpty(txtSenhaLogin, lbSenhaLogin);

            // Abre o formul�rio se o campo n�o estiver vazio


            if (isValid) // sa�da negativa == sem string nos campos
            {

                FrmHome frm = new FrmHome();
                frm.Show();
                this.Hide();

            }
            else            // Aviso de erro
            {
                MessageBox.Show("Os seguintes campos precisam serem preenchidos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
