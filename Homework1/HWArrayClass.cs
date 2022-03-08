using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class HWArrayClass
    {
       public static void WriteArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

        }

        public static int[] GenerateArray(int lenght)
        {
            Random r = new Random();

            int[] a = new int[lenght];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(100);
            }
            return a;
        }


        public static int GetMinElementArray()
        {
            int [] firstArray=GenerateArray(10);
            WriteArray(firstArray);
            int minValue=firstArray[0];
            for (int i=1; i < firstArray.Length; i++)
                if(firstArray[i]<minValue)
                {
                    minValue=firstArray[i];
                }

            return minValue;

        }
    }
}
