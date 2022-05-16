namespace Karamath.Algorithms {

    /// <summary>
    ///     Library module responsible for working and assembling different values and enumerables
    /// </summary>
    /// 
    public static class Enumerables {

        /// <summary>
        ///     Generates the Fibonacci's order in given range from one to given
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://mathworld.wolfram.com/FibonacciNumber.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="range">
        ///     An unsigned 32-bit integer value representing maximum range of Fibonacci's order
        /// </param>
        /// 
        /// <returns>
        ///     A list of an unsigned 32-bit values representing the Fibonacci's order
        /// </returns>
        /// 
        public static List<uint> Fibonacci(uint range) {

            List<uint> Fibonacci = new() { 1, 1 };

            for (int i = 2; i <= range; i++)
                Fibonacci.Add(Fibonacci[i - 1] + Fibonacci[i - 2]);

            return Fibonacci;
        }

        /// <summary>
        ///     Generates the Leonardo's order in given range from one to given
        /// </summary>
        /// 
        /// <param name="nmx">
        ///     An unsigned 32-bit integer value representing a position of number in Leonardo's numbers
        /// </param>
        /// 
        /// <returns>
        ///     An array of an unsigned 32-bit integers values representing a specified by position number in Leonardo's numbers
        /// </returns>
        ///  
        public static List<uint> Leonardo(uint range) {

            List<uint> Leonardo = new() { 1, 1 };

            for(int i = 2; i <= range; i++)
                Leonardo.Add(Leonardo[i - 1] + Leonardo[i - 2] + 1);

            return Leonardo;
        }

        /// <summary>
        ///     Generates an array of primes in given range from one to given
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://mathworld.wolfram.com/Primes.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="range">
        ///     An unsigned 32-bit integer value representing maximum range of primes array
        /// </param>
        /// 
        /// <returns>
        ///     A list of an unsigned 32-bit values representing the array of primes in given range
        /// </returns>
        ///
        public static List<uint> Primes(uint range) {

            List<uint> Primes = new();

            bool PRIMES = true;

            for (uint i = 0; i < range * 4; i++)
            {
                for (uint j = 2; j < range * 4; j++)
                    if (i != j && i % j == 0)
                    {
                        PRIMES = false;
                        break;
                    }

                if (PRIMES)
                    Primes.Add(i);

                PRIMES = true;
            }

            return Primes;
        }

        /// <summary>
        ///     Generates a hash set of prime divisors from given number with no repetitions
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://mathworld.wolfram.com/Factorization.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A 32-bit integer value on which factorization will be executed
        /// </param>
        /// 
        /// <returns>
        ///     A hash set of 32-bit integer values representing prime divisors of a given number
        /// </returns>
        /// 
        public static HashSet<int> Factorization(int amx) {

            HashSet<int> Primes = new();

            for(int i = 2; i <= amx; i++) {

                if(amx % i == 0) {

                    Primes.Add(i);

                    amx /= i;

                    i--;
                }
            }

            return Primes;
        }

        /// <summary>
        ///     Generates a string of after-point digits in PI constant
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://mathworld.wolfram.com/Pi.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="pos">
        ///     A 32-bit integer value representing count of digits after the point in PI constant
        /// </param>
        /// 
        /// <returns>
        ///     A string representing an array of digits after points in PI constant
        /// </returns>
        /// 
        public static string PointsPI(int pos) {

            /*
             * Using a trigonometry way for finding a PI's exact value.
             * It helps to discover more points after dot with only system bound.
             */

            double digits = 16 * Math.Atan(0.2) - 4 * Math.Atan(1 / 239);

            string res = Math.Round(digits, pos).ToString();

            return res;  
        }

        /// <summary>
        ///     Generates an array of primes with sieve of Eratosthenes
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://mathworld.wolfram.com/SieveofEratosthenes.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="range">
        ///     A 32-bit integer value representing range of an array of primes
        /// </param>
        ///     
        /// <returns>
        ///     A list of 32-bit integer values representing an array of primes of sieve of Eratosthenes
        /// </returns>
        /// 
        public static List<int> Eratosthenes(int range) {

            bool[] sieve = new bool[++range];

            List<int> Primes = new(++range);

            int coef = 2;

            while(coef * coef <= range) {
                
                sieve[coef * coef] = true;

                int multiple = coef * coef;

                while(multiple <= range) {
                    
                    sieve[multiple] = true;
                    multiple += coef;
                }

                for(int i = coef + 1; i <= range; i++)
                    if(!sieve[i]) {
                        coef = i;
                        break;
                    }
            }

            for(int i = 0; i <= range; i++)
                if(!sieve[i])
                    Primes.Add(i);

            return Primes;
        }

        /// <summary>
        ///     Generates an array of numbers with sieve of Atkin
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/sieve-of-atkin/">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="range">
        ///     A 32-bit integer value representing range of an array of numbers
        /// </param>
        ///     
        /// <returns>
        ///     A list of 32-bit integer values representing an array of numbers of sieve of Atkin
        /// </returns>
        /// 

        public static List<int> Atkin(int range) {

            List<int> res = new();

            if(range > 2)
                res.Add(2);
            else if(range > 3)
                res.Add(3);

            /*
             *  Initialising the sieve array with false values.
             */

            bool[] sieve = new bool[range++];

            for(int i = 0; i <= range; i++)
                sieve[i] = false;

            /*
             *  Formulae below are written just by scribing
             *  the formulae of Atkin's sieve.
             */

            for(int dx = 1; dx * dx <= range; dx++) {

                for(int dy = 1; dy * dy <= range; dy++) {

                    int dn = (4 * dx * dx) + (dy * dy);

                    if(dn <= range
                       && (dn % 12 == 1 || dn % 12 == 5))

                       sieve[dn] ^= true;

                    dn = (3 * dx * dx) + (dy * dy);

                    if(dn <= range && dn % 12 == 7)
                        sieve[dn] ^= true;

                    dn = (3 * dx * dx) + (dy * dy);

                    if(dx > dy && dn <= range
                       && dn % 12 == 11)
                       sieve[dn] ^= true;
                }
            }

            /*
             *  Marking all multiplies of squares as
             *  non-prime.
             */

            for(int dr = 5; dr * dr < range; dr++)
                if(sieve[dr])
                    for(int di = dr * dr; di < range; di += dr * dr)
                        sieve[di] = false;

            for(int da = 5; da <= range; da++)
                if(sieve[da])
                    res.Add(da);

            return res;
        }

        /// <summary>
        ///     Finds number of steps to get unity according to the Collatz hypothesis
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://mathworld.wolfram.com/CollatzProblem.html">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A 32-bit integer number on which algorithm will reproduce Collatz hypothesis
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing number of steps to get unity
        /// </returns>
        /// 
        public static int Collatz(int amx) {

            if (amx == 1)
                return 0;
            else if (amx % 2 == 0)
                return 1 + Collatz(amx % 2);
            else
                return 1 + Collatz(amx * 3 + 1);
        }

        /// <summary>
        ///     Finds approximate equiality of numbers within given tolerance
        /// </summary>
        /// 
        /// <param name="amx">
        ///     A double value representing first number in an approximate comprasion expression
        /// </param>
        /// <param name="mmx">
        ///     A double value representing second number in an approximate comprasion expression
        /// </param>
        /// <param name="ddx">
        ///     A 64-bit integer value representing representation to tolerance of how big an error is tolerated
        /// </param>
        /// 
        /// <returns>
        ///     A boolean value representing result of an approximate comprasion expression of two given numbers
        /// </returns>
        /// 
        public static bool Approximate(double amx, double mmx, long ddx) {

            long bamx = BitCTL(amx);
            long bmmx = BitCTL(mmx);

            long fpoint = Math.Abs(bamx - bmmx);

            return (fpoint <= ddx);
        }

        /// <summary>
        ///     Converts given number to bits to compelement in approximate
        /// </summary>
        /// 
        /// <param name="amx">
        ///     A double value which will be complemented to bits
        /// </param>
        /// 
        /// <returns>
        ///     A 64-bit integer value representing a complementary form in bits of given number
        /// </returns>
        /// 
        public static unsafe long BitCTL(double amx) {

            double* ptr = &amx;

            long* lprt = (long*)ptr;
            long res = *lprt;

            return res < 0
                ? (long)(0x8000000000000000 - (ulong)res)
                : res;
        }

        /// <summary>
        ///     Calculates a GCD of two numbers with recursive method
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/c-program-find-gcd-hcf-two-numbers/?ref=lbp">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A 32-bit integer value representing a first number
        /// </param>
        /// <param name="bmx">
        ///     A 32-bit integer value representing a second number
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing a GCD of two numbers
        /// </returns>
        /// 
        public static int GCD(int amx, int bmx) {

            if(amx == 0)
                return bmx;

            return GCD(bmx % amx, amx);
        }

        /// <summary>
        ///     Calculates a LCM of two numbers with help of GCD function
        /// </summary>
        /// 
        /// <remarks>
        ///     For the definition and details of this topic: go to the 
        ///     <see href="https://www.geeksforgeeks.org/program-to-find-lcm-of-two-numbers/?ref=lbp">
        ///         origin
        ///     </see>
        /// </remarks>
        /// 
        /// <param name="amx">
        ///     A 32-bit integer value representing a first number
        /// </param>
        /// <param name="bmx">
        ///     A 32-bit integer value representing a second number
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing a LCM of two numbers
        /// </returns>
        /// 
        public static int LCM(int amx, int bmx) {

            return (amx / GCD(amx, bmx)) * bmx;
        }
    }
}