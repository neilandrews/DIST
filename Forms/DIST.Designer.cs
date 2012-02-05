namespace DIST.Forms
{
    partial class DIST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog_imageSelect = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encoding_pictureBox_mainImage = new System.Windows.Forms.PictureBox();
            this.encoding_groupBox_settings = new System.Windows.Forms.GroupBox();
            this.encoding_label_stegAlgo = new System.Windows.Forms.Label();
            this.encoding_comboBox_Algo = new System.Windows.Forms.ComboBox();
            this.encoding_button_HideMessage = new System.Windows.Forms.Button();
            this.encoding_label_hiddenMessage = new System.Windows.Forms.Label();
            this.encoding_textBox_secretMessage = new System.Windows.Forms.TextBox();
            this.encoding_groupbox_uplod = new System.Windows.Forms.GroupBox();
            this.encoding_button_imageUpload = new System.Windows.Forms.Button();
            this.encoding_textBox_imagePath = new System.Windows.Forms.TextBox();
            this.encoding_button_browseFiles = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decoding_groupbox_settings = new System.Windows.Forms.GroupBox();
            this.decoding_label_stegAlgo = new System.Windows.Forms.Label();
            this.decoding_comboBox_Algo = new System.Windows.Forms.ComboBox();
            this.decoding_button_DecodeMessage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decoding_textBox_secretMessage = new System.Windows.Forms.TextBox();
            this.decoding_groupbox_uplod = new System.Windows.Forms.GroupBox();
            this.decoding_button_imageUpload = new System.Windows.Forms.Button();
            this.decoding_textBox_imagePath = new System.Windows.Forms.TextBox();
            this.decoding_button_browseFiles = new System.Windows.Forms.Button();
            this.decoding_pictureBox_mainImage = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encoding_pictureBox_mainImage)).BeginInit();
            this.encoding_groupBox_settings.SuspendLayout();
            this.encoding_groupbox_uplod.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.decoding_groupbox_settings.SuspendLayout();
            this.decoding_groupbox_uplod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decoding_pictureBox_mainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_imageSelect
            // 
            this.openFileDialog_imageSelect.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encoding_pictureBox_mainImage);
            this.tabPage1.Controls.Add(this.encoding_groupBox_settings);
            this.tabPage1.Controls.Add(this.encoding_groupbox_uplod);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encoding";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encoding_pictureBox_mainImage
            // 
            this.encoding_pictureBox_mainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encoding_pictureBox_mainImage.Location = new System.Drawing.Point(203, 12);
            this.encoding_pictureBox_mainImage.Name = "encoding_pictureBox_mainImage";
            this.encoding_pictureBox_mainImage.Size = new System.Drawing.Size(322, 302);
            this.encoding_pictureBox_mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.encoding_pictureBox_mainImage.TabIndex = 5;
            this.encoding_pictureBox_mainImage.TabStop = false;
            // 
            // encoding_groupBox_settings
            // 
            this.encoding_groupBox_settings.Controls.Add(this.encoding_label_stegAlgo);
            this.encoding_groupBox_settings.Controls.Add(this.encoding_comboBox_Algo);
            this.encoding_groupBox_settings.Controls.Add(this.encoding_button_HideMessage);
            this.encoding_groupBox_settings.Controls.Add(this.encoding_label_hiddenMessage);
            this.encoding_groupBox_settings.Controls.Add(this.encoding_textBox_secretMessage);
            this.encoding_groupBox_settings.Location = new System.Drawing.Point(9, 120);
            this.encoding_groupBox_settings.Name = "encoding_groupBox_settings";
            this.encoding_groupBox_settings.Size = new System.Drawing.Size(188, 194);
            this.encoding_groupBox_settings.TabIndex = 4;
            this.encoding_groupBox_settings.TabStop = false;
            this.encoding_groupBox_settings.Text = "Steg Settings";
            // 
            // encoding_label_stegAlgo
            // 
            this.encoding_label_stegAlgo.AutoSize = true;
            this.encoding_label_stegAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoding_label_stegAlgo.Location = new System.Drawing.Point(18, 26);
            this.encoding_label_stegAlgo.Name = "encoding_label_stegAlgo";
            this.encoding_label_stegAlgo.Size = new System.Drawing.Size(86, 13);
            this.encoding_label_stegAlgo.TabIndex = 4;
            this.encoding_label_stegAlgo.Text = "Select Algorithm:";
            // 
            // encoding_comboBox_Algo
            // 
            this.encoding_comboBox_Algo.FormattingEnabled = true;
            this.encoding_comboBox_Algo.Items.AddRange(new object[] {
            "Basic Encoding"});
            this.encoding_comboBox_Algo.Location = new System.Drawing.Point(18, 45);
            this.encoding_comboBox_Algo.Name = "encoding_comboBox_Algo";
            this.encoding_comboBox_Algo.Size = new System.Drawing.Size(153, 21);
            this.encoding_comboBox_Algo.TabIndex = 3;
            // 
            // encoding_button_HideMessage
            // 
            this.encoding_button_HideMessage.Location = new System.Drawing.Point(18, 158);
            this.encoding_button_HideMessage.Name = "encoding_button_HideMessage";
            this.encoding_button_HideMessage.Size = new System.Drawing.Size(153, 22);
            this.encoding_button_HideMessage.TabIndex = 2;
            this.encoding_button_HideMessage.Text = "Hide Message!";
            this.encoding_button_HideMessage.UseVisualStyleBackColor = true;
            this.encoding_button_HideMessage.Click += new System.EventHandler(this.ButtonHideMessageClick);
            // 
            // encoding_label_hiddenMessage
            // 
            this.encoding_label_hiddenMessage.AutoSize = true;
            this.encoding_label_hiddenMessage.Location = new System.Drawing.Point(15, 79);
            this.encoding_label_hiddenMessage.Name = "encoding_label_hiddenMessage";
            this.encoding_label_hiddenMessage.Size = new System.Drawing.Size(90, 13);
            this.encoding_label_hiddenMessage.TabIndex = 1;
            this.encoding_label_hiddenMessage.Text = "Hidden Message:";
            // 
            // encoding_textBox_secretMessage
            // 
            this.encoding_textBox_secretMessage.Location = new System.Drawing.Point(18, 99);
            this.encoding_textBox_secretMessage.Multiline = true;
            this.encoding_textBox_secretMessage.Name = "encoding_textBox_secretMessage";
            this.encoding_textBox_secretMessage.Size = new System.Drawing.Size(153, 53);
            this.encoding_textBox_secretMessage.TabIndex = 0;
            // 
            // encoding_groupbox_uplod
            // 
            this.encoding_groupbox_uplod.Controls.Add(this.encoding_button_imageUpload);
            this.encoding_groupbox_uplod.Controls.Add(this.encoding_textBox_imagePath);
            this.encoding_groupbox_uplod.Controls.Add(this.encoding_button_browseFiles);
            this.encoding_groupbox_uplod.Location = new System.Drawing.Point(9, 12);
            this.encoding_groupbox_uplod.Name = "encoding_groupbox_uplod";
            this.encoding_groupbox_uplod.Size = new System.Drawing.Size(188, 102);
            this.encoding_groupbox_uplod.TabIndex = 3;
            this.encoding_groupbox_uplod.TabStop = false;
            this.encoding_groupbox_uplod.Text = "File Selection";
            // 
            // encoding_button_imageUpload
            // 
            this.encoding_button_imageUpload.Location = new System.Drawing.Point(42, 48);
            this.encoding_button_imageUpload.Name = "encoding_button_imageUpload";
            this.encoding_button_imageUpload.Size = new System.Drawing.Size(129, 21);
            this.encoding_button_imageUpload.TabIndex = 2;
            this.encoding_button_imageUpload.Text = "Upload";
            this.encoding_button_imageUpload.UseVisualStyleBackColor = true;
            this.encoding_button_imageUpload.Click += new System.EventHandler(this.ButtonImageUploadClick);
            // 
            // encoding_textBox_imagePath
            // 
            this.encoding_textBox_imagePath.Location = new System.Drawing.Point(42, 22);
            this.encoding_textBox_imagePath.Name = "encoding_textBox_imagePath";
            this.encoding_textBox_imagePath.Size = new System.Drawing.Size(129, 20);
            this.encoding_textBox_imagePath.TabIndex = 1;
            // 
            // encoding_button_browseFiles
            // 
            this.encoding_button_browseFiles.Location = new System.Drawing.Point(7, 20);
            this.encoding_button_browseFiles.Name = "encoding_button_browseFiles";
            this.encoding_button_browseFiles.Size = new System.Drawing.Size(29, 23);
            this.encoding_button_browseFiles.TabIndex = 0;
            this.encoding_button_browseFiles.Text = ">";
            this.encoding_button_browseFiles.UseVisualStyleBackColor = true;
            this.encoding_button_browseFiles.Click += new System.EventHandler(this.ButtonBrowseFilesClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decoding_groupbox_settings);
            this.tabPage2.Controls.Add(this.decoding_groupbox_uplod);
            this.tabPage2.Controls.Add(this.decoding_pictureBox_mainImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decoding";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decoding_groupbox_settings
            // 
            this.decoding_groupbox_settings.Controls.Add(this.decoding_label_stegAlgo);
            this.decoding_groupbox_settings.Controls.Add(this.decoding_comboBox_Algo);
            this.decoding_groupbox_settings.Controls.Add(this.decoding_button_DecodeMessage);
            this.decoding_groupbox_settings.Controls.Add(this.label3);
            this.decoding_groupbox_settings.Controls.Add(this.decoding_textBox_secretMessage);
            this.decoding_groupbox_settings.Location = new System.Drawing.Point(9, 120);
            this.decoding_groupbox_settings.Name = "decoding_groupbox_settings";
            this.decoding_groupbox_settings.Size = new System.Drawing.Size(188, 194);
            this.decoding_groupbox_settings.TabIndex = 8;
            this.decoding_groupbox_settings.TabStop = false;
            this.decoding_groupbox_settings.Text = "Steg Settings";
            // 
            // decoding_label_stegAlgo
            // 
            this.decoding_label_stegAlgo.AutoSize = true;
            this.decoding_label_stegAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decoding_label_stegAlgo.Location = new System.Drawing.Point(18, 26);
            this.decoding_label_stegAlgo.Name = "decoding_label_stegAlgo";
            this.decoding_label_stegAlgo.Size = new System.Drawing.Size(135, 13);
            this.decoding_label_stegAlgo.TabIndex = 4;
            this.decoding_label_stegAlgo.Text = "Select Decoding Algorithm:";
            // 
            // decoding_comboBox_Algo
            // 
            this.decoding_comboBox_Algo.FormattingEnabled = true;
            this.decoding_comboBox_Algo.Items.AddRange(new object[] {
            "Basic Decoding"});
            this.decoding_comboBox_Algo.Location = new System.Drawing.Point(18, 45);
            this.decoding_comboBox_Algo.Name = "decoding_comboBox_Algo";
            this.decoding_comboBox_Algo.Size = new System.Drawing.Size(153, 21);
            this.decoding_comboBox_Algo.TabIndex = 3;
            // 
            // decoding_button_DecodeMessage
            // 
            this.decoding_button_DecodeMessage.Location = new System.Drawing.Point(18, 158);
            this.decoding_button_DecodeMessage.Name = "decoding_button_DecodeMessage";
            this.decoding_button_DecodeMessage.Size = new System.Drawing.Size(153, 22);
            this.decoding_button_DecodeMessage.TabIndex = 2;
            this.decoding_button_DecodeMessage.Text = "Extract Message!";
            this.decoding_button_DecodeMessage.UseVisualStyleBackColor = true;
            this.decoding_button_DecodeMessage.Click += new System.EventHandler(this.DecodingButtonDecodeMessageClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Decoded Message:";
            // 
            // decoding_textBox_secretMessage
            // 
            this.decoding_textBox_secretMessage.Location = new System.Drawing.Point(18, 99);
            this.decoding_textBox_secretMessage.Multiline = true;
            this.decoding_textBox_secretMessage.Name = "decoding_textBox_secretMessage";
            this.decoding_textBox_secretMessage.Size = new System.Drawing.Size(153, 53);
            this.decoding_textBox_secretMessage.TabIndex = 0;
            // 
            // decoding_groupbox_uplod
            // 
            this.decoding_groupbox_uplod.Controls.Add(this.decoding_button_imageUpload);
            this.decoding_groupbox_uplod.Controls.Add(this.decoding_textBox_imagePath);
            this.decoding_groupbox_uplod.Controls.Add(this.decoding_button_browseFiles);
            this.decoding_groupbox_uplod.Location = new System.Drawing.Point(9, 12);
            this.decoding_groupbox_uplod.Name = "decoding_groupbox_uplod";
            this.decoding_groupbox_uplod.Size = new System.Drawing.Size(188, 102);
            this.decoding_groupbox_uplod.TabIndex = 7;
            this.decoding_groupbox_uplod.TabStop = false;
            this.decoding_groupbox_uplod.Text = "File Selection";
            // 
            // decoding_button_imageUpload
            // 
            this.decoding_button_imageUpload.Location = new System.Drawing.Point(42, 48);
            this.decoding_button_imageUpload.Name = "decoding_button_imageUpload";
            this.decoding_button_imageUpload.Size = new System.Drawing.Size(129, 21);
            this.decoding_button_imageUpload.TabIndex = 2;
            this.decoding_button_imageUpload.Text = "Upload";
            this.decoding_button_imageUpload.UseVisualStyleBackColor = true;
            this.decoding_button_imageUpload.Click += new System.EventHandler(this.DecodingButtonImageUploadClick);
            // 
            // decoding_textBox_imagePath
            // 
            this.decoding_textBox_imagePath.Location = new System.Drawing.Point(42, 22);
            this.decoding_textBox_imagePath.Name = "decoding_textBox_imagePath";
            this.decoding_textBox_imagePath.Size = new System.Drawing.Size(129, 20);
            this.decoding_textBox_imagePath.TabIndex = 1;
            // 
            // decoding_button_browseFiles
            // 
            this.decoding_button_browseFiles.Location = new System.Drawing.Point(7, 20);
            this.decoding_button_browseFiles.Name = "decoding_button_browseFiles";
            this.decoding_button_browseFiles.Size = new System.Drawing.Size(29, 23);
            this.decoding_button_browseFiles.TabIndex = 0;
            this.decoding_button_browseFiles.Text = ">";
            this.decoding_button_browseFiles.UseVisualStyleBackColor = true;
            this.decoding_button_browseFiles.Click += new System.EventHandler(this.DecodingButtonBrowseFilesClick);
            // 
            // decoding_pictureBox_mainImage
            // 
            this.decoding_pictureBox_mainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decoding_pictureBox_mainImage.Location = new System.Drawing.Point(203, 12);
            this.decoding_pictureBox_mainImage.Name = "decoding_pictureBox_mainImage";
            this.decoding_pictureBox_mainImage.Size = new System.Drawing.Size(322, 302);
            this.decoding_pictureBox_mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.decoding_pictureBox_mainImage.TabIndex = 6;
            this.decoding_pictureBox_mainImage.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(539, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 379);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DIST - Digital image Steganorgaphy Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.encoding_pictureBox_mainImage)).EndInit();
            this.encoding_groupBox_settings.ResumeLayout(false);
            this.encoding_groupBox_settings.PerformLayout();
            this.encoding_groupbox_uplod.ResumeLayout(false);
            this.encoding_groupbox_uplod.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.decoding_groupbox_settings.ResumeLayout(false);
            this.decoding_groupbox_settings.PerformLayout();
            this.decoding_groupbox_uplod.ResumeLayout(false);
            this.decoding_groupbox_uplod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decoding_pictureBox_mainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_imageSelect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox encoding_pictureBox_mainImage;
        private System.Windows.Forms.GroupBox encoding_groupBox_settings;
        private System.Windows.Forms.Button encoding_button_HideMessage;
        private System.Windows.Forms.Label encoding_label_hiddenMessage;
        private System.Windows.Forms.TextBox encoding_textBox_secretMessage;
        private System.Windows.Forms.GroupBox encoding_groupbox_uplod;
        private System.Windows.Forms.Button encoding_button_imageUpload;
        private System.Windows.Forms.TextBox encoding_textBox_imagePath;
        private System.Windows.Forms.Button encoding_button_browseFiles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox encoding_comboBox_Algo;
        private System.Windows.Forms.Label encoding_label_stegAlgo;
        private System.Windows.Forms.PictureBox decoding_pictureBox_mainImage;
        private System.Windows.Forms.GroupBox decoding_groupbox_settings;
        private System.Windows.Forms.Label decoding_label_stegAlgo;
        private System.Windows.Forms.ComboBox decoding_comboBox_Algo;
        private System.Windows.Forms.Button decoding_button_DecodeMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decoding_textBox_secretMessage;
        private System.Windows.Forms.GroupBox decoding_groupbox_uplod;
        private System.Windows.Forms.Button decoding_button_imageUpload;
        private System.Windows.Forms.TextBox decoding_textBox_imagePath;
        private System.Windows.Forms.Button decoding_button_browseFiles;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

