using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac8
{
    internal class mainfile
    {
        public static int nomer = 0;
        public static int stolbec = 0;
        public static List<string> currenttext = new();
        public static void writetext()
        {
            string slovo = "";
            for (int i = 0; i != a.currentstroka.Length; i++)
            {
                Console.Write(a.currentstroka[i]);
                slovo += a.currentstroka[i];
                if (a.currentstroka[i] == ' ')
                {
                    nomer++;
                    currenttext.Add(slovo);
                    slovo = "";
                }
                if (nomer > 10)
                {
                    Console.WriteLine("");
                    nomer = 0;
                    stolbec++;
                }
            }
        }
        public static void checkinput()
        {
            int count = 0;
            int max_stolbec = stolbec;
            Console.WriteLine("Вводите выделенный текст:\n");
            int stolbec_count = 0;
            int symbol_count = 0;
            int symbol_on_string = 0;
            int words_count = 0;
            Console.SetCursorPosition(0, max_stolbec + 2);
            while (words_count != currenttext.Count)
            {
                int oldcount = symbol_count;
                if (words_count > 10)
                {
                    words_count = 0;
                    stolbec_count += 1;
                }
                int bukva = 0;
                string slovo = currenttext[words_count];
                while (bukva != slovo.Length)
                {
                    a.key = Console.ReadKey();
                    char charletter = a.key.KeyChar;
                    if (charletter == slovo[bukva])
                    {
                        colorgreen(max_stolbec, slovo, oldcount, stolbec_count, slovo[bukva].ToString(), symbol_on_string);
                        symbol_count++;
                        bukva++;
                        symbol_on_string ++;
                    }
                    else
                    {
                        colorred(max_stolbec, slovo, oldcount, stolbec_count, slovo[bukva].ToString(), symbol_on_string);
                        a.mistakes ++;
                        Console.WriteLine("                                   ");
                    }
                }
                bukva = 0;
                words_count ++;
                clearenter(max_stolbec, slovo);
                deleteword(oldcount, stolbec, slovo, max_stolbec);
            }
        }
        private static void colorred(int a, string b, int oldcount, int stolbec_count, string simvol, int xd)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xd, stolbec_count);
            Console.Write(simvol);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, a + 2);
        }
        private static void clearenter(int max_stolbec, string slovo)
        {
            string space = "";
            Console.SetCursorPosition(0, max_stolbec + 2);
            space = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                space += " ";
            }
            Console.WriteLine(space);
            Console.SetCursorPosition(0, max_stolbec + 2);
        }
        private static void colorgreen(int a, string b, int oldcount, int stolbec_count, string simvol, int xd)
        {
            clearenter(a, b);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xd, stolbec_count);
            Console.Write(simvol);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, a + 2);
        }
        private static void deleteword(int stroka, int stolbec, string slovo, int max_stolbec)
        {
            Console.SetCursorPosition(stroka, stolbec);
            string space = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                space += " ";
            }
            Console.WriteLine(space);
            Console.SetCursorPosition(0, max_stolbec + 2);
        }
    }
}
