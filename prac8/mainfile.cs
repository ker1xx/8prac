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
            for (int i = 0; i < a.currentstroka.Length; i++)
            {
                Console.Write(a.currentstroka[i]);
                slovo += a.currentstroka[i];
                if (a.currentstroka[i] == ' ')
                {
                    nomer++;
                    currenttext.Add(slovo);
                    slovo = "";
                    if (nomer == 10)
                    {
                        Console.WriteLine("");
                        nomer = 0;
                        stolbec++;
                    }
                }
            }
        }
        public static void checkinput()
        {
            int count = 0;
            Console.WriteLine("\nВводите выделенный текст:\n");
            int max_stolbec = stolbec;
            int stroka_count = 0;
            int symbol_count = 0;
            int symbol_on_string = 0;
            int words_count = 0;
            int allsymbols = 0;
            Thread secs = new Thread(_ =>
            {
                while (a.stop_that_shit == true)
                {

                    for (int i = 0; i < 100; i++)
                    {
                        Console.SetCursorPosition(0, max_stolbec + 3);
                        a.seconds = Math.Round(a.seconds, 2);
                        Console.Write(a.seconds);
                        a.seconds += 0.01;
                        Console.SetCursorPosition(0, max_stolbec + 2);
                        Thread.Sleep(10);
                    }
                }
            });
            secs.Start();
            Console.SetCursorPosition(0, max_stolbec + 2);
            while (allsymbols != a.currentstroka.Length)
            {
                if (words_count % 10 == 0 && words_count != 0)
                {
                    symbol_count = 0;
                    stroka_count += 1;
                    symbol_on_string = 0;
                }
                int oldcount = symbol_count;
                int bukva = 0;
                string slovo = currenttext[words_count];
                while (bukva != slovo.Length)
                {
                    Console.SetCursorPosition(0, max_stolbec + 2);
                    a.key = Console.ReadKey(true);
                    char charletter = a.key.KeyChar;
                    if (charletter == slovo[bukva])
                    {
                        colorgreen(max_stolbec, slovo, oldcount, stroka_count, slovo[bukva].ToString(), symbol_on_string);
                        symbol_count++;
                        bukva++;
                        allsymbols++;
                        symbol_on_string++;
                        Console.SetCursorPosition(0, max_stolbec + 2);
                    }
                    else
                    {
                        colorred(max_stolbec, slovo, oldcount, stroka_count, slovo[bukva].ToString(), symbol_on_string);
                        a.mistakes++;
                        Console.SetCursorPosition(0, max_stolbec + 2);
                        Console.SetCursorPosition(0, max_stolbec + 2);
                    }
                    Console.SetCursorPosition(0, max_stolbec + 4);
                    Console.Write("Вы ввели: " + allsymbols + " / " + a.currentstroka.Length);
                }
                words_count++;
                deleteword(oldcount, stolbec, slovo, max_stolbec);
                Console.SetCursorPosition(0, max_stolbec + 2);
            }
            a.stop_that_shit = false;
            a.newperson.symbolssec = a.currentstroka.Count() / a.seconds;
            double sym_min = (a.currentstroka.Count() / (a.seconds / 60));
            a.newperson.symblosmin = Math.Round(sym_min, 2);
            scoreboard.scoreb.Add(a.newperson);
            a.newperson.mistakes = a.mistakes;
        }
        private static void colorred(int max_stolbec, string slovo, int oldcount, int stolbec_count, string simvol, int xd)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xd, stolbec_count);
            Console.Write(simvol);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, max_stolbec + 2);
        }
        /* private static void clearenter(int max_stolbec, string slovo)
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
         }*/
        private static void colorgreen(int z, string b, int oldcount, int stolbec_count, string simvol, int xd)
        {
            /*            clearenter(z, b);*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xd, stolbec_count);
            Console.Write(simvol);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, z + 2);
        }
        private static void deleteword(int stroka, int stolbec, string slovo, int max_stolbec)
        {
            Console.SetCursorPosition(stroka, stolbec);
            string space = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                space += " ";
            }
            Console.SetCursorPosition(0, max_stolbec + 2);
            Console.WriteLine(space);
            Console.SetCursorPosition(0, max_stolbec + 2);
        }
    }
}
