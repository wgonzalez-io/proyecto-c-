using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string nombre;
        long suma, resta, multiplicacion, num1, num2;
        double division;
        bool valid = true;
        bool numero;
        do{
        Console.WriteLine("Ingresa tu nombre: ");
        nombre = (Console.ReadLine() ?? "").Trim();
        if(Regex.IsMatch(nombre, @"^[\p{L} ]+$") && nombre.Length >= 5)
        {
            Console.WriteLine("Nombre registrado con éxito\n");
            valid=true;
        }
        else
        {
            Console.WriteLine("Solo puedes ingresar letras y el nombre debe tener al menos 5 caracteres\n");
            valid = false;     
        }
        }while(!valid);

        do{
        Console.WriteLine("Ingresa tu primer numero: ");
        numero = long.TryParse(Console.ReadLine() , out num1);
            if (numero)
            {
                Console.WriteLine($"Numero ingresado correctamente: {num1}\n");
            }
            else
            {
                Console.WriteLine("Solo puedes ingresar numeros\n");
            }
        }while(!numero);
        do{
        Console.WriteLine("Ingresa tu segundo numero: ");
        numero = long.TryParse(Console.ReadLine(), out num2) && num2 != 0;
            if (numero)
            {
                Console.WriteLine($"Numero ingresado correctamente: {num2}\n");
            }
            else
            {
                Console.WriteLine("Solo puedes ingresar numeros distintos de cero\n");
            }
        }while(!numero);
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
