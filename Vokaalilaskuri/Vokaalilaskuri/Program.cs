using System;

namespace Vokaalilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = UserInput();
            string removedUserInput = VowelsRemove(userInput);
            Console.WriteLine("Vokaaleita tekstissä {0} on {1}", userInput, userInput.Length - removedUserInput.Length);
        }

        static string UserInput()
        {
            Console.Write("Syötä teksti: ");
            return Console.ReadLine().ToUpper();
        }

        static string VowelsRemove(string d)
        {
            string vowels = "AEIOUYÄÖ";
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (d[i] == vowels[j])
                    {
                        d = d.Remove(i, 1);
                        i--;
                        break;
                    }
                }
            }
            return d;
        }
    }
}
