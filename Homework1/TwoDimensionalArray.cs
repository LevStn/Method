namespace Homework4
{
    public class TwoDimensionalArray
    {
        public static int GetMinElement(int[,] array)
        {
            if(array.GetLength(0) < 1|| array.GetLength(1) < 1)
            {
                throw new Exception("array can`==null");
            }

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
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("array can`==null");
            }

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
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("array can`==null");
            }

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
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("array can`==null");
            }

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

        public static int FindElementThatIsLargerThanAllItsNeighbors(int[,] array)
        {
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("array can`==null");
            }

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
            int [,] result=new int[ array.GetLength(0), array.GetLength(1)];


            for(int i=0;i< array.GetLength(0); i++)
            {
                for(int j=0;j< array.GetLength(1); j++)
                {
                    if(i !=j)
                    {
                        result[i,j] = array[j,i];
                    }
                    else
                    {
                        result[i, j] = array[i, j];
                    }
                }
                
            }

            return result;
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