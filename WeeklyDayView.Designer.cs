namespace WeatherAppV2
{
    partial class WeeklyDayView
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
            this.pbConditions = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // pbConditions
            // 
            this.pbConditions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConditions.Location = new System.Drawing.Point(4, 81);
            this.pbConditions.Name = "pbConditions";
            this.pbConditions.Size = new System.Drawing.Size(116, 104);
            this.pbConditions.TabIndex = 0;
            this.pbConditions.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(126, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(87, 11);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxTemp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(120, 56);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(92, 69);
            this.lblMaxTemp.TabIndex = 11;
            this.lblMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinTemp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(125, 145);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(87, 68);
            this.lblMinTemp.TabIndex = 12;
            this.lblMinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(18, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 29);
            this.lblDate.TabIndex = 14;
            // 
            // WeeklyDayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.pbConditions);
            this.Name = "WeeklyDayView";
            this.Size = new System.Drawing.Size(215, 215);
            ((System.ComponentModel.ISupportInitialize)(this.pbConditions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConditions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblDate;
    }
}
