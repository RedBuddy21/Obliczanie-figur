using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static class Trapez1
    {
        public static void StartPoleTrapez()
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
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
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
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtB);

            Console.WriteLine("Podaj wysokość Trapezu: ");
            var isLenghtH = true;
            var lenghtH = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtH = TryParse(b, out lenghtH);
                if (!isLenghtH)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtH);




            if (isLenghtA && isLenghtB && isLenghtH)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole Trapezu wynosi " + ((lengthA + lenghtH) * lenghtH) / 2 + "cm\xB2");
            }
            else
                Console.WriteLine("Nieprawidłowy ciąg znaków");

            Console.ReadLine();
        }

        public static void StartObwodTrapez()
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
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
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
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
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
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtC);


            if (isLenghtA && isLenghtB && isLenghtC)
            {
                Console.WriteLine("Obwód trapezu wynosi " + ((lengthA + lenghtB) + lenghtC * 2) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }
    }
}
