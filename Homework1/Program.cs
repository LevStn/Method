using Homework4;


int[,] a = TwoDimensionalArray.GenerateRandom(3,3);

TwoDimensionalArray.Write(a);

int [,] b = TwoDimensionalArray.ReflectionMainDiagonal(a);
TwoDimensionalArray.Write(b);
