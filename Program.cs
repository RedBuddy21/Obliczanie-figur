using System.Text;
using static System.Double;


namespace Obliczanie_figur;

internal static class MenuProgramu
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
            if (Klawisz.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
            {
                Console.Clear();
                Trójkąt();
            }
            else if (Klawisz.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
            {
                Console.Clear();
                Kwadrat();
            }
            else if (Klawisz.Key is ConsoleKey.D3 or ConsoleKey.NumPad3)
            {
                Console.Clear();
                Prostokąt();
            }
            else if (Klawisz.Key is ConsoleKey.D4 or ConsoleKey.NumPad4)
            {
                Console.Clear();
                Koło();
            }
            else if (Klawisz.Key is ConsoleKey.D5 or ConsoleKey.NumPad5)
            {
                Console.Clear();
                Trapez();
            }
            else if (Klawisz.Key is ConsoleKey.Escape or ConsoleKey.D6 or ConsoleKey.NumPad6)
            {
                Environment.Exit(0);
            }
            
        }
        // ReSharper disable once FunctionNeverReturns
    }

    private static void Trójkąt()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(">>>>>>>>>> Figura: Trójkąt <<<<<<<<<");
            Console.WriteLine(">>>>>>>> Wybierz Obliczenia <<<<<<<<");
            Console.WriteLine("1 - Pole");
            Console.WriteLine("2 - Obwód");
            Console.WriteLine("3 - Wstecz");


            ConsoleKeyInfo klawisz = Console.ReadKey();
            if (klawisz.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
            {
                Console.Clear();
                PoleAH();
            }
            else if (klawisz.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
            {
                Console.Clear();
                ObwódABC();
            }
            else if (klawisz.Key is ConsoleKey.D3 or ConsoleKey.NumPad3 or ConsoleKey.Escape)
            {
                Console.Clear();
                Main();
            }
            else
            {
            }
        }
        static void PoleAH()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);


            Console.WriteLine("Podaj wysokość Trójkąta: ");
            var isLenghtH = true;
            var lenghtH = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtH = TryParse(b, out lenghtH);
                if (!isLenghtH)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtH);

            if (isLenghtA && isLenghtH)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole wynosi " + (lengthA * lenghtH) / 2 + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciag znaków");


            Console.ReadLine();
        }

        static void ObwódABC()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);

            Console.WriteLine("Podaj długośc boku b: ");
            var isLenghtB = true;
            var lenghtB = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtB = TryParse(b, out lenghtB);
                if (!isLenghtB)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtB);

            Console.WriteLine("Podaj długośc boku c: ");
            var isLenghtC = true;
            var lenghtC = 0.0;
            do
            {
                var c = Console.ReadLine();
                isLenghtC = TryParse(c, out lenghtC);

                if (!isLenghtC)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtC);

            if (isLenghtA && isLenghtB && isLenghtC)
            {
                Console.WriteLine("Obwód Trójkąta wynosi: " + (lenghtC + lenghtB + lengthA) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();

        }
    }

    private static void Kwadrat()
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
            if (klawisz.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
            {
                Console.Clear();
                PoleAA();
            }
            else if (klawisz.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
            {
                Console.Clear();
                ObwódAAAA();
            }
            else if (klawisz.Key is ConsoleKey.D3 or ConsoleKey.NumPad3 or ConsoleKey.Escape)
            {
                Console.Clear();
                Main();
            }
            else
            {
            }
        }

        static void PoleAA()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);

            if (isLenghtA)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole kwadratu wynosi " + lengthA * lengthA + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }

        static void ObwódAAAA()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);

            if (isLenghtA)
            {
                Console.WriteLine("Obwód kwadratu wynosi " + lengthA * 4 + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
            
        }
    }

    private static void Prostokąt()
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
            if (klawisz.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
            {
                Console.Clear();
                PoleAB();
            }
            else if (klawisz.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
            {
                Console.Clear();
                ObwódABAB();
            }
            else if (klawisz.Key is ConsoleKey.D3 or ConsoleKey.Escape or ConsoleKey.NumPad3)
            {
                Console.Clear();
                Main();
            }
            else
            {
            }
        }

        static void PoleAB()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);

            Console.WriteLine("Podaj długośc boku b: ");
            var isLenghtB = true;
            var lenghtB = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtB = TryParse(b, out lenghtB);
                if (!isLenghtB)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtB);

            if (isLenghtA && isLenghtB)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole porostokątu wynosi " + lengthA * lenghtB + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");


            Console.ReadLine();

        }

        static void ObwódABAB()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);

            Console.WriteLine("Podaj długośc boku b: ");
            var isLenghtB = true;
            var lenghtB = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtB = TryParse(b, out lenghtB);
                if (!isLenghtB)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtB);

            if (isLenghtA && isLenghtB)
            {
                Console.WriteLine("Obwód prostokatu wynowi " + (lengthA + lengthA + lenghtB + lenghtB) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();

        }
    }

    private static void Koło()
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
            if (Klawisz.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
            {
                Console.Clear();
                PoleR();
            }
            else if (Klawisz.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
            {
                Console.Clear();
                ObwódR();
            }
            else if (Klawisz.Key is ConsoleKey.Escape or ConsoleKey.D3 or ConsoleKey.NumPad3)
            {
                Console.Clear();
                Main();
            }
            else
            {
            }
        }
        static void PoleR()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtR = true;
            var lengthR = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtR = TryParse(a, out lengthR);
                if (!isLenghtR)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtR);

            if (isLenghtR)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Pole koła wynosi " + 3.14 * lengthR + "cm\xB2");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();
        }

        static void ObwódR()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtR = true;
            var lengthR = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtR = TryParse(a, out lengthR);
                if (!isLenghtR)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtR);

            if (isLenghtR)
            {
                Console.WriteLine("Obwód Trójkąta wynosi: " + 2 * 3.14 * lengthR + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();

        }





    }

    private static void Trapez()
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
            if (klawisz.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
            {
                Console.Clear();
                PoleAbh();
            }
            else if (klawisz.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
            {
                Console.Clear();
                ObwódABC();
            }
            else if (klawisz.Key is ConsoleKey.D3 or ConsoleKey.Escape or ConsoleKey.NumPad3)
            {
                Console.Clear();
                Main();
            }
            
        }

        static void ObwódABC()
        {
            Console.WriteLine("Podaj długość boku a: ");
            var isLenghtA = true;
            var lengthA = 0.0;
            do
            {
                var a = Console.ReadLine();
                isLenghtA = TryParse(a, out lengthA);
                if (!isLenghtA)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtA);

            Console.WriteLine("Podaj długośc boku b: ");
            var isLenghtB = true;
            var lenghtB = 0.0;
            do
            {
                var b = Console.ReadLine();
                isLenghtB = TryParse(b, out lenghtB);
                if (!isLenghtB)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtB);

            Console.WriteLine("Podaj długośc boku c: ");
            var isLenghtC = true;
            var lenghtC = 0.0;
            do
            {
                var c = Console.ReadLine();
                isLenghtC = TryParse(c, out lenghtC);
                
                if (!isLenghtC)
                {
                    Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
                }
            } while (!isLenghtC);


            if (isLenghtA && isLenghtB && isLenghtC )
            {
                Console.WriteLine("Obwód trapezu wynosi " + ((lengthA + lenghtB) + lenghtC * 2) + "cm");
            }
            else
                Console.WriteLine("Nie prawidłowy ciąg znaków");

            Console.ReadLine();


        }


    }

    public static void PoleAbh()
    {
        Console.WriteLine("Podaj długość boku a: ");
        var isLenghtA = true;
        var lengthA = 0.0;
        do
        {
            var a = Console.ReadLine();
            isLenghtA = TryParse(a, out lengthA);
            if (!isLenghtA)
            {
                Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
            }
        } while (!isLenghtA);

        Console.WriteLine("Podaj długośc boku b: ");
        var isLenghtB = true;
        var lenghtB = 0.0;
        do
        {
            var b = Console.ReadLine();
            isLenghtB = TryParse(b, out lenghtB);
            if (!isLenghtB)
            {
                Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
            }
        } while (!isLenghtB);

        Console.WriteLine("Podaj wysokość Trapezu: ");
        var isLenghtH = true;
        var lenghtH = 0.0;
        do
        {
            var b = Console.ReadLine();
            isLenghtH = TryParse(b, out lenghtH);
            if (!isLenghtH)
            {
                Console.WriteLine("Nie prawidłowy ciąg znaków! Podaj prawidłową wartość!");
            }
        } while (!isLenghtH);




        if (isLenghtA && isLenghtB && isLenghtH)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Pole Trapezu wynosi " + ((lengthA + lenghtH) * lenghtH) / 2 + "cm\xB2");
        }
        else
            Console.WriteLine("Nieprawidłowy ciąg znaków");

        Console.ReadLine();
    }
}