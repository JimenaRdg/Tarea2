using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productos;
            double PrecioArticulo=0;


            Console.WriteLine("Digite la cantidad de productos");
            productos=int.Parse(Console.ReadLine());

            if (productos<=10) {

                PrecioArticulo = 20;

            }
            else if (productos>10) 
            {
                PrecioArticulo = 15; 
         
            }
            double total = productos * PrecioArticulo;

            Console.WriteLine($"La cantidad de articulos es: {productos}");
            Console.WriteLine($"El precio de articulos es: {PrecioArticulo}");
            Console.WriteLine($"El total es: {total}");

            Console.ReadLine();
        }


    }
}
