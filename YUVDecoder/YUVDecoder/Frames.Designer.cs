namespace YUVDecoder
{
    partial class Frames
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxFrames = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonReplay = new System.Windows.Forms.Button();
            this.labelFPS = new System.Windows.Forms.Label();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrames)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFrames
            // 
            this.pictureBoxFrames.Location = new System.Drawing.Point(35, 29);
            this.pictureBoxFrames.Name = "pictureBoxFrames";
            this.pictureBoxFrames.Size = new System.Drawing.Size(380, 310);
            this.pictureBoxFrames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrames.TabIndex = 0;
            this.pictureBoxFrames.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonReplay
            // 
            this.buttonReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplay.Location = new System.Drawing.Point(227, 417);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(141, 41);
            this.buttonReplay.TabIndex = 1;
            this.buttonReplay.Text = "Tekrar Oynat";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Click += new System.EventHandler(this.ButtonReplay_Click);
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFPS.Location = new System.Drawing.Point(83, 425);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(48, 23);
            this.labelFPS.TabIndex = 23;
            this.labelFPS.Text = "FPS:";
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFPS.Location = new System.Drawing.Point(137, 425);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(51, 27);
            this.textBoxFPS.TabIndex = 22;
            this.textBoxFPS.Tag = "";
            this.textBoxFPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFPS_KeyPress);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.Location = new System.Drawing.Point(95, 359);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(87, 41);
            this.buttonPause.TabIndex = 24;
            this.buttonPause.Text = "Durdur";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.Location = new System.Drawing.Point(246, 359);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(109, 41);
            this.buttonResume.TabIndex = 25;
            this.buttonResume.Text = "Devam Et";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.ButtonResume_Click);
            // 
            // Frames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(450, 480);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.textBoxFPS);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.pictureBoxFrames);
            this.Name = "Frames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frames";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFrames;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonReplay;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonResume;
    }
}