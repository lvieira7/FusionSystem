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

                    Classes.Query.Insert(txtNomeAdd, txtTelAdd, txtCpfAdd, txtEndAdd);

                    MessageBox.Show("Dados inseridos com sucesso! ");

                    txtNomeAdd.Text = "";
                    txtTelAdd.Text = "";
                    txtCpfAdd.Text = "";
                    txtEndAdd.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
