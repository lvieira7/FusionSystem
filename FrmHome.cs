using FusionSystem.Classes.DefaultConfig;
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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            DefaultForm.Default(this);
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new();
            frm.Show();
        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {
            FrmInventory frm = new FrmInventory();
            frm.Show();
            this.Hide();
        }

        private void menuPDV_Click(object sender, EventArgs e)
        {
            FrmPDV frm = new FrmPDV();
            frm.Show(); 
            this.Hide();
        }
    }
}
