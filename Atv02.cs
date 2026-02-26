using System;

int A, B, C;

Console.WriteLine("Valor de A: ");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Valor de B: ");
B = int.Parse(Console.ReadLine());

Console.WriteLine("Valor de C: ");
C = int.Parse(Console.ReadLine());

double R = Math.Pow(A + B, 2);

double S = Math.Pow(B + B, 2);

double D = (R + S) / 2;

Console.WriteLine($"Valor de D é {D}");