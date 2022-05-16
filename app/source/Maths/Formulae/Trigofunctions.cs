using EMC
    = Karamath.Maths.Constants;
using ENU
    = Karamath.Algorithms.Enumerables;

namespace Karamath.Maths {

    /// <summary>
    ///     Library module responsible for advanced trigonometry and its calculations
    /// </summary>
    ///
    public static class Trigofunctions {

        /// <summary>
        ///     Calculates a cosecant of an angle
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this trigonometric function: go to the 
        ///     <see href="https://mathworld.wolfram.com/Cosecant.html">
        ///         its origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="radians">
        ///     A double value representing an angle with no repetitions on trigonometric circle
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing result of cosecant of given angle
        /// </returns>
        /// 
        public static double Cosecant(double radians) {

            if(radians == 0)
                return double.NaN;
            /*
             *  Approximate comparison of two numbers by bits for higher accuracy, 
             *  because values approaching PI break the function.
             */
             
            else if (ENU.Approximate(radians, EMC.PI, 10))
                return double.NaN;
            else
                return (1 / Math.Sin(radians));
        }

        /// <summary>
        ///     Calculates a secant of an angle
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this trigonometric function: go to the 
        ///     <see href="https://mathworld.wolfram.com/Secant.html">
        ///         its origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="radians">
        ///     A double value representing an angle with no repetitions on trigonometric circle
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing result of secant of given angle
        /// </returns>
        /// 
        public static double Secant(double radians) {

            if(ENU.Approximate(radians, EMC.PI / 2, 10))
                return double.NaN;
            else
                return (1 / Math.Cos(radians));
        }

        /// <summary>
        ///     Calculates a cotangent of an angle
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this trigonometric function: go to the 
        ///     <see href="https://mathworld.wolfram.com/Cotangent.html">
        ///         its origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="radians">
        ///     A double value representing an angle with no repetitions on trigonometric circle
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing result of cotangent of given angle
        /// </returns>
        /// 
        public static double Cotangent(double radians) {

            if(radians == 0)
                return double.NaN;
            /*
             *  Approximate comparison of two numbers by bits for higher accuracy, 
             *  because values approaching PI break the function.
             */

            else if(ENU.Approximate(radians, EMC.PI, 10))
                return double.NaN;
            else
                return (1 / Math.Tan(radians));
        }

        /// <summary>
        ///     Calculates a chord of an angle
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this trigonometric function: go to the 
        ///     <see href="https://mathworld.wolfram.com/Chord.html">
        ///         its origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="radians">
        ///     A double value representing an angle with no repetitions on trigonometric circle
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing result of chord of given angle
        /// </returns>
        ///
        public static double Chord(double radians) {

            double res = 2 * Math.Sin(radians / 2);

            return res;
        }

        /// <summary>
        ///     Calculates a versine of an angle
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this trigonometric function: go to the 
        ///     <see href="https://mathworld.wolfram.com/Versine.html">
        ///         its origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="radians">
        ///     A double value representing an angle with no repetitions on trigonometric circle
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing result of versine of given angle
        /// </returns>
        ///
        public static double Versine(double radians) {

            double res = 2 * (Math.Pow(Math.Sin(radians / 2), 2));

            return res;
        }

        /// <summary>
        ///     Calculates a exsecant of an angle
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this trigonometric function: go to the 
        ///     <see href="https://mathworld.wolfram.com/Exsecant.html">
        ///         its origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="radians">
        ///     A double value representing an angle with no repetitions on trigonometric circle
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing result of exsecant of given angle
        /// </returns>
        ///
        public static double Exsecant(double radians) {

            double res = (1 / Math.Sin(radians)) - 1;

            return res;
        }
    }
}