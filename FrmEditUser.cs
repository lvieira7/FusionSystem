using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionSystem
{
    public partial class FrmEditUser : Form
    {
        // Adicione campos para armazenar os dados do cliente
        private string nome;
        private string cpf;
        private string telefone;
        private string endereco;

        public FrmEditUser(string nome, string cpf, string telefone, string endereco)
        {
            InitializeComponent();
            Program.DefaultForm(this, 377, 325);

            // Atribuindo parâmetros
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.endereco = endereco;

            // Exibe os valores nas labels
            txtNome.Text = nome;
            txtCpf.Text = cpf;
            txtTel.Text = telefone;
            txtEnd.Text = endereco;


            txtNome.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtEnd.ReadOnly = true;
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {

            
        }
    }
    
}
