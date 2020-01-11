using System;

namespace Toistorakenne_jatkuu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            double square_root;
            Console.WriteLine("Luku     Neliöjuuri");
            while (number <= 10)
            {
                square_root = Math.Sqrt(number);
                square_root = Math.Round(square_root, 2);
                Console.WriteLine(" {0}          {1}", number, square_root);
                number++;
            }
        }
    }
}
