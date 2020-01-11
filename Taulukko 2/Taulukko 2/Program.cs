using System;

namespace Taulukko_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RandomNumbers = new int[7];
            int BonusNumber = 41;
            int DoublingNumber = 0;
            Random RandomNumberGen = new Random();

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                RandomNumbers[i] = RandomNumberGen.Next(1, 40);
            }

            BonusNumber = RandomNumberGen.Next(1, 40);
            DoublingNumber = RandomNumberGen.Next(1, 40);
            
            Array.Sort(RandomNumbers);
            
            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                Console.Write("{0} ", RandomNumbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Lisänumero: {0}", BonusNumber);
            Console.WriteLine("Tuplausnumero: {0}", DoublingNumber); 
        
        }
    }
}
