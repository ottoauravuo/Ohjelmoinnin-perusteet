using System;

namespace Toistorakenne_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int fn = 1;
            Console.Write("Syötä luku:");
            userinput = Convert.ToInt32(Console.ReadLine());
            int n = userinput;
            while (n >= 1)
            {
                fn = fn * n;
                n--;
            }
            Console.WriteLine("Luvun {0} kertoma on {1}", userinput, fn);


            Console.ReadKey();
        }
    }
}
