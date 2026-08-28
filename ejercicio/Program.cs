using System.Numerics;

class Program
{
    static void Main()
    {
        string nombre;
        long suma, resta, multiplicacion, num1, num2;
        double division;

        Console.WriteLine("Ingresa tu nombre: ");
        nombre = Console.ReadLine() ?? "";

        Console.WriteLine("Ingresa tu primer numero: ");
        num1 = long.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Ingresa tu segundo numero: ");
        num2 = long.Parse(Console.ReadLine() ?? "0");

        suma = num1 + num2;
        resta = num1 - num2;
        multiplicacion = num1 * num2;
        division = (double)num1 / num2;

        Console.WriteLine($"Hola {nombre}");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicacion: {multiplicacion}");
        Console.WriteLine($"Division: {division}");

        if (num1 > num2)
        {
            Console.WriteLine("El primer numero ingresado es mayor");
        }
        else if (num1 == num2)
        {
            Console.WriteLine("Los numeros ingresados son iguales");
        }
        else
        {
            Console.WriteLine("El segundo numero ingresado es mayor");
        }
    }
}
