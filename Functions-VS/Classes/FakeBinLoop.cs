using System;
using System.Collections.Generic;
using System.Text;

namespace Functions_VS
{
    public class FakeBinLoop
    {
        // This function is incomplete.
        //PEDAC
        //I should run my parameter by each letter to verifier the value of them
        //if n is less than 5 the output is 0
        //if n is major or equals than 5 the output is 1

         /*public string FakeBin(string x)
         {
             var y = "";
             for (var i = 0; i < x.Length; i++)
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
