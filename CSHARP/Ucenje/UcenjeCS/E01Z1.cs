using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z1
    {
        public static void Izvedi()
        {
            // Program unosi dva cijela broja ispisuje njihov zbroj

            int a, b;

            Console.WriteLine("Unesi prvi broj: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a+b);



        }
    }
}
