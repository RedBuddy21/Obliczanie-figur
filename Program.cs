using System.Text;
using static System.Double;


namespace Obliczanie_figur;

 public class MenuProgramu
{
    
    static void Main()
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
            Trojkat.StartPoleTrojkata();
        }

        static void ObwódABC()
        {
            Trojkat.StartObwodTajkat();
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
            Kwadrat1.StartPoleKwadrat();
        }

        static void ObwódAAAA()
        {
            Kwadrat1.StartObwodKwadrat();
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
            Prostakat.StartPoleProstakat();

        }

        static void ObwódABAB()
        {
            Prostakat.StartObwodProstakat();

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
            Kolo.StartPoleKolo();
        }

        static void ObwódR()
        {
            Kolo.StartObwodKolo();

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
            Trapez1.StartObwodTrapez();


        }


    }

    public static void PoleAbh()
    {
        Trapez1.StartPoleTrapez();
    }
}