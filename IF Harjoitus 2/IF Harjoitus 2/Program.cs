using System;

namespace IF_Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Ohjelma selvittää lipun hinnan ");

            Console.WriteLine("Oletko Varusmies K vai E");
            string userinput = Console.ReadLine();

            if (userinput == "K")
                Console.WriteLine("Lipun hinta on 8 euroa");
            else
            {
                Console.WriteLine("Oletko opiskelija K vai E");
                userinput = Console.ReadLine();
                if (userinput == "K")
                {
                    Console.WriteLine("Oletko MTK jäsen?");
                    userinput = Console.ReadLine();
                    if (userinput == "K")
                    Console.WriteLine("Lipun hinta on 6.4 euroa");
                    else
                    {
                        Console.WriteLine("Lipun hinta on 10.4 euroa");
                    }
                }
                else
                {
                    Console.WriteLine("Syötä ikäsi: ");
                    int userinput2 = int.Parse(Console.ReadLine());
                    if (userinput2 <= 7)
                    {
                        Console.WriteLine("Lipun hinta on 0 euroa");
                    }
                    else
                    {
                        if (userinput2 >= 65)
                        {
                            Console.WriteLine("Lipun hinta on 8 euroa");
                        }
                        else
                        {
                            Console.WriteLine("Lipun hinta on 16 euroa");
                        }
                    }
                }
            }






        }
    }
}
