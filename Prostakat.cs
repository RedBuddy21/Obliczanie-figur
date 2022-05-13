using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static class Prostakat
    {
        public static void StartPoleProstakat()
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

            if (isLenghtA && isLenghtB)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole porostokątu wynosi " + Funkcje.PoleProstakant(lengthA, lenghtB) + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");


            Console.ReadLine();
        }

        public static void StartObwodProstakat()
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

            if (isLenghtA && isLenghtB)
            {
                Console.WriteLine("Obwód prostokatu wynowi " + Funkcje.ObwodProstakant(lengthA, lenghtB) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }
    }
}
