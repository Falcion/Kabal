namespace MathFX.Algorithms
{

    public static class Texts
    {

        /// <summary>
        ///     Function checking given input on palindrome case
        /// </summary>
        /// 
        /// <returns>
        ///     A boolean value representing is it a palindrome case or not
        /// </returns>
        /// 
        public static bool Palindrome(string input) 
        { 
            int length = input.Length;

            if(length % 2 == 1)
            {
                int middle = length / 2;

                string lft = input.Substring(0, middle);
                string rft = input.Substring(middle + 1, length - middle - 1);

                if (lft == Reverse(rft))
                    return true;
                else
                    return false;
            } 
            else
            {
                int heaps = length / 2;

                string lft = input.Substring(0, heaps);
                string rft = input.Substring(heaps, length - heaps);

                if (lft == Reverse(rft))
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        ///     Function counting latin vowels in given input
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit integer value of vowels in string
        /// </returns>
        /// 
        public static int VowelsOf(string input) 
        {
            string ALPHABET = "aAeEiIoOuU";

            int count = 0;

            foreach(char ch in input)
            {
                if(ALPHABET.Contains(ch))
                    count++;
            }

            return count;
        }

        /// <summary>
        ///     Function counting latin consonants in given input
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit integer value of consonants in string
        /// </returns>
        /// 
        public static int ConsonantsOf(string input) 
        {
            string ALPHABET = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ";

            int count = 0;

            foreach (char ch in input)
            {
                if (ALPHABET.Contains(ch))
                    count++;
            }

            return count;
        }

        /// <summary>
        ///     Function accurately counting words in given string
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing count of words in given input
        /// </returns>
        /// 
        public static int WordsOf(string input) 
        {
            string[] decInput = input.Split(' ');

            int count = 0;

            foreach(string dec in decInput)
            {
                if (dec.Length <= 1 && dec != "I")
                    continue;

                else
                    count++;
            }

            return count;
        }

        /// <summary>
        ///     Implemented in .NET function of string reverse in easier format
        /// </summary>
        /// 
        /// <returns>
        ///     Reversed string
        /// </returns>
        /// 
        public static string Reverse(string input)
        {
            string rev = "";

            int cascade = input.Length - 1;

            for(int i = 0; i < input.Length; i++)
            {
                rev += input.ElementAt(cascade);

                cascade--;
            }

            return rev;
        }

        public static class Cyphers
        {

            /// <summary>
            ///     Caesers cypher function
            /// </summary>
            /// 
            /// <returns>
            ///     Shifted crypted string from given one
            /// </returns>
            public static string Caesers(string input, int shift)
            {
                char[] buffer = input.ToCharArray();

                for(int i = 0; i < buffer.Length; i++)
                {
                    char letter = buffer[i];

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
            ///     Function of ciphering into binaries
            /// </summary>
            /// 
            /// <returns>
            ///     A string of binaries converted char
            /// </returns>
            /// 
            public static string Binaries(string input)
            {
                string res = "";

                foreach (char sym in input)
                    res += Convert.ToString(sym, 2);

                return res;
            }

            /// <summary>
            ///     Function of ciphering into ASCII
            /// </summary>
            /// 
            /// <returns>
            ///     A string of ASCII converted chars
            /// </returns>
            /// 
            public static string ASCII(string input)
            {
                string res;

                res = string.Join("", System.Text.Encoding.ASCII.GetChars(
                                      System.Text.Encoding.ASCII.GetBytes(input.ToCharArray())
                                                                         ));

                return res;
            }
        }
    }
}