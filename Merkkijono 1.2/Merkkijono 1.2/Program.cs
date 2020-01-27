using System;

namespace Merkkijono_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä teksti: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Replace("e", "@"));
        }
    }
}
