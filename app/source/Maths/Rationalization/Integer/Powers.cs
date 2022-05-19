namespace Karamath.Ratio.Integer {

    /// <summary>
    /// Library module responsible for rationalization of power function expressions in integers
    /// </summary>
    public static class Powers {

        /// <summary>
        /// Calculates a rationalization of the difference of power function with the same base
        /// </summary>
        /// <param name="hmx">
        /// A double value representing a base of power functions
        /// </param>
        /// <param name="fmx">
        /// A double value representing a degree of first power function
        /// </param>
        /// <param name="gmx">
        /// A double value representing a degree of second power function
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result
        /// </returns>
        public static double RDPFSB(double hmx, double fmx, double gmx) {
            
            double res = 0;

            /*
             *  From the definition of a power function, its base must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return double.NaN;
            else
                res = (hmx - 1) * (fmx - gmx);

            return res;
        }

        /// <summary>
        /// Calculates a rationalization of the difference between a power function and unity
        /// </summary>
        /// <param name="hmx">
        /// A double value representing a base of power functions
        /// </param>
        /// <param name="fmx">
        /// A double value representing a degree of power function
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result
        /// </returns>
        public static double RDBPFU(double hmx, double fmx) {

            double res = 0;

            /*
             *  From the definition of a power function, its base must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return double.NaN;
            else 
                res = (hmx - 1) * fmx;

            return res;
        }

        /// <summary>
        /// Calculates a rationalization of the difference of power functions with the same degree
        /// </summary>
        /// <param name="hmx">
        /// A double value representing a degrees of power functions
        /// </param>
        /// <param name="fmx">
        /// A double value representing a base of first power function
        /// </param>
        /// <param name="gmx">
        /// A double value representing a base of second power function
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result
        /// </returns>
        public static double RDPFSD(double hmx, double fmx, double gmx) {

            double res = 0;

            /*
             *  From the definition of a power function, its base must 
             *  be strictly greater than zero.
             */

            if(fmx <= 0)
                return double.NaN;
            else if(gmx <= 0)
                return double.NaN;
            else 
                res = (fmx - gmx) * hmx;

            return res;
        }
    }
}