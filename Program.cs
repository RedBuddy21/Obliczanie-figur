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
                Console.WriteLine(">>>>>>>> Wybierz Figurę do obliczenia <<<<<<<<");
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
                        Console.Clear(); Trójkąt(); break;

                    case ConsoleKey.D2:
                        Console.Clear(); Kwadrat(); break;

                    case ConsoleKey.D3:
                        Console.Clear(); Prostokąt(); break;
                    case ConsoleKey.D4:
                        Console.Clear(); Koło(); break;
                    case ConsoleKey.D5:
                        Console.Clear(); Trapez(); break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D6:
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
                        Console.Clear(); PoleAH(); break;

                    case ConsoleKey.D2:
                        Console.Clear(); ObwódABC(); break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Console.Clear(); Main(); break;
                    default: break;

                }
            }
            static void PoleAH()
            {
                Console.WriteLine("Podaj Długość podstawy: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj wysokośc trójkąta: ");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole wynosi "+ (a*h)/2 +"cm\xB2");

                Console.ReadLine();
            }

            static void ObwódABC()
            {
                Console.WriteLine("Podaj długość boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj długośc boku b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj długośc boku c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Obwód Trójkąta wynosi: "+(a + b + c)+"cm");

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
                        Console.Clear(); PoleAA(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); ObwódAAAA(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.Escape:
                        Console.Clear(); Main(); break;
                    default: break;
                
                }
            }

            static void PoleAA()
            {
                Console.WriteLine("Podaj długość boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole kwadratu wynosi "+ a*a +"cm\xB2");
                Console.ReadLine();
            }

            static void ObwódAAAA()
            {
                Console.WriteLine("Podaj długość boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Obwód kwadratu wynosi "+ a*4 +"cm");
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
                        Console.Clear(); PoleAB(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); ObwódABAB(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.Escape:
                        Console.Clear(); Main(); break;
                    default: break;
                }
            }

            static void PoleAB()
            {
                Console.WriteLine("Podaj długość boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj długość boku b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole porostokątu wynosi "+ a*b +"cm\xB2");

                Console.ReadLine();

            }

            static void ObwódABAB()
            {
                Console.WriteLine("Podaj długośc boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj długość boku b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Obwód prostokatu wynowi "+ (a + a + b + b) +"cm");


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
                        Console.Clear(); PoleR(); break;

                    case ConsoleKey.D2:
                        Console.Clear(); ObwódR(); break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Console.Clear(); Main(); break;
                    default: break;

                }
            }
            static void PoleR()
            {
                Console.WriteLine("Podaj długość promienia r: ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole koła wynosi "+ 3.14*r  +"cm\xB2");

                Console.ReadLine();
            }

            static void ObwódR()
            {
                Console.WriteLine("Podaj długość promienia r: ");
                double r = Convert.ToDouble(Console.ReadLine());

                
                Console.WriteLine("Obwód Trójkąta wynosi: " + 2*3.14*r + "cm");

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
                        Console.Clear(); PoleABH(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); ObwódABC(); break;
                    case ConsoleKey.D3:
                    case ConsoleKey.Escape:
                        Console.Clear(); Main(); break;
                    default: break;
                }


            }
            static void PoleABH()
            {
                Console.WriteLine("Podaj długość Boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("POdaj długość boku b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj wysokość trapezu:  ");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole Trapezu wynosi "+ ((a+b)*h)/2+"cm\xB2");
                Console.ReadLine();


            }

            static void ObwódABC()
            {
                Console.WriteLine("Podaj długość boku a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj długośc boku b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Podaj długość ramion: ");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Obwód trapezu wynosi "+((a+b)+c*2)+"cm");
                Console.ReadLine();


            }


        }
    }
}