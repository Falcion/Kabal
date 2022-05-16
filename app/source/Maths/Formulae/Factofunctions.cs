using CTM 
    = Karamath.Maths.Constants;
using EMC 
    = Karamath.Algorithms.Enumerables;

namespace Karamath.Maths {

    /// <summary>
    ///     Library module responsible for counting and factorial functions
    /// </summary>
    /// 
    public static class Factofunctions {

        /// <summary>
        ///     Calculates the default factorial from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Factorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of factorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the product of natural numbers from one to the given one
        /// </returns>
        /// 
        public static uint Fct(uint max) {
            
            if(max == 0)
                return 1;

            uint res = 1;

            for(uint i = 1; i <= max; i++)
                res *= i;

            return res;
        }

        /// <summary>
        ///     Calculates the default factorial from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Factorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 64-bit integer value representing the maximum range of factorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 64-bit integer value representing the product of natural numbers from one to the given one
        /// </returns>
        /// 
        public static ulong Fct(ulong max)
        {

            if (max == 0)
                return 1;

            ulong res = 1;

            for (ulong i = 1; i <= max; i++)
                res *= i;

            return res;
        }

        /// <summary>
        ///     Calculates the factorion depending on its order from digits of given number
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Factorion.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="number">
        ///     An unsigned 32-bit integer value representing the given number for factorion
        /// </param>
        /// <param name="order">
        ///     A signed 8-bit integer value representing the order of factorion: first is about of sum when the second is product
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the sum or product of number's factorials of digits 
        /// </returns>
        /// 
        public static uint Foi(uint number, byte order) {

            if(number == 0)
                return 1;

            uint res = 0;

            string digits = number.ToString();

            if(order == 1) {
                foreach(char digit in digits)
                    res += Fct(Convert.ToUInt32(digit));
            }
                
            if(order == 2) {

                res = 1;

                foreach(char digit in digits)
                    res *= Fct(Convert.ToUInt32(digit));
            }

            return res;
        }

        /// <summary>
        ///     Calculates the superfactorial from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Superfactorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 64-bit integer value representing the maximum range of superfactorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 64-bit integer value representing the product of factorials of natural numbers from one to the given one
        /// </returns>
        /// 
        public static ulong Sft(ulong max) {

            if(max == 0)
                return 1;

            ulong res = 1;

            for(ulong i = 1; i <= max; i++)
                res *= Fct(i);

            return res;
        }

        /// <summary>
        ///     Calculates the hyperfactorial from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Hyperfactorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 64-bit integer value representing the maximum range of hyperfactorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 64-bit integer value representing the product of superfactorials of natural numbers from one to the given one
        /// </returns>
        /// 
        public static ulong Hft(ulong max) {

            if(max == 0)
                return 1;

            ulong res = 1;

            for(ulong i = 1; i < max; i++) {

                /*
                 *  Creating a max resulting limit for caughting overhelming values situtations.
                 */

                ulong LIMIT = res;

                res *= Sft(i);

                if(res != LIMIT * Sft(i)) {
                    res = LIMIT;
                    break;
                }
            }

            return res;
        }

        /// <summary>
        ///     Calculates the double factorial from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/DoubleFactorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of double factorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the product of numbers with the same parity as given number range
        /// </returns>
        /// 
        public static uint Dft(uint max) {

            if(max == 0)
                return 1;

            uint res = 0;

            if(max % 2 == 0) {

                res = 2;

                for(uint i = 2; i <= max - 2; i += 2) 
                    res *= i;
            }
            else {
                
                for(uint i = 1; i <= max; i++)
                    if(i % 2 != 0)
                        res *= i;
                    
            }

            return res;
        }

        /// <summary>
        ///     Calculates the multiply factorial from one to the given number range and the coefficient of multiplicities
        /// </summary>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of multiple factorial
        /// </param>
        /// <param name="divisor">
        ///     An unsigned 32-bit integer value representing the coefficient of multiplicities
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the product of number which are multiples to given coefficient
        /// </returns>
        /// 
        public static uint Mft(uint max, uint divisor) {

            if(max == 0)
                return 1;

            if(divisor >= max)
                return 0;

            if(divisor == 0)
                return 0;
            else if(divisor == 1)
                return Fct(max);
            else if(divisor == 2)
                return Dft(max);

            uint res = 1;

            for(uint i = 1; i < max; i++)
                if(i % divisor == 0)
                    res *= i;

            return res;
        }

