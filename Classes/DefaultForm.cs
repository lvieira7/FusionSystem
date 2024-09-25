using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class DefaultForm
    {
        public void Default(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
