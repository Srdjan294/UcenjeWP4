using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Subota
{
    internal class Program
    {
        public Program()
        {
            var ime1 = "ana";
            var ime2 = "ivo";

            bool ispravno = true;

            foreach(var z in ime1)
            {
                if (!char.IsLetter(z))
                {
                    ispravno = false;
                    break;
                }
            }

            if(!ispravno)
            {
                Console.WriteLine("nije dobro");
                return;
            }

            string s = ime1[0].ToString();
            char c = ime1[0];

            Console.WriteLine(s);




            s = ime1.ToLower() + ime2.ToLower();

            Console.WriteLine(s);

            int[] brojevi = new int[s.Length];
            //ivicamarica
            //int u;
            for(int i = 0; i < s.Length; i++)
            {
                /*
                u = 0;
                for(int j = 0; j< s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        u++;
                    }
                }
                brojevi[i] = u;
                */
                brojevi[i] = s.Count(znak => znak == s[i]);
            }

            //Console.WriteLine(string.Join("," , brojevi));

            brojevi = srediNiz(brojevi);

            Console.WriteLine(string.Join(",", brojevi));

            Console.WriteLine(" {0} i {1} se vole {2}%", ime1, ime2, ljubav(brojevi));



            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Faker.Name.FullName(NameFormats.StandardWithMiddleWithPrefix));
            }

            string br = "6";
            int b;
            if (!int.TryParse(br,out b))
            {
                Console.WriteLine("Ne valja");
            }
            Console.WriteLine(b);


            int kratko;
            int.TryParse("7",out kratko);

            Console.WriteLine(kratko);




        }

        private int ljubav(int[] brojevi)
        {
            if (brojevi.Length < 4)
            {
                var broj = int.Parse(string.Join("", brojevi));
                if (broj <= 100)
                {
                    return broj;
                }
            }
            int[] novi = new int[brojevi.Length % 2 == 0 ? brojevi.Length / 2 : brojevi.Length / 2 + 1];
            for (int i = 0; i < brojevi.Length/2; i++)
            {
                novi[i] = brojevi[i] + brojevi[brojevi.Length - 1 - i];
            }
            if(brojevi.Length%2 != 0)
            {
                novi[novi.Length - 1] = brojevi[brojevi.Length/2];
            }
            novi = srediNiz(novi);
            Console.WriteLine(string.Join(",", novi));
            // algoritam zbrajanja
            return ljubav(novi);

        }

        private int[] srediNiz(int[] brojevi)
        {
            var niz = string.Join("", brojevi);
            brojevi = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                brojevi[i] = int.Parse(niz[i].ToString());
            }

            return brojevi;
        }
    }
}