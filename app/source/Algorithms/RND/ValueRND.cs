namespace Karamath.RND {

    /// <summary>
    ///     Library module responsible for generating a pseudo-random integer and double values
    /// </summary>
    /// 
    public static class ValueRND {

        /// <summary>
        ///     Generates a pseudo-random integer value from given range
        /// </summary>
        /// 
        /// <param name="min">
        ///     A 32-bit integer value representing minimum of arrangement
        /// </param>
        ///  <param name="max">
        ///     A 32-bit integer value representing maximum of arrangement
        ///  </param>
        ///  
        /// <returns>
        ///     A 32-bit integer value representing a pseudo-random result
        /// </returns>
        /// 
        public static int ValuesRND(int min, int max) {

            Random rnd = new();

            int res = rnd.Next(min, max);

            return res;
        }

        /// <summary>
        ///     Generates a pseudo-random integer value from given range
        /// </summary>
        /// 
        /// <param name="min">
        ///     A 64-bit integer value representing minimum of arrangement
        /// </param>
        /// <param name="max">
        ///     A 64-bit integer value representing maximum of arrangement
        /// </param>
        ///  
        /// <returns>
        ///     A 64-bit integer value representing a pseudo-random result
        /// </returns>
        /// 
        public static long ValuesRND(long min, long max) {

            Random rnd = new();

            long res = rnd.NextInt64(min, max);

            return res;
        }

        /// <summary>
        ///     Generates a pseudo-random double value with a 64-bit integer base from given range
        /// </summary>
        /// 
        /// <param name="min">
        ///     A double value representing minimum of arrangement for generation of a 64-bit integer base 
        /// </param>
        /// <param name="max">
        ///     A double value representing maximum of arrangement for generation of a 64-bit integer base
        /// </param>
        ///  
        /// <returns>
        ///     A double value representing a pseudo-random result with a 64-bit integer base
        /// </returns>
        ///  
        public static double ValuesRND(double min, double max) {

            Random rnd = new();

            double res = rnd.NextDouble();

            long point = ValuesRND(Convert.ToInt64(min),
                                   Convert.ToInt64(max));

            return point + res;
        }

        /// <summary>
        ///     Generates a pseudo-random single value represented by a float type
        /// </summary>
        /// 
        /// <returns>
        ///     A float value representing a single type value
        /// </returns>
        /// 
        public static float ValuesRND() {

            Random rnd = new();

            float res = rnd.NextSingle();

            return res;
        }
    }
}