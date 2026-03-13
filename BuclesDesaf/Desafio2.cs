using System;

Console.Write("Ingresa un número: ");
int n = int.Parse(Console.ReadLine());

bool esPrimo = true; 

if (n <= 1) 
    esPrimo = false;

for (int i = 2; i < n; i++)
{
    if (n % i == 0) 
    {
        esPrimo = false; 
        break; 
    }
}

if (esPrimo)
    Console.WriteLine(n + " es un número primo.");
else
    Console.WriteLine(n + " NO es un número primo.");