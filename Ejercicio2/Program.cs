using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carnet;
            string nombre;

            float quiz1 = 0;
            float quiz2 = 0;
            float quiz3 = 0;

            float tarea1 = 0;
            float tarea2 = 0; 
            float tarea3=0;

            float examen1 = 0;
            float examen2 = 0;
            float examen3=0;
            float porcentajequiz;
            float porcentajeTarea;
            float porcentajeExam;
            float promedioFinal;

            Console.WriteLine("Digite el nombre del estudiante:");
            nombre=Console.ReadLine();

            Console.WriteLine("Digite el carnet del estudiante:");
            carnet = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite la nota del primer quiz:");
            quiz1=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del segundo quiz:");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del tercer quiz:");
            quiz3 = float.Parse(Console.ReadLine());

         
            

            Console.WriteLine("Digite la nota de la primer tarea:");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la segunta tarea:");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la tercera tarea:");
            quiz3 = float.Parse(Console.ReadLine());
  

            Console.WriteLine("Digite la nota del primer examen:");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del segundo examen:");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del tercer examen:");
            examen3 = float.Parse(Console.ReadLine());

            porcentajequiz = (quiz1 + quiz2 + quiz3) / 3 * 0.25f;
            porcentajeTarea = (tarea1 + tarea2 + tarea3) / 3 * 0.30f;
            porcentajeExam = (examen1 + examen2 + examen3) / 3 * 0.45f; 

            promedioFinal = porcentajequiz + porcentajeTarea + porcentajeExam ;

            Console.WriteLine($"Nombre del estudiante:{nombre}");
            Console.WriteLine($"Carnet del estudiante:{carnet}");
            Console.WriteLine($"El porcentaje de los quices es: {porcentajequiz}");
            Console.WriteLine($"El porcentaje de las tareas es: {porcentajeTarea}");
            Console.WriteLine($"El porcentaje de los examenes es: {porcentajeExam}");
            Console.WriteLine($"El promedio final del estudiante es:{promedioFinal}");

            if (promedioFinal >= 70)
            {
                Console.WriteLine("La condicion de estudiante es aprobado");
            }
            else if (promedioFinal >= 50 && promedioFinal > 70)
            {
                Console.WriteLine("La condicion del estudiante es aplazado");
            }

            else if (promedioFinal < 50)
            {

                Console.WriteLine("la condicion del estudiante es reprobado");
            }

            Console.ReadLine();
        }


    }
}
