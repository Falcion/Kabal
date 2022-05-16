namespace Karamath.Algorithms {

    /// <summary>
    ///     Library module responsible for cyphering strings in popular and useful ways
    /// </summary>
    /// 
    public static class Cyphers {

        /// <summary>
        ///     Cyphers the string with Caesers cypher
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/caesar-cipher-in-cryptography/?ref=gcse">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A string representing future cyphered string
        /// </param>
        /// <param name="shift">
        ///     A 8-bit integer value representing a shift in alphabet by key
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a cyphered version of given one with help of key
        /// </returns>
        /// 
        public static string Caesers(string amx, byte shift) {

            char[] buffer = amx.ToCharArray();

            for(int i = 0; i < buffer.Length; i++) {
                
                char letter = buffer[i];

                /*
                 *  Implementing shift in alphabet with help of key.
                 */

                letter = (char)(letter + shift);

                if (letter > 'z')
                    letter = (char)(letter - 26);

                else if (letter < 'a')
                    letter = (char)(letter + 26);

                buffer[i] = letter;
            }

            return new string(buffer);
        }
    
        /// <summary>
        ///     Cyphers the string with binaries coding
        /// </summary>
        /// 
        /// <param name="amx">
        ///     A string representing future cyphered string
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a cyphered version of given one
        /// </returns>
        /// 
        public static string Binaries(string amx) {

            string bins = "";

            /*
             * Parsing each character in binary encoding by declaring base.
             */

            foreach(char smx in amx)
                bins += Convert.ToString(smx, 2);

            return bins;
        }

        /// <summary>
        ///     Cyphers the string with ASCII coding
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/program-print-ascii-value-character/?ref=gcse">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A string representing future cyphered string
        /// </param>
        /// 
        /// <returns>
        ///     A string representing a cyphered version of given one
        /// </returns>
        /// 
        public static string ASCII(string amx)
        {
            string res;

            res = string.Join("", System.Text.Encoding.ASCII.GetChars(
                                  System.Text.Encoding.ASCII.GetBytes(amx.ToCharArray())
                                                                     ));

            return res;
        }
    }
}