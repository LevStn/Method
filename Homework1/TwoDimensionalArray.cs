using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class TwoDimensionalArray
    {
        public static int GetMinElement(int [,] array)
        {
            int minValue= array[0,0];
            for(int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1); j++)
                    if(array[i,j] < minValue)
                    {
                        minValue = array[i,j];
                    }
            }    
            return minValue;
        }
        public static int GetMaxElement(int[,] array )
        {
            int maxValue = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                    }
            }
            return maxValue;
        }

        public static int[] GetMinIndex(int[,] array )
        {
            int [] tmp = new int[2];
            int minIndex = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minIndex)
                    {
                        minIndex = array[i, j];

                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == minIndex)
                    {

                        tmp[0] = j;
                        tmp[1] = i;
                    }
                }
            }
            return tmp;
        }
        public static int [] GetMaxIndex(int[,] array)
            {
                int [] tmp=new int[2];

            
                int maxIndex = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > maxIndex)
                        {
                            maxIndex = array[i, j];

                        }
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == maxIndex)
                        {

                            tmp[0] = j;
                            tmp[1] = i;
                        }
                    }
                }
              return tmp;
            }














        public static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0; j < array.GetLength(1); j++)
                Console.Write($"{ array[i,j]}  ");
            Console.WriteLine();
            }
        }

        public static int[,] GenerateRandomArray(int lenght1, int lenght2, int min = -100, int max = 100)
        {
            Random random = new Random();

            int[,] array = new int[lenght1, lenght2];
            for (int i = 0; i < lenght1; i++)
            {
                for(int j = 0; j < lenght2; j++)
                array[i,j] = random.Next(min, max + 1);
            }
            return array;
        }
    }
}
