using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkCSCTaks2.Extention
{
    static class ExtentionMethods
    {
        //Task 1
       public static bool IsEven(this int a)
        {
            if (a%2== 0)
            {
                return true;
            }
            return false;
        }

        //Task 2
        public static int[] methodGetValueIndexes(this int[] arr, int b)
        {
            int[] arrb = { };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == b)
                {
                    Array.Resize(ref arrb, arrb.Length + 1);
                    arrb[arrb.Length - 1] = i;
                }
            }

            return arrb;


        }



    }
}
