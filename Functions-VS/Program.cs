using Functions_VS.Classes;
using System;
using System.Linq;

namespace Functions_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 2, 4, 6, 8, 10, 1 }));

            Console.WriteLine(new SmallestInArray().Smallest(new int[] { 20, 10, 6, -9, 14, 0, 12 }));

            // Console.WriteLine(new SumUsingForEach().SumForEach(new int[] { 10, 20, 30, 40 }));
            Console.WriteLine(new SumUsingForEach().SumForEach(new int[] { 10, 20, 30, 40 }));

            Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 20, 40, 60, 80 }));

            Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 2, 3, 6, 5, 7 }));

            Console.WriteLine(new KataSquareSum().SquareSum(new int[] { 2, 4, 5 }));

           // Console.WriteLine(new KataRemoveString().Remove(new string ( "Hi!!!" )));

           // Console.WriteLine(new FakeBinLoop().FakeBin(new string("unnanswered")));

            //How is it possible to allow user to input ints and output the largest int in array? 

           Console.ReadLine();
        }


    }
}

