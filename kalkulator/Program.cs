using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, nrdzialania, wynik;

        Console.WriteLine("Podaj pierwsza liczbe");
        a = inputValue();
        Console.WriteLine("Podaj druga liczbe");
        b = inputValue();
        Console.WriteLine("Podaj rodzaj obliczen, ktore chcesz wykonac.");
        Console.WriteLine("1 dodawanie");
        Console.WriteLine("2 odejmowanie");
        Console.WriteLine("3 mnożenie");
        Console.WriteLine("4 dzielenie");
        nrdzialania = inputValue();
        if (nrdzialania == 1)
        {
            wynik = a + b;
            Console.WriteLine(wynik);
        }
        else
        {
            if (nrdzialania == 2)
            {
                wynik = a - b;
                Console.WriteLine("Wynik to " + wynik);
            }
            else
            {
                if (nrdzialania == 3)
                {
                    wynik = a * b;
                    Console.WriteLine("Wynik to " + wynik);
                }
                else
                {
                    if (b != 0)
                    {
                        wynik = a / b;
                        Console.WriteLine("Wynik to " +wynik);
                    }
                    else
                    {
                        Console.WriteLine(a + "/" + b);
                    }
                }
            }
        }
        Console.ReadKey();
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
