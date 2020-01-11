using System;

namespace Taulukko_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductPrices();
        }

        public static void ProductPrices()
        {

            bool ValidInput;
            int UserInputInt;
            decimal UserInputDecimal;
            decimal[] ProductPrice = new decimal[3];
            decimal[] TotalPrice = new decimal[3];
            int[] ProductAmount = new int[3];

            for (int i = 0; i < ProductPrice.Length; i++)
            {
                Console.Write("Syötä tuotteen numero {0} hinta: ", i + 1);
                ValidInput = Decimal.TryParse(Console.ReadLine(), out UserInputDecimal);
                if (ValidInput)
                {
                    ProductPrice[i] = UserInputDecimal;
                }
                else
                {
                    while (!ValidInput)
                    {
                        Console.WriteLine("Et syöttänyt numeroa.");
                        Console.Write("Syötä tuotteen numero {0} hinta: ", i + 1);
                        ValidInput = Decimal.TryParse(Console.ReadLine(), out UserInputDecimal);
                    }
                }
            }

            for (int i = 0; i < ProductAmount.Length; i++)
            {
                Console.Write("Syötä kuinka monta kappaletta haluat tuotetta {0} : ", i + 1);
                ValidInput = Int32.TryParse(Console.ReadLine(), out UserInputInt);
                if (ValidInput)
                {
                    ProductAmount[i] = UserInputInt;
                }
                else
                {
                    while (!ValidInput)
                    {
                        Console.WriteLine("Et syöttänyt numeroa.");
                        Console.Write("Syötä kuinka monta kappaletta haluat tuotetta {0} : ", i + 1);
                        ValidInput = Int32.TryParse(Console.ReadLine(), out UserInputInt);
                    }
                }
            }

            for (int i = 0; i < TotalPrice.Length; i++)
            {
                TotalPrice[i] = ProductPrice[i] * ProductAmount[i];
                Console.WriteLine("Tuote {0}: {1}e.", i + 1, TotalPrice[i]);
            }
        }
    }
}
