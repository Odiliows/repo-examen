using System;

namespace Exercici2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaració variables
            int a, b, c;
            double x1, x2;


            //Demanar valors
            Console.WriteLine("Escriu la a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu la b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu la a");
            c = Convert.ToInt32(Console.ReadLine());

            //Algoritme
            if (a == 0)
                Console.WriteLine("Error divisió per 0");

            else if (b * b - 4 * a * c < 0) 

            Console.WriteLine("El valor es negatiu");
            
            x1 = (-b + Math.Sqrt(Math.Pow(b,2) - (4 * a * c))) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            //


        }
    }
}
