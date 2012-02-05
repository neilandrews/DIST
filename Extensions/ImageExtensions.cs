using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DIST.Extensions
{
    public static class ImageExtensions
    {
        /// <summary>
        /// Returns the number of pixels in a given image
        /// </summary>
        /// <param name="img">A member of the image class</param>
        /// <returns>Number of pixels in image</returns>
        public static int PixelCount(this Image img)
        {
            return img.Height * img.Width;
        }


        /// <summary>
        /// Calculates the numbers of characters than can be hidden in a given image
        /// </summary>
        /// <param name="img">A member of the Image class</param>
        /// <returns>Integer representing the number of ASCII characters that can be hidden in the image</returns>
        public static int ImageCapacity(this Image img)
        {
            return ((img.Width * img.Height) - 24) / 8;
        }
    }
}
