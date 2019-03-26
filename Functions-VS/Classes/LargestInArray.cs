using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions_VS.Classes
{
    public class LargestInArray
    {

        // Method
        public int Largest(int[] arr)

        {
            int element = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
               if ( element < arr[i])
                {
                    element = arr[i];
               }
            }
               return element;
        }


        // or //

       /* public int Largest(int[] arr)
        {
            return arr.Max();
        }*/

        //

        


    }
}

