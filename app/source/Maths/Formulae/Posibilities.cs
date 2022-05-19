using FCT
    = Karamath.Maths.Factofunctions;
using EMC
    = Karamath.Maths.Constants;

namespace Karamath.Maths {

    /// <summary>
    /// Library module responsible for simple calcs of posibilities algebra
    /// </summary>
    public static class Posibilities {

        /// <summary>
        /// Calcs a count of permutations
        /// </summary>
        /// <param name="nmx">
        /// An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <returns>
        /// A 32-bit signed integer value representing a count of permutations
        /// </returns>
        public static uint Permutations(uint nmx) {

            uint res = FCT.Fct(nmx);

            return res;
        }

        /// <summary>
        /// Calcs a count of placements
        /// </summary>
        /// <param name="nmx">
        /// An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        /// An unsigned 32-bit integer value representing the number of exact objects
        /// </param>
        /// <returns>
        /// A 32-bit signed integer value representing a count of placements
        /// </returns>
        public static uint Placements(uint nmx, uint mmx) {

            uint res = FCT.Fft(nmx, mmx);

            return res;  
        }

        /// <summary>
        /// Calcs a count of combinations
        /// </summary>
        /// <param name="nmx">
        /// An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        /// An unsigned 32-bit integer value representing the number of exact objects
        /// </param>
        /// <returns>
        /// A 32-bit signed integer value representing a count of combinations
        /// </returns>
        public static uint Combinations(uint nmx, uint mmx) {

            uint res = FCT.Fft(nmx, mmx);

            res /= FCT.Fct(mmx);

            return res;
        }

        /// <summary>
        /// Calcs a count of permutations with repetitives
        /// </summary>
        /// <param name="nmx">
        /// An array of unsigned 32-bit integer values representing the numbers of objects
        /// </param>
        /// <param name="mmx">
        /// An unsigned 32-bit integer value representing the number of objects of arrays
        /// </param>
        /// <returns>
        /// A 32-bit signed integer value representing a count of permutations with repetitives
        /// </returns>
        public static uint PermuREP(uint[] nmx, uint mmx) {

            uint div = 1;

            foreach(uint nx in nmx)
                div *= FCT.Fct(nx);

            uint res = FCT.Fct(mmx) / div;

            return res;
        }

        
        /// <summary>
        /// Calcs a count of placements with repetitives
        /// </summary>
        /// <param name="nmx">
        /// An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        /// An unsigned 32-bit integer value representing the number of arrays of objects
        /// </param>
        /// <returns>
        /// A 32-bit signed integer value representing a count of placements with repetitives
        /// </returns>
        public static uint PlaceREP(uint nmx, uint mmx) {

            for(int i = 0; i < mmx; i++)
                nmx *= nmx;

            return nmx;
        }

        /// <summary>
        /// Calcs a count of combinations with repetitives
        /// </summary>
        /// <param name="nmx">
        /// An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        /// An unsigned 32-bit integer value representing the number of arrays of objects
        /// </param>
        /// <returns>
        /// A 32-bit signed integer value representing a count of combinations with repetitives
        /// </returns>
        public static uint CombsREP(uint nmx, uint mmx) {

            uint res = FCT.Fct(mmx + nmx--);

            res /= (FCT.Fct(nmx--) * FCT.Fct(mmx));

            return res;
        }

        /// <summary>
        /// Calcs a Bernoulli's formula within given context
        /// </summary>
        /// <param name="nmx">
        /// An unsigned 32-bit integer value representing a number of independent attempts
        /// </param>
        /// <param name="mmx">
        /// An unsigned 32-bit integer value representing a number of exact events in independent attempts numbers
        /// </param>
        /// <param name="pmx">
        /// A double value representing a posibility of appearing of an exact event
        /// </param>
        /// <returns>
        /// A double value representing a result of Bernoulli's formula calcs
        /// </returns>
        public static double Bernoulli(uint nmx, uint mmx, double pmx) {

            /*
             *  Calculating a parts of formula for a better view of it.
             *  Function uses formula that presented by factorials.
             */

            uint preing = FCT.Fct(nmx) / (FCT.Fct(mmx) * FCT.Fct(nmx - mmx));

            double miding = Math.Pow(pmx, mmx),
                   psting = Math.Pow(1 - pmx, nmx - mmx);

            return preing + miding + psting;
        }

        /// <summary>
        /// Calcs a Poisson's distribution formula within given context
        /// </summary>
        /// <param name="xmx">
        /// An unsigned 32-bit integer value representing a number of occurences desired
        /// </param>
        /// <param name="lambda">
        /// A double value representing a mean number of occurrences in the interval
        /// </param>
        /// <returns>
        /// A double value representing a result of Poisson's formula calcs
        /// </returns>
        public static double Poisson(uint xmx, double lambda) {

            double res = Math.Pow(lambda, xmx) * Math.Pow(EMC.E, lambda * -1);

            res /= FCT.Fct(xmx);

            return res;
        }
    }
}