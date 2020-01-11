using System;

namespace Itsearviointi_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1;
            int userinput2;
            int Added;
            int Subtracted;
            int Multiplied;
            int Divided;
            bool ValidInput;

            Console.Write("Syötä ensimmäinen luku: ");
            ValidInput = Int32.TryParse(Console.ReadLine(), out userinput1);

            while (!ValidInput)
            {
                Console.WriteLine("Et syöttänyt numeroa. Syötä numero: ");
                ValidInput = Int32.TryParse(Console.ReadLine(), out userinput1);
            }

            Console.Write("Syötä toinen luku: ");
            ValidInput = Int32.TryParse(Console.ReadLine(), out userinput2);

            while (!ValidInput)
            {
                Console.WriteLine("Et syöttänyt numeroa. Syötä numero: ");
                ValidInput = Int32.TryParse(Console.ReadLine(), out userinput2);
            }

            Added = userinput1 + userinput2;
            Subtracted = userinput1 - userinput2;
            Multiplied = userinput1 * userinput2;
            Divided = userinput1 / userinput2;

            Console.WriteLine();
            Console.WriteLine("1. luku = {0}", userinput1);
            Console.WriteLine("2. luku = {0}", userinput2);
            Console.WriteLine("{0} + {1} = {2}", userinput1, userinput2, Added);
            Console.WriteLine("{0} - {1} = {2}", userinput1, userinput2, Subtracted);
            Console.WriteLine("{0} * {1} = {2}", userinput1, userinput2, Multiplied);
            Console.WriteLine("{0} / {1} = {2}", userinput1, userinput2, Divided);

        }
    }
}
