using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes.Fields
{
    internal class Empty
    {
        public static void IsEmpty(TextBox txt, Label lb)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                lb.ForeColor = Color.Red;
                lb.Text += " *";
            }
            else
            {
                lb.ForeColor = Color.Black;
                lb.Text = lb.Text;
            }
        }
    }
}
