using System;

Console.Write("Escribe un número que sea positivo: ");
int n = int.Parse(Console.ReadLine()); 

Console.WriteLine("Los pares son: ");

for (int i = 1; i <= n; i++)
    if (i % 2 == 0) 
        Console.WriteLine(i);

