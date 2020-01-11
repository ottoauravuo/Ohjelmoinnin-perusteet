using System;

namespace Toistorakenne_jatkuu_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int kruunu = 0;
            int klaava = 0;
            int n = 0;
            int userinput;
            double number;
            Random rnd = new Random();
            Console.WriteLine("Syötä heittojen lukumäärä: ");
            userinput = Convert.ToInt32(Console.ReadLine());
            while (n < userinput)
            {
                number = rnd.NextDouble() * 100;
                if (number < 50)
                {
                    klaava = klaava + 1;
                    _ = n + 1;
                }
                else
                {
                    kruunu = kruunu + 1;
                    _ = n + 1;
                }
                n++;
            }
            Console.WriteLine("Vastaus: " +
                "Rahaa on heitetty {0} kertaa. " +
                "Klaavoja tuli {1} ja kruunuja {2}.", n, klaava, kruunu);
        }
    }
}
