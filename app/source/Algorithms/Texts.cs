namespace Karamath.Algorithms {

    /// <summary>
    ///     Library module responsible for working and assembling different strings
    /// </summary>
    /// 
    public static class Texts {

        /// <summary>
        ///     Checks the word on palindrome case   
        /// </summary>
        /// 
        /// <param name="amx">
        ///     A string which will be checked on palindrome case
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value representing a status of palindrome case
        /// </returns>
        /// 
        public static bool Palindrome(string amx) { 

            int length = amx.Length;

            if(length % 2 == 1) {
                
                int middle = length / 2;

                string left = amx[..middle];
                string right = amx.Substring(middle + 1, length - middle - 1);

                if (left == RevCS(right))
                    return true;
                else
                    return false;
            } 
            else {
                int heaps = length / 2;

                string left = amx[..heaps];
                string right = amx[heaps..length];

                if (left == RevCS(right))
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        ///     Pathfinds the most longest substring of palindrome case
        /// </summary>
        /// 
        /// <param name="amx">
        ///     A string which will substring palindrome
        /// </param>
        /// 
        /// <returns>
        ///     A string representing substring of palindrome case with biggest length
        /// </returns>
        /// 
        public static string PalindromeST(string amx) {

            if(amx.Length <= 1)
                return amx;

            int length = amx.Length,
                mx = 1;

            bool[,] arr = new bool[length, length];

            string adjuster = "";

            for(int i = 0; i < length; i++) {
                for(int j = 0; j < length - 1; j++) {

                    int coef = i + j;

                    if(amx.ElementAt(j) == amx.ElementAt(coef) && (coef - j <= 2 || arr[j++, coef--])) {

                        arr[j, coef] = true;

                        if(coef++ - j > mx) {

                            mx = coef++ - j;

                            adjuster = amx.Substring(j, coef++);
                        }
                    }
                }
            }

            return adjuster;
        }

        /// <summary>
        ///     Checks two strings on anagram case  
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/check-whether-two-strings-are-anagram-of-each-other/">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A first string which will be checked on anagram case
        /// </param>
        /// <param name="bmx">
        ///     A second string which will be checked on anagram case
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value representing a status of anagram case
        /// </returns>
        /// 
        public static bool Anagram(string amx, string bmx) {
            
            int ctamx = amx.Length,
                ctbmx = bmx.Length;

            if(ctamx == ctbmx)
                return false;

            amx = StringSORT(amx);
            bmx = StringSORT(bmx);

            for (int i = 0; i < ctamx; i++)
                if(amx[i] != bmx[i])
                    return false;

            return true;
        }


        /// <summary>
        ///     Checks string on pangram case  
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/pangram-checking/">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A string which will be checked on pangram case
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value representing a status of pangram case
        /// </returns>
        /// 
        public static bool Pangram(string amx) {
            
            /*
             *  Creating a hash table to mark the chars
             *  present in the string.
             */

            bool[] mark = new bool[26];

            int index = 0;

            for(int i = 0; i < amx.Length; i++) {

                if('A' <= amx[i] && amx[i] <= 'Z')
                    index = amx[i] - 'A';
                else if('a' <= amx[i] && amx[i] <= 'z')
                    index = amx[i] - 'a';
                else
                    continue;
            }

            mark[index] = true;

            for(int i = 0; i <= 25; i++)
                if(mark[i] == false)
                    return false;

            return true;
        }

        /// <summary>
        ///     Checks string on ISBN case  
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/program-check-isbn/">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A string which will be checked on ISBN case
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value representing a status of ISBN case
        /// </returns>
        /// 
        public static bool ISBN(string amx) {

            int length = amx.Length;

            if(length != 10)
                return false;

            int sum = 0;

            for(int i = 0; i < 9; i++) {

                int digit = amx[i] - '0';

                if(0 > digit || 9 < digit)
                    return false;

                sum += (digit * (10 - i));
            }

            char bmx = amx[9];

            if(bmx != 'X' && (bmx < '0'
                          ||  bmx > '9'))
                return false;

            sum += (bmx == 'X') ? 10 : (bmx - '0');

            bool res = (sum % 11 == 0);

            return res;
        }

        /// <summary>
        ///     Parse non-parsed string of given path in correct format for .NET
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string representing non-parsed path
        /// </param>
        /// 
        /// <returns>
        ///     A string representing parsed string of given path
        /// </returns>
        /// 
        public static string Pathlify(string stringify) {

            if(!stringify.Contains('\\'))
                return stringify;
            else if(!stringify.Contains('/'))
                return stringify;
            else if(!stringify.Contains("\\\\"))
                return stringify;
            else {

                stringify = stringify.Replace("\\", "/");
                stringify = stringify.Replace("\\\\", "/");
            }

            return stringify;
        }

        /// <summary>
        ///     Parse non-parsed string of given path in correct format for .NET
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string representing non-parsed path
        /// </param>
        /// 
        /// <returns>
        ///     A string representing parsed string of given path
        /// </returns>
        /// 
        public static string URLlify(string stringify) {

            if(!stringify.Contains(' '))
                return stringify;
            else
                return stringify.Replace(" ", "%20");

        }

        /// <summary>
        ///     Counts vowels in given string
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string in which function would count vowels
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing count of vowels
        /// </returns>
        /// 
        public static int VowelsOf(string stringify) {

            string ALPHABET = "aAeEiIoOuU";

            int count = 0;

            foreach(char ch in stringify)
                if(ALPHABET.Contains(ch))
                    count++;

            return count;
        }

        /// <summary>
        ///     Counts consonants in given string
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string in which function would count consonants
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing count of consonants
        /// </returns>
        /// 
        public static int ConsonantsOf(string stringify) {

            string ALPHABET = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ";

            int count = 0;

            foreach(char ch in stringify)
                if(ALPHABET.Contains(ch))
                    count++;

            return count;
        }

        /// <summary>
        ///     Counts words in given string
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string in which function would count words
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing count of words
        /// </returns>
        ///
        public static int WordsOf(string stringify) {

            string[] squash = stringify.Split(' ');

            int count = 0;

            foreach(string str in squash) {

                /*
                 * Self-mention in text counts as whole word.
                 */

                if(str.Length <= 1 && str != "I")
                    continue;
                else
                    count++;
            }

            return count;
        }

        /// <summary>
        ///     Reverses a given string with no excessive enumerables and parameters
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string which will be reversed by function
        /// </param>
        /// 
        /// <returns>
        ///     A reversed string
        /// </returns>
        /// 
        private static string RevCS(string stringify) {

            string res = "";

            int cascade = stringify.Length - 1;

            for(int i = 0; i < stringify.Length; i++) {

                res += stringify.ElementAt(cascade);
                cascade--;
            }

            return res;
        }

        /// <summary>
        ///     Sorts a given string with no excessive enumerables and parameters
        /// </summary>
        /// 
        /// <param name="stringify">
        ///     A string which will be sorted by function
        /// </param>
        /// 
        /// <returns>
        ///     A sorted string
        /// </returns>
        ///
        public static string StringSORT(string stringify)
        {
            char[] chars = stringify.ToArray();

            Array.Sort(chars);

            return new string(chars);
        }
    }
}