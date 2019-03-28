using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_VS.Classes
{
    public class SumOddArrayForLoop
    {
       /*public int SumOddArray(int[] arr)
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

        public int SumOddArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }

    }
}
