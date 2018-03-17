using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minVal, int maxVal)
        {
            byte[] randomNumber = new byte[1];

            generator.GetBytes(randomNumber);

            double asciiValOfRandomChar = Convert.ToDouble(randomNumber[0]);

            double multiplier = Math.Max(0, (asciiValOfRandomChar / 255d) - 0.00000000001d);

            int range = maxVal - minVal + 1;

            double randomValInRange = Math.Floor(multiplier * range);

            return (int)(minVal + randomValInRange);
        }
    }
}
