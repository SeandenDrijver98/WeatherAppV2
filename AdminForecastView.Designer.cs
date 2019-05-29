namespace WeatherAppV2
{
    partial class AdminForecastView
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label humidityLabel;
            System.Windows.Forms.Label maxTempLabel;
            System.Windows.Forms.Label minTempLabel;
            System.Windows.Forms.Label precipitationLabel;
            System.Windows.Forms.Label windspeedLabel;
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.maxTempTextBox = new System.Windows.Forms.TextBox();
            this.minTempTextBox = new System.Windows.Forms.TextBox();
            this.precipitationTextBox = new System.Windows.Forms.TextBox();
            this.windspeedTextBox = new System.Windows.Forms.TextBox();
            this.forecastGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cityLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            humidityLabel = new System.Windows.Forms.Label();
            maxTempLabel = new System.Windows.Forms.Label();
            minTempLabel = new System.Windows.Forms.Label();
            precipitationLabel = new System.Windows.Forms.Label();
            windspeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.forecastGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(26, 75);
            cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 23;
            cityLabel.Text = "city:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(26, 98);
            conditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(53, 13);
            conditionLabel.TabIndex = 25;
            conditionLabel.Text = "condition:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(26, 121);
            dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 27;
            dateLabel.Text = "date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(26, 144);
            endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(54, 13);
            endDateLabel.TabIndex = 29;
            endDateLabel.Text = "end Date:";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Location = new System.Drawing.Point(26, 166);
            humidityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(48, 13);
            humidityLabel.TabIndex = 31;
            humidityLabel.Text = "humidity:";
            // 
            // maxTempLabel
            // 
            maxTempLabel.AutoSize = true;
            maxTempLabel.Location = new System.Drawing.Point(26, 188);
            maxTempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maxTempLabel.Name = "maxTempLabel";
            maxTempLabel.Size = new System.Drawing.Size(59, 13);
            maxTempLabel.TabIndex = 33;
            maxTempLabel.Text = "max Temp:";
            // 
            // minTempLabel
            // 
            minTempLabel.AutoSize = true;
            minTempLabel.Location = new System.Drawing.Point(26, 211);
            minTempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            minTempLabel.Name = "minTempLabel";
            minTempLabel.Size = new System.Drawing.Size(56, 13);
            minTempLabel.TabIndex = 35;
            minTempLabel.Text = "min Temp:";
            // 
            // precipitationLabel
            // 
            precipitationLabel.AutoSize = true;
            precipitationLabel.Location = new System.Drawing.Point(26, 234);
            precipitationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precipitationLabel.Name = "precipitationLabel";
            precipitationLabel.Size = new System.Drawing.Size(67, 13);
            precipitationLabel.TabIndex = 37;
            precipitationLabel.Text = "precipitation:";
            // 
            // windspeedLabel
            // 
            windspeedLabel.AutoSize = true;
            windspeedLabel.Location = new System.Drawing.Point(26, 257);
            windspeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            windspeedLabel.Name = "windspeedLabel";
            windspeedLabel.Size = new System.Drawing.Size(61, 13);
            windspeedLabel.TabIndex = 39;
            windspeedLabel.Text = "windspeed:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 357);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 31);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(98, 322);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 31);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(98, 286);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(151, 31);
            this.btnCreate.TabIndex = 41;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(98, 72);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(151, 20);
            this.cityTextBox.TabIndex = 24;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(98, 95);
            this.conditionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(151, 20);
            this.conditionTextBox.TabIndex = 26;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(98, 118);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateDateTimePicker.TabIndex = 28;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Location = new System.Drawing.Point(98, 141);
            this.endDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.endDateDateTimePicker.TabIndex = 30;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(98, 163);
            this.humidityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(151, 20);
            this.humidityTextBox.TabIndex = 32;
            // 
            // maxTempTextBox
            // 
            this.maxTempTextBox.Location = new System.Drawing.Point(98, 186);
            this.maxTempTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxTempTextBox.Name = "maxTempTextBox";
            this.maxTempTextBox.Size = new System.Drawing.Size(151, 20);
            this.maxTempTextBox.TabIndex = 34;
            // 
            // minTempTextBox
            // 
            this.minTempTextBox.Location = new System.Drawing.Point(98, 209);
            this.minTempTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minTempTextBox.Name = "minTempTextBox";
            this.minTempTextBox.Size = new System.Drawing.Size(151, 20);
            this.minTempTextBox.TabIndex = 36;
            // 
            // precipitationTextBox
            // 
            this.precipitationTextBox.Location = new System.Drawing.Point(98, 232);
            this.precipitationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precipitationTextBox.Name = "precipitationTextBox";
            this.precipitationTextBox.Size = new System.Drawing.Size(151, 20);
            this.precipitationTextBox.TabIndex = 38;
            // 
            // windspeedTextBox
            // 
            this.windspeedTextBox.Location = new System.Drawing.Point(98, 254);
            this.windspeedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.windspeedTextBox.Name = "windspeedTextBox";
            this.windspeedTextBox.Size = new System.Drawing.Size(151, 20);
            this.windspeedTextBox.TabIndex = 40;
            // 
            // forecastGridView
            // 
            this.forecastGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forecastGridView.Location = new System.Drawing.Point(280, 75);
            this.forecastGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forecastGridView.Name = "forecastGridView";
            this.forecastGridView.RowTemplate.Height = 24;
            this.forecastGridView.Size = new System.Drawing.Size(632, 310);
            this.forecastGridView.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 45;
            // 
            // AdminForecastView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(humidityLabel);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(maxTempLabel);
            this.Controls.Add(this.maxTempTextBox);
            this.Controls.Add(minTempLabel);
            this.Controls.Add(this.minTempTextBox);
            this.Controls.Add(precipitationLabel);
            this.Controls.Add(this.precipitationTextBox);
            this.Controls.Add(windspeedLabel);
            this.Controls.Add(this.windspeedTextBox);
            this.Controls.Add(this.forecastGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForecastView";
            this.Size = new System.Drawing.Size(939, 461);
            this.Load += new System.EventHandler(this.AdminForecastView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forecastGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox humidityTextBox;
        private System.Windows.Forms.TextBox maxTempTextBox;
        private System.Windows.Forms.TextBox minTempTextBox;
        private System.Windows.Forms.TextBox precipitationTextBox;
        private System.Windows.Forms.TextBox windspeedTextBox;
        private System.Windows.Forms.DataGridView forecastGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
