using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.BrzaHrana
{
    internal class Narudzba
    {
        public int? Sifra { get; set; }
        public Korisnik? Korisnik { get; set; }
        public string? Adresa { get; set; }
        public DateTime? Datum { get; set; }
        public decimal? UkupnaCijena { get; set; }
    }
}
