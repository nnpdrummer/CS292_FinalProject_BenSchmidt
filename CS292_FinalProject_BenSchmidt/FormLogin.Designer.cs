﻿namespace CS292_FinalProject_BenSchmidt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(6, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Location = new System.Drawing.Point(184, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(128, 131);
            this.grpLogin.TabIndex = 5;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackToMain.Location = new System.Drawing.Point(190, 149);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(98, 23);
            this.btnBackToMain.TabIndex = 6;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // picLogin
            // 
            this.picLogin.Location = new System.Drawing.Point(12, 12);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(165, 158);
            this.picLogin.TabIndex = 7;
            this.picLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBackToMain;
            this.ClientSize = new System.Drawing.Size(321, 183);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.ToolTip toolTipLogin;
    }
}