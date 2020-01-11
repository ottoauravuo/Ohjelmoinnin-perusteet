using System;

namespace IF_Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Syötä luku: ");
            int luku = int.Parse(Console.ReadLine());

            
            if (luku % 2 == 0)
            {
                Console.WriteLine("Luku on parillinen");
            }
            else
            {
                Console.WriteLine("Luku on pariton");
            }
            Console.ReadKey();
        }   


    }
}
