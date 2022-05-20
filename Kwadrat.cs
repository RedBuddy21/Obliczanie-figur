using System;
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
            Funkcje.BOKA();

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole kwadratu wynosi " + Funkcje.PoleKwadrat(Funkcje.LengthA) + "cm\xB2");
                
            Console.ReadLine();
        }

        public static void StartObwodKwadrat()
        {
            Console.WriteLine("Podaj długość boku a: ");
            Funkcje.BOKA();

                Console.WriteLine("Obwód kwadratu wynosi " + Funkcje.ObwodKwadrat(Funkcje.LengthA) + "cm");
                
            Console.ReadLine();
        }
    }
}
