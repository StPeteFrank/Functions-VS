using Functions_VS.Classes;
using System;

namespace Functions_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestInArray(new int[] { 2, 4, 6 } ));

            Console.WriteLine(SmallestInArray(new int[] { 10, 4, 7, 9, 3, -8, 6 }));

            Console.ReadLine();
        }

        ///

        static int LargestInArray(int[] arr)
        {
            int element = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (element < arr[i])
                {
                    element = arr[i];
                }
            }
            return element;
        }

        ///

        static int SmallestInArray(int[] arr)
        {
            int element = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (element > arr[i])
                {
                    element = arr[i];
                }
            }
            return element;
        }




    }
}
