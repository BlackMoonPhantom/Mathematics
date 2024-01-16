using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {   public double Area(double height, double width)
        {
            return height * width;
        }
        public double Average(params double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }
        public double Squared(double value)
        {
            return value * value;
        }
        public double PythagoreanTheorem(double a, double b)
        {
            double cSquared = Squared(a) + Squared(b);
            return Math.Sqrt(cSquared);
        }

    }

}
