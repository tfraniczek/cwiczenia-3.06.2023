using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Podaj 3 dlugosci boku trojkata.");

        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        if (a == b)
        {
            if (b == c)
            {
                Console.WriteLine("To jest trojkat rownoboczny.");
            }
            else
            {
                Console.WriteLine("To nie jest trojkat rownoboczny.");
            }
        }
        else
        {
            Console.WriteLine("To nie jest trojkat rownoboczny.");
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
