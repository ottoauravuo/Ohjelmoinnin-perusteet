using System;

namespace Itsearviointi_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = 0;
            int TotalInput = 0;
            bool ValidInt;

            while(UserInput != -1)
            {
                Console.Write("Input: ");

                ValidInt = Int32.TryParse(Console.ReadLine(), out UserInput);
                if (!ValidInt)
                {
                    Console.Write("Et syöttänyt numeroa.");
                }
                else
                {
                    TotalInput = TotalInput + UserInput;
                }
            }

            Console.WriteLine("Output: Lukujen summa on {0}", TotalInput + 1);
        
        }
    }
}
