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
            var boka = Funkcje.BOK("Podaj długość boku a: ");
            var bokb = Funkcje.BOK("Podaj długośc boku b: ");

            Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole porostokątu wynosi " + Funkcje.PoleProstakant(boka, bokb) + "cm\xB2");


                Console.ReadLine();
        }

        public static void StartObwodProstakat()
        {
            var boka = Funkcje.BOK("Podaj długość boku a: ");
            var bokb = Funkcje.BOK("Podaj długośc boku b: ");

            Console.WriteLine("Obwód prostokatu wynowi " + Funkcje.ObwodProstakant(boka, bokb) + "cm");

                Console.ReadLine();
        }
    }
}
