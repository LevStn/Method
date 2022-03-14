using Homework4;



//int[,] a = TwoDimensionalArray.GenerateRandom(3,3);

//TwoDimensionalArray.Write(a);

//int [,] b = TwoDimensionalArray.ReflectionMainDiagonal(a);
//TwoDimensionalArray.Write(b);

double x1 = 0;
double y1 = 0;
double x2 = 5;
double y2 = 0;
 double pointA;
double pointB;


HW1Class.GetTheSolutionOfTheLinearEquationStraightLineIn4Coordinates(x1, y1, x2, y2,
             out pointA,  out pointB);
    ;
Console.WriteLine(pointB);