using System;
class Programa
{
    static void Main(){
        Console.WriteLine("Hola mundo en C#");
        int edad;
        string nombre = "waskart";
        string dato;
        bool mayor = true;
        Console.WriteLine("Escribe tu nombre: ");
        dato=Console.ReadLine();
        Console.WriteLine("Escribe tu edad:");
        edad=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hola " + dato + ", tienes " + edad + " años.");
    }
}