using System;
using System.Collections.Generic;
using System.Text;

namespace klasa_pojazd
{
    class Pojazd
    {        
        public int AktualnaPredkosc { get; private set; }//wlasciwosc

        public int MaxPredkosc { get; }//wlasciwosc
                
        public Pojazd(int maxPredkosc)//konstruktor
        {
            AktualnaPredkosc = 0;
            MaxPredkosc = maxPredkosc;
        }

        public void Przyspiesz(int wartoscPrzyspieszenia)//metoda
        {
            if(AktualnaPredkosc + wartoscPrzyspieszenia > MaxPredkosc)
            {
                AktualnaPredkosc = MaxPredkosc;
            }
            else
            {
                AktualnaPredkosc = AktualnaPredkosc + wartoscPrzyspieszenia;
            }
        }

        public void Wyswietl()//metoda
        {
            Console.WriteLine("Aktualna prędkość {0} km/h", AktualnaPredkosc);
        }


    }
}
