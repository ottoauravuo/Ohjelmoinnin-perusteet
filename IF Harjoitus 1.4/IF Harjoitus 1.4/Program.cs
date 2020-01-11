using System;

namespace IF_Harjoitus_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int[] a = new int[30];
            Console.WriteLine("Kuinka monta lukua haluat syöttää? ");
            int n = Convert.ToInt16(Console.ReadLine());
            for (luku = 1; luku <= n; luku++)

            {
                Console.Write("Syötä luku " + luku + ":");
                a[luku] = Convert.ToInt16(Console.ReadLine());
            }
            for (luku = 1; luku <= n; luku++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.Write("Pienimmästä suurimpaan : ");
            for (luku = 1; luku <= n; luku++)
            {
                Console.Write(a[luku] + " ");
            }
        }
    }
}
