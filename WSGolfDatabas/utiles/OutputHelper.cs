using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGolfDatabas.utiles
{
    internal class OutputHelper
    {
        public static void Write(string sentence)
        {
            Console.WriteLine(sentence);
        }
        public static string WriteAndInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
        private static string Style(string namn)
        {
            namn = namn.Trim();
            var förstaBokstav = namn.Substring(0, 1).ToUpper();
            var restenAvNamnet = namn.Substring(1).ToLower();
            return förstaBokstav + restenAvNamnet;
        }
    }
}
