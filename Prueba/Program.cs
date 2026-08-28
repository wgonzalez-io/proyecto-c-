class Program
{
    static void Main(String [] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese un numero:");
        long num1 = long.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su segundo numero");
        long num2 = long.Parse(Console.ReadLine());
        long suma = num1 + num2;
        long resta = num1 - num2;
        long multiplicación = num1 * num2;
        long división = num1 / num2;
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
