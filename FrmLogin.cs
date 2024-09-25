using FusionSystem.Classes;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace FusionSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            // Instanciando configuração padrão de página
            DefaultForm frm = new(); // this indica o frm atual
            frm.Default(this);

            InitializeComponent();

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }
    }
}
