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
            var boka = Funkcje.BOK("Podaj długość boku a: ");

            Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole kwadratu wynosi " + Funkcje.PoleKwadrat(boka) + "cm\xB2");
                
            Console.ReadLine();
        }

        public static void StartObwodKwadrat()
        {
            var boka = Funkcje.BOK("Podaj długość boku a: ");

            Console.WriteLine("Obwód kwadratu wynosi " + Funkcje.ObwodKwadrat(boka) + "cm");
                
            Console.ReadLine();
        }
    }
}
