namespace Karamath.Ratio.Integer {

    /// <summary>
    /// Library module responsible for rationalization of logariphmics expressions in integers
    /// </summary>
    public static class Logariphms {

        /// <summary>
        /// Calculates a rationalization of the difference of two logarithms with the same bases
        /// </summary> 
        /// <param name="hmx">
        /// A double value representing a base of logariphms
        /// </param>
        /// <param name="fmx">
        /// A double value representing a number of first logariphm
        /// </param>
        /// <param name="gmx">
        /// A double value representing a number of second logariphm
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result
        /// </returns>
        public static double RDTLSB(double hmx, double fmx, double gmx) {
            
            double res = 0;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return double.NaN;
            else if(fmx <= 0)
                return double.NaN;
            else if(gmx <= 0)
                return double.NaN;
            else
                res = (hmx - 1) * (fmx - gmx);

            return res;
        }

        /// <summary>
        /// Calculates a rationalization of the difference between the logarithm and the unit
        /// </summary>  
        /// <param name="hmx">
        /// A double value representing a base of logariphm
        /// </param>
        /// <param name="fmx">
        /// A double value representing a number of logariphm
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result
        /// </returns>
        public static double RDBLAU(double hmx, double fmx) {

            double res = 0;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return double.NaN;
            else if(fmx <= 0)
                return double.NaN;
            else
                res = (hmx - 1) * (fmx - hmx);

            return res;
        }

        /// <summary>
        /// Calculates a rationalization of a single logariphm
        /// </summary>  
        /// <param name="hmx">
        /// A double value representing a base of logariphm
        /// </param>
        /// <param name="fmx">
        /// A double value representing a number of logariphm
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result
        /// </returns>
        public static double RSL(double hmx, double fmx) {

            double res = 0;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return double.NaN;
            else if(fmx <= 0)
                return double.NaN;
            else
                res = (hmx - 1) * (fmx - 1);

            return res;
        }

        /// <summary>
        /// Calculates a rationalization of the difference of two logarithms with the same numbers
        /// </summary>
        /// <param name="hmx">
        /// A double value representing a numbers of logariphms
        /// </param>
        /// <param name="fmx">
        /// A double value representing a base of first logariphm
        /// </param>
        /// <param name="gmx">
        /// A double value representing a base of second logariphm
        /// </param>
        /// <returns>
        /// A double value representing a rationalization's result step-by-step
        /// </returns>
        public static double RDTLSN(double hmx, double fmx, double gmx) {

            double res = 0;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return double.NaN;
            else if(fmx <= 0)
                return double.NaN;
            else if(gmx <= 0)
                return double.NaN;
            else
                res = (fmx - 1) * (gmx - 1) * (hmx - 1) * (gmx - fmx);

            return res;
        }
    }
}