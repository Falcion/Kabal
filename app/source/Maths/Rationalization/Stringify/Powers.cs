namespace Karamath.Ratio.Stringify {

    /// <summary>
    ///     Library module responsible for rationalization of power function expressions in strings
    /// </summary>
    ///
    public static class Powers {

        /// <summary>
        ///     Formalizes a rationalization of the difference of power function with the same base
        /// </summary>
        /// 
        /// <param name="hmx">
        ///     A double value representing a base of power functions
        /// </param>
        /// <param name="fmx">
        ///     A double value representing a degree of first power function
        /// </param>
        /// <param name="gmx">
        ///     A double value representing a degree of second power function
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        /// 
        public static string[] RDPFSB(double hmx, double fmx, double gmx) {
            
            string[] res;

            /*
             *  From the definition of a power function, its base must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return new string[] { "NaN" };
            else
                res = new string[] {
                    $"({hmx} - 1)({fmx} - {gmx})",
                    $"({hmx - 1} * {fmx  - gmx})"
                };

            return res;
        }

        /// <summary>
        ///     Formalizes a rationalization of the difference between a power function and unity
        /// </summary>
        /// 
        /// <param name="hmx">
        ///     A double value representing a base of power functions
        /// </param>
        /// <param name="fmx">
        ///     A double value representing a degree of power function
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        /// 
        public static string[] RDBPFU(double hmx, double fmx) {

            string[] res;

            /*
             *  From the definition of a power function, its base must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return new string[] { "NaN" };
            else 
                res = new string[] {
                    $"({hmx} - 1) * {fmx}",
                    $"({hmx - 1} * {fmx})"
                };

            return res;
        }

        /// <summary>
        ///     Formalizes a rationalization of the difference of power functions with the same degree
        /// </summary>
        /// 
        /// <param name="hmx">
        ///     A double value representing a degrees of power functions
        /// </param>
        /// <param name="fmx">
        ///     A double value representing a base of first power function
        /// </param>
        /// <param name="gmx">
        ///     A double value representing a base of second power function
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        /// 
        public static string[] RDPFSD(double hmx, double fmx, double gmx) {

            string[] res;

            /*
             *  From the definition of a power function, its base must 
             *  be strictly greater than zero.
             */

            if(fmx <= 0)
                return new string[] { "NaN" };
            else if(gmx <= 0)
                return new string[] { "NaN" };
            else 
                res = new string[] {
                    $"({fmx} - {gmx}) * {hmx}",
                    $"({fmx - gmx} * {hmx})"
                };

            return res;
        }
    }
}