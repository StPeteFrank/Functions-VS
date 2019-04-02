using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_VS.Classes
{
    public class SumOddArrayForLoop
    {
        public int SumOddArray(int[] a)
        {
            int sum = 0;
            for (int i =0; i < a.Length; i++)
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
