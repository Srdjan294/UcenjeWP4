using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Z2
    {
        internal static void Izvedi()
        {
            // Definirajte dvodimenzionalni niz od 4 elementa koji su decimalni brojevi
            // DZ: Korisnik upisuje vrijednosti
            // Program ispisuje unesene brojeve jedno prokraj drugog odvojeno zarezom


            int[,] niz = new int[,]
            {
                {21,223},
                {332,32}
            };

            Console.WriteLine("{0}, {1}, {2}, {3}", niz[0,0], niz[0,1], niz[1,0], niz[1,1]);
        }
    }
}
