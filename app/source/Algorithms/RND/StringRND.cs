namespace Karamath.RND {

    /// <summary>
    ///     Library module responsible for generating a pseudo-random strings
    /// </summary>
    /// 
    public static class StringRND {

        /// <summary>
        ///     Generates a pseudo-random string with pseudo-random length
        /// </summary>
        /// 
        /// <returns>
        ///     A pseudo-random string with pseudo-random length
        /// </returns>
        /// 
        public static string StringsRND() {

            Random rnd = new();

            int length = rnd.Next(1, 257);

            string res = "";

            for(int i = 0; i < length; i++) {

                int cascade = rnd.Next(0, 26);

                char letter = (char) (cascade + 65);

                res += letter;
            }

            return res;
        }

        /// <summary>
        ///     Generates a pseudo-random string with given length
        /// </summary>
        /// 
        /// <param name="length">
        ///     A 32-bit integer value representing length of pseudo-random string
        /// </param>
        /// 
        /// <returns>
        ///     A pseudo-random string with given length
        /// </returns>
        /// 
        public static string StringsRND(uint length) {

            Random rnd = new();

            string res = "";

            for(int i = 0; i < length; i++) {

                int cascade = rnd.Next(0, 26);

                char letter = (char) (cascade + 65);

                res += letter;
            }

            return res;
        }
    }
}