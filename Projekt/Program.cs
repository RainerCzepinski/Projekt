using System;

class Program
{
    static void Main()
    {
    Start:

        Console.WriteLine("Kalkulator");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        Console.WriteLine("5. Potęgowanie");
        Console.WriteLine("6. Średnia ");
        Console.WriteLine("7. Pierwiastkowanie");
        Console.Write("Wybierz opcję: ");

        int opcja = Convert.ToInt32(Console.ReadLine());

        if (opcja == 1)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wynik: " + (a + b));
        }
        else if (opcja == 2)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wynik: " + (a - b));
        }
        else if (opcja == 3)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wynik: " + (a * b));
        }
        else if (opcja == 4)
        {
            Console.Write("Podaj liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dzielnik: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0");
                goto Start;
            }

            Console.WriteLine("Wynik: " + (a / b));
        }
        else if (opcja == 5)
        {
            Console.Write("Podaj podstawę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wykładnik: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (b < 0)
            {
                Console.WriteLine("Wykładnik nie może być ujemny");
                goto Start;
            }

            double wynik = 1;
            for (int i = 0; i < b; i++)
            {
                wynik *= a;
            }

            Console.WriteLine("Wynik potęgowania: " + wynik);
        }
        else if (opcja == 6)
        {
            Console.Write("Ile liczb chcesz podać: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("Ilość liczb musi być większa od zera");
                goto Start;
            }

            double[] tab = new double[a];
            int i = 0;
            double suma = 0;

            while (i < a)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                double l = Convert.ToDouble(Console.ReadLine());

                if (l < 0)
                {
                    Console.WriteLine("Pominięto liczbę ujemną");
                    i++;
                    continue;
                }

                tab[i] = l;
                suma += l;
                i++;
            }

            Console.WriteLine("Średnia: " + (suma / a));
        }
        else if (opcja == 7)
        {
            Console.Write("Podaj liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Nie można pierwiastkować liczby ujemnej.");
                goto Start;
            }

            double wynik = Math.Sqrt(a);
            Console.WriteLine("Pierwiastek z " + a + " to: " + wynik);
        }
        else
        {
            Console.WriteLine("Błąd");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć");
        Console.ReadKey(true);
    }
}
