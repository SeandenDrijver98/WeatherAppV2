namespace WeatherAppV2
{
    partial class WeatherView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherView));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.pnlFullReport = new System.Windows.Forms.Panel();
            this.lblPrecipitation = new System.Windows.Forms.Label();
            this.pbPrecipitation = new System.Windows.Forms.PictureBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.pbHumidity = new System.Windows.Forms.PictureBox();
            this.lblWindspeed = new System.Windows.Forms.Label();
            this.pbWind = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.pbConditions = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dateSearch = new System.Windows.Forms.DateTimePicker();
            this.pnlWeeklyForecast = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTownName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFullReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecipitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "City :";
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetWeather.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeather.ForeColor = System.Drawing.Color.Black;
            this.btnGetWeather.Location = new System.Drawing.Point(62, 334);
            this.btnGetWeather.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(167, 39);
            this.btnGetWeather.TabIndex = 2;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = false;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // pnlFullReport
            // 
            this.pnlFullReport.BackColor = System.Drawing.Color.Transparent;
            this.pnlFullReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFullReport.Controls.Add(this.lblDate);
            this.pnlFullReport.Controls.Add(this.lblTownName);
            this.pnlFullReport.Controls.Add(this.lblPrecipitation);
            this.pnlFullReport.Controls.Add(this.pbPrecipitation);
            this.pnlFullReport.Controls.Add(this.lblHumidity);
            this.pnlFullReport.Controls.Add(this.pbHumidity);
            this.pnlFullReport.Controls.Add(this.lblWindspeed);
            this.pnlFullReport.Controls.Add(this.pbWind);
            this.pnlFullReport.Controls.Add(this.groupBox1);
            this.pnlFullReport.Controls.Add(this.lblMaxTemp);
            this.pnlFullReport.Controls.Add(this.lblMinTemp);
            this.pnlFullReport.Controls.Add(this.pbConditions);
            this.pnlFullReport.Location = new System.Drawing.Point(401, 82);
            this.pnlFullReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFullReport.Name = "pnlFullReport";
            this.pnlFullReport.Size = new System.Drawing.Size(820, 291);
            this.pnlFullReport.TabIndex = 20;
            // 
            // lblPrecipitation
            // 
            this.lblPrecipitation.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecipitation.Location = new System.Drawing.Point(591, 204);
            this.lblPrecipitation.Name = "lblPrecipitation";
            this.lblPrecipitation.Size = new System.Drawing.Size(120, 73);
            this.lblPrecipitation.TabIndex = 16;
            this.lblPrecipitation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbPrecipitation
            // 
            this.pbPrecipitation.Image = ((System.Drawing.Image)(resources.GetObject("pbPrecipitation.Image")));
            this.pbPrecipitation.Location = new System.Drawing.Point(714, 205);
            this.pbPrecipitation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPrecipitation.Name = "pbPrecipitation";
            this.pbPrecipitation.Size = new System.Drawing.Size(91, 69);
            this.pbPrecipitation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrecipitation.TabIndex = 15;
            this.pbPrecipitation.TabStop = false;
            // 
            // lblHumidity
            // 
            this.lblHumidity.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(591, 116);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(120, 73);
            this.lblHumidity.TabIndex = 14;
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbHumidity
            // 
            this.pbHumidity.Image = ((System.Drawing.Image)(resources.GetObject("pbHumidity.Image")));
            this.pbHumidity.Location = new System.Drawing.Point(716, 116);
            this.pbHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbHumidity.Name = "pbHumidity";
            this.pbHumidity.Size = new System.Drawing.Size(91, 69);
            this.pbHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumidity.TabIndex = 13;
            this.pbHumidity.TabStop = false;
            // 
            // lblWindspeed
            // 
            this.lblWindspeed.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindspeed.Location = new System.Drawing.Point(591, 32);
            this.lblWindspeed.Name = "lblWindspeed";
            this.lblWindspeed.Size = new System.Drawing.Size(120, 73);
            this.lblWindspeed.TabIndex = 12;
            this.lblWindspeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbWind
            // 
            this.pbWind.Image = ((System.Drawing.Image)(resources.GetObject("pbWind.Image")));
            this.pbWind.Location = new System.Drawing.Point(714, 32);
            this.pbWind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbWind.Name = "pbWind";
            this.pbWind.Size = new System.Drawing.Size(91, 69);
            this.pbWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWind.TabIndex = 11;
            this.pbWind.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(296, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(154, 11);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxTemp.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(286, 88);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(163, 69);
            this.lblMaxTemp.TabIndex = 0;
            this.lblMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinTemp.Font = new System.Drawing.Font("Georgia", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(287, 187);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(163, 68);
            this.lblMinTemp.TabIndex = 8;
            this.lblMinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbConditions
            // 
            this.pbConditions.BackColor = System.Drawing.Color.Transparent;
            this.pbConditions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbConditions.Image = ((System.Drawing.Image)(resources.GetObject("pbConditions.Image")));
            this.pbConditions.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbConditions.InitialImage")));
            this.pbConditions.Location = new System.Drawing.Point(33, 88);
            this.pbConditions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbConditions.Name = "pbConditions";
            this.pbConditions.Size = new System.Drawing.Size(201, 167);
            this.pbConditions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConditions.TabIndex = 6;
            this.pbConditions.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(393, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 43);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Daily Weather Report";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.White;
            this.cmbCity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Cape Town",
            "Johannesburg",
            "Durban",
            "Stellenbosch",
            "Pretoria"});
            this.cmbCity.Location = new System.Drawing.Point(62, 186);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(292, 32);
            this.cmbCity.TabIndex = 0;
            this.cmbCity.Text = "Select a Town..";
            // 
            // dateSearch
            // 
            this.dateSearch.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch.Location = new System.Drawing.Point(62, 269);
            this.dateSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(292, 30);
            this.dateSearch.TabIndex = 1;
            // 
            // pnlWeeklyForecast
            // 
            this.pnlWeeklyForecast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeeklyForecast.Location = new System.Drawing.Point(66, 459);
            this.pnlWeeklyForecast.MaximumSize = new System.Drawing.Size(1155, 180);
            this.pnlWeeklyForecast.Name = "pnlWeeklyForecast";
            this.pnlWeeklyForecast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlWeeklyForecast.Size = new System.Drawing.Size(1155, 180);
            this.pnlWeeklyForecast.TabIndex = 24;
            // 
            // lblTownName
            // 
            this.lblTownName.AutoSize = true;
            this.lblTownName.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownName.Location = new System.Drawing.Point(38, 20);
            this.lblTownName.Name = "lblTownName";
            this.lblTownName.Size = new System.Drawing.Size(0, 35);
            this.lblTownName.TabIndex = 17;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(325, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 35);
            this.lblDate.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 43);
            this.label4.TabIndex = 26;
            this.label4.Text = "Weekly Weather Report";
            // 
            // WeatherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlWeeklyForecast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.pnlFullReport);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dateSearch);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WeatherView";
            this.Size = new System.Drawing.Size(1280, 707);
            this.pnlFullReport.ResumeLayout(false);
            this.pnlFullReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecipitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConditions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Panel pnlFullReport;
        private System.Windows.Forms.Label lblPrecipitation;
        private System.Windows.Forms.PictureBox pbPrecipitation;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.PictureBox pbHumidity;
        private System.Windows.Forms.Label lblWindspeed;
        private System.Windows.Forms.PictureBox pbWind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.PictureBox pbConditions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dateSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlWeeklyForecast;
        private System.Windows.Forms.Label lblTownName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
