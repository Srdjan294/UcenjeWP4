﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            // eng. Arrays
            // još na HR polja

            // jednodimenzionalni niz
            // AltGr + F je uglata zagrada[
            int[] godine = new int[17];


            godine[0] = 43; // Element na indeksu 0 poprima vrijednost 43
            // ...
            godine[godine.Length - 1] = 23;  // na zadnji element postavljena vrijednost 23

            Console.WriteLine(godine);
            Console.WriteLine(string.Join(",", godine));

            // skraćena sintaksa definiranja niza skupa s zadanim vrijednostima

            int[] niz = {2,3,4,5,6,7,7,6,5,6,5,3,5,5};

            Console.WriteLine(niz[1]);

            string[] gradovi = { "Osijek", "DonjiMiholjac","Valpovo"};

            // dvodimenzionalni niz
            // tablica, matrica

            int[,] tablica ={
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            };

            // ispiši broj 3
            Console.WriteLine(tablica[0,2]);

            // zvjezdane staze

            int[,,,,] multiverse = new int[10, 10, 10, 10, 10];



            // smisao nizova u CSHARP je da budu istog tipa

            object[] objekti = { 1, "Pero", true, 2.2 };





        }
    }
}
