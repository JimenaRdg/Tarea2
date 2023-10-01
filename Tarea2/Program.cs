using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de camisas");
            float camisas = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio");
            float precio=float.Parse(Console.ReadLine());

            if (camisas == 1)
            {
                precio = precio;
                Console.WriteLine("Queda a precio de costo");

            }
            else if  (camisas>2 || camisas<5 ) {
                precio = precio * 0.15f;
                Console.WriteLine($"El precio total es de: {precio} con un descuento de 15%");
            }
            else if (camisas>5)
            {
                precio = precio * 0.20f;
                Console.WriteLine($"El precio total es de: {precio} con un descuento de 20%");
           


            }
            Console.ReadLine();
        }

    }
}
