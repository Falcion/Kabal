using System;
using System.Collections.Generic;

namespace MathFX
{
    public static class MathFX
    {

        public static UInt64 Fct(UInt64 _enum)
        {

            if (_enum == 0)
                return 1;

            UInt64 _result = 1;

            for (UInt64 iterator = 1; iterator < _enum; iterator++)
            {
                _result *= iterator;
            }

            return _result;
        }

        public static UInt64 dFct(UInt64 _enum)
        {

            if (_enum == 0)
                return 1;

            UInt64 _result = 1;

            if (_enum % 2 == 0)
            {

                for (UInt64 iterator = 1; iterator < _enum; iterator += 2)
                {
                    _result *= iterator;
                }
            }
            else
            {
                for (UInt64 iterator = 1; (iterator < _enum && iterator % 2 == 1); iterator++)
                {
                    _result *= iterator;
                }
            }

            return _result;
        }

        public static UInt64 mtFct(UInt64 _enum, UInt64 mtp)
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
                    return dFct(_enum);
            }

            UInt64 _result = 1;

            for (UInt64 iterator = 1; (iterator < _enum && iterator % mtp == 0); iterator++)
            {
                _result *= iterator;
            }

            return _result;
        }

        public static UInt64 decFct(UInt64 _enum, UInt64 num)
        {

            if (_enum == 0)
                return 1;

            if (num == 0)
                return 0;

            UInt64 _result = _enum;

            for (UInt64 iterator = 1; iterator < num; iterator++)
            {
                _result *= (_enum - num);
            }

            return _result;
        }

        public static UInt64 upsFct(UInt64 _enum, UInt64 num)
        {

            if (_enum == 0)
                return 1;

            if (num == 0)
                return 0;

            UInt64 _result = _enum;

            for (UInt64 iterator = 1; iterator < num; iterator++)
            {
                _result *= (_enum + num);
            }

            return _result;
        }

        public static UInt64 Prm(UInt64 _enum)
        {

            if (_enum == 0)
                return 1;

            List<UInt64> Primes = new List<UInt64>();

            while (_enum % 2 == 0)
            {
                Primes.Add(2);
                _enum /= 2;
            }

            Double _sqrt
                = Math.Sqrt(_enum);

            for (UInt64 iterator = 3; iterator <= _sqrt; iterator += 2)
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
                List<UInt64> dList = Primes.FindAll(match
                                                  => match == number);

                if (dList.Count > 1)
                {
                    Primes.RemoveAll(match
                                   => match == number);
                    Primes.Add(number);
                }
            }

            UInt64 _result = 1;

            foreach (dynamic iterator in Primes)
            {
                _result *= iterator;
            }

            return _result;
        }
    }
}
