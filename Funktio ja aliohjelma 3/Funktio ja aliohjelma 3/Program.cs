using System;

namespace Funktio_ja_aliohjelma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberinRange();
        }


        public static void NumberinRange()
        {
            int lowerbound = 1;
            int upperbound = 10;
            int userinput;

            Console.WriteLine("Syötä luku väliltä 1-10: ");
            if (Int32.TryParse(Console.ReadLine(), out userinput))
            {
                if (userinput < lowerbound || userinput > upperbound)
                {
                    Console.WriteLine("Luku {0} ei ole välillä 1-10.", userinput);
                    NumberinRange();
                }
                else
                { 
                    Console.WriteLine("Luku {0} on välillä 1-10", userinput);
                }
            }
            else
            {
                Console.WriteLine("Et syöttänyt lukua");
                NumberinRange();
            }
        }
    }
}
