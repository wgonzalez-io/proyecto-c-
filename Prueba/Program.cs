class Program
{
    static void Main(String [] args)
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();
        long num1 = -1;
        bool comprobar = true;
        do {
        Console.WriteLine("Ingrese un numero:");
        if (long.TryParse(Console.ReadLine() , out num1))
        {
            Console.WriteLine("Se ingresó correctamente");
            comprobar = false;
        }
        else
        {
            Console.WriteLine("SOLO PUEDE INGRESAR NUMEROS");
            comprobar = true;
        }
        } while (comprobar);
       
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
