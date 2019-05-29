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
            this.gridWeather = new System.Windows.Forms.DataGridView();
            this.townForecastBinding = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precipitationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.townForecastBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblTown
            // 
            this.lblTown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTown.AutoSize = true;
            this.lblTown.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTown.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(332, 0);
            this.lblTown.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(85, 32);
            this.lblTown.TabIndex = 0;
            this.lblTown.Text = "Town";
            this.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridWeather
            // 
            this.gridWeather.AllowUserToAddRows = false;
            this.gridWeather.AutoGenerateColumns = false;
            this.gridWeather.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWeather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.precipitationDataGridViewTextBoxColumn,
            this.maxTempDataGridViewTextBoxColumn,
            this.minTempDataGridViewTextBoxColumn,
            this.windspeedDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn});
            this.gridWeather.DataSource = this.townForecastBinding;
            this.gridWeather.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridWeather.Location = new System.Drawing.Point(0, 28);
            this.gridWeather.Name = "gridWeather";
            this.gridWeather.RowTemplate.Height = 24;
            this.gridWeather.Size = new System.Drawing.Size(744, 80);
            this.gridWeather.TabIndex = 1;
            this.gridWeather.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWeather_CellContentClick);
            // 
            // townForecastBinding
            // 
            this.townForecastBinding.DataSource = typeof(WeatherAppV2.ForecastModel);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // precipitationDataGridViewTextBoxColumn
            // 
            this.precipitationDataGridViewTextBoxColumn.DataPropertyName = "precipitation";
            this.precipitationDataGridViewTextBoxColumn.HeaderText = "Precipitation";
            this.precipitationDataGridViewTextBoxColumn.Name = "precipitationDataGridViewTextBoxColumn";
            // 
            // maxTempDataGridViewTextBoxColumn
            // 
            this.maxTempDataGridViewTextBoxColumn.DataPropertyName = "maxTemp";
            this.maxTempDataGridViewTextBoxColumn.HeaderText = "Max Temp";
            this.maxTempDataGridViewTextBoxColumn.Name = "maxTempDataGridViewTextBoxColumn";
            // 
            // minTempDataGridViewTextBoxColumn
            // 
            this.minTempDataGridViewTextBoxColumn.DataPropertyName = "minTemp";
            this.minTempDataGridViewTextBoxColumn.HeaderText = "Min Temp";
            this.minTempDataGridViewTextBoxColumn.Name = "minTempDataGridViewTextBoxColumn";
            // 
            // windspeedDataGridViewTextBoxColumn
            // 
            this.windspeedDataGridViewTextBoxColumn.DataPropertyName = "windspeed";
            this.windspeedDataGridViewTextBoxColumn.HeaderText = "Windspeed";
            this.windspeedDataGridViewTextBoxColumn.Name = "windspeedDataGridViewTextBoxColumn";
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            // 
            // analyseTownGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridWeather);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "analyseTownGrid";
            this.Size = new System.Drawing.Size(744, 108);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.townForecastBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.DataGridView gridWeather;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precipitationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource townForecastBinding;
    }
}
