using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    public class DefaultForm
    {
        public static void Default(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(
                width: 1030
                , height: 600
                );
        }
    }
}
