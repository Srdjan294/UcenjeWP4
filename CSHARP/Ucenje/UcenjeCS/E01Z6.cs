using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z6
    {
        // program od korisnika učitava ime grada i broj stanovnika
        // Ispisuje rečenicu : u xxxxxxx živi xxxxx ljudi

        public static void Izvedi()
        {
            Console.WriteLine("Upiši ime grada: ");

            string grad = Console.ReadLine();

            Console.WriteLine("Upiši broj stanovnika: ");

            int bs = int.Parse(Console.ReadLine());

            Console.WriteLine("U {0} živi {1} stavnovnika", grad, bs);
        }
    }
}
