using System;

namespace Itsearviointi_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String userinput;

            Console.Write("Input: ");
            userinput = Console.ReadLine();

            for (int i = 0; i < userinput.Length; i++)
            {
                Console.WriteLine(userinput);
            }
        }
    }
}
