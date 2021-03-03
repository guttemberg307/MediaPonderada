using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\n\n===========Media ponderada de 3 notas ===================");



            Console.Write("Insira nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Insira nota 2: ");
            double nota2= double.Parse(Console.ReadLine());

            Console.Write("Insira nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());


            double MediaPonderada = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)/10);


            Console.WriteLine(MediaPonderada);




        }
    }
} 