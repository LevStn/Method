namespace Homework4
{
    internal class TwoDimensionalArray
    {
        public static int GetMinElement(int[,] array)
        {
            int minValue = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                    }
            }
            return minValue;
        }
        public static int GetMaxElement(int[,] array)
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

        public static int[] GetMinIndex(int[,] array)
        {
            int[] tmp = new int[2];
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
        public static int[] GetMaxIndex(int[,] array)
        {
            int[] tmp = new int[2];


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

        public static int ElementThatIsLargerThanAllItsNeighbors(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if ((i == 0 || array[i, j] > array[i - 1, j])
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                        )
                    {
                        count++;
                    }
                }

            }
          return count;
        }


        public static int [,] ReflectionMainDiagonal(int [,] array)

        {
            int [,] swap=new int[ array.GetLength(0), array.GetLength(1)];


            for(int i=0;i< array.GetLength(0); i++)
            {
                for(int j=0;j< array.GetLength(1); j++)
                {
                    if(i !=j)
                    {
                        swap[i,j] = array[j,i];
                    }
                    else
                    {
                        swap[i, j] = array[i, j];
                    }
                }
                
            }

            return swap;
        }








            public static void Write(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                    int freeeSpace=4- array[i, j].ToString().Length;
                    
                        for(int k = 0; k < freeeSpace; k++)
                        {
                        Console.Write(" ");
                        }
                    
                        Console.Write($"{ array[i, j]}  ");
                    }
                Console.WriteLine();
                }
            }

            public static int[,] GenerateRandom(int lenghtX, int lenghtY, int min = -100, int max = 100)
            {
                int[,] array = new int[lenghtX, lenghtY];
                Random random = new Random();

                for (int i = 0; i < lenghtX; i++)
                {
                    for (int j = 0; j < lenghtY; j++)
                    {
                        array[i, j] = random.Next(min, max + 1);

                    }
                }
                return array;
            }
        
    }

}