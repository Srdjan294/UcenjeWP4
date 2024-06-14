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
            // Za uneseni cijeli broj ispisati True ako je parni ili False ako je neparni


            Console.WriteLine("Unesi cijeli broj: ");

            int a;

            a = int.Parse(Console.ReadLine());

            bool jeParni = a % 2 == 0 ? true : false;

            Console.WriteLine(jeParni);
            


        }
    }
}
