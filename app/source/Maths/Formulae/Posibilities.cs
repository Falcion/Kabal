using FCT
    = Karamath.Maths.Factofunctions;


namespace Karamath.Maths {

    public static class Posibilities {

        /// <summary>
        ///     Calcs a count of permutations
        /// </summary>
        /// 
        /// <param name="nmx">
        ///     An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a count of permutations
        /// </returns>
        ///
        public static uint Permutations(uint nmx) {

            uint res = FCT.Fct(nmx);

            return res;
        }

        /// <summary>
        ///     Calcs a count of placements
        /// </summary>
        /// 
        /// <param name="nmx">
        ///     An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        ///     An unsigned 32-bit integer value representing the number of exact objects
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a count of placements
        /// </returns>
        ///
        public static uint Placements(uint nmx, uint mmx) {

            uint res = FCT.Fft(nmx, mmx);

            return res;  
        }

        /// <summary>
        ///     Calcs a count of combinations
        /// </summary>
        /// 
        /// <param name="nmx">
        ///     An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        ///     An unsigned 32-bit integer value representing the number of exact objects
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a count of combinations
        /// </returns>
        ///
        public static uint Combinations(uint nmx, uint mmx) {

            uint res = FCT.Fft(nmx, mmx);

            res /= FCT.Fct(mmx);

            return res;
        }

        /// <summary>
        ///     Calcs a count of permutations with repetitives
        /// </summary>
        /// 
        /// <param name="nmx">
        ///     An array of unsigned 32-bit integer values representing the numbers of objects
        /// </param>
        /// <param name="mmx">
        ///     An unsigned 32-bit integer value representing the number of objects of arrays
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a count of permutations with repetitives
        /// </returns>
        ///
        public static uint PermuREP(uint[] nmx, uint mmx) {

            uint div = 1;

            foreach(uint nx in nmx)
                div *= FCT.Fct(nx);

            uint res = FCT.Fct(mmx) / div;

            return res;
        }

        
        /// <summary>
        ///     Calcs a count of placements with repetitives
        /// </summary>
        /// 
         /// <param name="nmx">
        ///     An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        ///     An unsigned 32-bit integer value representing the number of arrays of objects
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a count of placements with repetitives
        /// </returns>
        ///
        public static uint PlaceREP(uint nmx, uint mmx) {

            for(int i = 0; i < mmx; i++)
                nmx *= nmx;

            return nmx;
        }

        /// <summary>
        ///     Calcs a count of combinations with repetitives
        /// </summary>
        /// 
        /// <param name="nmx">
        ///     An unsigned 32-bit integer value representing the number of objects
        /// </param>
        /// <param name="mmx">
        ///     An unsigned 32-bit integer value representing the number of arrays of objects
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit signed integer value representing a count of combinations with repetitives
        /// </returns>
        ///
        public static uint CombsREP(uint nmx, uint mmx) {

            uint res = FCT.Fct(mmx + nmx--);

            res /= (FCT.Fct(nmx--) * FCT.Fct(mmx));

            return res;
        }
    }
}