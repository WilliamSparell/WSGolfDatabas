using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGolfDatabas.utiles
{
    internal class InputHelper
    {
        private static string Correct(string name)
        {
            name = name.Trim();
            var firstLetter = name.Substring(0, 1).ToUpper();
            var rest = name.Substring(1).ToLower();
            return firstLetter + rest;
        }
    }
}
