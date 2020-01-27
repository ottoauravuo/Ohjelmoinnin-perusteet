using System;

namespace Vakuutusmaksut
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            string userinput;
            
            Console.WriteLine("Syötä kirjain joka vastaa haluamasi eläintä");
            Console.WriteLine("");
            Console.WriteLine("Koira, syötä kirjain: A");
            Console.WriteLine("Kissa, syötä kirjain: B");
            Console.WriteLine("Lintu, syötä kirjain: C");
            Console.WriteLine("Matelija, syötä kirjain: D");

            userinput = Console.ReadLine();
            animal.CheckInput(userinput);
            animal.SetSpecies(userinput);
            if (animal.isDogOrCat == true)
            {
                Console.WriteLine("Onko eläimesi leikattu?");
                Console.WriteLine("");
                Console.WriteLine("Leikattu, syötä kirjan: K");
                Console.WriteLine("Leikkaamaton, syötä kirjan: E");
                userinput = Console.ReadLine();
                animal.CheckInput2(userinput);
                animal.IsNeutered(userinput);
            }
            animal.SetPrice();
            animal.PrintInfo();
        }
    }
}
