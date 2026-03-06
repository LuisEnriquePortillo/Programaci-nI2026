using System;

namespace Calculadora
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Calculadora ESpecial");
            
            int n1 = 50;
            int n2 = 5;
            
            int suma = Operaciones.Suma(n1, n2);
            int resta = Operaciones.Resta(n1, n2);
            int multi = Operaciones.Multiplicacion(n1, n2);
            int divi = Operaciones.Division(n1, n2);
            
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: " + multi);
            Console.WriteLine("División: "  + divi);
        }
    }
}
