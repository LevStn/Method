

namespace Homework4
{
    public class HWArrayClass
    {


        public static int GetMinElementArray(int[] firstArray)
        {

            int minValue = firstArray[0];
            for (int i = 1; i < firstArray.Length; i++)
                if (firstArray[i] < minValue)
                {
                    minValue = firstArray[i];
                }

            return minValue;

        }

        public static int GetMaxElementArray(int[] firstArray)
        {
            int maxValue = firstArray[0];
            for (int i = 1; i < firstArray.Length; i++)
                if (firstArray[i] > maxValue)
                {
                    maxValue = firstArray[i];
                }
            return maxValue;
        }

        public static int GetIndexMinElementArray(int[] firstArray)
        {
            int indexMin = 0;
            int minValue = firstArray[0];
            for (int i = 1; i < firstArray.Length; i++)
            {
                if (firstArray[i] < minValue)
                {
                    minValue = firstArray[i];
                }
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == minValue)
                {
                    indexMin = i;
                }
            }
         return indexMin;
            
        }

        public static int GetIndexMaxElementArray(int[] firstArray)
        {
            int indexMax = 0;
            int maxValue = firstArray[0];
            for (int i = 1; i < firstArray.Length; i++)
            {
               
                if (firstArray[i] > maxValue)
                {
                    maxValue = firstArray[i];
                }
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == maxValue)
                {
                    indexMax = i;
                }
            }
            return indexMax;
        }

        public static int SumOfElementsArray(int[] firstArray)
        {
            int sum = 0;
            for (int i = 1; i < firstArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += firstArray[i];
                }
            }

            return sum;
        }

        public static int[] ReverseArray(int[] array)
        {
            int[] result = CopyArray(array);

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = result[i];
                result[i] = result[result.Length - (1 + i)];
                result[result.Length - (1 + i)] = tmp;
            }

            return result;
        }

        public static int NumberOfOddElements(int[] firstArray)
        {
            int sum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] % 2 != 0)
                {
                    sum++;
                }

            }
            return sum;
        }

        public static int[] ReverseHalfArray(int[] array)
        {
            int[] result = CopyArray(array);

            for (int i = 0; i < array.Length/2 ; i++)
            {
                if (array.Length % 2 != 0)
                {
                    int tmp = result[i];  
                    result[i] = result[result.Length / 2 + 1 + i];
                    result[result.Length / 2 + 1 + i] = tmp;
                }
                else
                {
                    int tmp = result[i];
                    result[i] = result[result.Length / 2  + i];
                    result[result.Length / 2  + i] = tmp;
                }
                
            }

            return result;
        }

        public static int[] SortArrayAscendingInsert(int[] array)
        {
           
            int tmp;
            for(int i = 0; i < array.Length; i++)
            {
               int index = i;
                tmp = array[i];
                while(index>0 && tmp<array[index-1])
                {
                    array[index]=array[index-1];
                    index--;
                }
                array[index] = tmp;
            }
            return array;
        }

        public static int[] SortArrayBubbleDescending(int [] array)
        {

            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j=0;j<array.Length -1; j++)
                {
                    if (array[j] < array[j+1])
                    {
                        tmp= array[j];
                        array[j]=array[j+1];
                        array[j+1]=tmp;
                    }
                }
            }

            return array;
        }

        public static int[] CopyArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }

        public static void WriteArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{ array[i]}   ");
            }
            Console.WriteLine();
        }

        public static int[] GenerateRandomArray(int lenght, int min = -100, int max = 100)
        {
            Random random = new Random();

            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }
            
    }









}     
