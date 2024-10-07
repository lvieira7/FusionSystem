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
            listClientes.Enabled = false; // Desabilita o controle inteiro


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

            DataList.DefaultClientView(listClientes);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (!Field.IsEmpty(txtNome, lbNome))
            {
                DataList.ClientViewParameter(listClientes, txtNome);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            DataList.DefaultClientView(listClientes);

        }
    }
}
