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
            Funkcje.BOKA();

            Console.WriteLine("Podaj długośc boku b: ");
            Funkcje.BOKB();

            Console.WriteLine("Podaj wysokość Trapezu: ");
            Funkcje.BOKH();

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole Trapezu wynosi " + Funkcje.PoleTrapez(Funkcje.LengthA, Funkcje.LenghtB, Funkcje.LenghtH) + "cm\xB2");

                Console.ReadLine();
        }

        public static void StartObwodTrapez()
        {
            Console.WriteLine("Podaj długość boku a: ");
            Funkcje.BOKA();

            Console.WriteLine("Podaj długośc boku b: ");
            Funkcje.BOKB();

            Console.WriteLine("Podaj długośc boku c: ");
            Funkcje.BOKC();

                Console.WriteLine("Obwód trapezu wynosi " + Funkcje.ObwodTrapez(Funkcje.LengthA, Funkcje.LenghtB, Funkcje.LenghtC) + "cm");

                Console.ReadLine();
        }
    }
}
