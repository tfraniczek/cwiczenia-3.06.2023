// See https://aka.ms/new-console-template for more information
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, sredniaArytmetyczna;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        sredniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("Srednia arytmetyczna dla podanych liczb to:");
        Console.WriteLine(sredniaArytmetyczna);
        Console.ReadKey();
    }

 
}

