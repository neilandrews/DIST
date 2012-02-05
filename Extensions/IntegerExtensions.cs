using System;

namespace DIST.Extensions
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Generates a binary string representing the number of characters hidden in the image, padded to 24 bits
        /// This makes decoding more efficient.
        /// </summary>
        /// <param name="length">Number of characters to embedd in image</param>
        /// <returns>Binary string - padded to 24 characters</returns>
        public static string LengthStampToBinary(this int length)
        {
            return Convert.ToString(length, 2).PadLeft(24, '0');
        }
    }
}
