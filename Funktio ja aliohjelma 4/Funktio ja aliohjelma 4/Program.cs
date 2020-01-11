using System;
using System.Text;

namespace Funktio_ja_aliohjelma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] PositiveNumbers = new int[10];
            int counter = 0;
            int userinput;
            StringBuilder numbers;
            int GreatestNumber = 0;
            int numberposition = 0;

            while(counter < 10)
            {
                Console.WriteLine("Syötä positiivinen numero: ");
                if (Int32.TryParse(Console.ReadLine(), out userinput))
                {
                    if (userinput >= 0)
                    {
                        PositiveNumbers[counter] = userinput;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Et syöttänyt positiivista numeroa.");
                    }
                }
                else
                {
                    Console.WriteLine("Et syöttänyt numeroa.");
                }
            }

            numbers = new StringBuilder(PositiveNumbers.Length * 2);

            for (int i = 0; i < PositiveNumbers.Length; i++)
            {
                numbers.Append(PositiveNumbers[i]);
                numbers.Append(" ");
            }

            for (int i = 0; i < PositiveNumbers.Length; i++)
            {
                if(PositiveNumbers[i] > GreatestNumber)
                {
                    GreatestNumber = PositiveNumbers[i];
                    numberposition = i+1;
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine("Suurin {0} oli {1} luku.", GreatestNumber, numberposition);
        }
    }
}
