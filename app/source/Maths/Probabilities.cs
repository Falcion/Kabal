using FCT
    = MathFX.Maths.Factofunctions;

namespace MathFX.Maths
{

    public static class Probabilities
    {

        /// <summary>
        ///     Number of permutations
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a value of permutations
        /// </returns>
        /// 
        public static uint Permutations(uint n)
        {
            uint calcs = FCT.Fct(n);

            return calcs;
        }

        /// <summary>
        ///     Number of placements
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a value of placements
        /// </returns>
        /// 
        public static uint Placements(uint n, uint k)
        {
            uint calcs = FCT.Dff(n, k);

            return calcs;
        }

        /// <summary>
        ///     Number of combinations
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a value of combinations
        /// </returns>
        /// 
        public static uint Combinations(uint n, uint k)
        {
            uint calcs = FCT.Dff(n, k);

            calcs /= FCT.Fct(k);

            return calcs;
        }

        /// <summary>
        ///     Number of permutations with repetitions
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a value of permutations with repetitions
        /// </returns>
        /// 
        public static uint PermutaREP(uint n, uint[] nk)
        {
            uint div = 1;

            foreach (uint k in nk)
                div *= FCT.Fct(k);

            uint calcs = FCT.Fct(n) / div;

            return calcs;
        }

        /// <summary>
        ///     Number of placements with repetitions
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a value of placements with repetitions
        /// </returns>
        /// 
        public static uint PlacemeREP(uint n, uint k)
        {
            for (int i = 0; i < k; i++)
                n *= n;

            return n;
        }

        /// <summary>
        ///     Number of combinations with repetitions
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a value of placements with combinations
        /// </returns>
        /// 
        public static uint CombinaREP(uint n, uint k)
        {
            uint calcs = FCT.Fct(k + n - 1);

            calcs /= (FCT.Fct(n - 1) * FCT.Fct(k));

            return calcs;
        }
    }
}
