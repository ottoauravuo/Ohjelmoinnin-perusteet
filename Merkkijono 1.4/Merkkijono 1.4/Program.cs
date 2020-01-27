using System;

namespace Merkkijono_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana tai lause: ");
            string text = Console.ReadLine().ToUpper().Replace(" ", "");

            bool isPalindrome = true;
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Sana {0} on palintromi", text);
            }
            else
                Console.WriteLine("Sana {0} ei ole palintromi.", text);
        }
    }
}
