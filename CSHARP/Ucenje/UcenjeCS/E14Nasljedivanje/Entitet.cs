using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{

    // apstraktna klasa je ona klasa koja nema implementaciju
    // kreira se kako bi zadržavala zajednička svojstva i metode koje će koristiti
    // sve klase koje ju nasljeđuju
    internal abstract class Entitet: object // sve klase htjele one to ili ne, nasljeđuju klasu object
    {

        public int? Sifra { get; set; }

        protected int VidiSeUPodklasi = 7;

        private int VidiSeSamoUKlasiUKojojJeDefinirano = 2;

        public override string ToString()
        {
            Console.WriteLine(VidiSeSamoUKlasiUKojojJeDefinirano);
            return Sifra.ToString();
        }

    }
}
