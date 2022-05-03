namespace MathFX.Randomize
{

    public static class KernRND
    {
        public enum NUM_TYPES
        {
            INT32,
            INT64,
            UINT32,
            UINT64,
            FLOAT,
            DOUBLE,
            DECIMAL,
            SINGLE
        }

        public static dynamic? RND_NUM(NUM_TYPES type, dynamic[] limits)
        {
            if (limits.Length > 2 || limits.Length < 1)
                return null;

            switch(type)
            {
                case NUM_TYPES.INT32:
                    int rnd_int32 = new Random().Next(limits[0], 
                                                      limits[1]);

                    return rnd_int32;
                        
                case NUM_TYPES.INT64:
                    long rnd_int64 = new Random().NextInt64(limits[0], 
                                                            limits[1]);

                    return rnd_int64;

                case NUM_TYPES.UINT32:
                    int rnd_uint32 = new Random().Next(limits[0], 
                                                       limits[1]);

                    if (rnd_uint32 < 0)
                        rnd_uint32 *= -1;

                    return rnd_uint32;

                case NUM_TYPES.UINT64:
                    long rnd_uint64 = new Random().NextInt64(limits[0], 
                                                             limits[1]);

                    if (rnd_uint64 < 0)
                        rnd_uint64 *= -1;

                    return rnd_uint64;

                case NUM_TYPES.FLOAT:
                    float point_float = new Random().NextSingle();

                    float float_div = limits[0] * limits[1];

                    float float_sum = float_div + point_float;

                    return float_sum;

                case NUM_TYPES.DOUBLE:
                    double point_double = new Random().NextDouble();

                    double pre_point = limits[0] * limits[1];

                    double db_sum_rd = pre_point + point_double;

                    return db_sum_rd;

                case NUM_TYPES.DECIMAL:
                    double point_dec = new Random().NextDouble();

                    double decimal_div = limits[0] * limits[1];

                    double decimal_sum = decimal_div + point_dec;

                    return (decimal)(decimal_sum);

                default:
                    return null;
            }
        }

        public static string? RND_STRING()
        {

        }
    }
}
