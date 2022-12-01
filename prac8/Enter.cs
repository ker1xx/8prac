using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace prac8
{
    internal class Enter
    {
        public static void enter()
        {

            Console.WriteLine("Введите свое имя: ");
            string nameofcurrentuser = Console.ReadLine();
            a.newperson.name = nameofcurrentuser;
            Console.Clear();
        }

    }
}
