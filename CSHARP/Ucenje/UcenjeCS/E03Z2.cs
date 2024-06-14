using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {
        public static void Izvedi()
        {
            // Korisnik unosi 2 decimalna broja 
            // Program ispisuje veći ili jednaki su ako su uneseni brojevi jednaki

            float[] b = new float[2];
            Console.WriteLine("Unesi prvi broj: ");
            b[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            b[1] = float.Parse(Console.ReadLine());

            Console.WriteLine(
                b[1] == b[0]);

        }
    }
}
