using System;
using System.Collections.Generic;
using System.Text;

namespace DIST.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns an integer representing the number of pixels required to hide a given string
        /// </summary>
        /// <param name="message">A member of the string class</param>
        /// <returns>Integer representing the number of pixels required to encode the message</returns>
        public static int PixelsRequiredToHide(this string message)
        {
            return (message.Length * 8) + 24;
        }


        /// <summary>
        /// Converts a plain text string to a binary string
        /// </summary>
        /// <param name="message">String object to be converted</param>
        /// <returns>The converted string - to binary</returns>
        public static String ToBinaryString(this string message)
        {
            var binString = "";

            var encoding = new ASCIIEncoding();
            var chars = encoding.GetBytes(message);

            for (var i = 0; i < chars.Length; i++)
            {
                var b = chars[i];
                var bin = Convert.ToString(b, 2).PadLeft(8, '0');

                binString += bin;
            }

            return binString;
        }


        /// <summary>
        /// Splits a string into chunks, of a specified size
        /// </summary>
        /// <param name="binaryString">Binary string - Shold be 32 bits in this instance</param>
        /// <param name="chunkSize">Size of chunks to be created</param>
        /// <returns>List of binary strings (RGBA)</returns>
        public static List<string> SplitIntoChucks(this string binaryString, int chunkSize)
        {
            var chunks = new List<string>();

            var offset = 0;
            while (offset < binaryString.Length)
            {
                var size = Math.Min(chunkSize, binaryString.Length - offset);
                chunks.Add(binaryString.Substring(offset, size));
                offset += size;
            }
            return chunks;
        }


        /// <summary>
        /// Converts a binary string to byte array - required for further processing with built in ASCII conversion methods
        /// </summary>
        /// <param name="binaryString">A binary string</param>
        /// <returns>byte array</returns>
        public static byte[] BinaryToByteArray(this string binaryString)
        {
            //convert binary string to byte array
            var numOfBytes = binaryString.Length / 8;
            var bytes = new byte[numOfBytes];

            for (int i = 0; i < numOfBytes; i++)
            {
                bytes[i] = Convert.ToByte(binaryString.Substring(8 * i, 8), 2);
            }
            return bytes;
        }
    }
}
