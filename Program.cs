using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OblicznieFigur
{
    static class MenuProgramu
    {
    
        public static void Main()
        {
            Console.Title = "Oblicznie Figur";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>> Wybierz Figurę <<<<<<<<");
                Console.WriteLine("1 - Trójkąt");
                Console.WriteLine("2 - Kwadrat");
                Console.WriteLine("3 - Prostokąt");
                Console.WriteLine("4 - Koło ");
                Console.WriteLine("5 - Trapez ");
                Console.WriteLine("6 - Zakończ");

                ConsoleKeyInfo Klawisz = Console.ReadKey();
                switch (Klawisz.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear(); Trójkąt(); break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); Kwadrat(); break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear(); Prostokąt(); break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear(); Koło(); break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear(); Trapez(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Environment.Exit(0); break;
                    default: break;

                }
            }

        }
        static void Trójkąt()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>>>> Figura: Trójkąt <<<<<<<<<");
                Console.WriteLine(">>>>>>>> Wybierz Obliczenia <<<<<<<<");
                Console.WriteLine("1 - Pole");
                Console.WriteLine("2 - Obwód");
                Console.WriteLine("3 - Wstecz");
               

                ConsoleKeyInfo Klawisz = Console.ReadKey();
                switch (Klawisz.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear(); PoleAH(); break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); ObwódABC(); break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear(); Main(); break;
                    default: break;

                }
            }
            static void PoleAH()
            {



                Console.WriteLine("Podaj Długość podstawy: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);


                Console.WriteLine("Podaj wysokośc trójkąta: ");
                string h = Console.ReadLine();
                double cyferka2 = 0;
                bool cyferka3 = double.TryParse(h, out cyferka2);

                if (cyferka1 == true && cyferka3 == true)
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Pole wynosi " + (cyferka * cyferka2) / 2 + "cm\xB2");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciag znaków");
                    

                Console.ReadLine();
            }

            static void ObwódABC()
            {
                Console.WriteLine("Podaj długość boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);

                Console.WriteLine("Podaj długośc boku b: ");
                string b = Console.ReadLine();
                double cyferka2 = 0;
                bool cyferka3 = double.TryParse(b, out cyferka2);


                Console.WriteLine("Podaj długośc boku c: ");
                string c = Console.ReadLine();
                double cyferka4 = 0;
                bool cyferka5 = double.TryParse(c, out cyferka4);

                if (cyferka1 == true && cyferka3 == true && cyferka5 == true)
                {
                    Console.WriteLine("Obwód Trójkąta wynosi: " + (cyferka + cyferka2 + cyferka4) + "cm");
                }
                else
                     Console.WriteLine("Nie prawidłowy ciąg znaków");
                
                Console.ReadLine();

            }
        }

        static void Kwadrat()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>>> Figura: Kwadrat <<<<<<<<<<");
                Console.WriteLine(">>>>>>>> Wybierz Oblicznie <<<<<<<<<");
                Console.WriteLine("1 - Pole");
                Console.WriteLine("2 - Obwód");
                Console.WriteLine("3 - Wstecz");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear(); PoleAA(); break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); ObwódAAAA(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.Escape:
                        Console.Clear(); Main(); break;
                    default: break;
                
                }
            }

            static void PoleAA()
            {
                Console.WriteLine("Podaj długość boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);

                if (cyferka1 == true)
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Pole kwadratu wynosi " + cyferka * cyferka + "cm\xB2");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");

                Console.ReadLine();
            }

            static void ObwódAAAA()
            {
                Console.WriteLine("Podaj długość boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);

                if (cyferka1 == true)
                {
                    Console.WriteLine("Obwód kwadratu wynosi " + cyferka * 4 + "cm");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");

                Console.ReadLine();
            
            }
        }

        static void Prostokąt()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>> Figura: Prostokąt <<<<<<<<");
                Console.WriteLine(">>>>>>>> Wybierz Oblicznia <<<<<<<<");
                Console.WriteLine("1 - Pole");
                Console.WriteLine("2 - Obwód");
                Console.WriteLine("3 - Wstecz");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear(); PoleAB(); break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); ObwódABAB(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.Escape:
                    case ConsoleKey.NumPad3:
                        Console.Clear(); Main(); break;
                    default: break;
                }
            }

            static void PoleAB()
            {
                Console.WriteLine("Podaj długość boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);

                Console.WriteLine("Podaj długość boku b: ");
                string b = Console.ReadLine();
                double cyferka2 = 0;
                bool cyferka3 = double.TryParse(b, out cyferka2);

                if (cyferka1 == true && cyferka3 == true)
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Pole porostokątu wynosi " + cyferka * cyferka2 + "cm\xB2");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");


                Console.ReadLine();

            }

            static void ObwódABAB()
            {
                Console.WriteLine("Podaj długośc boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);

                Console.WriteLine("Podaj długość boku b: ");
                string b = Console.ReadLine();
                double cyferka2 = 0;
                bool cyferka3 = double.TryParse(b, out cyferka2);

                if (cyferka1 == true && cyferka3 == true)
                {
                    Console.WriteLine("Obwód prostokatu wynowi " + (cyferka + cyferka + cyferka2 + cyferka2) + "cm");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();

            }
        }
        static void Koło()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>>>> Figura: koło <<<<<<<<<<<<");
                Console.WriteLine(">>>>>>>> Wybierz Obliczenia <<<<<<<<");
                Console.WriteLine("1 - Pole");
                Console.WriteLine("2 - Obwód");
                Console.WriteLine("3 - Wstecz");


                ConsoleKeyInfo Klawisz = Console.ReadKey();
                switch (Klawisz.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear(); PoleR(); break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); ObwódR(); break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear(); Main(); break;
                    default: break;

                }
            }
            static void PoleR()
            {
                Console.WriteLine("Podaj długość promienia r: ");
                string r = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(r, out cyferka);

                if (cyferka1 == true)
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Pole koła wynosi " + 3.14 * cyferka + "cm\xB2");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");
                Console.ReadLine();
            }

            static void ObwódR()
            {
                Console.WriteLine("Podaj długość promienia r: ");
                string r = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(r, out cyferka);

                if (cyferka1 == true)
                {
                    Console.WriteLine("Obwód Trójkąta wynosi: " + 2 * 3.14 * cyferka + "cm");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");

                Console.ReadLine();

            }





        }
        static void Trapez()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>>>>>>> Figura: Trapez <<<<<<<<<<");
                Console.WriteLine(">>>>>>>> Wybierz Oblicznia <<<<<<<<");
                Console.WriteLine("1 - Pole");
                Console.WriteLine("2 - Obwód");
                Console.WriteLine("3 - Wstecz");
                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear(); PoleABH(); break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear(); ObwódABC(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.Escape:
                    case ConsoleKey.NumPad3:
                        Console.Clear(); Main(); break;
                    default: break;
                }


            }
            static void PoleABH()
            {
                Console.WriteLine("Podaj długość Boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);


                Console.WriteLine("POdaj długość boku b: ");
                string b = Console.ReadLine();
                double cyferka2 = 0;
                bool cyferka3 = double.TryParse(b, out cyferka2);

                Console.WriteLine("Podaj wysokość trapezu:  ");
                string h = Console.ReadLine();
                double cyferka4 = 0;
                bool cyferka5 = double.TryParse(h, out cyferka4);

                if (cyferka1 == true && cyferka3 == true && cyferka5 == true)
                {
                    Console.OutputEncoding = Encoding.Unicode;
                    Console.WriteLine("Pole Trapezu wynosi " + ((cyferka + cyferka2) * cyferka4) / 2 + "cm\xB2");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");
                Console.ReadLine();


            }

            static void ObwódABC()
            {
                Console.WriteLine("Podaj długość boku a: ");
                string a = Console.ReadLine();
                double cyferka = 0;
                bool cyferka1 = double.TryParse(a, out cyferka);

                Console.WriteLine("Podaj długośc boku b: ");
                string b = Console.ReadLine();
                double cyferka2 = 0;
                bool cyferka3 = double.TryParse(b, out cyferka2);


                Console.WriteLine("Podaj długośc boku c: ");
                string c = Console.ReadLine();
                double cyferka4 = 0;
                bool cyferka5 = double.TryParse(c, out cyferka4); ;
                if (cyferka1 == true && cyferka3 == true && cyferka5 == true)
                {
                    Console.WriteLine("Obwód trapezu wynosi " + ((cyferka + cyferka2) + cyferka4 * 2) + "cm");
                }
                else
                    Console.WriteLine("Nie prawidłowy ciąg znaków");
                Console.ReadLine();


            }


        }
    }
}