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
            return (lenghtA * lenghtH) / 2;
        }
        

        public static double ObwodTrojkant(double lenghtA, double lenghtB, double lenghtC)
        {
            return (lenghtA + lenghtB + lenghtC);
        }

        public static double PoleKwadrat(double lenghtA)
        {
            return (lenghtA * lenghtA);
        }

        public static double ObwodKwadrat(double lenghtA)
        {
            return (lenghtA * 4);
        }

        public static double PoleProstakant(double lenghtA, double lenghtB)
        {
            
            return (lenghtA * lenghtB);
        }

        public static double ObwodProstakant(double lenghtA, double lenghtB)
        {
            return ((lenghtA * 2) + (lenghtB * 2));
        }

        public static double PoleKolo(double lengthR)
        {
            return ((lengthR * lengthR)*3.14);
        }

        public static double ObwodKolo(double lengthR)
        {
            return (lengthR * 2 * 3.14); ;
        }

        public static double PoleTrapez(double lengthA,double lenghtB, double lenghtH)
        {
            return (((lengthA + lenghtB) * lenghtH) / 2);
        }

        public static double ObwodTrapez(double lengthA, double lenghtB, double lenghtC)
        {
            return (((lengthA + lenghtB) + lenghtC * 2));
        }

       
    }
}
