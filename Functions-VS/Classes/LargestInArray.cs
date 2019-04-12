using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions_VS.Classes
{
    public class LargestInArray
    {
        public int Largest(int[] a)
        {
            int b = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (b < a[i])
                {
                    b = a[i];
                }
            }
            return b;
        }
    }


        // or //

        /* public int Largest(int[] arr)
         {
             return arr.Max();
         }*/

        //

    }


