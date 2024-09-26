using FusionSystem.Classes;
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
            // Instanciando configuração padrão de página
            //DefaultForm frm = new(); // this indica o frm atual
            //frm.Default(this);

            DefaultForm.Default(this);
            InitializeComponent();
        }

        private void menuAdicionar_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new();
            frm.Show();
        }
    }
}
