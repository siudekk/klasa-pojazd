using System;

namespace klasa_pojazd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pojazd audi = new Pojazd(90);
            //Console.WriteLine("Max Prędkość: {0} km/h", audi.MaxPredkosc);
            //audi.Wyswietl();
            //audi.Przyspiesz(50);
            //audi.Wyswietl();
            //audi.Przyspiesz(50);
            //audi.Wyswietl();

            //Interwal ts = new Interwal(30,20,15);
            //ts.Print();

            Punkt P1 = new Punkt(10, 20);
            P1.Wyswietl();
            P1.PrzesunDol(5);
            P1.Wyswietl();
            P1.PrzesunPrawo(10);
            P1.Wyswietl();
            
            Console.ReadLine();
        }
    }
}
