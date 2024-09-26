using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class DefaultForm
    {
        public static void Default(Form form)
        {
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;

            // static: pode ser chamado sem criar uma instância da classe
            // void: indica que não retorna valor
            // no C# métodos estáticos precisam de um tipo de retorno, mesmo que seja void.

        }
    }
}
