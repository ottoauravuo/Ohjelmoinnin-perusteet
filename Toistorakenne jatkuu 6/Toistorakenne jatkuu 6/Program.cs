using System;

namespace Toistorakenne_jatkuu_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double number;
            int kutoset = 0;
            Random rnd = new Random();
            while (n < 1000)
            {
                number = rnd.Next(1, 7);
                if (number == 6)
                {
                    kutoset = kutoset + 1;
                }
                n++;
                Console.WriteLine("{0}. {1}", n, number);
            }
            Console.WriteLine("Kuutonen arvottiin {0} kertaa.", kutoset);
        }
    }
}
