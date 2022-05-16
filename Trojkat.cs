using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static class Trojkat
    {
        public static void StartPoleTrojkata()
        {
            Console.Title = "Oblicznie Figur";

            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Funkcje.niepoprawnie();
                }
            } while (!isLenghtA);


            Console.WriteLine("Podaj wysokość Trójkąta: ");
            var isLenghtH = true;
            var lenghtH = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtH = TryParse(b, out lenghtH);
                if (!isLenghtH)
                {
                    Funkcje.niepoprawnie();
                }
            } while (!isLenghtH);

            if (isLenghtA && isLenghtH)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole wynosi " + Funkcje.PoleTrojkant(lengthA, lenghtH)+ "cm\xB2");
                //Funkcje.PoleTrojkant(lengthA, lenghtH);
            }
            else
                Console.WriteLine("Nie prawidłowy ciag znaków");


            Console.ReadLine();
        }

        public static void StartObwodTajkat()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Funkcje.niepoprawnie();
                }
            } while (!isLenghtA);

            Console.WriteLine("Podaj długośc boku b: ");
            var isLenghtB = true;
            var lenghtB = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtB = TryParse(b, out lenghtB);
                if (!isLenghtB)
                {
                    Funkcje.niepoprawnie();
                }
            } while (!isLenghtB);

            Console.WriteLine("Podaj długośc boku c: ");
            var isLenghtC = true;
            var lenghtC = 0.0;
            do
            {
                var c = Console.ReadLine();
                isLenghtC = TryParse(c, out lenghtC);

                if (!isLenghtC)
                {
                    Funkcje.niepoprawnie();
                }
            } while (!isLenghtC);

            if (isLenghtA && isLenghtB && isLenghtC)
            {
                Console.WriteLine("Obwód Trójkąta wynosi: " + Funkcje.ObwodTrojkant(lengthA, lenghtB, lenghtC) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }
    }
}
