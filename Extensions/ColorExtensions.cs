using System;
using System.Drawing;

namespace DIST.Extensions
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Binary conversion
        /// </summary>
        public static String ToBinary(this Color colour)
        {

            //bin = bin.PadLeft(8, '0');

            var a = colour.A;
            var a1 = Convert.ToString(a, 2).PadLeft(8, '0');

            var r = colour.R;
            var r1 = Convert.ToString(r, 2).PadLeft(8, '0');

            var g = colour.G;
            var g1 = Convert.ToString(g, 2).PadLeft(8, '0');

            var b = colour.B;
            var b1 = Convert.ToString(b, 2).PadLeft(8, '0');

            return a1 + r1 + g1 + b1;
        }


        /// <summary>
        /// Passes in a colour object, chnages LSB (of Aplha) to 'chartoEmbedd'
        /// </summary>
        /// <param name="originalColour">Original colour - before steg is applied</param>
        /// <param name="charToEmbedd">character to embed in the image</param>
        /// <returns>New colour with required steg changes applied</returns>
        public static Color ToStegColour(this Color originalColour, char charToEmbedd)
        {

            //replace last bin char with steg char
            var binColour = originalColour.ToBinary();
            binColour = binColour.Substring(0, 31);
            binColour += charToEmbedd;

            //split into 4 bin strings
            var colours = binColour.SplitIntoChucks(8);

            //cast into colour object
            var a = Convert.ToInt32(colours[0], 2);
            var r = Convert.ToInt32(colours[1], 2);
            var g = Convert.ToInt32(colours[2], 2);
            var b = Convert.ToInt32(colours[3], 2);

            var newColour = Color.FromArgb(a, r, g, b);

            return newColour;

        }
    }
}
