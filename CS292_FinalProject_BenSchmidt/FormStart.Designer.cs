﻿namespace CS292_FinalProject_BenSchmidt
{
    partial class frmStartScreen
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnOfficialLogin = new System.Windows.Forms.Button();
            this.grpSearchFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchPlayerName = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProviderStart = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.radExactMatch = new System.Windows.Forms.RadioButton();
            this.radSimilarMatch = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpSearchFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(602, 389);
            this.dgv.TabIndex = 3;
            // 
            // btnOfficialLogin
            // 
            this.btnOfficialLogin.Location = new System.Drawing.Point(768, 155);
            this.btnOfficialLogin.Name = "btnOfficialLogin";
            this.btnOfficialLogin.Size = new System.Drawing.Size(77, 23);
            this.btnOfficialLogin.TabIndex = 4;
            this.btnOfficialLogin.Text = "Official Login";
            this.toolTipStart.SetToolTip(this.btnOfficialLogin, "Login Portal for League Officials only");
            this.btnOfficialLogin.UseVisualStyleBackColor = true;
            // 
            // grpSearchFilter
            // 
            this.grpSearchFilter.Controls.Add(this.btnClear);
            this.grpSearchFilter.Controls.Add(this.btnSearch);
            this.grpSearchFilter.Controls.Add(this.panel1);
            this.grpSearchFilter.Controls.Add(this.cboPosition);
            this.grpSearchFilter.Controls.Add(this.cboSchool);
            this.grpSearchFilter.Controls.Add(this.label3);
            this.grpSearchFilter.Controls.Add(this.label2);
            this.grpSearchFilter.Location = new System.Drawing.Point(620, 236);
            this.grpSearchFilter.Name = "grpSearchFilter";
            this.grpSearchFilter.Size = new System.Drawing.Size(226, 165);
            this.grpSearchFilter.TabIndex = 12;
            this.grpSearchFilter.TabStop = false;
            this.grpSearchFilter.Text = "Search Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(36, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.toolTipStart.SetToolTip(this.btnSearch, "Searches for the player(s) that most closely match the search conditions above");
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radSimilarMatch);
            this.panel1.Controls.Add(this.radExactMatch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSearchPlayerName);
            this.panel1.Location = new System.Drawing.Point(10, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 56);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name:";
            // 
            // txtSearchPlayerName
            // 
            this.txtSearchPlayerName.Location = new System.Drawing.Point(64, 7);
            this.txtSearchPlayerName.Name = "txtSearchPlayerName";
            this.txtSearchPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchPlayerName.TabIndex = 13;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(74, 19);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(121, 21);
            this.cboPosition.TabIndex = 12;
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(74, 46);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(121, 21);
            this.cboSchool.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "School:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Position:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(620, 155);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(77, 23);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "Show All";
            this.toolTipStart.SetToolTip(this.btnShowAll, "Shows the statistics for every player in the league");
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(768, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.toolTipStart.SetToolTip(this.btnExit, "Closes the program");
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(674, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Enable Search Filter";
            this.toolTipStart.SetToolTip(this.checkBox1, "Provides additional information to search by");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // errorProviderStart
            // 
            this.errorProviderStart.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // radExactMatch
            // 
            this.radExactMatch.AutoSize = true;
            this.radExactMatch.Location = new System.Drawing.Point(15, 33);
            this.radExactMatch.Name = "radExactMatch";
            this.radExactMatch.Size = new System.Drawing.Size(85, 17);
            this.radExactMatch.TabIndex = 15;
            this.radExactMatch.TabStop = true;
            this.radExactMatch.Text = "Exact Match";
            this.toolTipStart.SetToolTip(this.radExactMatch, "Looks for the player with the exact name entered above");
            this.radExactMatch.UseVisualStyleBackColor = true;
            // 
            // radSimilarMatch
            // 
            this.radSimilarMatch.AutoSize = true;
            this.radSimilarMatch.Location = new System.Drawing.Point(106, 33);
            this.radSimilarMatch.Name = "radSimilarMatch";
            this.radSimilarMatch.Size = new System.Drawing.Size(88, 17);
            this.radSimilarMatch.TabIndex = 16;
            this.radSimilarMatch.TabStop = true;
            this.radSimilarMatch.Text = "Similar Match";
            this.toolTipStart.SetToolTip(this.radSimilarMatch, "Searches for the player(s) that most resemble the name entered above");
            this.radSimilarMatch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.toolTipStart.SetToolTip(this.btnClear, "Resets the search filters back to their default states");
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(621, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 136);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmStartScreen
            // 
            this.AcceptButton = this.btnShowAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(857, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grpSearchFilter);
            this.Controls.Add(this.btnOfficialLogin);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmStartScreen";
            this.Text = "Start Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpSearchFilter.ResumeLayout(false);
            this.grpSearchFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnOfficialLogin;
        private System.Windows.Forms.GroupBox grpSearchFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchPlayerName;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProviderStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolTip toolTipStart;
        private System.Windows.Forms.RadioButton radSimilarMatch;
        private System.Windows.Forms.RadioButton radExactMatch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

