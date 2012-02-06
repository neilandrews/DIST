using System;
using System.Drawing;
using System.IO;
using NLog;

namespace DIST.Utilities
{
    class Utilities
    {
        /// <summary>
        /// Generates a timestamp - used for file names (year-month-day-hour-minute-second)
        /// </summary>
        /// <returns>Time stamp string</returns>
        public static String GetTimeStamp()
        {
            var date = DateTime.Now;            
            //return String.Format("{0:00}", date.Year) + String.Format("{0:00}", date.Month) + String.Format("{0:00}", date.Day) + String.Format("{0:00}", date.Hour) + String.Format("{0:00}", date.Minute) + String.Format("{0:00}", date.Second);
            var stamp = date.ToString("ddMMyyyyHH.mm.ss");
            return stamp;
        }

        /// <summary>
        /// Clears the directory uploaded images are saved
        /// </summary>
        public static void ClearImageDirectory()
        {
            //Logger 
            var logger = LogManager.GetCurrentClassLogger();

            var imageStoreDir = Directory.GetCurrentDirectory();
            imageStoreDir = imageStoreDir.Substring(0, imageStoreDir.Length - 9) + "Uploads\\";

            var imageStore = new DirectoryInfo(imageStoreDir);

            foreach (FileInfo f in imageStore.GetFiles())
            {
                f.Delete();
            }

            logger.Info("Image store directory cleared");
        }

        /// <summary>
        /// Reads the secret 'header' that specifies the actual amount of embedded data,
        /// The is used to increase efficiency of data extraction.
        /// </summary>
        /// <returns>Length of embedded message</returns>
        public static int GetEbmeddedMessageLength(Image image)
        {
            var count = 0;
            var binString = "";
            var doBreak = false;

            var img = (Bitmap) image;

            for (var i = 0; i < image.Width; i++)
            {
                for (var j = 0; j < image.Height; j++)
                {

                    if (count == 24)
                    {
                        doBreak = true;
                        break;
                    }

                    //cast image to Bitmap - then get pixel
                    var px = img.GetPixel(i, j);

                    //get 'B' colour - conver to Binary then take last bit
                    var colour = px.B;
                    var colourBin = Convert.ToString(colour, 2).PadLeft(8, '0');

                    binString += colourBin[colourBin.Length - 1];
                    count++;
                }

                if (doBreak)
                {
                    break;
                }
            }

            return Convert.ToInt32(binString, 2);
        }
    }
}
