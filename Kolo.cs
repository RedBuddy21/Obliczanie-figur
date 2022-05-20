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
            Console.WriteLine("Podaj długość promienia R: ");
            Funkcje.BOKR();

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole koła wynosi " + Funkcje.PoleKolo(Funkcje.LenghtR) + "cm\xB2");

                Console.ReadLine();
        }

        public static void StartObwodKolo()
        {
            Console.WriteLine("Podaj długość promienia R: ");
            Funkcje.BOKR();

                Console.WriteLine("Obwód Trójkąta wynosi: " + Funkcje.ObwodKolo(Funkcje.LenghtR) + "cm");

                Console.ReadLine();

        }

    }
    

}
