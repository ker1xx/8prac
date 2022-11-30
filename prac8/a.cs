using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac8
{
    internal static class a
    {
        private static Random rand = new Random();
        private static int number = rand.Next(0, 11);
        public static string currentstroka = File.ReadLines("C:\\Users\\klink\\OneDrive\\Рабочий стол\\texts.txt").ElementAt(number);
    }
}
