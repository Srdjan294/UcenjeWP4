using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z5
    {

        // Program od korisnika učitava decimalni broj te ispisuje drugi korijen učitanog broja
        internal static void Izvedi()
        {
            Console.WriteLine("Učitaj decimalni broj: ");

            double db = double.Parse(Console.ReadLine());

            db = Math.Sqrt(db);

            Console.WriteLine(db);

            Console.WriteLine("Učitaj decimalni broj: ");
            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));
        }
    }
}
