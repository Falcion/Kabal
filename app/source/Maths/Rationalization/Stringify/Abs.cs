namespace Karamath.Ratio.Stringify {

    /// <summary>
    ///     Library module responsible for rationalization of abs expressions in strings
    /// </summary>
    /// 
    public static class Abs {

        /// <summary>
        ///     Formalizes a rationalization of difference between two abs
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
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        /// 
        public static string[] RDBTM(double fmx, double gmx) {

            string[] res;

            res = new string[] {
                $"({fmx} - {gmx})({fmx} + {gmx})",
                $"({fmx - gmx} * {fmx + gmx})"
            };

            return res;
        }
    }
}