using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            //Calling a method
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double bitch = AreaOfACircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {bitch}");
            
        }


        //declaring a method
        public static double AreaOfACircle(double r)
        {
            double area = Math.Pow(Math.PI * r, 2);
            return area;
        }

    }
}
