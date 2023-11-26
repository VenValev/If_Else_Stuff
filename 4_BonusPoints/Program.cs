using System;

namespace _4_BonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double bt = 0;

            if (a <= 100)
            {
                bt += 5;
            }
            else if (a > 1000)
            {
                bt = bt + a * 0.1;
            }
            else
            {
                bt = bt + a * 0.2;
            }

            if (a % 2 == 0)
            {
                bt += 1;
            }
            if (a % 10 == 5)
            {
                bt += 2;
            }
            Console.WriteLine(bt);
            Console.WriteLine(a + bt);
        }
    }
}
