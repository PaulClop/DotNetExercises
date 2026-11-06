using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow
{
    public class Power
    {
        public static double ToThePowerOf(int a, int b)
        {
            double result = 1;
            double op = a;

            if (b == 0)
            {
                return 1;
            }

            if (b < 0)
            {
                op = (double)1 / a;
                b = -b;
            }

            while (b > 0)
            {
                result *= op;
                --b;
            }

            return result;
        }

        public static double ToThePowerOfV2(double a, int b)
        {
            if (b < 0) return ToThePowerOfV2(1 / a, -b);
            if (b == 0) return 1;
            if (b == 1) return a;

            return a * ToThePowerOfV2(a, --b);
         }
    }
}
