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
    public partial class FrmAddInventory : Form
    {
        public FrmAddInventory()
        {

            InitializeComponent();
            Program.Default(this, 816, 489);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteCommand cmd = new())
                {

                    Classes.Query.Insert(txtNomeProd, txtDescProd, comboTamanho, txtCorProd, comboCategoria, txtPrecoProd, txtQntProd);

                    MessageBox.Show("Dados inseridos com sucesso! ");
                    txtNomeProd.Text = "";
                    txtDescProd.Text = "";
                    comboTamanho.Text = "";
                    txtCorProd.Text = "";
                    comboCategoria.Text = "";
                    txtPrecoProd.Text = "";
                    txtQntProd.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
