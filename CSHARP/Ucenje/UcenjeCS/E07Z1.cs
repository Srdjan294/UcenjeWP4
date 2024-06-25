using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1

    {
        // program od korisnika unosi cijeli broj
        // koristeći while petlju program ispisuje 
        // zbroj svih parnih brojeva od 1 do unesenog broja
        // unos 10
        // ispis 30
        // unos 12
        // ispis 42


        internal static void Izvedi()
        {
            Console.WriteLine("Unesi cijeli broj: ");
            int broj = 0;
            int a = 1;
            int b = 0;
            broj = int.Parse(Console.ReadLine());

            while(a <= broj)
            {
                if(a % 2 == 0)
                {
                    b += a;
                }

                a++;
            }

            Console.WriteLine(b);

        }
    }
}
