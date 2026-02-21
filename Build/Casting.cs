//Casting implicito 
int valor = 200;
double total = valor;
Console.WriteLine("implicito: "  + total);

//Casting explicito
double precio = 500.23;
int descuento = (int)precio;
Console.WriteLine("Explicito: "  + descuento);

char letra = 'A';
int condigoAsci = letra;
Console.WriteLine(condigoAsci);

string palabra = "123456";
int numero = Convert.ToInt32(palabra);
Console.WriteLine(numero);