using System;
namespace array
{
    class sem
    {
        static void Main()
        {
            
            Console.WriteLine("Enter the number of elements in the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter value for a[{0}]:", i);
                a[i] = Convert.Toint32(Console.ReadLine());
            }
            Console.WriteLine("\nArray elements:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]: {1}", i, a[i]);
            }
        }
    }
}
