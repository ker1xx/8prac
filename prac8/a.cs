using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac8
{
    internal static class a
    {
        static Random rand = new();
        static int number = rand.Next(0, 11);
        public static string currentstroka = File.ReadLines("C:\\Users\\klink\\OneDrive\\Рабочий стол\\texts.txt").ElementAt(number);
        public static int mistakes = 0;
        public static ConsoleKeyInfo key;
    }
}
