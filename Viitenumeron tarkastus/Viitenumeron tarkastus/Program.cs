using System;
using System.Collections.Generic;
using System.Text;

namespace Viitenumeron_tarkastus
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            int setting;
            do
            {
                setting = int.Parse(Console.ReadLine());
                switch (setting)
                {
                    case 1:
                        RefNumCheck();
                        break;
                    case 2:
                        RefNumCreate();
                        break;
                    case 3:
                        RefNumCreateMany();
                        break;
                    default:
                        Console.Write("Virheellinen syöte! Valitse 1, 2 tai 3:");
                        break;
                }
            } while (setting != 1 || setting != 2 || setting != 3);

        }
        static void Intro()
        {
            Console.WriteLine("1. Ohjelma tarkistaa kotimaisen viitenumeron \n" +
                "2. Ohjelma luo kotimaisen viitenumeron \n" + "3. Ohjelma luo halutun määrän viitenumeroita tallentaen ne teksitiedostoon");
            Console.Write("Syötä ohjelman numero 1, 2 tai 3, jonka haluat ajaa ja paina enter:");
        }

        static void RefNumCheck()
        {
            string refNum = InputNum();
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNum.Length];
            for (int i = 0; i < refNum.Length; i++)
            {
                refArr[i] = int.Parse(refNum[i].ToString());
            }
            for (int i = 0; i < refArr.Length - 1; i++)
            {
                sum += refArr[refArr.Length - 2 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine("Syöte: {0}", refNum);
            if (refArr[refArr.Length - 1] == checkNum)
            {
                Console.WriteLine("Viitenumero on oikein.");
            }
            else
            {
                Console.WriteLine("Viitenumero on väärin.");
            }
        }

        static string InputNum()
        {
            string input = "";
            int inputNum = 0;
            do
            {
                Console.Write("Syötä viitenumero, jossa on vain numeroita ja on 4-20 merkkiä pitkä:");
                input = Console.ReadLine();
            }
            while (input.Length <= 3 || input.Length >= 21 || !Int32.TryParse(input, out inputNum) || inputNum < 0);
            return input;
        }

        static void RefNumCreate()
        {

            string refNumInput;
            do
            {
                Console.Write("Syötä viitenumeron alkuosa, joka on 3-19 merkkiä pitkä:");
                refNumInput = Console.ReadLine();
            }
            while (refNumInput.Length <= 2 || refNumInput.Length >= 20);
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNumInput.Length];
            for (int i = 0; i < refNumInput.Length; i++)
            {
                refArr[i] = int.Parse(refNumInput[i].ToString());
            }
            for (int i = 0; i < refArr.Length; i++)
            {
                sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine("Syöte: {0}", refNumInput);
            string refNumOutput = refNumInput + checkNum;
            for (int i = 1; i < refNumOutput.Length; i++)
            {
                if (i % 5 == 0)
                {
                    refNumOutput = refNumOutput.Insert(i, " ");
                }
            }
            Console.WriteLine("Uusi viitenumero: {0}", refNumOutput);
        }

        static void RefNumCreateMany()
        {
            string userInput;
            int numberOfReferences;
            int lengthOfRefNumber = 19;
            int basepart;
            bool continueRunning = true;
            bool validInput1;
            bool validInput2;
            List<String> referenceNumber = new List<String>();
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();


            Console.Write("Syötä viitenumeron alkuosa, joka on 3-19 merkkiä pitkä:");
            userInput = Console.ReadLine();
            validInput1 = Int32.TryParse(userInput, out basepart);

            while (!validInput1)
            {
                Console.WriteLine("Syöttämäsi alkuosa ei kelpaa.");
                Console.Write("Syötä viitenumeron alkuosa, joka on 3-19 merkkiä pitkä:");
                userInput = Console.ReadLine();
                validInput1 = Int32.TryParse(userInput, out basepart);
            }

            lengthOfRefNumber = lengthOfRefNumber - userInput.Length;

            Console.Write("Syötä kuinka monta viitenumeroa haluat luoda:");
            userInput = Console.ReadLine();
            validInput2 = Int32.TryParse(userInput, out numberOfReferences);

            while (continueRunning)
            {
                if (validInput2)
                {
                    for (int i = 0; i < numberOfReferences; i++)
                    {

                        stringBuilder.Append(basepart.ToString() + "-");

                        for (int j = 0; j < lengthOfRefNumber; j++)
                        {
                            stringBuilder.Append(random.Next(0, 10).ToString());
                        }

                        foreach (String storedString in referenceNumber)
                        {
                            if (storedString.Equals(stringBuilder.ToString()))
                            {

                                Console.WriteLine("Jo olemassa oleva viitenumero.");

                                stringBuilder.Clear();
                                stringBuilder.Append(basepart.ToString() + "-");

                                for (int j = 0; j < lengthOfRefNumber; j++)
                                {
                                    stringBuilder.Append(random.Next(0, 10).ToString());
                                }

                            }
                        }

                        referenceNumber.Add(stringBuilder.ToString());
                        stringBuilder.Clear();

                    }

                    continueRunning = false;

                }
                else while (!validInput2)
                    {
                        Console.WriteLine("Syöttämäsi merkki ei kelpaa!");
                        Console.Write("Syötä kuinka monta viitenumeroa haluat luoda:");
                        userInput = Console.ReadLine();
                        validInput2 = Int32.TryParse(userInput, out numberOfReferences);
                    }

            }

            foreach (String outputString in referenceNumber)
            {

                Console.WriteLine(outputString);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Otto\Desktop\referencenumber.txt", true))
                {
                    file.WriteLine(outputString);
                }
            }
        }
    }
}
