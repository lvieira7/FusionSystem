using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FusionSystem.Classes
{
    internal class OnlyString
    {
        public static bool IsOnlyString(string input) // false em caso de número
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }


        //public static void Validator(TextBox txt)
        //{
        //    OnlyString validator = new OnlyString();
        //    IsOnlyString(txt.Text);
        //}
    }
}
