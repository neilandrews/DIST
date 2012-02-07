using System;
using System.IO;
using System.Drawing;
using DIST.Extensions;
using NLog;

namespace DIST.Algorithms
{
    class BaseAlgorithm
    {
        /// <summary>
        /// Checks some required conditions (does the image have adequate capacity etc), then generates
        /// binaries to embed into image.
        /// </summary>
        /// <param name="imagePath">Path of selected/uploaded image (application path)</param>
        /// <param name="message">Plain text message to be embedded</param>
        public void Embed(string imagePath, string message)
        {

            var lengthStamp = message.Length;

            var img = new Bitmap(imagePath);
            var imageCapacity = img.ImageCapacity();

            if (imageCapacity >= message.PixelsRequiredToHide())
            {
                var lengthStampBin = lengthStamp.LengthStampToBinary();
                var messageBin = message.ToBinaryString();

                var binMessage = lengthStampBin + messageBin;

                PerformEmbedding(binMessage, imagePath);
            }
        }


        /// <summary>
        /// Creates copy of uploaded image, performs embedding of data.
        /// </summary>
        /// <param name="binMessage">Binary string to be embedded into image</param>
        /// <param name="imgPath">Path of selected/uploaded image (application path)</param>
        private static void PerformEmbedding(string binMessage, string imgPath)
        {
            //make copy of original - perfrom steg on new copy of image
            var savePath = Directory.GetCurrentDirectory();
            var savePath1 = savePath.Substring(0, savePath.Length - 9) + "Uploads\\NSTEG" + Utilities.Utilities.GetTimeStamp() + ".jpg";
            var savePath2 = savePath.Substring(0, savePath.Length - 9) + "Uploads\\STEG" + Utilities.Utilities.GetTimeStamp() + ".jpg";

            File.Copy(imgPath, savePath1);

            var newImg = new Bitmap(savePath1, false);

            var myImage = new Bitmap(newImg);
            var binCount = 0;
            var doBreak = false;

            for (var i = 0; i < newImg.Width; i++)
            {
                for (var j = 0; j < newImg.Height; j++)
                {
                    if (binCount >= binMessage.Length)
                    {
                        doBreak = true;
                        break;
                    }

                    //curr character to be imbedded in pixel/image
                    var currBinChar = binMessage[binCount];
                    binCount++;

                    //get current pixel colour - apply steg rules, get new colour
                    var curPixelColour = myImage.GetPixel(i, j);
                    var newPixelColour = curPixelColour.ToStegColour(currBinChar);

                    //Set pixel colour
                    myImage.SetPixel(i, j, newPixelColour);
                }

                if (doBreak)
                {
                    break;
                }
            }

            myImage.Save(savePath2);


            File.Delete(savePath1);
        }


        /// <summary>
        /// Some basic validation then requests extraction of data.
        /// </summary>
        /// <param name="imagePath">Path of selected/uploaded image (application path)</param>
        public string Extract(string imagePath)
        {
            var extractedMessage = "";

            if (!string.IsNullOrEmpty(imagePath))
            {
                //call action method
                extractedMessage = PerformExtraction(imagePath);
            }
            return extractedMessage;
        }


        /// <summary>
        /// Performs extraction of data.
        /// </summary>
        /// <param name="imagePath">Path of selected/uploaded image (application path)</param>
        /// <returns>plain text string, the embedded message</returns>
        private static string PerformExtraction(string imagePath)
        {
            var image = new Bitmap(imagePath);
            var binString = "";

            var count = 0;
            var doBreak = false;

            var messageLength = Utilities.Utilities.GetEbmeddedMessageLength(image) * 8;

            //calculates starting x & y values - i.e. disregard first 24 pixels (message length)
            var startX = int.Parse(Math.Floor((Double)24 / image.Width).ToString());
            var startY = 24 % image.Width;

            for (var x = startX; x < image.Width; x++)
            {
                for (var y = startY; y < image.Height; y++)
                {
                    //iterate through pixels 'messageLength' times
                    if (count >= messageLength)
                    {
                        doBreak = true;
                        break;
                    }

                    //get LSB of 'B' to binary
                    var currPixel = image.GetPixel(x, y);
                    var pixelBinary = Convert.ToString(currPixel.B, 2).PadLeft(8, '0');

                    //concatenate to string
                    binString += pixelBinary[pixelBinary.Length - 1];
                    count++;
                }

                if (doBreak)
                {
                    break;
                }
            }

            var byteArray = binString.BinaryToByteArray();

            var ASCII = new System.Text.ASCIIEncoding();
            var binToASCII = ASCII.GetString(byteArray);

            return binToASCII;
        }
    }
}