        /// <summary>
        ///     Calculates the falling factorial function from one to given number range and the coefficient of decreasing
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/FallingFactorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of falling factorial
        /// </param>
        /// <param name="coef">
        ///     An unsigned 32-bit integer value representing the coefficient of falling
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the result of strict formulae
        /// </returns>
        /// 
        public static uint Fft(uint max, uint coef) {

            if(max == 0)
                return 1;

            if(coef == 0)
                return 0;
            if(coef == max)
                return 0;

            uint res = Fct(max);

            res /= Fct(max - coef);

            return res;
        }

        /// <summary>
        ///     Calculates the increasing factorial function from one to given number range and the coefficient of increasing
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/RisingFactorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of increasing factorial
        /// </param>
        /// <param name="coef">
        ///     An unsigned 32-bit integer value representing the coefficient of increasing
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the result of strict formulae
        /// </returns>
        /// 
        public static uint Ift(uint max, uint coef) {

            if(max == 0)
                return 1;

            if(coef == 0)
                return 0;
            if(coef == max)
                return 0;

            uint res = Fct(max + --coef);

            res /= Fct(--max);

            return res;
        }

        /// <summary>
        ///     Calculates a primorial from prime numbers in range from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Primorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of primorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the product of prime numbers in given range
        /// </returns>
        ///
        public static uint Prm(uint max) {

            if(max == 0)
                return 1;
            else if(max == 1)
                return 1;

            List<uint> Primes = new();

            bool PRIMES = true;

            /*
             *  Algorithm of finding number's primes.
             *  Also imported in enumerables modules.
             */

            for (uint i = 0; i < max * 4; i++)
            {
                for (uint j = 2; j < max * 4; j++)
                    if (i != j && i % j == 0)
                    {
                        PRIMES = false;
                        break;
                    }

                if (PRIMES)
                    Primes.Add(i);

                PRIMES = true;
            }

            uint res = 1;

            /* 
             *  Reaching out array of multipliers for a given length, not for the entire array
             *  for the correct calculation.
             */

            for(int i = 0; i < max; i++)
                res *= Primes[i];

            return res;
        }

        /// <summary>
        ///     Calculates a fibonorial from Fibonacci's numbers in range from one to the given number range
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Fibonorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="max">
        ///     An unsigned 32-bit integer value representing the maximum range of fibonorial
        /// </param>
        /// 
        /// <returns>
        ///     An unsigned 32-bit integer value representing the product of Fibonacci's numbers in given range
        /// </returns>
        /// 
        public static uint Fbn(uint max) {

            if(max == 0)
                return 1;
            else if(max == 1)
                return 1;

            uint res = 1;

            List<uint> Fibbonaci = new() { 1, 1 };

            for (int i = 3; i <= max; i++)
                Fibbonaci.Add(Fibbonaci[i - 2] + Fibbonaci[i - 3]);

            /* 
             *  Reaching out array of multipliers for a given length, not for the entire array
             *  for the correct calculation.
             */

            for(int i = 0; i < max; i++)
                res *= Fibbonaci[i];

            return res;
        }

        /// <summary>
        ///     Calculates a subfactorial or a number of disorders of given number
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this factofunction: go to the 
        ///     <see href="https://mathworld.wolfram.com/Subfactorial.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A double type value representing the given number from which disorders would be calculated
        /// </param>
        /// 
        /// <returns>
        ///     A double type value representing the value of disorders count of given number
        /// </returns>
        /// 
        public static double Sbf(double amx) {

            if(amx == 0.0)
                return 0;
            else if(amx == 1.0)
                return 0;

            double disorders = 1.0;

            for (double i = 1.0; i <= amx; i++)
                disorders *= i;


            disorders /= Constants.E;

            return disorders;
        }
    }
}