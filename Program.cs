using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Promedio promedio = new Promedio();
            Console.WriteLine("1 - Agregar valor \t\n2 - Calcular Promedio \t\n3 - Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese un valor");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        promedio.agregarValor(valor);
                        break;
                    case 2:
                        double prom = promedio.calcularPromedio();
                        Console.Clear();
                        Console.WriteLine("Su promedio es de: {0:F2}" , prom);
                        Console.ReadKey(); 
                        break;
                    case 3:
                        break;
                }
                Console.Clear();    
                Console.WriteLine("1 - Agregar valor \t\n2 - Calcular Promedio \t\n3 - Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 3) ;
            Console.ReadKey();
        }
    }
}





