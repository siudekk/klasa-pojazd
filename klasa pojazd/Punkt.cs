using System;
using System.Collections.Generic;
using System.Text;

namespace klasa_pojazd
{
    class Punkt
    {
        public int x { get; private set; }//wlasciwosci

        public int y { get; private set; }

        public Punkt(int X, int Y)//konstruktor
        {
            x = X;
            y = Y;       
        }

        public void PrzesunPrawo(int WartPrzesunieciaP)//metoda
        {
            x = x + WartPrzesunieciaP;
        }

        public void PrzesunLewo(int WartPrzesunieciaL)
        {
            x = x - WartPrzesunieciaL;
        }

        public void PrzesunDol(int WartPrzesunieciaD)
        {
            y = y - WartPrzesunieciaD;
        }

        public void PrzesunGora(int WartPrzesunieciaG)
        {
            y = y + WartPrzesunieciaG;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Wspolzedna x {0}", x);
            Console.WriteLine("Wspolzedna y {0}", y);            
        }
    }
}
