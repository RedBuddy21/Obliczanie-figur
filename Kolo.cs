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
            var bokr = Funkcje.BOK("Podaj długość boku a: ");

            Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole koła wynosi " + Funkcje.PoleKolo(bokr) + "cm\xB2");

                Console.ReadLine();
        }

        public static void StartObwodKolo()
        {
            var bokr = Funkcje.BOK("Podaj długość boku a: ");

            Console.WriteLine("Obwód Trójkąta wynosi: " + Funkcje.ObwodKolo(bokr) + "cm");

                Console.ReadLine();

        }

    }
    

}
