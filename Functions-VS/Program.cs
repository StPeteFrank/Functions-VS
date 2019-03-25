using System;
using System.Linq;

namespace Functions_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestInArray(new int[] { 2, 4, 6 } ));

            Console.WriteLine(SmallestInArray(new int[] { 10, 4, 7, 9, 3, -8, 6 }));

            Console.WriteLine(SumForEach(new int[] { 10, 20, 30, 40 }));

            Console.WriteLine(SumArray(new int[] { 20, 40, 60, 80 }));

            Console.WriteLine(SumOddArray(new int[] { 2, 3, 6, 5, 4, 7 }));

            Console.ReadLine();
        }

        ///

        /*static int LargestInArray(int[] arr)
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
        }*/
      static int LargestInArray(int[] a)
        {
            int b = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if ( b < a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }

        // or //

        /* static int LargestInArray(int[] arr)
         {
             return arr.Max();
         }*/

        //

        /* static int SmallestInArray(int[] arr)
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
         }*/

        static int SmallestInArray(int[] a)
        {
            int b = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (b > a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }

        // or //

         /*   static int SmallestInArray(int[] arr)
        {
            return arr.Min();
        }*/

        //

       /* static int SumForEach(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum += num;
            }
            return sum;
        }*/

        static int SumForEach(int[] a)
        {
            int sum = 0;
            foreach(int b in a)
            {
                sum += b;
            }
            return sum;
        }

        //

       /* static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }*/

        static int SumArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        // or //

        //

       /* static int SumArray(int[] arr)
        {
            return arr.Sum();
        }*/

        //

        /*static int SumOddArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }*/
        static int SumOddArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ( a[i] % 2 == 1)
                {
                    sum += a[i];
                }
            }
            return sum;
        }

       

    }
}
