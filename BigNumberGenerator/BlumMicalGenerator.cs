using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigNumberGenerator
{
    class BlumMicalGenerator
    {
        readonly BigInteger _seed;
        readonly BigInteger _safePrime;
        readonly BigInteger _primitiveRoot;
        BigInteger _intermed;

        public BlumMicalGenerator(BigInteger seed, BigInteger safePrime, BigInteger primitiveRoot)
        {
            _seed = seed;
            _safePrime = safePrime;
            _primitiveRoot = primitiveRoot;
            _intermed = BigInteger.ModPow(_primitiveRoot, _seed, _safePrime);
        }

        public byte GetNextRandomBit()
        {
            _intermed = BigInteger.ModPow(_primitiveRoot, _intermed, _safePrime);
            if (_intermed < ((_safePrime - 1) / 2)) return 1;
            return 0;
        }

        public byte GetNextRandomByte()
        {
            var xx = 0;
            byte res = 0;
            while (xx < 8)
            {
                var b = GetNextRandomBit();
                res += (byte)(b * Math.Pow(2, xx));
                xx++;
            }
            return res;
        }

        public byte[] GetRandomBytes(int num)
        {
            var res = new List<byte>();
            while (res.Count < num) res.Add(GetNextRandomByte());
            return res.ToArray();
        }
    }
}
