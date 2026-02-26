using System;

class Program
{
    static void Main() 
    {
        int A, B, C;
        int M = 0;

        Console.WriteLine("Digite o valo de A");
        A = int.Parse(Console.ReadLine());

        if (A > M)
        {
            M = A;
        }

        Console.WriteLine("Digite o valo de B");
        B = int.Parse(Console.ReadLine());

        if (B > M)
        {
            M = B;
        }

        Console.WriteLine("Digite o valo de C");
        C = int.Parse(Console.ReadLine());

        if (C > M)
        {
            M = C;
        }

        int S = A + B + C;

        if (S % 2 == 0)
        {
            Console.WriteLine($"A soma de todos os valores {S} é Par");
        }
        else
        {
            Console.WriteLine($"A soma de todos os valores {S} é Impar");
        }

        Console.WriteLine($"O maior valor é {M}");
    }
}
