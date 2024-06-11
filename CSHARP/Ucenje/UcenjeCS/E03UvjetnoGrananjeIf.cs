using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {

            int i = 8;  // Nisam koristio Console.ReadLine kako bi bili brži

            // uvjetno grananje if radi s bool tipom podatka

            bool uvjet = i == 7;

            Console.WriteLine(uvjet);

            // minimalna if sintaksa

            if (uvjet)
            {
                Console.WriteLine("1. Ušao sam u if granu");
            }
            // dodatak(neobavezni dio) if grananja
            else
            {
                Console.WriteLine("2. Uvjet nije zadovoljen, otišao u else granu");
            }

            // uobičajena sintaksa što se tiče uvjeta 
            // ako ne postoje {} if se odnosi samo na 1. sljedeću liniju
            if (i > 2)
            {
                Console.WriteLine("3. Ušao u if bez vitičastih zagrada");
                Console.WriteLine("4. ovo se izvodi bez obzira na gornji if");
            }




        }
       


    }
}
