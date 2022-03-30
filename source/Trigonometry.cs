using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFX
{
    public static class Trigonometry
    {
        public static double Cosec(double rad)
        {
            return 1 / Math.Sin(rad);
        }

        public static double Sec(double rad)
        {
            return 1 / Math.Cos(rad);
        }
    }
}
