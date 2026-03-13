using System;

double suma = 0;
int contador = 0;
string entrada = "";

Console.WriteLine("--- Registro de Calificaciones ---");
Console.WriteLine("Ingresa las notas (1 a 10). Ingrese fin para terminar");

while (entrada != "fin")
{
    Console.Write("Ingresa puntaje: ");
    entrada = Console.ReadLine().ToLower(); 

    if (entrada != "fin")
    {
        bool esNumero = double.TryParse(entrada, out double nota);
        
        if (esNumero && nota >= 1 && nota <= 10)
        {
            suma = suma + nota;
            contador = contador + 1;
        }
        else
        {
            Console.WriteLine("¡Error! Ingrese un número del 1 al 10 o la palabra -fin-.");
        }
    }
}
if (contador > 0)
{
    double promedio = suma / contador;
    Console.WriteLine("Cantidad de notas: " + contador);
    Console.WriteLine("El promedio final es: " + promedio);
}
else
{
    Console.WriteLine("No se ingresaron notas válidas.");
}