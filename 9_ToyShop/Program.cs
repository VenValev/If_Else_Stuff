using System;

namespace _9_ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ex = double.Parse(Console.ReadLine());
            int puz = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            double sum = puz * 2.60 + doll * 3 + bear * 4.10 + min * 8.20 + truck * 2;
            int br = puz + doll + bear + min + truck;
            //value = (float)System.Math.Round(value, 2);
            if (br >= 50)
            {
                sum = sum - (sum * 0.25);
            }
            sum = sum - (sum * 0.10);
            if (sum >= ex)
            {
                Console.WriteLine($"Yes! {sum - ex:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {ex - sum:f2} lv needed.");
            }
        }
    }
}
