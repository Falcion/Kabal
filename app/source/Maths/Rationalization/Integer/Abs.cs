namespace Karamath.Ratio.Integer {

    public static class Abs {

        /// <summary>
        ///     Calculates a rationalization of difference between two abs
        /// </summary>
        /// 
        /// <param name="fmx">
        ///     A double value representing a number of first abs
        /// </param>
        /// <param name="gmx">
        ///     A double value representing a number of second abs
        /// </param>
        /// 
        /// <returns>
        ///     A double value representing a rationalization's result
        /// </returns>
        /// 
        public static double RDBTM(double fmx, double gmx) {

            double res = 0;

            res = (fmx - gmx) * (fmx + gmx);

            return res;
        }
    }
}