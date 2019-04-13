using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_VS.Classes
{
    /*public class KataSquareSum
    {
        public int SquareSum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += (n[i] * n[i]);
            }
            return sum;
        }
    }*/
    public class KataSquareSum
    {
        public int SquareSum(int [] n)
        {
            int sum = 0;
            for(int i = 0; i < n.Length; i++)
            {
                sum += (n[i] * n[i]);
            }
            return sum;
        }
    }


}
