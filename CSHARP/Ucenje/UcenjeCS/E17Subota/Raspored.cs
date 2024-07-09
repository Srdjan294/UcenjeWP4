using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Subota
{
    internal class Raspored
    {
        public Raspored() 
        {
            //08.07.2024 - 14.07.2024.      stan 1
            //15.07.2024 - 21.07.2024.      stan 2
            //22.07.2024 - 28.07.2024       stan 3

            // u ljetnim mjesecima svaki mjesec dana a u zimskim svaka dva tjedna

            DateTime datumOd = DateTime.Parse("2024-10-28");
            DateTime datumDo = datumOd;
            DateTime tjedan;
            int broj = 0;

            while(datumOd.Year < 2028)
            {
                if(datumDo.Month >= 4 && datumOd.Month <= 10) 
                {
                    datumDo = datumOd.AddDays(27);
                }
                else
                {
                    datumDo = datumOd.AddDays(13);
                }
                tjedan = datumOd.AddDays(6);
                
                Console.WriteLine("{0} - {1}, {2}",
                    datumOd.ToString("dd.MM.yyyy."),
                    tjedan.ToString("dd.MM.yyyy."), ++broj %3 +1);
                datumOd = datumDo.AddDays(1);
            }


        }
    }
}
