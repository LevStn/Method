using Homework4;


int[,] a = TwoDimensionalArray.GenerateRandom(4,4);

TwoDimensionalArray.Write(a);

Console.WriteLine(   TwoDimensionalArray.ElementThatIsLargerThanAllItsNeighbors(a));