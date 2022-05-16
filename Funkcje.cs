using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static public class Funkcje
    {
        public static double PoleTrojkant(double lenghtA,double lenghtH) =>
            (lenghtA * lenghtH) / 2;
        
        

        public static double ObwodTrojkant(double lenghtA, double lenghtB, double lenghtC) =>
            (lenghtA + lenghtB + lenghtC);
        

        public static double PoleKwadrat(double lenghtA) =>
            (lenghtA * lenghtA);
        

        public static double ObwodKwadrat(double lenghtA) =>
            (lenghtA * 4);
        

        public static double PoleProstakant(double lenghtA, double lenghtB) =>
            (lenghtA * lenghtB);
        

        public static double ObwodProstakant(double lenghtA, double lenghtB) =>
            ((lenghtA * 2) + (lenghtB * 2));
        

        public static double PoleKolo(double lengthR) =>
            ((lengthR * lengthR)*3.14);
        

        public static double ObwodKolo(double lengthR) =>
            (lengthR * 2 * 3.14); 
        

        public static double PoleTrapez(double lengthA,double lenghtB, double lenghtH) =>
            (((lengthA + lenghtB) * lenghtH) / 2);
        

        public static double ObwodTrapez(double lengthA, double lenghtB, double lenghtC) =>
            (((lengthA + lenghtB) + lenghtC * 2));

        public static void niepoprawnie()
        {
            Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
        }

    }
}
