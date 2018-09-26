using System;
using System.Collections.Generic;
using System.Text;

namespace klasa_pojazd
{
    class Interwal
    {
        public int TotalSeconds { get; set; }//wlasciwosci az do konstruktora

        public double TotalMinutes
        {
            get
            {
                return TotalSeconds/(double)60;
            }
            set
            {
                TotalSeconds = (int)(value * 60);
            }
        }

        public double TotalHours 
        {
            get
            {
                return TotalMinutes / 60;
            }
            set
            {
                TotalMinutes = value * 60;
            }
        }

        public int Seconds
        {
            get
            {
                return (int)(TotalSeconds % 60);
            }
            set
            {
                if (value >=0 && value <= 60)
                {
                    TotalSeconds = TotalSeconds - Seconds + value;                
                }
                
            }
        }

        public int Minutes
        {
            get
            {
                return (int)(TotalMinutes % 60);
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    TotalMinutes = TotalMinutes - Minutes + value;
                }
                
            }
        }

        public double Hours
        {
            get
            {
                return (int)TotalHours;
            }
            set
            {
                if (value >= 0)
                {
                    TotalHours = TotalHours - Hours + value;
                }
            }
        }

        public Interwal(int hours, int minutes, int seconds)//konstruktor
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void Print()//metoda
        {
            Console.WriteLine("Total sec. {0}", TotalSeconds);
            Console.WriteLine("Total min. {0}", TotalMinutes);
            Console.WriteLine("Total hour. {0}", TotalHours);
            Console.WriteLine("Time {0}:{1}:{2}", Hours, Minutes, Seconds);

        }

    }
}
