using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {
        // Za tri učitana cijela broja od strane korisnika program ispisuje najmanji
        internal static void Izvedi()
        {
            int b1;
            Console.WriteLine("Učitaj prvi broj: ");
            b1 = int.Parse(Console.ReadLine());

            int b2;
            Console.WriteLine("Učitaj drugi broj: ");
            b2 = int.Parse(Console.ReadLine());

            int b3;
            Console.WriteLine("Učitaj treći broj: ");
            b3 = int.Parse(Console.ReadLine());

            if(b1 < b2 && b1 < b3)
            {
                Console.WriteLine(b1);
            }
            else if(b2 < b3 && b2 < b1)
            {
                Console.WriteLine(b2);
            }
            else if(b3 < b1 && b3 < b2)
            {
                Console.WriteLine(b3);
            }else
            {
                Console.WriteLine(b1);
            }

        }
    }
}
