using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSGolfDatabas.Database;

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
        public static void ShowAll() 
        {
            using (var db = new GolfContext())
            {
                foreach (var item in db.Scores)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
