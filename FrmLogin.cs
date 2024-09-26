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

            #region Verifica se os campos estão preenchidos

            bool isValid = !string.IsNullOrEmpty(txtUsuarioLogin.Text); //boolean recebe valor do método ( se sim, então não)

            Empty.IsEmpty(txtUsuarioLogin, lbUsuarioLogin);
            Empty.IsEmpty(txtSenhaLogin, lbSenhaLogin);

            // Abre o formulário se o campo não estiver vazio


            if (isValid) // saída negativa == sem string nos campos
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
            #region Campo só contém string

            OnlyString str = new();


            if (!OnlyString.IsOnlyString(txtUsuarioLogin.Text)) //positivo em caso de número (se não, então sim)
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
