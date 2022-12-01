using Newtonsoft.Json;

namespace prac8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wow = 0;
            while (wow < 2)
            {
                if (wow == 1)
                {
                    string jsonfile = "C:\\Users\\klink\\OneDrive\\Рабочий стол\\Results.json";
                    scoreboard.scoreb = JsonConvert.DeserializeObject<List<y>>(jsonfile);
                }
                a.number = a.rand.Next(0, 11);
                a.currentstroka = File.ReadLines("C:\\Users\\klink\\OneDrive\\Рабочий стол\\texts.txt").ElementAt(a.number);
                a.mistakes = 0;
                a.stop_that_shit = true;
                a.newperson = new("lox", 0, 0, 0);
                a.seconds = 0;
                Enter.enter();
                mainfile.writetext();
                mainfile.checkinput();
                Thread.Sleep(1000);
                scoreboard.write();
                ConsoleKeyInfo repeat = Console.ReadKey();
                if (repeat.Key == ConsoleKey.F1)
                    wow = 1;
                else
                    wow = 2;
                string json = JsonConvert.SerializeObject(mainfile.currenttext);
                File.WriteAllText("C:\\Users\\klink\\OneDrive\\Рабочий стол\\Results.json", json);
            }
        }
    }
}