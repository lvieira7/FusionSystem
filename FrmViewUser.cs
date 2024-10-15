using FusionSystem.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FusionSystem
{
    public partial class FrmViewUser : Form
    {

        public FrmViewUser()
        {
            InitializeComponent();
            Program.DefaultForm(this, 818, 497);

        }



        private void FrmViewUser_Load(object sender, EventArgs e)
        {

            // Impede edição de rótulos
            listClientes.LabelEdit = false;

            // Impede a seleção 
            listClientes.Enabled = true; // Desabilita o controle inteiro


            // iniciando list view

            listClientes.Clear();
            listClientes.View = View.Details;
            listClientes.LabelEdit = false;
            listClientes.FullRowSelect = true;
            listClientes.GridLines = true;

            // adicionando colunas ao listview

            // Adicionando colunas ao ListView
            listClientes.Columns.Add("Nome", 150); // nome e largura
            listClientes.Columns.Add("Telefone", 100);
            listClientes.Columns.Add("CPF", 100);
            listClientes.Columns.Add("Endereço", 200);

            ClientDataView.DefaultClientView(listClientes);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (!Field.IsEmpty(txtNome, lbNome))
            {
                ClientDataView.ClientViewParameter(listClientes, txtNome);
            }else
            {
                MessageBox.Show("Campo de pesquisa vazio.", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            ClientDataView.DefaultClientView(listClientes);

        }

        private void listClientes_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listClientes.SelectedItems[0];


            string nome = selectedItem.SubItems[0].Text;       // Nome do cliente
            string tel = selectedItem.SubItems[1].Text;        // CPF do cliente
            string cpf = selectedItem.SubItems[2].Text;        // Telefone do cliente
            string end = selectedItem.SubItems[3].Text;        // Email do cliente



            FrmEditUser frm = new(nome, cpf, tel, end);
            frm.Show();

        }
        
    }
}
