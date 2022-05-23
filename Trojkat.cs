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

            var boka = Funkcje.BOK("Podaj długość boku a: ");
            var bokh = Funkcje.BOK("Podaj wysokość trójkąta: ");


            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Pole trójkąta wynosi "+Funkcje.PoleTrojkant(boka, bokh)+"cm\xB2");
            

            Console.ReadLine();
        }

        public static void StartObwodTajkat()
        {
            var boka = Funkcje.BOK("Podaj długość boku a: ");
            var bokb = Funkcje.BOK("Podaj długośc boku b: ");
            var bokc = Funkcje.BOK("Podaj długośc boku c: ");

                Console.WriteLine("Obwód Trójkąta wynosi: " + Funkcje.ObwodTrojkant(boka,bokb,bokc) + "cm");

                Console.ReadLine();
        }
    }
}
