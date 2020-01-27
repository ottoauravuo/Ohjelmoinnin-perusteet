using System;

namespace Merkkijono_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä teksti: ");
            string text = Console.ReadLine().ToUpper();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'L')
                {
                    counter++;
                }
            }
            Console.WriteLine("Syöttämässäsi tekstissä {0} on {1} L-kirjainta.", text, counter);
        }
    }
}
