namespace WeatherAppV2
{
    partial class AnalyseWeatherView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyseWeatherView));
            this.pnlData = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.chbWindspeed = new System.Windows.Forms.CheckBox();
            this.chbHumidity = new System.Windows.Forms.CheckBox();
            this.chbPrecipitation = new System.Windows.Forms.CheckBox();
            this.chbMinTemp = new System.Windows.Forms.CheckBox();
            this.chbMaxTemp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateSearch = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCitySelection = new System.Windows.Forms.Label();
            this.btnCity = new System.Windows.Forms.Button();
            this.lblSelectCity = new System.Windows.Forms.Label();
            this.chbPE = new System.Windows.Forms.CheckBox();
            this.chbDurban = new System.Windows.Forms.CheckBox();
            this.chbPretoria = new System.Windows.Forms.CheckBox();
            this.chbJhb = new System.Windows.Forms.CheckBox();
            this.chbCapeTown = new System.Windows.Forms.CheckBox();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlData.Location = new System.Drawing.Point(308, 0);
            this.pnlData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pnlData.Size = new System.Drawing.Size(972, 706);
            this.pnlData.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnApplyFilters);
            this.panel1.Controls.Add(this.chbWindspeed);
            this.panel1.Controls.Add(this.chbHumidity);
            this.panel1.Controls.Add(this.chbPrecipitation);
            this.panel1.Controls.Add(this.chbMinTemp);
            this.panel1.Controls.Add(this.chbMaxTemp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblCitySelection);
            this.panel1.Controls.Add(this.btnCity);
            this.panel1.Controls.Add(this.lblSelectCity);
            this.panel1.Controls.Add(this.chbPE);
            this.panel1.Controls.Add(this.chbDurban);
            this.panel1.Controls.Add(this.chbPretoria);
            this.panel1.Controls.Add(this.chbJhb);
            this.panel1.Controls.Add(this.chbCapeTown);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 707);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Show a report panel which can be\r\nsaved or printed";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Show Weather Reporter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(63, 676);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 25);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(11, 559);
            this.btnApplyFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(116, 25);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "Apply Filters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // chbWindspeed
            // 
            this.chbWindspeed.AutoSize = true;
            this.chbWindspeed.Location = new System.Drawing.Point(20, 602);
            this.chbWindspeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbWindspeed.Name = "chbWindspeed";
            this.chbWindspeed.Size = new System.Drawing.Size(173, 21);
            this.chbWindspeed.TabIndex = 7;
            this.chbWindspeed.Text = "Strongest Windspeeds";
            this.chbWindspeed.UseVisualStyleBackColor = true;
            // 
            // chbHumidity
            // 
            this.chbHumidity.AutoSize = true;
            this.chbHumidity.Location = new System.Drawing.Point(11, 524);
            this.chbHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbHumidity.Name = "chbHumidity";
            this.chbHumidity.Size = new System.Drawing.Size(136, 21);
            this.chbHumidity.TabIndex = 6;
            this.chbHumidity.Text = "Highest Humidity";
            this.chbHumidity.UseVisualStyleBackColor = true;
            // 
            // chbPrecipitation
            // 
            this.chbPrecipitation.AutoSize = true;
            this.chbPrecipitation.Location = new System.Drawing.Point(11, 497);
            this.chbPrecipitation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPrecipitation.Name = "chbPrecipitation";
            this.chbPrecipitation.Size = new System.Drawing.Size(212, 21);
            this.chbPrecipitation.TabIndex = 5;
            this.chbPrecipitation.Text = "Highest Precipitation Chance";
            this.chbPrecipitation.UseVisualStyleBackColor = true;
            // 
            // chbMinTemp
            // 
            this.chbMinTemp.AutoSize = true;
            this.chbMinTemp.Location = new System.Drawing.Point(11, 470);
            this.chbMinTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMinTemp.Name = "chbMinTemp";
            this.chbMinTemp.Size = new System.Drawing.Size(160, 21);
            this.chbMinTemp.TabIndex = 4;
            this.chbMinTemp.Text = "Lowest Temperature";
            this.chbMinTemp.UseVisualStyleBackColor = true;
            // 
            // chbMaxTemp
            // 
            this.chbMaxTemp.AutoSize = true;
            this.chbMaxTemp.Location = new System.Drawing.Point(11, 443);
            this.chbMaxTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMaxTemp.Name = "chbMaxTemp";
            this.chbMaxTemp.Size = new System.Drawing.Size(164, 21);
            this.chbMaxTemp.TabIndex = 3;
            this.chbMaxTemp.Text = "Highest Temperature";
            this.chbMaxTemp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Conditions Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateSearch);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 238);
            this.panel3.TabIndex = 9;
            // 
            // dateSearch
            // 
            this.dateSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateSearch.Location = new System.Drawing.Point(0, 23);
            this.dateSearch.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateSearch.MinDate = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click and drag to select a range";
            // 
            // lblCitySelection
            // 
            this.lblCitySelection.BackColor = System.Drawing.Color.Silver;
            this.lblCitySelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCitySelection.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitySelection.Location = new System.Drawing.Point(-3, -1);
            this.lblCitySelection.Name = "lblCitySelection";
            this.lblCitySelection.Size = new System.Drawing.Size(309, 28);
            this.lblCitySelection.TabIndex = 3;
            this.lblCitySelection.Text = "Select Date Range:";
            this.lblCitySelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(11, 379);
            this.btnCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(117, 25);
            this.btnCity.TabIndex = 3;
            this.btnCity.Text = "Search";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // lblSelectCity
            // 
            this.lblSelectCity.BackColor = System.Drawing.Color.Silver;
            this.lblSelectCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectCity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCity.Location = new System.Drawing.Point(0, 273);
            this.lblSelectCity.Name = "lblSelectCity";
            this.lblSelectCity.Size = new System.Drawing.Size(309, 25);
            this.lblSelectCity.TabIndex = 1;
            this.lblSelectCity.Text = "Select Cities to Compare:";
            this.lblSelectCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbPE
            // 
            this.chbPE.AutoSize = true;
            this.chbPE.Location = new System.Drawing.Point(13, 355);
            this.chbPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPE.Name = "chbPE";
            this.chbPE.Size = new System.Drawing.Size(118, 21);
            this.chbPE.TabIndex = 2;
            this.chbPE.Text = "Port Elizabeth";
            this.chbPE.UseVisualStyleBackColor = true;
            // 
            // chbDurban
            // 
            this.chbDurban.AutoSize = true;
            this.chbDurban.Location = new System.Drawing.Point(182, 328);
            this.chbDurban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDurban.Name = "chbDurban";
            this.chbDurban.Size = new System.Drawing.Size(77, 21);
            this.chbDurban.TabIndex = 5;
            this.chbDurban.Text = "Durban";
            this.chbDurban.UseVisualStyleBackColor = true;
            // 
            // chbPretoria
            // 
            this.chbPretoria.AutoSize = true;
            this.chbPretoria.Location = new System.Drawing.Point(182, 301);
            this.chbPretoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPretoria.Name = "chbPretoria";
            this.chbPretoria.Size = new System.Drawing.Size(80, 21);
            this.chbPretoria.TabIndex = 4;
            this.chbPretoria.Text = "Pretoria";
            this.chbPretoria.UseVisualStyleBackColor = true;
            // 
            // chbJhb
            // 
            this.chbJhb.AutoSize = true;
            this.chbJhb.Location = new System.Drawing.Point(13, 328);
            this.chbJhb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbJhb.Name = "chbJhb";
            this.chbJhb.Size = new System.Drawing.Size(121, 21);
            this.chbJhb.TabIndex = 1;
            this.chbJhb.Text = "Johannesburg";
            this.chbJhb.UseVisualStyleBackColor = true;
            // 
            // chbCapeTown
            // 
            this.chbCapeTown.AutoSize = true;
            this.chbCapeTown.Location = new System.Drawing.Point(13, 301);
            this.chbCapeTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbCapeTown.Name = "chbCapeTown";
            this.chbCapeTown.Size = new System.Drawing.Size(101, 21);
            this.chbCapeTown.TabIndex = 0;
            this.chbCapeTown.Text = "Cape Town";
            this.chbCapeTown.UseVisualStyleBackColor = true;
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // AnalyseWeatherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnalyseWeatherView";
            this.Size = new System.Drawing.Size(1280, 706);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.CheckBox chbWindspeed;
        private System.Windows.Forms.CheckBox chbHumidity;
        private System.Windows.Forms.CheckBox chbPrecipitation;
        private System.Windows.Forms.CheckBox chbMinTemp;
        private System.Windows.Forms.CheckBox chbMaxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar dateSearch;
        private System.Windows.Forms.Label lblCitySelection;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Label lblSelectCity;
        private System.Windows.Forms.CheckBox chbPE;
        private System.Windows.Forms.CheckBox chbDurban;
        private System.Windows.Forms.CheckBox chbPretoria;
        private System.Windows.Forms.CheckBox chbJhb;
        private System.Windows.Forms.CheckBox chbCapeTown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}
