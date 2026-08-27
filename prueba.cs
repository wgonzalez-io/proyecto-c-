using System;
class Programa
{
    static void Main(){
        Console.WriteLine("Hola mundo en C#, soy " + nombre);
        int edad;
        string nombre = "waskart";
        string dato;
        Console.WriteLine("Escribe tu nombre: ");
        dato=Console.ReadLine();
        Console.WriteLine("Escribe tu edad:");
        edad=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hola " + dato + ", tienes " + edad + " años.");
    }
}