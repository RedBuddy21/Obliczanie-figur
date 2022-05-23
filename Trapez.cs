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
            var boka = Funkcje.BOK("Podaj długość boku a: ");
            var bokb = Funkcje.BOK("Podaj długośc boku b: ");
            var bokh = Funkcje.BOK("Podaj długośc boku c: "); ;

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole Trapezu wynosi " + Funkcje.PoleTrapez(boka,bokb,bokh) + "cm\xB2");

                Console.ReadLine();
        }

        public static void StartObwodTrapez()
        {
            var boka = Funkcje.BOK("Podaj długość boku a: ");
            var bokb = Funkcje.BOK("Podaj długośc boku b: ");
            var bokc = Funkcje.BOK("Podaj długośc boku c: ");

            Console.WriteLine("Obwód trapezu wynosi " + Funkcje.ObwodTrapez(boka,bokb, bokc) + "cm");

                Console.ReadLine();
        }
    }
}
