using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Double;
using System.Threading.Tasks;

namespace Obliczanie_figur
{
    static class Kolo
    {
        public static void StartPoleKolo()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtR = true;
            var lengthR = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtR = TryParse(a, out lengthR);
                if (!isLenghtR)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtR);

            if (isLenghtR)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole koła wynosi " + Funkcje.PoleKolo(lengthR) + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }

        public static void StartObwodKolo()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtR = true;
            var lengthR = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtR = TryParse(a, out lengthR);
                if (!isLenghtR)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtR);

            if (isLenghtR)
            {
                Console.WriteLine("Obwód Trójkąta wynosi: " + Funkcje.ObwodKolo(lengthR) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();

        }

    }
    

}
