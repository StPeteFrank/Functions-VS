using Functions_VS.Classes;
using System;
using System.Linq;

namespace Functions_VS
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(new LargestInArray().Largest(new int[] { 2, 4, 6 } ));  

           Console.WriteLine(new SmallestInArray().Smallest(new int[] { 10, 4, 7, 9, 3, -8, 6 }));

            Console.WriteLine(new SumUsingForEach().SumForEach(new int[] { 10, 20, 30, 40 }));

           Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 20, 40, 60, 80 }));

           //  Console.WriteLine(SumOddArray(new int[] { 2, 3, 6, 5, 4, 7 }));

            //Console.WriteLine(FakeBin("announcement"));

            Console.ReadLine();
        }

        //

       

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
                if (a[i] % 2 == 1)
                {
                    sum += a[i];
                }
            }
            return sum;
        }

        //PEDA
        //I should run my parameter by each letter to verifier the value of them
        //if n is less than 5 the output is 0
        //if n is major or equals than 5 the output is 1

        /* static string FakeBin(string x)
         {
             var total = x.Length;
             var y = "";
             for (int i = 0; i < total; i++)
             {
                 if (x[i] < '5')
                 {
                     y += '0';
                     Console.WriteLine("I am less than 5");
                     return y;

                 }
                 else
                 {
                     y += '1';
                     Console.WriteLine("I am major than 5");
                    return y;
                 }
                  // Console.WriteLine(x[i]);
             }
                     return y;
         }*/

        // or //

        /*public static string FakeBin(string x)
        {
            var y = "";

            for (var i = 0; i < x.Length; i++)
            {
                if (Char.GetNumericValue(x[i]) < 5)
                {
                    y += '0';
                    return y;
                }
                else
                {
                    y += '1';
                    return y;
                }
            }

            return y;
        }*/


    }
}

