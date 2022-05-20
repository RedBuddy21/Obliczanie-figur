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
            Funkcje.BOKA();

            Console.WriteLine("Podaj wysokość Trójkąta: ");
            Funkcje.BOKH();

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Pole trójkąta wynosi "+Funkcje.PoleTrojkant(Funkcje.LengthA, Funkcje.LenghtH)+"cm\xB2");
            

            Console.ReadLine();
        }

        public static void StartObwodTajkat()
        {
            Console.WriteLine("Podaj długość boku a: ");
            Funkcje.BOKA();

            Console.WriteLine("Podaj długośc boku b: ");
            Funkcje.BOKB();

            Console.WriteLine("Podaj długośc boku c: ");
            Funkcje.BOKC();

                Console.WriteLine("Obwód Trójkąta wynosi: " + Funkcje.ObwodTrojkant(Funkcje.LengthA, Funkcje.LenghtB, Funkcje.LenghtC) + "cm");

                Console.ReadLine();
        }
    }
}
