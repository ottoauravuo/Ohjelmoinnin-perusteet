using System;
using System.Text;

namespace Taulukko_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RandomArrayOne = new int[10];
            int[] RandomArrayTwo = new int[10];
            int[] LargestNumberArray = new int[10];
            int Compare;
            int TempIntOne;
            int TempIntTwo;
            Random RandomNumberGen = new Random();
            StringBuilder OutputString = new StringBuilder();

            for (int i = 0; i < RandomArrayOne.Length; i++)
            {
                RandomArrayOne[i] = RandomNumberGen.Next(1, 100);
            }

            for (int i = 0; i < RandomArrayTwo.Length; i++)
            {
                RandomArrayTwo[i] = RandomNumberGen.Next(1, 100);
            }

            for (int i = 0; i < LargestNumberArray.Length; i++)
            {
                TempIntOne = RandomArrayOne[i];
                TempIntTwo = RandomArrayTwo[i];

                Compare = RandomArrayOne[i].CompareTo(RandomArrayTwo[i]);

                if (Compare == 1)
                {
                    LargestNumberArray[i] = RandomArrayOne[i];
                }
                else if (Compare == -1)
                {
                    LargestNumberArray[i] = RandomArrayTwo[i];
                }
                else
                {
                    LargestNumberArray[i] = RandomArrayOne[i];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                OutputString.AppendFormat("{0} ", i.ToString("00")); 
            }


            Console.Write("          ");
            Console.WriteLine(OutputString.ToString());
            OutputString.Clear();
            Console.WriteLine("          -----------------------------");

            for (int i = 0; i < RandomArrayOne.Length; i++)
            {
                OutputString.AppendFormat("{0}", RandomArrayOne[i].ToString("00"));
                OutputString.Append(" ");
            }

            Console.Write("Array 1:  ");
            Console.WriteLine(OutputString.ToString());
            OutputString.Clear();

            for (int i = 0; i < RandomArrayTwo.Length; i++)
            {
                OutputString.AppendFormat("{0}", RandomArrayTwo[i].ToString("00"));
                OutputString.Append(" ");
            }

            Console.Write("Array 2:  ");
            Console.WriteLine(OutputString.ToString());
            OutputString.Clear();

            for (int i = 0; i < LargestNumberArray.Length; i++)
            {
                OutputString.AppendFormat("{0}", LargestNumberArray[i].ToString("00"));
                OutputString.Append(" ");
            }

            Console.Write("Array 3:  ");
            Console.WriteLine(OutputString.ToString());
            OutputString.Clear();
        }
    }
}
