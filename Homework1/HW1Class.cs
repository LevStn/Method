

namespace Homework4
{
    public static class HW1Class
    {
        public static int [] GetResultDevisionWithRemaider(int a,  int b)
        {
            int [] result=new int[2];
            if (b == 0)
            {
                throw new Exception("variable b can’t == 0");
            }
            result[0] = a / b;
            result[1] = a % b;

            return result;
        }  


        public static int GetTheResultOfEquation(int a, int b)
        {
            if(b==a)
            {
                throw new Exception("a can’t == b");
            }

            int result = (5 * a + (b * b)) / (b - a);

            return result;
        }


        public static void SwapTheContentsOfTwoVariables(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
       
        public static double GetTheResultOfLinearEquation(double a, double b, double c) 
        {
            if(a==0)
            {
                throw new Exception("a can’t ==0");
            }

            double result = (c - b) / a;

            return result;
        }


        public static void GetTheSolutionOfTheLinearEquationStraightLineIn4Coordinates(double x1, double y1, double x2,double y2,
            out double pointA, out double pointB)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 can’t == x2");
            }

            pointA = (y1 - y2) / (x1 - x2);
            pointB = y2 - pointA * x2;
                    
        }
    }
}
