using System;

namespace Toistorakenne_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäistä lukua yhteen positiivisilla ja negatiivisilla numeroilla");

            int number = 0;
            int summa = 0;
            do
            {
                Console.WriteLine("Syötä luku");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                if (number == 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }
            }
            while (number == 0);
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    summa += i;
                }
            }
            else
            {
                for (int i = -1; i >= number; i--)
                {
                    summa += i;
                }
            }
            Console.WriteLine($"Luvun {number} summa on {summa}");
            Console.ReadKey();
        }
    }
}
