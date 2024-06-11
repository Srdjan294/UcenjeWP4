using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            // korisnik unosi brojčani iznos ocjene. Program ispisuje
            // tekstualnu ocjenu

            int x = 0;
            Console.WriteLine("Unesite ocjenu: ");

            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1: Console.WriteLine("nedovoljan");
                        break;

                    case 2: Console.WriteLine("dovoljan");
                        break;

                    case 3: Console.WriteLine("dobar");
                    break;
                    case 4: Console.WriteLine("vrlo dobar");
                    break;

                    case 5: Console.WriteLine("odličan");
                    break;

                    default: Console.WriteLine("nije definirano");
                    break;
            }
        }
    }
}
