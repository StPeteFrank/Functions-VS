using Functions_VS.Classes;
using System;
using System.Linq;

namespace Functions_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new LargestInArray().Largest(new int[] { 2, 4, 6, 8, 10 }));
           //Console.WriteLine(new LargestInArray().Largest(new int[] { 2, 4, 6 }));  

           Console.WriteLine(new SmallestInArray().Smallest(new int[] { 10, 4, 7, 9, 3, -8, 6 }));

           Console.WriteLine(new SumUsingForEach().SumForEach(new int[] { 10, 20, 30, 40 }));

           Console.WriteLine(new SumArrayForLoop().SumArray(new int[] { 20, 40, 60, 80 }));

           Console.WriteLine(new SumOddArrayForLoop().SumOddArray(new int[] { 2, 3, 6, 5, 4, 7 }));

          // Console.WriteLine(new FakeBinLoop().FakeBin(new string ("announcement")));

           Console.ReadLine();
        }


    }
}

