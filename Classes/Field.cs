using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class Field
    {

        public static bool IsEmpty(TextBox txt, Label lb)
        {
            return string.IsNullOrWhiteSpace(txt.Text); // Retorna verdadeiro se o campo está vazio
        }
        public static bool MinLength(TextBox txt, Label lb, int min = 3)
        {
            return txt.Text.Length < min; // Deve ser menor que o mínimo
        }

        /*
        public static bool IsEmpty(TextBox txt)
        {
            return string.IsNullOrEmpty(txt.Text);
        }

        public static bool IsOnlyString(string input) // false em caso de número
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        public static bool IsOnlyNumeric(string input)
        {
            return Regex.IsMatch(input, "^[0-9]+$"); // retorna true em caso de número
        }

        public static bool MaxLength(TextBox txt, int max = 30) // retorna true se ultrapassar o comprimento
        {
            return txt.Text.Length > max;
        }

        public static bool MinLength(TextBox txt, int min = 3) // idem MaxLength
        {
            return txt.Text.Length <= min;
        }
         */
    }
}
