using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi()
        {
            // Program od korisnika traži unos broja godina koje ima korisnik
            // Program ispisuje da li je korisnik punoljetno osoba ili ne

            Console.WriteLine("Unesi broj godina");
            Console.WriteLine(int.Parse(Console.ReadLine()) >= 18 ? "Punoljetna" : "Maloljetna");


        }
        }
}
