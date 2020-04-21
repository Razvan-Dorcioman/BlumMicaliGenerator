using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigNumberGenerator
{
    class PrimitiveRoots
    {
        public static BigInteger GetPrimitiveRootOfSafePrime(BigInteger safePrime)
        {
            //safe primes are either (+2 or -2) % safePrime
            var md = safePrime % 8;

            if (md == 3) return 2;
            if (md == 7) return safePrime - 2;

            return 0;  //we just don't know what it is
        }
    }
}
