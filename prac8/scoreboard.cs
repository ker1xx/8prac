using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace prac8
{
    internal class scoreboard
    {
        public static List<y> scoreb = new();
        public static void write()
        {
            
            Console.Clear();
            Console.WriteLine("Таблица лидеров:");
            Console.SetCursorPosition(0, 1);
            foreach (var human in scoreb)
            {
                Console.WriteLine("Имя : " + human.name);
                Console.WriteLine("Количество символов в секунду: " + human.symbolssec);
                Console.WriteLine("Количество символов в минуту: " + human.symblosmin);
                Console.WriteLine("Количество ошибок: " + human.mistakes);
            }
            Console.WriteLine("Если вы хотите запустить программу еще раз, нажмите F1\nЕсли вы хотите выйти из программы, любую другую клавишу");
        }
    }
}
