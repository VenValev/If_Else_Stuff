using System;

namespace _8_PlusMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int hour = a;
            int min = b + 15;
            if (min >= 60)
            {
                min = min - 60;
                hour++;
            }
            if (hour > 23)
            {
                hour = hour - 24;
            }
            if (min < 10)
            {
                Console.WriteLine($"{hour}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hour}:{min}");
            }
        }
    }
}
