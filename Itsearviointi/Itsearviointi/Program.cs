using System;

namespace Itsearviointi
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            
            Console.Write("Input: ");
            userinput = Console.ReadLine();

            Console.WriteLine("Output: ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", userinput);
            }
        }
    }
}
