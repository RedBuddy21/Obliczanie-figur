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
        public static float LengthA;
        public static float LenghtH;
        public static float LenghtB;
        public static float LenghtC;
        public static float LenghtR;
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

        public static void BOKA()
        {
            var A = Console.ReadLine();
            var isLenght = float.TryParse(A, out var Trojkat);
            while (!isLenght)
            {
                A = Console.ReadLine();
                isLenght = float.TryParse(A, out Trojkat);
                if (!isLenght)
                {
                    Funkcje.niepoprawnie();
                }
            }

            if (isLenght)
            {
                LengthA = Trojkat;
                
            }
        }
        public static void BOKH()
        {
            var A = Console.ReadLine();
            var isLenght = float.TryParse(A, out var Trojkat);
            while (!isLenght)
            {
                A = Console.ReadLine();
                isLenght = float.TryParse(A, out Trojkat);
                if (!isLenght)
                {
                    Funkcje.niepoprawnie();
                }
            }

            if (isLenght)
            {
                LenghtH = Trojkat;
            }
        }

        public static void BOKB()
        {
            var A = Console.ReadLine();
            var isLenght = float.TryParse(A, out var Trojkat);
            while (!isLenght)
            {
                A = Console.ReadLine();
                isLenght = float.TryParse(A, out Trojkat);
                if (!isLenght)
                {
                    Funkcje.niepoprawnie();
                }
            }

            if (isLenght)
            {
                LenghtB = Trojkat;
            }
        }
        public static void BOKC()
        {
            var A = Console.ReadLine();
            var isLenght = float.TryParse(A, out var Trojkat);
            while (!isLenght)
            {
                A = Console.ReadLine();
                isLenght = float.TryParse(A, out Trojkat);
                if (!isLenght)
                {
                    Funkcje.niepoprawnie();
                }
            }

            if (isLenght)
            {
                LenghtC = Trojkat;
            }
        }
        public static void BOKR()
        {
            var A = Console.ReadLine();
            var isLenght = float.TryParse(A, out var Trojkat);
            while (!isLenght)
            {
                A = Console.ReadLine();
                isLenght = float.TryParse(A, out Trojkat);
                if (!isLenght)
                {
                    Funkcje.niepoprawnie();
                }
            }

            if (isLenght)
            {
                LenghtR = Trojkat;
            }
        }
    }
}
