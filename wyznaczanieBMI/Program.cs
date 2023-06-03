using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h, bmi;
        Console.WriteLine("Podaj swoja wage w kg:");
        w = inputValue();
        Console.WriteLine("Podaj swoja wage w metrach:");
        h = inputValue();
        bmi = w / Math.Pow(h, 2);
        Console.WriteLine("Twoje BMI wynosi: " + bmi);
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
