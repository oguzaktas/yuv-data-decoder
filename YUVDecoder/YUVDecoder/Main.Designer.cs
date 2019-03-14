namespace YUVDecoder
{
    partial class Main
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelPixelFormat = new System.Windows.Forms.Label();
            this.comboBoxPixelFormat = new System.Windows.Forms.ComboBox();
            this.labelSelectFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(395, 22);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(118, 41);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Dosya Sec";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFile.Location = new System.Drawing.Point(543, 31);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(136, 24);
            this.textBoxFile.TabIndex = 2;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilePath.Location = new System.Drawing.Point(300, 78);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(379, 24);
            this.textBoxFilePath.TabIndex = 3;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.Location = new System.Drawing.Point(325, 149);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(81, 27);
            this.labelSettings.TabIndex = 4;
            this.labelSettings.Text = "Ayarlar";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "YUV 4:4:4",
            "YUV 4:2:2",
            "YUV 4:2:0"});
            this.comboBoxFormat.Location = new System.Drawing.Point(85, 233);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(123, 28);
            this.comboBoxFormat.TabIndex = 5;
            this.comboBoxFormat.Tag = "";
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFormat_SelectedIndexChanged);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidth.Location = new System.Drawing.Point(327, 276);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(51, 27);
            this.textBoxWidth.TabIndex = 6;
            this.textBoxWidth.Tag = "";
            this.textBoxWidth.Visible = false;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWidth_KeyPress);
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(294, 339);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(143, 41);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "Dosyayi Oku";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(276, 422);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(179, 41);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Goruntuyu Oynat";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(271, 276);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(50, 23);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "Size:";
            this.labelSize.Visible = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(409, 276);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(51, 27);
            this.textBoxHeight.TabIndex = 11;
            this.textBoxHeight.Tag = "";
            this.textBoxHeight.Visible = false;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHeight_KeyPress);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(384, 276);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(19, 23);
            this.labelX.TabIndex = 12;
            this.labelX.Text = "x";
            this.labelX.Visible = false;
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxResolution.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Items.AddRange(new object[] {
            "QCIF (176x144)",
            "CIF (352x288)",
            "D1 (720x576)",
            "1920x1080",
            "Custom"});
            this.comboBoxResolution.Location = new System.Drawing.Point(290, 233);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(159, 28);
            this.comboBoxResolution.TabIndex = 13;
            this.comboBoxResolution.Tag = "";
            this.comboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResolution_SelectedIndexChanged);
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormat.Location = new System.Drawing.Point(81, 193);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(116, 23);
            this.labelFormat.TabIndex = 14;
            this.labelFormat.Text = "YUV Format:";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(286, 193);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(163, 23);
            this.labelResolution.TabIndex = 15;
            this.labelResolution.Text = "Image Resolution:";
            // 
            // labelPixelFormat
            // 
            this.labelPixelFormat.AutoSize = true;
            this.labelPixelFormat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPixelFormat.Location = new System.Drawing.Point(527, 193);
            this.labelPixelFormat.Name = "labelPixelFormat";
            this.labelPixelFormat.Size = new System.Drawing.Size(119, 23);
            this.labelPixelFormat.TabIndex = 19;
            this.labelPixelFormat.Text = "Pixel Format:";
            // 
            // comboBoxPixelFormat
            // 
            this.comboBoxPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPixelFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPixelFormat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxPixelFormat.FormattingEnabled = true;
            this.comboBoxPixelFormat.Items.AddRange(new object[] {
            "Planar",
            "Packed"});
            this.comboBoxPixelFormat.Location = new System.Drawing.Point(531, 233);
            this.comboBoxPixelFormat.Name = "comboBoxPixelFormat";
            this.comboBoxPixelFormat.Size = new System.Drawing.Size(115, 28);
            this.comboBoxPixelFormat.TabIndex = 18;
            this.comboBoxPixelFormat.Tag = "";
            this.comboBoxPixelFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPixelFormat_SelectedIndexChanged);
            // 
            // labelSelectFile
            // 
            this.labelSelectFile.AutoSize = true;
            this.labelSelectFile.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectFile.Location = new System.Drawing.Point(51, 31);
            this.labelSelectFile.Name = "labelSelectFile";
            this.labelSelectFile.Size = new System.Drawing.Size(324, 23);
            this.labelSelectFile.TabIndex = 1;
            this.labelSelectFile.Text = "Okunacak .yuv uzantılı dosyayi seciniz";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(731, 508);
            this.Controls.Add(this.labelPixelFormat);
            this.Controls.Add(this.comboBoxPixelFormat);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.comboBoxResolution);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelSelectFile);
            this.Controls.Add(this.buttonSelect);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YUV (YCbCr) Decoder";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelPixelFormat;
        private System.Windows.Forms.ComboBox comboBoxPixelFormat;
        private System.Windows.Forms.Label labelSelectFile;
    }
}

