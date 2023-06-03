using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Podaj pierwsza liczbe");
        a = inputValue();
        Console.WriteLine("Podaj druga liczbe");
        b = inputValue();
        if (a == b)
            Console.WriteLine("Podales takie same liczby.");
        else
            Console.WriteLine("Wieksza z tych dwoch liczb to ");
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
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
