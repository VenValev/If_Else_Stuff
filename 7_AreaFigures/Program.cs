using System;

namespace _7_AreaFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (a == "square")
            {
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b * b);
            }
            if (a == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine(b * c);
            }
            if (a == "circle")
            {
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine((b * b) * Math.PI);
            }
            if (a == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine((b * c) / 2.0);
            }
        }
    }
}
