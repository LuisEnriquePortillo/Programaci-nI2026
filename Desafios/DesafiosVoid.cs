// Desafio 1

static void PromedioCalculo()
{
    Console.WriteLine("Escriba su nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine("Escriba su ingreso del primer mes");
    double mes1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Escriba su ingreso del segundo mes");
    double mes2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Escriba su ingreso del tercer mes");
    double mes3 = double.Parse(Console.ReadLine());
    double suma = mes1 + mes2 + mes3;
    double promedio = (mes1 + mes2 + mes3) / 3;
    Console.WriteLine($"Hola {nombre}, en total ganaste {suma} y promediaste {promedio}");
}
//PromedioCalculo();

//Desafio 3
static void Errores()
{
    try
    {
        Console.WriteLine("Introduce el primer numero");
        int n1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Introduce el segundo numero");
        int n2 = int.Parse(Console.ReadLine());

        int Suma = n1 + n2;
        Console.WriteLine("La suma es : " + Suma);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

//Errores();