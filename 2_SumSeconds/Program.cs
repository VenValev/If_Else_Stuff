using System;

namespace _2_SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            /*
            int d = 0;
            d += int.Parse(Console.ReadLine()); *3
            */
            int d = a + b + c;
            int min = d / 60;
            int sec = d % 60;
            /*
             * bool issec = sec<10;
            if(issec) ...
            */
            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}"); //$"{min}:{sec:d2} i premahvame if/else
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
            /*
            
             */
        }
    }
}
