namespace Karamath.Ratio.Stringify {

    /// <summary>
    ///     Library module responsible for rationalization of logariphmics expressions in strings
    /// </summary>
    /// 
    public static class Logariphms {

        /// <summary>
        ///     Formalizes a rationalization of the difference of two logarithms with the same bases
        /// </summary>
        ///     
        /// <param name="hmx">
        ///     A double value representing a base of logariphms
        /// </param>
        /// <param name="fmx">
        ///     A double value representing a number of first logariphm
        /// </param>
        /// <param name="gmx">
        ///     A double value representing a number of second logariphm
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        ///
        public static string[] RDTLSB(double hmx, double fmx, double gmx) {
            
            string[] res;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return new string[] { "NaN" };
            else if(fmx <= 0)
                return new string[] { "NaN" };
            else if(gmx <= 0)
                return new string[] { "NaN" };
            else
                res = new string[] {
                    $"({hmx} - 1)({fmx} - {gmx})",
                    $"({hmx - 1} * {fmx - gmx})",
                };

            return res;
        }

        /// <summary>
        ///     Formalizes a rationalization of the difference between the logarithm and the unit
        /// </summary>
        ///     
        /// <param name="hmx">
        ///     A double value representing a base of logariphm
        /// </param>
        ///  <param name="fmx">
        ///     A double value representing a number of logariphm
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        ///
        public static string[] RDBLAU(double hmx, double fmx) {

            string[] res;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return new string[] { "NaN" };
            else if(fmx <= 0)
                return new string[] { "NaN" };
            else
                res = new string[] {
                    $"({hmx} - 1)({fmx} - {hmx})",
                    $"({hmx - 1} * {fmx - hmx})"
                };

            return res;
        }

        /// <summary>
        ///     Formalizes a rationalization of a single logariphm
        /// </summary>
        ///     
        /// <param name="hmx">
        ///     A double value representing a base of logariphm
        /// </param>
        ///  <param name="fmx">
        ///     A double value representing a number of logariphm
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        ///
        public static string[] RSL(double hmx, double fmx) {

            string[] res;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return new string[] { "NaN" };
            else if(fmx <= 0)
                return new string[] { "NaN" };
            else
                res = new string[] {
                    $"({hmx} - 1)({fmx} - 1)",
                    $"({hmx - 1} * {fmx - 1})"
                };

            return res;
        }

        /// <summary>
        ///     Formalizes a rationalization of the difference of two logarithms with the same numbers
        /// </summary>
        /// 
        /// <param name="hmx">
        ///     A double value representing a numbers of logariphms
        /// </param>
        ///  <param name="fmx">
        ///     A double value representing a base of first logariphm
        /// </param>
        ///  <param name="gmx">
        ///     A double value representing a base of second logariphm
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a rationalization's result step-by-step
        /// </returns>
        ///
        public static string[] RDTLSN(double hmx, double fmx, double gmx) {

            string[] res;

            /*
             *  From the definition of a logarithm, its base and number must 
             *  be strictly greater than zero.
             */

            if(hmx <= 0)
                return new string[] { "NaN" };
            else if(fmx <= 0)
                return new string[] { "NaN" };
            else if(gmx <= 0)
                return new string[] { "NaN" };
            else
                res = new string[] {
                    $"({fmx} - 1)({gmx} - 1)({hmx} - 1)({gmx} - {fmx})",
                    $"({fmx - 1})({gmx - 1})({hmx - 1})({gmx - fmx})",
                    $"({fmx - 1} * {gmx - 1})({hmx - 1} * {gmx - fmx})",
                    $"({fmx - 1 * gmx - 1} * {hmx - 1 * gmx - fmx})",
                };

            return res;
        }
    }
}