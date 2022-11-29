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
            int words_count = 0;
            while (words_count != currenttext.Count)
            {
                Console.SetCursorPosition(0, max_stolbec + 2);
                int oldcount = symbol_count;
                if (words_count > 10)
                {
                    words_count = 0;
                    stolbec_count += 1;
                }
                int bukva = 0;
                string slovo = currenttext[words_count];
                Thread clearenter = new Thread(_ =>
                {
                    string space = "";
                    Console.SetCursorPosition(0, max_stolbec + 2);
                    space = "";
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        space += " ";
                    }
                    Console.WriteLine(space);
                    space = "";
                });
                while (bukva != slovo.Length)
                {
                    a.key = Console.ReadKey();
                    char charletter = a.key.KeyChar;
                    if (charletter == slovo[bukva])
                    {
                        symbol_count++;
                        bukva++;
                    }
                    else
                    {
                        Thread colorred = new Thread(_ =>
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            clearenter.Start();
                        });
                        colorred.Start();
                        a.mistakes += 1;
                        Console.WriteLine("                                   ");
                        bukva = 0;
                    }
                }
                bukva = 0;
                words_count += 1;
                Thread colorgreen = new(_ =>
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(oldcount, stolbec_count);
                    string space = "";
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        space += " ";
                    }
                    Console.WriteLine(space);
                });
                clearenter.Start();
                colorgreen.Start();
                
            }
        }
    }
}
