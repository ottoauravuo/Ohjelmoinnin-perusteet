using System;

namespace IF_Harjoitus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku: ");
            int luku = int.Parse(Console.ReadLine());
                
            
            if (luku != 0)
            {
                if (luku > 0)
                {
                    Console.WriteLine("Luku on positiivinen");
                }
                else
                {
                    Console.WriteLine("Luku on negatiivinen");
                }                              
            }
            else
            {
                Console.WriteLine("Luku on nolla");
            }
            Console.ReadKey();
        }   
    }
}
