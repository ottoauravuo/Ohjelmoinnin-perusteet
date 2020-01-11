using System;

namespace Toistorakenne_jatkuu_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            Random rnd = new Random();
            Console.WriteLine("Vastaus:");
            while (n < 5)
            {
                num1 = rnd.Next(50);
                num2 = rnd.Next(50);
                num3 = rnd.Next(50);
                num4 = rnd.Next(50);
                num5 = rnd.Next(50);
                Console.WriteLine("Rivi {5}: {0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, num5, n + 1);
                _ = n + 1;
                n++;
            }
        }
    }
}
