
using System;

namespace ejercicioPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Promedio p = new Promedio();
            double promedio;
            int opcionMenu;
            do
            {
                Console.WriteLine("Seleccoine una opción");
                Console.WriteLine("1. Agregar un valor");
                Console.WriteLine("2. Calcular promedio");
                Console.WriteLine("3. Salir");
                opcionMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcionMenu)
                {
                    case 1:

                        Console.WriteLine("Ingrese un nuevo valor");
                        p.AgregarValor(Convert.ToDouble(Console.ReadLine()));
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        promedio = p.CalcularPromedio();
                        Console.WriteLine("El promedio es: {0}", promedio);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opcionMenu != 3);
        }
    }
}
