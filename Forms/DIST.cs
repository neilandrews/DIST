using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using NLog;
using DIST.Algorithms;

namespace DIST.Forms
{
    public partial class DIST: Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public DIST()
        {
            InitializeComponent();
            Logger.Info("Application Launched");
        }


        #region EMBEDDING: Followiing code handles embedding requests

        /// <summary>
        /// Opens file browser - sets textbox text to selected path
        /// </summary>
        private void ButtonBrowseFilesClick(object sender, EventArgs e)
        {
            openFileDialog_imageSelect.Title = "Select Image for Steganalysis";
            openFileDialog_imageSelect.Filter = "JPG Files|*.jpg|JPEG Files|*.jpeg";

            openFileDialog_imageSelect.ShowDialog();
            encoding_textBox_imagePath.Text = openFileDialog_imageSelect.FileName;
        }


        /// <summary>
        /// Copies file to local directory - then displays in picture_box
        /// </summary>
        private void ButtonImageUploadClick(object sender, EventArgs e)
        {
            try
            {
                var savePath = Directory.GetCurrentDirectory();
                savePath = savePath.Substring(0, savePath.Length - 9) + "Uploads\\ORIG" + Utilities.Utilities.GetTimeStamp() + ".jpg";
                File.Copy(encoding_textBox_imagePath.Text, savePath);

                encoding_pictureBox_mainImage.BorderStyle = BorderStyle.FixedSingle;
                encoding_pictureBox_mainImage.SizeMode = PictureBoxSizeMode.StretchImage;
                encoding_pictureBox_mainImage.Image = Image.FromFile(savePath);

                Logger.Info("Image uploaded for encoding");

            }
            catch (Exception ex)
            {
                Logger.ErrorException(ex.Message, ex);
            }
        }


        /// <summary>
        /// Creates new instance of algorithm, then sends for embedding of data
        /// </summary>
        private void ButtonHideMessageClick(object sender, EventArgs e)
        {
            var message = encoding_textBox_secretMessage.Text;
            var path = encoding_textBox_imagePath.Text;

            var dist = new BaseAlgorithm();
            dist.Embed(path, message);
        }

        #endregion


        #region EXTRACTION: Following code handles extraction requests

        /// <summary>
        /// Opens file browser - sets textbox text to selected path
        /// </summary>
        private void DecodingButtonBrowseFilesClick(object sender, EventArgs e)
        {
            openFileDialog_imageSelect.Title = "Select Image to Extract";
            openFileDialog_imageSelect.Filter = "JPG Files|*.jpg|JPEG Files|*.jpeg";

            openFileDialog_imageSelect.ShowDialog();
            decoding_textBox_imagePath.Text = openFileDialog_imageSelect.FileName;
        }


        /// <summary>
        /// Copies file to local directory - then displays in picture_box
        /// </summary>
        private void DecodingButtonImageUploadClick(object sender, EventArgs e)
        {
            try
            {
                decoding_pictureBox_mainImage.BorderStyle = BorderStyle.FixedSingle;
                decoding_pictureBox_mainImage.SizeMode = PictureBoxSizeMode.StretchImage;
                decoding_pictureBox_mainImage.Image = Image.FromFile(decoding_textBox_imagePath.Text);

                Logger.Info("Image uploaded for decoding");

            }
            catch (Exception ex)
            {
                Logger.ErrorException(ex.Message, ex);
            }
        }


        /// <summary>
        /// Creates new instance of algorithm, then sends for extraction of data
        /// </summary>
        private void DecodingButtonDecodeMessageClick(object sender, EventArgs e)
        {
            if (encoding_pictureBox_mainImage != null)
            {
                var dist = new BaseAlgorithm();
                var extractedText = dist.Extract(decoding_textBox_imagePath.Text);

                decoding_textBox_secretMessage.Text = extractedText;
            }
        }

        #endregion
    }
}