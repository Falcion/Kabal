using System;
using System.Collections.Generic;

namespace MathFX
{
    public static class Factorials
    {
        // Declaring own Euler's number for better accuracy.
        public const double E = 2.7182818284590452353602874713527F;

        private static Exception NonDigitException = new Exception("Invalid input contains non digits");

        /// <summary>
        /// Factorial of a number is the product of natural numbers from 1 to N.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        public static ulong Factorial(ulong N)
        {
            if (N == 0)
                return 1;

            ulong result = 1;

            for(ulong i = 1; i < N; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Factorion is a natural number that is equals to the sum of the factorials of its digits.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="NonDigitException">
        /// Thrown in unpredictable situtation when given number don't contain digits (theoretical exception).
        /// </exception>
        public static ulong Factorion(ulong N)
        {
            if (N == 0)
                return 1;

            ulong result = 0;

            string numDigits = N.ToString();

            if (numDigits.Equals(null))
                throw NonDigitException;

            foreach(char numDigit in numDigits)
            {
                result += Factorial(Convert.ToUInt64(numDigit));
            }

            return result;
        }

        /// <summary>
        /// Factorion of second order is a natural number that is equals to the product of the factorials of its digits.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="NonDigitException">
        /// Thrown in unpredictable situtation when given number don't contain digits (theoretical exception).
        /// </exception>
        public static ulong FactorionSecondOrder(ulong N)
        {
            // Factorion of second order could be applied even to very big numbers.
            // That's why there is no factorion of third order: product of 'groups' of digits of number.
            // Because it would just kill any RAM because of its hypothetical character.
            //
            // If you reading this and know how to write an algorithm of factorion of third order, please, contact developer at GitHub.

            if (N == 0)
                return 1;

            ulong result = 0;

            string numDigits = N.ToString();

            if (numDigits.Equals(null))
                throw NonDigitException;

            foreach (char numDigit in numDigits)
            {
                result *= Factorial(Convert.ToUInt64(numDigit));
            }

            return result;
        }

        /// <summary>
        /// Superfactorial is the product of the first factorials of a number from 1 to N.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of superfactorial calculation is too high. Formula of prediction: result from 'i' > ulong.MaxValue - number**2
        /// </exception>
        public static ulong Superfactorial(ulong N)
        {
            if (N == 0)
                return 1;

            ulong result = 1;

            for(ulong i = 1; i < N; i++)
            {
                result *= Factorial(i);

                if (result > ulong.MaxValue - Math.Pow(N, 2))
                    throw new OverflowException("Result of superfactorial is too big! Formula of prediction thrown an exception!");
            }

            return result;
        }

        /// <summary>
        /// Hyperfactorial is the product of the first superfactorials of a number from 1 to N.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="OverflowException">
        /// Thrown when the result of hyperfactorial calculation is too high. Formula of prediction: result from 'i' > ulong.MaxValue / sqrt(3)
        /// </exception>
        public static ulong Hyperfactorial(ulong N)
        {
            if (N == 0)
                return 1;

            ulong result = 1;

            for (ulong i = 1; i < N; i++)
            {
                result *= Superfactorial(i);

                if (result > (ulong)(ulong.MaxValue / Math.Sqrt(3)))
                    throw new OverflowException("Result of superfactorial is too big! Formula of prediction thrown an exception!");
            }

            return result;
        }

        /// <summary>
        /// Double factorial of a number is defined as the product of all natural numbers from 1 to N that have the same parity as N.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        public static ulong DoubleFactorial(ulong N)
        {
            if (N == 0)
                return 1;

            ulong result = 1;

            if(N % 2 == 0)
            {
                for(ulong i = 2; i < N - 2; i += 2)
                {
                    result *= i;
                }
            }
            else
            {
                for(ulong i = 1; i < N && i % 2 == 1; i++)
                {
                    result *= i;
                }
            }

            return result;
        }

        /// <summary>
        /// Multiple factorial is the product of natural numbers from 1 to N, at that, which are multiples of M.
        /// </summary>
        /// <remarks>
        /// If a multiple number ('M') is equals 1 - function will return factorial of N, if M = 2: double factorial of N.
        /// </remarks>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <param name="M">A 64-bit non-negative integer which is defined as M (or multiple).</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="DivideByZeroException">Thrown when multiple number ('M') equals 0.</exception>
        /// <exception cref="ArithmeticException">Thrown when multiple number ('M') equals or greater than subfuction number 'N'.</exception>
        public static ulong MultipleFactorial(ulong N, ulong M)
        {
            if (N == 0)
                return 1;

            if (M == 0)
                throw new DivideByZeroException();

            if (M >= N)
                throw new ArithmeticException("Can't count multiple factorial when the multiple greater or equals to subfunction number!");

            switch(M)
            {
                // Factorial is a special case of the multiple factorial when multiple = 1
                case 1:
                    return Factorial(N);

                // Double factorial is a special case of the multiple factorial when multiple = 2
                case 2:
                    return DoubleFactorial(N);
            }

            ulong result = 1;

            for (ulong i = 1; i < N && i % M == 0; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Decreasing factorial is a factorial function provided by expression: Factorial(N) / Factorial(N-K) or N! / (N-K)!
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <param name="K">A 64-bit non-negative integer which is being a decreasing increment of subfunction expressions.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="ArithmeticException">
        /// Thrown when decreasing increment equals zero or subfunction number.
        /// </exception>
        public static ulong DecreasingFactorial(ulong N, ulong K)
        {
            if (N == 0)
                return 1;

            if (K == 0 || K == N)
                throw new ArithmeticException("Decreasing increment of decreasing factorial can't be equal to zero or subfunction number!");

            // A simplified function is used for simpler code and faster execution
            // (memory consumption is about the same). 

            return Factorial(N) / Factorial(N - K);
        }

        /// <summary>
        /// Increasing factorial is a factorial  function provided by expression: Factorial(N+K-1) / Factorial(N-1) or (N+K-1)! / (N-1)!
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <param name="K">A 64-bit non-negative integer which is being a increasing increment of subfunction expressions.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        /// <exception cref="ArithmeticException">
        /// Thrown when increasing increment equals zero or subfunction number.
        /// </exception>
        public static ulong IncreasingFactorial(ulong N, ulong K)
        {
            if (N == 0)
                return 1;

            if (K == 0 || K == N)
                throw new ArithmeticException("Increasing increment of increasing factorial can't be equal to zero or subfunction number!");

            // A simplified function is used for simpler code and faster execution
            // (memory consumption is about the same).

            return Factorial(N + K - 1) / Factorial(N - 1);
        }

        /// <summary>
        /// Primorial is the product of the first prime numbers of P in the range up to N.
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0 and N = 1: returns 1.</returns>
        public static ulong Primorial(ulong N)
        {
            if (N == 0)
                return 1;

            // Special case of primorial: if N = 1 => return 1;
            if (N == 1)
                return 1;

            List<ulong> primes = new List<ulong>();

            while(N % 2 == 0)
            {
                primes.Add(2);
                N /= 2;
            }

            for(ulong i = 3; i < Math.Sqrt(N); i += 2)
            {
                while(N % i == 0)
                {
                    primes.Add(i);
                    N /= i;
                }
            }

            if (N > 2)
                primes.Add(N);

            foreach(ulong value in primes)
            {
                List<ulong> map = primes.FindAll(match => match == value);

                if(map.Count > 1)
                {
                    primes.RemoveAll(match => match == value);
                    primes.Add(value);
                }
            }

            ulong result = 1;

            foreach(ulong prime in primes)
            {
                result *= prime;
            }

            return result;
        }

        /// <summary>
        /// The product of several first Fibonacci numbers (range from 1 to N > last Fibonacci number).
        /// </summary>
        /// <param name="N">A 64-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0: returns 1.</returns>
        public static ulong Fibonaccial(ulong N)
        {
            if (N == 0)
                return 1;

            ulong result = 1;

            List<ulong> fibonaccis = new List<ulong>();

            fibonaccis.Add(1);
            fibonaccis.Add(1);

            for(int i = 3; (ulong)i < N; i++)
            {
                // If next value in Fibonacci's order greater than subfunction N, stop calculations of order.
                if (fibonaccis[i - 2] + fibonaccis[i - 3] > N)
                    break;

                fibonaccis.Add(fibonaccis[i - 2] + fibonaccis[i - 3]);
            }

            foreach(ulong value in fibonaccis)
            {
                result *= value;
            }

            return result;
        }

        /// <summary>
        /// Subfactorial is defined as the number of disorder of order N, that is, permutations of order N without fixed points.
        /// </summary>
        /// <param name="N">A 32-bit non-negative integer from which the function will be calculated.</param>
        /// <returns>A calculation of function from given number. If N = 0 and N = 1: return 0.</returns>
        public static ulong Subfactorial(uint N)
        {
            // From the definition of subfactorial: the number of permutations of
            // a number or its disorder, zero and one have no disorder.
            if (N == 0 || N == 1)
                return 0;

            // Using exponental formula against OverflowException of 
            // formulas from standard combinatorics (function is too risky with big numbers).

            return Convert.ToUInt64(Factorial(N) / E);
        }
    }
}
