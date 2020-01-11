using System;

namespace Taulukko_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] RandomNumbers = new int[10,20];
            Random RandomNumberGen = new Random();

            for (int i = 0; i < RandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < RandomNumbers.GetLength(1); j++)
                {
                    RandomNumbers[i, j] = RandomNumberGen.Next(0, 100);
                }
            }

            Console.WriteLine("[X, Y] = Arvo");
        
            for (int i = 0; i < RandomNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < RandomNumbers.GetLength(1); j++)
                {
                    Console.WriteLine("[{0},{1}] = {2}", i, j, RandomNumbers[i, j].ToString("00"));
                }
            }
        }
    }
}
