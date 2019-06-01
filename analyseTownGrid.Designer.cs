namespace WeatherAppV2
{
    partial class analyseTownGrid
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTown = new System.Windows.Forms.Label();
            this.townForecastBinding = new System.Windows.Forms.BindingSource(this.components);
            this.gridWeather = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townForecastBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblTown
            // 
            this.lblTown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTown.AutoSize = true;
            this.lblTown.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTown.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(335, 0);
            this.lblTown.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(85, 32);
            this.lblTown.TabIndex = 0;
            this.lblTown.Text = "Town";
            this.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // townForecastBinding
            // 
            this.townForecastBinding.DataSource = typeof(WeatherAppV2.ForecastModel);
            // 
            // gridWeather
            // 
            this.gridWeather.AllowUserToAddRows = false;
            this.gridWeather.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWeather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colCondition,
            this.colPrecip,
            this.colMax,
            this.ColMin,
            this.colHumidity,
            this.Humidity});
            this.gridWeather.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridWeather.Location = new System.Drawing.Point(0, 28);
            this.gridWeather.Name = "gridWeather";
            this.gridWeather.RowTemplate.Height = 24;
            this.gridWeather.Size = new System.Drawing.Size(751, 80);
            this.gridWeather.TabIndex = 2;
            // 
            // colDate
            // 
            this.colDate.Frozen = true;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colCondition
            // 
            this.colCondition.Frozen = true;
            this.colCondition.HeaderText = "Condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.ReadOnly = true;
            // 
            // colPrecip
            // 
            this.colPrecip.Frozen = true;
            this.colPrecip.HeaderText = "Precipitation";
            this.colPrecip.Name = "colPrecip";
            this.colPrecip.ReadOnly = true;
            // 
            // colMax
            // 
            this.colMax.Frozen = true;
            this.colMax.HeaderText = "Max Temp.";
            this.colMax.Name = "colMax";
            this.colMax.ReadOnly = true;
            // 
            // ColMin
            // 
            this.ColMin.Frozen = true;
            this.ColMin.HeaderText = "Min Temp.";
            this.ColMin.Name = "ColMin";
            this.ColMin.ReadOnly = true;
            // 
            // colHumidity
            // 
            this.colHumidity.Frozen = true;
            this.colHumidity.HeaderText = "WindSpeed";
            this.colHumidity.Name = "colHumidity";
            this.colHumidity.ReadOnly = true;
            // 
            // Humidity
            // 
            this.Humidity.Frozen = true;
            this.Humidity.HeaderText = "Humidity";
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            // 
            // analyseTownGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridWeather);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "analyseTownGrid";
            this.Size = new System.Drawing.Size(751, 108);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townForecastBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource townForecastBinding;
        private System.Windows.Forms.DataGridView gridWeather;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
    }
}
