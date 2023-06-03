using System;

public class MyProgram
{

    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("Podaj liczbe a: ");
        a = (int)inputValue();
        Console.WriteLine("Podaj liczbe b: ");
        b = (int)inputValue();
        Console.WriteLine("Podaj liczbe c: ");
        c = (int)inputValue();
        Console.WriteLine("Podaj liczbe d: ");
        d = (int)inputValue();
        
        if (b == 0 || d == 0)

        
            Console.WriteLine("Brak rozwiązania");

        else
        {
            x = (a * b) + (b*c);
            y = b*d;
            Console.WriteLine("Liczba x to" + x);
            Console.WriteLine("Liczba Y to "+ y);
        }
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
