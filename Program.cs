
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de talleres del centro:");
        int cantidad = ValidarNum();
        string[] NombreTaller = new string[cantidad];
        string[][] HerramientasTallerNombre = new string[cantidad][];
        int[][] HerramientasTallerCantidad = new int[cantidad][];
        RegistrarNombre(NombreTaller);
        RegisttarCantidadHerramientas(HerramientasTallerCantidad, HerramientasTallerNombre,NombreTaller);
        MostrarDatos(HerramientasTallerNombre,NombreTaller, HerramientasTallerCantidad);

    }

    static void RegistrarNombre(string[] NombreTaller)
    {
        for(int i = 0; i < NombreTaller.Length; i++)
        {
            Console.Write($"Ingrese el nombre del taller n°{i+1}: ");
            NombreTaller[i] = ValidarNombre();

        }
    }
    static void RegisttarCantidadHerramientas(int[][] HerramientasTallerCantidad, string[][] HerramientasTallerNombre, string[] NombreTaller)
    {
        int cantidad = 0;
        for (int i = 0; i < HerramientasTallerCantidad.Length; i++)
        {
          Console.WriteLine($"Ingrese el número de tipo de herramientas que usa el taller {NombreTaller[i]}: ");
          cantidad = ValidarNum();
          HerramientasTallerCantidad[i] = new int[cantidad];
          HerramientasTallerNombre[i] = new string[cantidad];
          Console.WriteLine();
          Console.WriteLine("=======================================");
          for (int j = 0; j < HerramientasTallerCantidad[i].Length; j++)
            {
                Console.Write($"Ingrese el tipo de herramienta n°{j+1} del taller {NombreTaller[i]}: ");
                HerramientasTallerNombre[i][j] = ValidarNombre();
                Console.WriteLine();
                Console.Write("Ingrese la cantidad de herramientas disponibles:");
                HerramientasTallerCantidad[i][j] = ValidarNum();
                Console.WriteLine();

            }
            Console.WriteLine("===========================================");
          

        }
        
    }
    static string ValidarNombre()
    {
        string temp = " ";
        do
        {
           temp = Console.ReadLine()? .Trim()?? "";
            if (string.IsNullOrWhiteSpace(temp))
            {
                Console.Write("No puede dejar vacío el espacio. Intente otra vez:");
                continue;
            }
              if(temp.Length < 5 && temp.Length < 8)
            {
                Console.Write("Debe introducir el nombre completo. Mínimo 8 caracteres.");
                Console.WriteLine("Intente de nuevo. ");
                continue;
            } else if(!Regex.IsMatch(temp, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$")){
                Console.Write("El nombre solo puede contener letras. Intente otra vez:");
                temp = " ";
            }  
         } while(string.IsNullOrWhiteSpace(temp));
        return temp;
    }

    static int ValidarNum()
    {
        int retorno = 0;
        do
        {
            try
            {
                retorno = int.Parse(Console.ReadLine());
                    if(retorno < 1)
                {
                    Console.WriteLine("No puede ingresar una cantidad menor a 1.");
                }
                
                
            } catch (FormatException e)
            {
                Console.WriteLine("Solo puede ingresar números. Intente de nuevo:");
                retorno = 0;
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"{e.Message} Intente con una cantidad mas baja:");
                retorno = 0;
            }
        } while(retorno <1); 
        return retorno;
    }

    static void MostrarDatos(string[][] HerramientasTallerNombre, string[] NombreTaller, int[][] HerramientasTallerCantidad)
    {
        Console.WriteLine("---------DATOS DE LOS TALLERES DEL CENTRO---------");
        for(int i = 0; i < HerramientasTallerNombre.Length; i++)
        {
            
            Console.WriteLine($"Las herramientas del taller {NombreTaller[i]} son: ");
            Console.WriteLine("----------------------------------------");
            for(int j = 0; j < HerramientasTallerCantidad[i].Length; j++)
            {
                Console.Write($"{HerramientasTallerNombre[i][j]}: {HerramientasTallerCantidad[i][j]}");
                Console.WriteLine();
            }
        }
    }
}


