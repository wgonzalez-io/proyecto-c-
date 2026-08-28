using System.Runtime.InteropServices;

class Program
{
    static void Main(String [] args)
    {
        bool comprobar = true;
        long num1 = -1, num2 = -1;
        do
        {
            Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();
        if (nombre.All(c => char.IsLetter(c) || c == ' '))
        {
            Console.WriteLine("Nombre registrado correctamente");
            comprobar = false;
        } else
        {
            Console.WriteLine("Solo puede ingresar letras");
            comprobar = true;
        }
        } while (comprobar);
        
        
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
        Console.WriteLine(" ");
        do
        {
            Console.WriteLine("Ingrese su segundo numero");
            if (long.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Se registró correctamente");
            }
        } while (comprobar);
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
