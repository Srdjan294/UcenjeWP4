using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {

        public static void Izvedi()
        {
            // Ispiši deset puta Osijek

            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("***********************");

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Osijek");
            }

            Console.WriteLine("***********************");

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********************");
            // Zbrojiti prvih sto brojeva
            int suma = 0;
            for(int i=0; i <= 100; i++)
            {
                suma += i;

            }
            Console.WriteLine(suma);

            
            
            // ispiši sve parne brojeve od 3 do 29

            // loše rješenje
            for(int i= 4; i < 29; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********************");
            int brojOd = 3;   // ovo se može učitati od korisnika
            int brojDo = 29;  // ovo se može učitati od korisnika
            // u nastavku u kodu nema konstanti
            for(int i = brojOd; i < brojDo; i++ )

            {
                if(i % 2 == 0 )
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("***********************");

            int[] niz = { 2, 3, 4, 5, 3, 44, 5, 6, 7 };

            for(int i = 0;i < niz.Length;i++)
            {
                Console.WriteLine(niz[i]);
            }


            Console.WriteLine("***********************");


            // ispiši sve brojeve od 20 do 10

            for(int i = 20; i>=10; i--)
            {
                Console.WriteLine(i);
            }



            // Ispiši sve prim brojeve od 2 do 50
            int ukupno = 0;
            bool prim;

            for (int i = 2; i <= 1400; i++)
            {
                prim = true;
                for(int j = 2; j < i; j++)
                {
                    //Console.WriteLine("{0} % {1} = {2}", i, j, i%j);

                    if(i%j == 0)
                    {
                        prim = false;  // 2000000 da li je prim broj
                        // prekini unutarnju petlju jer sve ostale provjere nisu više bitne
                        break;
                    }

                    if (!prim)
                    {
                        ukupno++;
                        //Console.WriteLine("Nepotrebno izvođenje" + ++ukupno);
                    }
                }

                if (prim)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("***********************");

            // preskakanje petlje
            for(int i = 0; i < 10; i++) 
            {
                if(i == 3)
                {
                    continue;
                }

                if(i == 5)
                {
                    break;
                }

                Console.WriteLine(i);

            }

            for(int i = 0; i<= 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i*j);

                    //  Želim prekinuti vanjsku petlju: varijabla i
                    goto labela;
                }
            }



        labela:
            Console.WriteLine("*********************");


            // beskonačna petlja
            // Unesi broj između 1 i 10
            Console.WriteLine(int.MaxValue);
            int max = int.MaxValue;
            Console.WriteLine(max + 1);
            
            
            
            
            
            //int broj;

            //for(; ; )
            //{
            //    Console.Write("Unesi broj od 1 do 10: ");
            //    broj = int.Parse(Console.ReadLine());

            //    if (broj < 1 || broj > 10)
            //    {
            //        Console.WriteLine("Nisi unio broj u rasponu");
            //        continue;
            //    }
            //    break;
            //}
            //Console.WriteLine(broj);


            Console.WriteLine("***********************");

            niz = PodaciInt.niz;

            Console.WriteLine(niz.Length);
            /*
            for(int i = 0; i < niz.Length ; i++)
            {
                Console.WriteLine(niz[i]);
            }
            */

            // Postoji li dva ista broja? Ako postoji koji je to broj?

            //for(int i = 0; i< niz.Length; i++)
            //{
            //    for(int j=i+1; j<niz.Length; j++)
            //    {
            //        if (niz[i] == niz[j])
            //        {
            //            Console.WriteLine(niz[i]);
            //            break;
            //        }
            //    }
            //}

            //kraj:
            //Console.WriteLine("**************************");

            string[] imena = PodaciString.Niz;

            Console.WriteLine(imena.Length);

            // string je isto niz znakova

            string grad = "Osijek";

            Console.WriteLine(grad[0]);
            Console.WriteLine(grad[grad.Length - 1]); 





        }


    }
}
