using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static  class Funkcje
    {
        public static double PoleTrojkant(double lenghtA,double lenghtH)
        {
            double wynik = (lenghtA * lenghtH) / 2;
            return wynik;
        }
        

        public static double ObwodTrojkant(double lenghtA, double lenghtB, double lenghtC)
        {
            double wynik =(lenghtA + lenghtB + lenghtC );
            return wynik;
        }

        public static double PoleKwadrat(double lenghtA)
        {
            double wynik =(lenghtA * lenghtA);
            return wynik;
        }

        public static double ObwodKwadrat(double lenghtA)
        {
            double wynik =(lenghtA*4);
            return wynik;
        }

        public static double PoleProstakant(double lenghtA, double lenghtB)
        {
            double wynik = (lenghtA * lenghtB);
            return wynik;
        }

        public static double ObwodProstakant(double lenghtA, double lenghtB)
        {
            double wynik = ((lenghtA*2)+(lenghtB*2));
            return wynik;
        }

        public static double PoleKolo(double lengthR)
        {
            double wynik = (lengthR * 3.14);
            return wynik;
        }

        public static double ObwodKolo(double lengthR)
        {
            double wynik = (lengthR * 2 * 3.14);
            return wynik;
        }

        public static double PoleTrapez(double lengthA,double lenghtB, double lenghtH)
        {
            double wynik = (((lengthA + lenghtB) * lenghtH) / 2);
            return wynik;
        }

        public static double ObwodTrapez(double lengthA, double lenghtB, double lenghtC)
        {
            double wynik = (((lengthA + lenghtB) + lenghtC * 2));
            return wynik;
        }

       
    }
}
