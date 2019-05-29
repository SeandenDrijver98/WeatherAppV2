namespace WeatherAppV2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlView = new System.Windows.Forms.Panel();
            this.btnViewWeather = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlView.Location = new System.Drawing.Point(0, 53);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1280, 707);
            this.pnlView.TabIndex = 1;
            // 
            // btnViewWeather
            // 
            this.btnViewWeather.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWeather.Location = new System.Drawing.Point(-1, 0);
            this.btnViewWeather.Name = "btnViewWeather";
            this.btnViewWeather.Size = new System.Drawing.Size(322, 55);
            this.btnViewWeather.TabIndex = 0;
            this.btnViewWeather.Text = "View";
            this.btnViewWeather.UseVisualStyleBackColor = true;
            this.btnViewWeather.Click += new System.EventHandler(this.btnViewWeather_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(958, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(321, 55);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(320, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(639, 55);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WeatherWatcher";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Location = new System.Drawing.Point(639, 0);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(320, 55);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Visible = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyse.Location = new System.Drawing.Point(320, 0);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(320, 55);
            this.btnAnalyse.TabIndex = 5;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Visible = false;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlNavbar.Controls.Add(this.pnlTitle);
            this.pnlNavbar.Controls.Add(this.btnViewWeather);
            this.pnlNavbar.Controls.Add(this.btnSignOut);
            this.pnlNavbar.Controls.Add(this.btnAnalyse);
            this.pnlNavbar.Controls.Add(this.btnCapture);
            this.pnlNavbar.Location = new System.Drawing.Point(1, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(1279, 55);
            this.pnlNavbar.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.pnlNavbar);
            this.Controls.Add(this.pnlView);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherWatcher";
            this.pnlTitle.ResumeLayout(false);
            this.pnlNavbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button btnViewWeather;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlNavbar;
    }
}

