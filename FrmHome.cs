﻿using FusionSystem.Classes;
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
            Program.DefaultForm(this);
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new();
            frm.Show();
        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {
            FrmAddInventory frm = new();
            frm.Show();

        }

        private void menuPDV_Click(object sender, EventArgs e)
        {
            FrmPDV frm = new FrmPDV();
            frm.Show();

        }

        private void menuConsultar_Click(object sender, EventArgs e)
        {
            FrmViewUser frm = new FrmViewUser();
            frm.Show();
        }
    }
}
