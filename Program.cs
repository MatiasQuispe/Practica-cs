using System;

namespace clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string nombre;

            Console.WriteLine(" Cómo se llama el cliente ?");
            nombre = Console.ReadLine();

            Console.WriteLine("El cliente se llama {0}", nombre);
            Console.ReadKey();

            string nombre = "jorge";

            Console.WriteLine($"El cliente se llama {nombre}");
            Console.ReadKey();

            */

            bool n1 = true, n2 = false, n3 = true;

            int n4 = 5, n5 = 10;

            const double IVA = 0.21;

            double remera = 59.9, pantalon = 99.9, campera = 149.9;


            Console.WriteLine("n1 ^ n2 :" + (n1 ^ n2));
            Console.WriteLine("(n1 & !n2) | n3: " + ((n1 & !n2) | n3));
            Console.WriteLine("(n1 | n2) & !n3: " + ((n1 | n2) & !n3));
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("n4 == 5: " + (n4 == 5));
            Console.WriteLine("n2 == 10: " + (n5 == 10));
            Console.WriteLine("n4 + n5 == 15: " + ((n4 + n5) == 15));
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("El precio con IVA remera: " + (remera + (remera * IVA)));
            Console.WriteLine("El precio con IVA pantalon " + (pantalon + (pantalon * IVA)));
            Console.WriteLine("El precio con IVA campera: " + (campera + (campera * IVA)));
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();

        }
    }
}