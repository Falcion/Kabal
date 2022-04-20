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
        public static List<uint> Fibonacci(uint N)
        {
            List<uint> Fibbonaci = new List<uint>() { 1, 1 };

            for (int i = 3; i <= N; i++)
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
        public static List<uint> Primes(uint N)
        {
            uint PRIMES_RANGE = N * N;

            List<uint> Primes = new List<uint>();

            bool IS_PRIME = true;

            for (uint i = 0; i < N * 4; i++)
            {
                for (uint j = 2; j < N * 4; j++)
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
        public static HashSet<int> Factorization(int N)
        {
            HashSet<int> Primes = new HashSet<int>();

            int QR = N;

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

        public static HashSet<int> Eratosthenes()
        {
            return new HashSet<int>();
        }

        public static HashSet<int> Collatz()
        {
            return new HashSet<int>();
        }
    }
}
