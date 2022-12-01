using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac8
{
    internal static class a
    {
        public static Random rand = new();
        public static int number = rand.Next(0, 11);  
        public static string currentstroka = File.ReadLines("C:\\Users\\klink\\OneDrive\\Рабочий стол\\texts.txt").ElementAt(number);
        public static int mistakes = 0;
        public static ConsoleKeyInfo key;
        public static bool stop_that_shit = true;
        public static y newperson =  new("lox",0,0,0);
        public static double seconds = 0;
    }
}
