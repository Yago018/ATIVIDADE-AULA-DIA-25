using System;

class Program
{
    static void Main()
    {
        int num;

        Console.WriteLine("Digite o valor para verificação");
        num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"O numero {num} é par");
        }
        else
            Console.WriteLine($"O numeor {num} é impar");
    }
}