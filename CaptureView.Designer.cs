namespace WeatherAppV2
{
    partial class CaptureView
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
            this.lblPrecip = new System.Windows.Forms.Label();
            this.lblPrecipitation = new System.Windows.Forms.Label();
            this.numPrecipitation = new System.Windows.Forms.NumericUpDown();
            this.lblHumid = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblCaptureTitle = new System.Windows.Forms.Label();
            this.numHumidity = new System.Windows.Forms.NumericUpDown();
            this.cmbConditions = new System.Windows.Forms.ComboBox();
            this.numWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblWindspeed = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.minTempSelector = new System.Windows.Forms.NumericUpDown();
            this.maxTempSelector = new System.Windows.Forms.NumericUpDown();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.cmbCitySelector = new System.Windows.Forms.ComboBox();
            this.gridForecasts = new System.Windows.Forms.DataGridView();
            this.lblForecasts = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.min_temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precipitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windspeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblForecastID = new System.Windows.Forms.Label();
            this.forecastModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecipitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTempSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecasts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecip.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecip.Location = new System.Drawing.Point(288, 311);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(33, 29);
            this.lblPrecip.TabIndex = 49;
            this.lblPrecip.Text = "%";
            // 
            // lblPrecipitation
            // 
            this.lblPrecipitation.AutoSize = true;
            this.lblPrecipitation.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecipitation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecipitation.Location = new System.Drawing.Point(40, 316);
            this.lblPrecipitation.Name = "lblPrecipitation";
            this.lblPrecipitation.Size = new System.Drawing.Size(125, 24);
            this.lblPrecipitation.TabIndex = 48;
            this.lblPrecipitation.Text = "Precipitation";
            // 
            // numPrecipitation
            // 
            this.numPrecipitation.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastModelBindingSource, "precipitation", true));
            this.numPrecipitation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecipitation.Location = new System.Drawing.Point(219, 310);
            this.numPrecipitation.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.numPrecipitation.Name = "numPrecipitation";
            this.numPrecipitation.Size = new System.Drawing.Size(70, 30);
            this.numPrecipitation.TabIndex = 3;
            // 
            // lblHumid
            // 
            this.lblHumid.AutoSize = true;
            this.lblHumid.BackColor = System.Drawing.Color.Transparent;
            this.lblHumid.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumid.Location = new System.Drawing.Point(288, 511);
            this.lblHumid.Name = "lblHumid";
            this.lblHumid.Size = new System.Drawing.Size(33, 29);
            this.lblHumid.TabIndex = 46;
            this.lblHumid.Text = "%";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.BackColor = System.Drawing.Color.Transparent;
            this.lblWind.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.Location = new System.Drawing.Point(288, 460);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(65, 29);
            this.lblWind.TabIndex = 45;
            this.lblWind.Text = "Knot";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(288, 410);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(38, 29);
            this.lblMax.TabIndex = 44;
            this.lblMax.Text = "°C";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(288, 360);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 29);
            this.lblMin.TabIndex = 43;
            this.lblMin.Text = "°C";
            // 
            // lblCaptureTitle
            // 
            this.lblCaptureTitle.AutoSize = true;
            this.lblCaptureTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptureTitle.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptureTitle.Location = new System.Drawing.Point(61, 85);
            this.lblCaptureTitle.Name = "lblCaptureTitle";
            this.lblCaptureTitle.Size = new System.Drawing.Size(458, 43);
            this.lblCaptureTitle.TabIndex = 42;
            this.lblCaptureTitle.Text = "Capture a Weather Report";
            // 
            // numHumidity
            // 
            this.numHumidity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastModelBindingSource, "humidity", true));
            this.numHumidity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHumidity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHumidity.Location = new System.Drawing.Point(218, 510);
            this.numHumidity.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.numHumidity.Name = "numHumidity";
            this.numHumidity.Size = new System.Drawing.Size(70, 30);
            this.numHumidity.TabIndex = 7;
            // 
            // cmbConditions
            // 
            this.cmbConditions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastModelBindingSource, "condition", true));
            this.cmbConditions.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConditions.FormattingEnabled = true;
            this.cmbConditions.Items.AddRange(new object[] {
            "Sunny",
            "Overcast",
            "Showers",
            "Partly Cloudy"});
            this.cmbConditions.Location = new System.Drawing.Point(218, 260);
            this.cmbConditions.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.cmbConditions.Name = "cmbConditions";
            this.cmbConditions.Size = new System.Drawing.Size(318, 32);
            this.cmbConditions.TabIndex = 2;
            this.cmbConditions.Text = "Current conditions..";
            // 
            // numWindSpeed
            // 
            this.numWindSpeed.AllowDrop = true;
            this.numWindSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastModelBindingSource, "windspeed", true));
            this.numWindSpeed.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numWindSpeed.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numWindSpeed.Location = new System.Drawing.Point(218, 460);
            this.numWindSpeed.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.numWindSpeed.Name = "numWindSpeed";
            this.numWindSpeed.Size = new System.Drawing.Size(70, 30);
            this.numWindSpeed.TabIndex = 6;
            // 
            // lblWindspeed
            // 
            this.lblWindspeed.AutoSize = true;
            this.lblWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.lblWindspeed.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindspeed.Location = new System.Drawing.Point(40, 466);
            this.lblWindspeed.Name = "lblWindspeed";
            this.lblWindspeed.Size = new System.Drawing.Size(117, 24);
            this.lblWindspeed.TabIndex = 41;
            this.lblWindspeed.Text = "Wind Speed";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(40, 516);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(96, 24);
            this.lblHumidity.TabIndex = 40;
            this.lblHumidity.Text = "Humidity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Conditions";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxTemp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(40, 416);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(110, 24);
            this.lblMaxTemp.TabIndex = 38;
            this.lblMaxTemp.Text = "Max Temp.";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblMinTemp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(40, 366);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(108, 24);
            this.lblMinTemp.TabIndex = 37;
            this.lblMinTemp.Text = "Min Temp.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(40, 216);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 24);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date: ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(40, 163);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 24);
            this.lblCity.TabIndex = 33;
            this.lblCity.Text = "City: ";
            // 
            // minTempSelector
            // 
            this.minTempSelector.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastModelBindingSource, "min_temp", true));
            this.minTempSelector.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempSelector.Location = new System.Drawing.Point(218, 360);
            this.minTempSelector.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.minTempSelector.Name = "minTempSelector";
            this.minTempSelector.Size = new System.Drawing.Size(70, 30);
            this.minTempSelector.TabIndex = 4;
            // 
            // maxTempSelector
            // 
            this.maxTempSelector.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastModelBindingSource, "max_temp", true));
            this.maxTempSelector.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempSelector.Location = new System.Drawing.Point(218, 410);
            this.maxTempSelector.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.maxTempSelector.Name = "maxTempSelector";
            this.maxTempSelector.Size = new System.Drawing.Size(70, 30);
            this.maxTempSelector.TabIndex = 5;
            this.maxTempSelector.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // datepicker
            // 
            this.datepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.forecastModelBindingSource, "date", true));
            this.datepicker.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Location = new System.Drawing.Point(218, 210);
            this.datepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(318, 30);
            this.datepicker.TabIndex = 1;
            // 
            // cmbCitySelector
            // 
            this.cmbCitySelector.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastModelBindingSource, "city", true));
            this.cmbCitySelector.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCitySelector.FormattingEnabled = true;
            this.cmbCitySelector.Items.AddRange(new object[] {
            "Cape Town",
            "Johannesburg",
            "Durban",
            "Pretoria",
            "Port Elizabeth"});
            this.cmbCitySelector.Location = new System.Drawing.Point(218, 160);
            this.cmbCitySelector.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.cmbCitySelector.Name = "cmbCitySelector";
            this.cmbCitySelector.Size = new System.Drawing.Size(318, 32);
            this.cmbCitySelector.TabIndex = 0;
            this.cmbCitySelector.Text = "Select a City... ";
            // 
            // gridForecasts
            // 
            this.gridForecasts.AutoGenerateColumns = false;
            this.gridForecasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridForecasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.min_temp,
            this.max_temp,
            this.precipitation,
            this.windspeed,
            this.humidity});
            this.gridForecasts.DataSource = this.forecastModelBindingSource;
            this.gridForecasts.Location = new System.Drawing.Point(584, 160);
            this.gridForecasts.Name = "gridForecasts";
            this.gridForecasts.RowTemplate.Height = 24;
            this.gridForecasts.Size = new System.Drawing.Size(644, 396);
            this.gridForecasts.TabIndex = 10;
            // 
            // lblForecasts
            // 
            this.lblForecasts.AutoSize = true;
            this.lblForecasts.BackColor = System.Drawing.Color.Transparent;
            this.lblForecasts.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecasts.Location = new System.Drawing.Point(729, 79);
            this.lblForecasts.Name = "lblForecasts";
            this.lblForecasts.Size = new System.Drawing.Size(385, 49);
            this.lblForecasts.TabIndex = 51;
            this.lblForecasts.Text = "Existing Forecasts:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(44, 565);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(160, 49);
            this.btnNew.TabIndex = 58;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(210, 618);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 49);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(44, 618);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 49);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(210, 565);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 49);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // min_temp
            // 
            this.min_temp.DataPropertyName = "min_temp";
            this.min_temp.HeaderText = "min Temp";
            this.min_temp.Name = "min_temp";
            // 
            // max_temp
            // 
            this.max_temp.DataPropertyName = "max_temp";
            this.max_temp.HeaderText = "max Temp";
            this.max_temp.Name = "max_temp";
            // 
            // precipitation
            // 
            this.precipitation.DataPropertyName = "precipitation";
            this.precipitation.HeaderText = "precipitation";
            this.precipitation.Name = "precipitation";
            // 
            // windspeed
            // 
            this.windspeed.DataPropertyName = "windspeed";
            this.windspeed.HeaderText = "windspeed";
            this.windspeed.Name = "windspeed";
            // 
            // humidity
            // 
            this.humidity.DataPropertyName = "humidity";
            this.humidity.HeaderText = "humidity";
            this.humidity.Name = "humidity";
            // 
            // lblForecastID
            // 
            this.lblForecastID.AutoSize = true;
            this.lblForecastID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forecastModelBindingSource, "forecast_id", true));
            this.lblForecastID.Font = new System.Drawing.Font("Georgia", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecastID.Location = new System.Drawing.Point(55, 108);
            this.lblForecastID.Name = "lblForecastID";
            this.lblForecastID.Size = new System.Drawing.Size(0, 4);
            this.lblForecastID.TabIndex = 59;
            // 
            // forecastModelBindingSource
            // 
            this.forecastModelBindingSource.DataSource = typeof(WeatherAppV2.ForecastModel);
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // CaptureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.lblForecastID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblForecasts);
            this.Controls.Add(this.gridForecasts);
            this.Controls.Add(this.lblPrecip);
            this.Controls.Add(this.lblPrecipitation);
            this.Controls.Add(this.numPrecipitation);
            this.Controls.Add(this.lblHumid);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblCaptureTitle);
            this.Controls.Add(this.numHumidity);
            this.Controls.Add(this.cmbConditions);
            this.Controls.Add(this.numWindSpeed);
            this.Controls.Add(this.lblWindspeed);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.minTempSelector);
            this.Controls.Add(this.maxTempSelector);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.cmbCitySelector);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CaptureView";
            this.Size = new System.Drawing.Size(1280, 707);
            this.Load += new System.EventHandler(this.CaptureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecipitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTempSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridForecasts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forecastModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label lblPrecipitation;
        private System.Windows.Forms.NumericUpDown numPrecipitation;
        private System.Windows.Forms.Label lblHumid;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblCaptureTitle;
        private System.Windows.Forms.NumericUpDown numHumidity;
        private System.Windows.Forms.ComboBox cmbConditions;
        private System.Windows.Forms.NumericUpDown numWindSpeed;
        private System.Windows.Forms.Label lblWindspeed;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.NumericUpDown minTempSelector;
        private System.Windows.Forms.NumericUpDown maxTempSelector;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.ComboBox cmbCitySelector;
        private System.Windows.Forms.DataGridView gridForecasts;
        private System.Windows.Forms.Label lblForecasts;
        private System.Windows.Forms.BindingSource forecastModelBindingSource;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn precipitation;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.Label lblForecastID;
    }
}
