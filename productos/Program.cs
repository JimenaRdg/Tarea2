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
            

            Console.WriteLine("Digite la cantidad de productos");
            productos=int.Parse(Console.ReadLine());

            if (productos<=10) {
                Console.WriteLine("el precio por producto es de $20");

            }
            else if (productos>10) 
            {
                Console.WriteLine("El precio por producto es de $15");
         
            }
            Console.ReadLine();
        }


    }
}
