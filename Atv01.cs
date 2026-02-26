using System;

class Program
{
    static void Main()
    {
        double x1, x2, y1, y2;

        Console.WriteLine("Valor de x1:");
        x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor de y1:");
        y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor de x2:");
        x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor de y2:");
        y2 = double.Parse(Console.ReadLine());

        double s01 = Math.Pow(x2 - x1, 2);
        double s02 = Math.Pow(y2 - y1, 2);

        double r = Math.Sqrt(s01 + s02);

        Console.WriteLine($"O valor da conta é {r}");

    }
}