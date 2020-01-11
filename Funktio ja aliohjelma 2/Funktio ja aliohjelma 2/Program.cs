using System;

namespace Funktio_ja_aliohjelma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1;
            int userinput2;
            int compare;

            Console.WriteLine("Syötä ensimmäinen luku: ");
            userinput1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku: ");
            userinput2 = Int32.Parse(Console.ReadLine());

            compare = userinput1.CompareTo(userinput2);

            if (compare == -1)
            {

                Console.WriteLine("{0} on pienempi kuin {1}.", userinput1, userinput2);

            }
            else if (compare == 1)
            {

                Console.WriteLine("{0} on suurempi kuin {1}.", userinput1, userinput2);

            }
            else
            {

                Console.WriteLine("{0} on yhtäsuuri kuin {1}.", userinput1, userinput2);
            }
        }
    }
}
