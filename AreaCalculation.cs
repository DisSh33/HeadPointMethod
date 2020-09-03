using System;
using System.Collections.Generic;
using System.Text;

namespace HeadPointMethod
{
    public class AreaCalculation
    {

        public double Area(double a, double b, double c)
        {
            var input = new List<double>();
            if (a > 0 && b > 0 && c > 0)
            {
                input.Add(a);
                input.Add(b);
                input.Add(c);
            }
            else
            {
                return 0;
            }

            input.Sort();

            if (input[2] == Math.Sqrt(Math.Pow(input[0], 2) + Math.Pow(input[1], 2)))
            {
                return (input[0] * input[1]) / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
