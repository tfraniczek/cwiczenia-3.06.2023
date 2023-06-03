using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double r, p, o;
        Console.WriteLine("Wprowadz wartos pola kola:");
        p = inputValue();
        r = Math.Sqrt(p / Math.PI);
        o = 2 * Math.PI * r;
        Console.WriteLine("Obwod kola to: " + o);
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
