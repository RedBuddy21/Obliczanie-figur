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
            Funkcje.BOKA();

            Console.WriteLine("Podaj długośc boku b: ");
            Funkcje.BOKB();

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole porostokątu wynosi " + Funkcje.PoleProstakant(Funkcje.LengthA, Funkcje.LenghtB) + "cm\xB2");


                Console.ReadLine();
        }

        public static void StartObwodProstakat()
        {
            Console.WriteLine("Podaj długość boku a: ");
            Funkcje.BOKA();

            Console.WriteLine("Podaj długośc boku b: ");
            Funkcje.BOKB();

            Console.WriteLine("Obwód prostokatu wynowi " + Funkcje.ObwodProstakant(Funkcje.LengthA, Funkcje.LenghtB) + "cm");

                Console.ReadLine();
        }
    }
}
