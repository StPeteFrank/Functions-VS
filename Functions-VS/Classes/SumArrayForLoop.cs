using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_VS
{
    public class SumArrayForLoop
    {
       public int SumArray(int[] a)
        {
            int sum = 0;
            for ( int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }

        // or //

        /* static int SumArray(int[] arr)
         {
             return arr.Sum();
         }*/
    }
}
