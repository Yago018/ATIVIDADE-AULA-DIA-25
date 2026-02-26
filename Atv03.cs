using System;

int N01, N02, N03;

Console.WriteLine("Digite a primeira Nota:");
N01 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda Nota:");
N02 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira Nota:");
N03 = int.Parse(Console.ReadLine());

int P01 = N01 * 2;
int P02 = N02 * 3;
int P03 = N03 * 5;

double M = (P01 + P02 + P03)  / 10;

Console.WriteLine($"A media é {M}");