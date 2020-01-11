using System;

namespace Toistorakenne_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int even = 0;
            int odd = 0;
            Console.Write("Syötä luku:");
            userinput = Convert.ToInt32(Console.ReadLine());
            int n = userinput;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    even = even + n;
                }
                else
                {
                    odd = odd + n;
                }

                n--;
            }

            Console.Write("Parillisten lukujen summa on {0}, parittomien lukujen summa on {1}", even, odd);

            Console.ReadKey();
        }
    }
}
