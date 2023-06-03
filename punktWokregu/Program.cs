using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r, a, b, ra, rb;

        Console.WriteLine("Podaj X");
        x = inputValue();
        Console.WriteLine("Podaj Y");
        y = inputValue();
        Console.WriteLine("Podaj R");
        r = inputValue();
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("Tak, punkt miesci sie w kole.");
        }
        else
        {
            Console.WriteLine("Nie, punkt nie miesci sie w kole.");
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
