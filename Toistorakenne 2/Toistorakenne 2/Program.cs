using System;

namespace Toistorakenne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int fn = 1;
            Console.Write("Syötä kuinka monta lukua haluat laskea yhteen: ");
            userinput = Convert.ToInt32(Console.ReadLine());
            int n = userinput;
            while (n > 1)
            {
                fn = fn + n;
                n--;
            }
            Console.Write("Lukujen summa on {0}",fn);
            
            Console.ReadKey();

        }
    }
}
