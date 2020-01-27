using System;

namespace Merkkijono_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä teksti: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Length);
        }
    }
}
