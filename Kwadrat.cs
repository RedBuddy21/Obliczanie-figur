﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static class Kwadrat1
    {
        public static void StartPoleKwadrat()
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

            if (isLenghtA)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole kwadratu wynosi " + Funkcje.PoleKwadrat(lengthA) + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }

        public static void StartObwodKwadrat()
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

            if (isLenghtA)
            {
                Console.WriteLine("Obwód kwadratu wynosi " + Funkcje.ObwodKwadrat(lengthA) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }
    }
}
