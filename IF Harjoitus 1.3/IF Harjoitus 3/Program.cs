using System;

namespace IF_Harjoitus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku: ");
            int luku = int.Parse(Console.ReadLine());

            if (luku >= 0)
            {
                if (luku % 2 == 0)
                {
                    Console.WriteLine("Luku on positiivinen ja parillinen");
                }
                else
                {
                    Console.WriteLine("Luku on positiivinen ja pariton");
                }
                Console.ReadKey();    
            }
            else
            {
                if (luku % 2 == 0)
                {
                    Console.WriteLine("Luku on negatiivinen ja parillinen");
                }
                else
                {
                    Console.WriteLine("Luku on negatiivinen ja pariton");
                }
                Console.ReadKey();
            
            }
        }
    }
}
