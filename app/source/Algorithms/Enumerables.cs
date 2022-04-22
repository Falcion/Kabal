namespace MathFX.Algorithms
{

    public static class Enumerables
    {

        /// <summary>
        ///     Function generating a fibonacci's number to given one
        /// </summary>
        ///
        /// <returns>
        ///     List of unsigned 32-bit integer values of fibonacci's order
        /// </returns>
        /// 
        public static List<uint> Fibonacci(uint number)
        {

            List<uint> Fibbonaci = new() { 1, 1 };

            for (int i = 3; i <= number; i++)
                Fibbonaci.Add(Fibbonaci[i - 2] + Fibbonaci[i - 3]);

            return Fibbonaci;
        }

        /// <summary>
        ///     Function generating an array of primes to given one
        /// </summary>
        /// 
        /// <returns>
        ///     List of unsigned 32-bit integer values of primes
        /// </returns>
        /// 
        public static List<uint> Primes(uint number)
        {

            List<uint> Primes = new();

            bool IS_PRIME = true;

            for (uint i = 0; i < number * 4; i++)
            {
                for (uint j = 2; j < number * 4; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        IS_PRIME = false;
                        break;
                    }
                }

                if (IS_PRIME)
                    Primes.Add(i);

                IS_PRIME = true;
            }

            return Primes;
        }

        /// <summary>
        ///     Function of decomposing a number into its prime factors
        /// </summary>
        /// 
        /// <returns>
        ///     A set of integers hashes: array with no repeats of exclusive values of prime factors
        /// </returns>
        /// 
        public static HashSet<int> Factorization(int number)
        {

            HashSet<int> Primes = new();

            int QR = number;

            for(int i = 2; i <= QR; i++)
            {
                if(QR % i == 0)
                {
                    Primes.Add(i);

                    QR /= i;

                    i--;
                }
            }

            return Primes;
        }

        /// <summary>
        ///     Function generating string with digits to given pos of constant PI
        /// </summary>
        /// 
        /// <returns>
        ///     A string of digits of given range of constant PI
        /// </returns>
        /// 
        public static string PointsPI(int digit)
        {

            double DECIMAL = (16 * Math.Atan(0.2) - 4 * Math.Atan(1 / 239));

            string DIGs = Convert.ToString(Math.Round(DECIMAL, digit));

            return DIGs;
        }

        /// <summary>
        ///     Function of sieve of Eratosthenes about finding primes under ten millions
        /// </summary>
        /// 
        /// <returns>
        ///     List of 32-bit integer values of primes
        /// </returns>
        /// 
        public static List<int> Eratosthenes(int limit)
        {

            bool[] sieve = new bool[++limit];

            List<int> Primes = new(++limit);

            int P = 2;

            while(P * P <= limit)
            {
                sieve[P * P] = true;

                int multiple = P * P;

                while(multiple <= limit)
                {
                    sieve[multiple] = true;
                    multiple += P;
                }

                for(int i = P + 1; i <= limit; i++)
                {
                    if(!sieve[i])
                    {
                        P = i;
                        break;
                    }
                }
            }

            for(int i = 0; i <= limit; i++)
            {
                if(!sieve[i])
                    Primes.Add(i);
            }

            return Primes;
        }

        /// <summary>
        ///     An Function of Collatz' recursive conjecture algorithm
        /// </summary>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing number of steps to get unity according to the Collatz hypothesis
        /// </returns>
        /// 
        public static int Collatz(int number)
        {

            if (number == 1)
                return 0;
            else if (number % 2 == 0)
                return 1 + Collatz(number % 2);
            else
                return 1 + Collatz(number * 3 + 1);
        }
    }
}
