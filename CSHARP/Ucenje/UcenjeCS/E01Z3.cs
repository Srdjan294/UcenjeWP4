using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z3
    {
        public static void Izvedi()
        {
            // zadatak
            // Korisnik će unijeti dvoznamenkasti broj
            // ispisuje se prva znamenka
            // 56 => 5
            // 11 => 1

            int a;
            Console.WriteLine("Unesi dvoznamenkasti broj");
            a = int.Parse(Console.ReadLine());

            int b = a / 10;

            Console.WriteLine(b);



        }
    }
}
