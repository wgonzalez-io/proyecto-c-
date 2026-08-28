class Program
{
    static void Main(String [] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese un numero:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su segundo numero");
        int num2 = int.Parse(Console.ReadLine());
        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicación = num1 * num2;
        int división = num1 / num2;
        Console.WriteLine("La suma fue:" + suma);
        Console.WriteLine("La resta fue:" + resta);
        Console.WriteLine("La multiplicación fue:" + multiplicación);
        Console.WriteLine("La división fue:" + división);
        if (num1 > num2)
        {
            Console.WriteLine("El primer número es mayor");
        }
        else
        {
            Console.WriteLine("El segundo numero fue mayor:" + num2);
        }

    }
}
