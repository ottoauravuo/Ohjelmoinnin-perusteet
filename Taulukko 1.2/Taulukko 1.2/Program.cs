using System;
namespace Taulukko_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            OneHundredRandom();
        }
    
        public static void OneHundredRandom()
        {
            Random random = new Random();
            int[] RandomNumbers = new int[100];
            int SumOfNumbers = 0;
            double AverageOfNumbers = 0;

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = random.Next(0, 50);
            }

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, RandomNumbers[i]);
            }

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                SumOfNumbers = SumOfNumbers + RandomNumbers[i];
            }

            AverageOfNumbers = SumOfNumbers / RandomNumbers.Length;
            AverageOfNumbers = Math.Round(AverageOfNumbers, 2);

            Console.WriteLine("Ka. = {0}", AverageOfNumbers);
        }
    
    
    
    
    }
}
