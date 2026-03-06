//Desafio 1
using System;

Console.WriteLine("Registro");

Console.Write("Crear un nombre de usuario: ");
string Registrado = Console.ReadLine();

Console.Write("Crear tu contraseña: ");
string Contrasena = Console.ReadLine();

Console.WriteLine("\n¡Registro exitoso! Ahora inicia sesión.\n");

Console.WriteLine("---- INICIO DE SESIÓN ------");

Console.Write("Usuario: ");
string usuarioIngresado = Console.ReadLine();

Console.Write("Contraseña: ");
string ContraIngresada = Console.ReadLine();

if (usuarioIngresado == Registrado && ContraIngresada == Contrasena)
{
    Console.WriteLine("\n¡Sesion Exitosa");
}
else if (usuarioIngresado != Registrado && ContraIngresada == Contrasena)
{
    Console.WriteLine("\nError: El usuario es incorrecto");
}
else if (usuarioIngresado == Registrado && ContraIngresada != Contrasena)
{
    Console.WriteLine("\nError: La contraseña es incorrecta.");
}
else
{
    Console.WriteLine("\nError total: Los datos son incorrectos");
}

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();