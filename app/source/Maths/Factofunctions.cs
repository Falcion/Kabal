using CTM 
    = MathFX.Maths.Constants;
using EMC
    = MathFX.Algorithms.Enumerables;

namespace MathFX.Maths
{

    public static class Factofunctions
    {

        /// <summary>
        ///     A default factorial
        /// </summary>
        /// 
        /// <returns>
        ///     Product of natural numbers from one to the given one
        /// </returns>
        /// 
        public static uint Fct(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 1;

            for(uint i = 1; i < number; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        ///     Factorion
        /// </summary>
        /// 
        /// <returns>
        ///     Sum of digits' factorials of given number
        /// </returns>
        /// 
        public static uint Foi(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 0;

            string digits = Convert.ToString(number);

            foreach(char digit in digits)
                result += Fct(Convert.ToUInt32(digit));

            return result;
        }

        /// <summary>
        ///     Factorion of second order
        /// </summary>
        /// 
        /// <returns>
        ///     Product of digits' factorials of given number
        /// </returns>
        /// 
        public static uint Foi2(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 0;

            string digits = Convert.ToString(number);

            foreach (char digit in digits)
                result *= Fct(Convert.ToUInt32(digit));

            return result;
        }

        /// <summary>
        ///     A superfactorial function
        /// </summary>
        /// 
        /// <returns>
        ///      Product of natural numbers' factorials from one to the given one
        /// </returns>
        /// 
        public static ulong Sft(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 1;

            for (uint i = 1; i < number; i++)
            {
                result *= Fct(i);
            }

            return result;
        }

        /// <summary>
        ///     A hyperfactorial function
        /// </summary>
        /// 
        /// <returns>
        ///      Product of natural numbers' factorials from one to the given one
        /// </returns>
        /// 
        public static ulong Hft(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 1;

            for (uint i = 1; i < number; i++)
            {
                /*
                 *  Creating a 32-bit unsigned integer value as clone of current result value,
                 *  for checking it on violation of maximum range of unsigned 32-bit integers.
                 */

                uint NUM_STORAGE = result;

                result *= Fct(i);

                if(result != NUM_STORAGE * Fct(i))
                {
                    result = NUM_STORAGE;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        ///     Double factorial function
        /// </summary>
        /// 
        /// <returns>
        ///     Product of natural numbers from one to the given one with the same parity as given
        /// </returns>
        /// 
        public static uint Dft(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 1;

            if (number % 2 == 0)
            {
                result *= 2;

                for (uint i = 2; i <= number - 2; i += 2)
                    result *= i;
            }
            else
            {
                for (uint i = 1;(i <= number && i % 2 == 1); i++)
                    result *= i;
            }

            return result;
        }

        /// <summary>
        ///     A multiple factorial function
        /// </summary>
        /// 
        /// <returns>
        ///     Product of natural numbers from one to the given one which are could be multiplied by multiple number
        /// </returns>
        /// 
        public static uint Mft(uint number, uint multiple)
        {
            if (number == 0)
                return 1;

            switch(multiple)
            {
                case 0:
                    throw new DivideByZeroException();

                case 1:
                    return Fct(number);

                case 2:
                    return Dft(number);
            }

            if (multiple >= number)
                throw new ArithmeticException();

            uint result = 1;

            for (uint i = 0; (i <= number && i % multiple == 0); i++)
                result *= i;

            return result;
        }

        /// <summary>
        ///     A decreasing factorial function
        /// </summary>
        /// 
        /// <returns>
        ///     Result of dividing of a number's factorial by the factorial of difference between the given number and the coefficient
        /// </returns>
        /// 
        public static uint Dff(uint number, uint increment)
        {
            if (number == 0)
                return 1;

            if (increment == 0 || increment == number)
                throw new ArithmeticException();

            uint result = Fct(number);

            result /= Fct(number - increment);

            return result;
        }

        /// <summary>
        ///     An increasing factorial function
        /// </summary>
        /// 
        /// <returns>
        ///     Result of dividing a high-expression's factorial: more about it in documentation
        /// </returns>
        /// 
        public static uint Ift(uint number, uint increment)
        {
            if (number == 0)
                return 1;

            if (increment == 0 || increment == number)
                throw new ArithmeticException();

            uint result 
                    = Fct(number + increment - 1);

            result /= Fct(number - 1);

            return result;
        }

        /// <summary>
        ///     A primorial function
        /// </summary>
        /// 
        /// <returns>
        ///     Product of primes in range from one to given number
        /// </returns>
        /// 
        public static uint Prm(uint number)
        {

            if (number == 0 || number == 1)
                return 1;

            List<uint> Primes = EMC.Primes(number);

            uint result = 1;

            for (int i = 0; i < number; i++)
                result *= Primes[i];

            return result;
        }

        /// <summary>
        ///     Fibbonacial function
        /// </summary>
        /// 
        /// <returns>
        ///     Product of first fibonacci's numbers in range from one to given number 
        /// </returns>
        /// 
        public static uint Fbn(uint number)
        {
            if (number == 0)
                return 1;

            uint result = 1;

            /*
             * Implementing the two first numbers in Fibonacci's array
             * for algorithm setup and its initial work.
             */

            List<uint> Fibbonaci = EMC.Fibonacci(number);

            for(int i = 0; i < number; i++)
                result *= Fibbonaci[i];

            return result;
        }

        /// <summary>
        ///     A subfactorial function
        /// </summary>
        /// 
        /// <returns>
        ///     Number of disorder or its permutations without points
        /// </returns>
        /// 
        public static UInt64 Sbf(uint number)
        {
            if (number == 0 || number == 1)
                return 0;

            /*
             * Using specified exponental formula for more comforted view and
             * faster calcs without garbaging the RAM.
             */

            return Convert.ToUInt64(Fct(number) / CTM.E);
        }
    }
}
