using System;
namespace array
{
    class Sem
    {
        static void Main()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[s, f];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < f; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array elements:");
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < f; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
