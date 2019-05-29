namespace WeatherAppV2
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnAdmin = new System.Windows.Forms.RadioButton();
            this.rbnGeneral = new System.Windows.Forms.RadioButton();
            this.txtSignUpEmail = new System.Windows.Forms.TextBox();
            this.txtSignupPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSuPassword = new System.Windows.Forms.Label();
            this.lblSignUpEmail = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSignUp.Controls.Add(this.pictureBox2);
            this.pnlSignUp.Controls.Add(this.btnSubmit);
            this.pnlSignUp.Controls.Add(this.groupBox1);
            this.pnlSignUp.Controls.Add(this.txtSignUpEmail);
            this.pnlSignUp.Controls.Add(this.txtSignupPassword);
            this.pnlSignUp.Controls.Add(this.label3);
            this.pnlSignUp.Controls.Add(this.lblSuPassword);
            this.pnlSignUp.Controls.Add(this.lblSignUpEmail);
            this.pnlSignUp.Location = new System.Drawing.Point(600, 59);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(602, 611);
            this.pnlSignUp.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(195, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 181);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(235, 503);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnAdmin);
            this.groupBox1.Controls.Add(this.rbnGeneral);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(151, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Type";
            // 
            // rbnAdmin
            // 
            this.rbnAdmin.AutoSize = true;
            this.rbnAdmin.Location = new System.Drawing.Point(7, 31);
            this.rbnAdmin.Name = "rbnAdmin";
            this.rbnAdmin.Size = new System.Drawing.Size(134, 21);
            this.rbnAdmin.TabIndex = 0;
            this.rbnAdmin.TabStop = true;
            this.rbnAdmin.Text = "Administrator";
            this.rbnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbnGeneral
            // 
            this.rbnGeneral.AutoSize = true;
            this.rbnGeneral.Location = new System.Drawing.Point(168, 31);
            this.rbnGeneral.Name = "rbnGeneral";
            this.rbnGeneral.Size = new System.Drawing.Size(123, 21);
            this.rbnGeneral.TabIndex = 1;
            this.rbnGeneral.TabStop = true;
            this.rbnGeneral.Text = "General User";
            this.rbnGeneral.UseVisualStyleBackColor = true;
            // 
            // txtSignUpEmail
            // 
            this.txtSignUpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUpEmail.Location = new System.Drawing.Point(290, 323);
            this.txtSignUpEmail.Name = "txtSignUpEmail";
            this.txtSignUpEmail.Size = new System.Drawing.Size(191, 27);
            this.txtSignUpEmail.TabIndex = 0;
            this.txtSignUpEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtSignUpEmail_Validating_1);
            // 
            // txtSignupPassword
            // 
            this.txtSignupPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignupPassword.Location = new System.Drawing.Point(290, 376);
            this.txtSignupPassword.Name = "txtSignupPassword";
            this.txtSignupPassword.PasswordChar = '*';
            this.txtSignupPassword.Size = new System.Drawing.Size(191, 27);
            this.txtSignupPassword.TabIndex = 1;
            this.txtSignupPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtSignupPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign Up";
            // 
            // lblSuPassword
            // 
            this.lblSuPassword.AutoSize = true;
            this.lblSuPassword.Location = new System.Drawing.Point(146, 376);
            this.lblSuPassword.Name = "lblSuPassword";
            this.lblSuPassword.Size = new System.Drawing.Size(81, 17);
            this.lblSuPassword.TabIndex = 6;
            this.lblSuPassword.Text = "Password:";
            // 
            // lblSignUpEmail
            // 
            this.lblSignUpEmail.AutoSize = true;
            this.lblSignUpEmail.Location = new System.Drawing.Point(146, 328);
            this.lblSignUpEmail.Name = "lblSignUpEmail";
            this.lblSignUpEmail.Size = new System.Drawing.Size(118, 17);
            this.lblSignUpEmail.TabIndex = 5;
            this.lblSignUpEmail.Text = "Email Address:";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtLoginEmail);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Location = new System.Drawing.Point(-3, 59);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(602, 611);
            this.pnlLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(174, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 181);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email Address:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(222, 423);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginEmail.Location = new System.Drawing.Point(270, 323);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(191, 27);
            this.txtLoginEmail.TabIndex = 0;
            this.txtLoginEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoginEmail_Validating);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(270, 376);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(191, 27);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoginPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 65);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to WeatherWatcher";
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // PasswordError
            // 
            this.PasswordError.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlSignUp);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnAdmin;
        private System.Windows.Forms.RadioButton rbnGeneral;
        private System.Windows.Forms.TextBox txtSignUpEmail;
        private System.Windows.Forms.TextBox txtSignupPassword;
        private System.Windows.Forms.Label lblSuPassword;
        private System.Windows.Forms.Label lblSignUpEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider EmailError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider PasswordError;
        public System.Windows.Forms.TextBox txtLoginPassword;
    }
}