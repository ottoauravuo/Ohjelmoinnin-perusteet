using System;

namespace Taulukko_3
{
    class Program
    {

        static void Main(string[] args)
        {
            RandomTwenty();
        }

        public static void RandomTwenty()
        {
            int[] RandomNumbers = new int[20];
            Random RandomNumberGen = new Random();

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = RandomNumberGen.Next(0, 20);
            }

            Console.WriteLine("[x] = Arvo");
        
            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                Console.WriteLine("[{0}] = {1}", i, RandomNumbers[i].ToString("00"));
            }
        
        
        }
    }
}
