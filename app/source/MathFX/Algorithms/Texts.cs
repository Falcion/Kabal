namespace MathFX.Algorithms
{

    public static class Texts
    {

        /// <summary>
        ///     Function counting vowels in given string
        /// </summary>
        /// 
        /// <returns>
        ///     Number of vowels in default latin alphabet
        /// </returns>
        /// 
        public static int CountVowels(string param)
        {
            string CHARS_DICT = "aeiou";

            int counter = 0;

            param = param.ToLower();

            foreach (char P_CHAR in param)
            {
                if (CHARS_DICT.Any(C => C == P_CHAR))
                    counter++;
            }

            return counter;
        }

        /// <summary>
        ///     Function counting consonants in given string
        /// </summary>
        /// 
        /// <returns>
        ///     Number of consonants in default latin alphabet
        /// </returns>
        /// 
        public static int CountConsonants(string param)
        {
            string CHARS_DICT = "bcdfghjklmnpqrstvwxyz";

            int counter = 0;

            param = param.ToLower();

            foreach (char P_CHAR in param)
            {
                if (CHARS_DICT.Any(C => C == P_CHAR))
                    counter++;
            }

            return counter;
        }

        /// <summary>
        ///     Function counting backspaces in given string
        /// </summary>
        /// 
        /// <returns>
        ///     Number of backspaces in given string
        /// </returns>
        /// 
        public static int CountSpaces(string param)
        {
            int counter = 0;

            foreach(char P_CHAR in param)
            {
                if(P_CHAR == ' ')
                    counter++;
            }


            return counter;
        }

        /// <summary>
        ///     Function counting words in given string
        /// </summary>
        /// 
        /// <returns>
        ///     Number of words which are defined by cutting by spaces
        /// </returns>
        /// 
        public static int CountWords(string param)
        {
            int counter = 0;

            string[] ONE_WORDS = new string[] 
            { 
                "A", "a", 
                "I", "i" 
            };

            string[] enumParams = param.Split(' ');

            foreach(string enumParam in enumParams)
            {
                if(enumParam.Length <= 1)
                {
                    if (ONE_WORDS.Any(W => W == enumParam))
                        counter++;
                }
                else
                {
                    if(enumParam != " " || enumParam != null)
                        counter++;
                }
            }

            return counter;
        }
    }
}