using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
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
            Console.WriteLine("Unesi prvi decimalni broj: ");
            b[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi decimalni broj: ");
            b[1] = float.Parse(Console.ReadLine());

            //Console.WriteLine(
            //    b[1] == b[0]);

            //if (b[1] > b[0])
            //{
            //    Console.WriteLine(b[1] + " je veći od " + b[0]);
            //}
            //if (b[0] > b[1])
            //{
            //    Console.WriteLine(b[0] + " je veći od " + b[1]);
            //}
            //if(b[1] == b[0])
            //{
            //    Console.WriteLine("Brojevi su jednaki");
            //}

            Console.WriteLine(
                b[1] == b[0] ? "Jednaki su" :
                b[0] > b[1] ? b[0] : b[1]);
        }
    }
}
