using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class HW2Class
    {
        public static double CompareTwoValuesAndPerformAMathematicalCharacteristicDependingOnTheComparison (double a, double b  )
        {
            double result;
          if (a>b)
          {
            result = a + b;
          }

          else if (a ==b)
          {
                 result = a * b;
          } 
          else 
          {
                 result = a - b;
          }

          return result;  
            
        }
    }
}
