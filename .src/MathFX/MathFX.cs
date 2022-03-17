using System;
using System.Collections.Generic;

namespace MathFX
{
    public static class MathFX
    {
        //*
        /*  Declaring exponental functions declare number.
         *  Eulers number.
         */
        //*

        public const double E = 2.7182818284590452353602874713527;

        //*
        /*
         *  Function: a default factorial.
         *  Description: is the product of all positive integers less than or equal to number.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong Fct(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            ulong _result = 1;

            for (ulong iterator = 1; iterator <= _enum; iterator++)
            {
                _result *= iterator;
            }

            return _result;
        }

        //*
        /*
         *  Function: a factorion.
         *  Description: is the product of all factorials of all integer char-numbers of given enum.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong Foi(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            ulong _result = 1;

            string strNum = Convert.ToString(_enum);

            foreach(dynamic charNum in strNum)
            {
                _result *= Fct(Convert.ToUInt64(charNum));
            }

            return _result;
        }

        //*
        /*
         *  Function: a super-factorial.
         *  Description: is the product of all factorials of all positive integers less than or equal to number.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong SpFct(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            ulong _result = 1;

            for (ulong iterator = 1; iterator < _enum; iterator++)
            {
                _result *= Fct(iterator);
            }

            return _result;
        }

        //*
        /*
         *  Function: a hyper-factorial.
         *  Description: is the product of all superfactorials of all positive integers less than or equal to number.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong HpFct(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            ulong _result = 1;

            for (ulong iterator = 1; iterator < _enum; iterator++)
            {
                _result *= SpFct(iterator);
            }

            return _result;
        }

        //*
        /*
         *  Function: a double-factorial.
         *  Description: if the number is even, the function will count the factorials of even numbers, applies to odd numbers too.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong DbFct(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            ulong _result = 1;

            if (_enum % 2 == 0)
            {

                for (ulong iterator = 1; iterator < _enum; iterator += 2)
                {
                    _result *= iterator;
                }
            }
            else
            {
                for (ulong iterator = 1; (iterator < _enum && iterator % 2 == 1); iterator++)
                {
                    _result *= iterator;
                }
            }

            return _result;
        }

        //*
        /*
         *  Function: a multiple-factorial.
         *  Description: if the number is a multiple of the sought one, then the sought factorials are counted.
         *  Input: non-negative integer number, non-negative multiple number.
         *  Commentary: default and double factorials are special cases of the multiple-factorial as for first and second numbers of multiple number.
         */
        //*

        public static ulong MtFct(ulong _enum, ulong mtp)
        {

            if (_enum == 0)
                return 1;

            if (mtp >= _enum)
                return 0;

            switch (mtp)
            {
                case 0:
                    return 0;

                case 1:
                    return Fct(_enum);

                case 2:
                    return DbFct(_enum);
            }

            ulong _result = 1;

            for (ulong iterator = 1; (iterator < _enum && iterator % mtp == 0); iterator++)
            {
                _result *= iterator;
            }

            return _result;
        }

        //*
        /*
         *  Function: a decreasing factorial.
         *  Description: counts the number of different sequences of number distinct items that can be drawn from a universe of 
         *               numbered items in type of decreasing function.
         *  Input: non-negative integer number, non-negative items number.
         */
        //*

        public static ulong DecFct(ulong _enum, ulong num)
        {

            if (_enum == 0)
                return 1;

            if (num == 0)
                return 0;

            ulong _result = _enum;

            for (ulong iterator = 1; iterator < num; iterator++)
            {
                _result *= (_enum - num);
            }

            return _result;
        }

        //*
        /*
         *  Function: an increasing factorial.
         *  Description: counts the number of different sequences of number distinct items that can be drawn from a universe of 
         *               numbered items in type of increasing function.
         *  Input: non-negative integer number, non-negative items number.
         */
        //*

        public static ulong UpsFct(ulong _enum, ulong num)
        {

            if (_enum == 0)
                return 1;

            if (num == 0)
                return 0;

            ulong _result = _enum;

            for (ulong iterator = 1; iterator < num; iterator++)
            {
                _result *= (_enum + num);
            }

            return _result;
        }

        //*
        /*
         *  Function: a primorial.
         *  Description: is defined as the product of first prime numbers to range of number.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong Prm(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            List<ulong> Primes = new List<ulong>();

            while (_enum % 2 == 0)
            {
                Primes.Add(2);
                _enum /= 2;
            }

            Double _sqrt
                = Math.Sqrt(_enum);

            for (ulong iterator = 3; iterator <= _sqrt; iterator += 2)
            {
                while (_enum % iterator == 0)
                {
                    Primes.Add(iterator);
                    _enum /= iterator;
                }

            }

            if (_enum > 2)
                Primes.Add(_enum);

            foreach (dynamic number in Primes)
            {
                List<ulong> dList = Primes.FindAll(match
                                                  => match == number);

                if (dList.Count > 1)
                {
                    Primes.RemoveAll(match
                                   => match == number);
                    Primes.Add(number);
                }
            }

            ulong _result = 1;

            foreach (dynamic number in Primes)
            {
                _result *= number;
            }

            return _result;
        }

        //*
        /*
         *  Function: a fibonarial either called as fibonaccial.
         *  Description: is defined as the product of first fibbonaci numbers to range of number.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong Fbr(ulong _enum)
        {

            if (_enum == 0)
                return 1;

            ulong _result = 1;

            List<ulong> Fibonacci = new List<ulong>();

            Fibonacci.Add(1);
            Fibonacci.Add(1);

            for (int iterator = 3; Convert.ToUInt64(iterator) <= _enum; iterator++)
            {
                Fibonacci.Add(
                        Fibonacci[iterator - 2] + Fibonacci[iterator - 3]
                    );
            }

            foreach (dynamic number in Fibonacci)
            {
                _result *= number;
            }

            return _result;
        }

        //*
        /*
         *  Function: a subfactorial
         *  Description: yields the number of derangements of a set of enum objects.
         *  Input: non-negative integer number.
         */
        //*

        public static ulong SubFct(ulong _enum)
        {
            
            if(_enum == 0)
                    return 1;

            ulong _result = 1;

            /*
             * Using a exponental formula of subfactorial in the case of protection 
             * against violation of the upper limit value.
             */

            _result = Convert.ToUInt64(
                                    Fct(_enum) / E);

            return _result;
        }
    }
}
