using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac8
{
    internal class mainfile
    {
        public static void writetext()
        {
            int count = 0;
            for (int i = 0; i != a.currentstroka.Count(); i++)
            {
                Console.Write(a.currentstroka[i]);
                if (a.currentstroka[i] == ' ')
                    count++;
                if (count == 30)
                {
                    Console.WriteLine("");
                    count = 0;
                }
            }

        }
        private static void checkinput()
        {
            ConsoleKeyInfo key = new();
            int i = 0;
            foreach (var letter in a.currentstroka)
            {
                key = Console.ReadKey();
                string keyy = key.Key.ToString();
                if (keyy == a.currentstroka[i].ToString())
                {
                    i++;
                    Console.ForegroundColor(a.currentstroka[i])
                }
                else
                {

                }

            }
        }
    }
}
