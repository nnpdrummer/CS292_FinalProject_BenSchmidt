namespace CS292_FinalProject_BenSchmidt
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
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.grpSearchFilter = new System.Windows.Forms.GroupBox();
            this.cboStanding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radSimilarMatch = new System.Windows.Forms.RadioButton();
            this.radExactMatch = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchPlayerName = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.errorProviderStart = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.grpSearchFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(244, 27);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(678, 223);
            this.dgvPlayers.TabIndex = 3;
            // 
            // grpSearchFilter
            // 
            this.grpSearchFilter.Controls.Add(this.cboStanding);
            this.grpSearchFilter.Controls.Add(this.label1);
            this.grpSearchFilter.Controls.Add(this.btnClear);
            this.grpSearchFilter.Controls.Add(this.btnSearch);
            this.grpSearchFilter.Controls.Add(this.panel1);
            this.grpSearchFilter.Controls.Add(this.cboPosition);
            this.grpSearchFilter.Controls.Add(this.cboSchool);
            this.grpSearchFilter.Controls.Add(this.label3);
            this.grpSearchFilter.Controls.Add(this.label2);
            this.grpSearchFilter.Location = new System.Drawing.Point(12, 27);
            this.grpSearchFilter.Name = "grpSearchFilter";
            this.grpSearchFilter.Size = new System.Drawing.Size(226, 194);
            this.grpSearchFilter.TabIndex = 12;
            this.grpSearchFilter.TabStop = false;
            this.grpSearchFilter.Text = "Search Filter";
            // 
            // cboStanding
            // 
            this.cboStanding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStanding.FormattingEnabled = true;
            this.cboStanding.Location = new System.Drawing.Point(74, 73);
            this.cboStanding.Name = "cboStanding";
            this.cboStanding.Size = new System.Drawing.Size(121, 21);
            this.cboStanding.TabIndex = 20;
            this.cboStanding.SelectedIndexChanged += new System.EventHandler(this.cboStanding_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Standing:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.toolTipStart.SetToolTip(this.btnClear, "Resets the search filters back to their default states");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(32, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.toolTipStart.SetToolTip(this.btnSearch, "Searches for the player(s) that most closely match the search conditions above");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radSimilarMatch);
            this.panel1.Controls.Add(this.radExactMatch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSearchPlayerName);
            this.panel1.Location = new System.Drawing.Point(6, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 56);
            this.panel1.TabIndex = 15;
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
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(74, 19);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(121, 21);
            this.cboPosition.TabIndex = 12;
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboPosition_SelectedIndexChanged);
            // 
            // cboSchool
            // 
            this.cboSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(74, 46);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(121, 21);
            this.cboSchool.TabIndex = 9;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
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
            this.btnShowAll.Location = new System.Drawing.Point(12, 227);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(226, 23);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "Show All";
            this.toolTipStart.SetToolTip(this.btnShowAll, "Shows the statistics for every player in the league");
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // errorProviderStart
            // 
            this.errorProviderStart.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemLogin,
            this.mnuItemShowAll,
            this.toolStripMenuItem1,
            this.mnuItemExit});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // mnuItemLogin
            // 
            this.mnuItemLogin.Name = "mnuItemLogin";
            this.mnuItemLogin.Size = new System.Drawing.Size(120, 22);
            this.mnuItemLogin.Text = "Login";
            this.mnuItemLogin.Click += new System.EventHandler(this.mnuItemLogin_Click);
            // 
            // mnuItemShowAll
            // 
            this.mnuItemShowAll.Name = "mnuItemShowAll";
            this.mnuItemShowAll.Size = new System.Drawing.Size(120, 22);
            this.mnuItemShowAll.Text = "Show All";
            this.mnuItemShowAll.Click += new System.EventHandler(this.mnuItemShowAll_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(120, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // frmStartScreen
            // 
            this.AcceptButton = this.btnShowAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 280);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grpSearchFilter);
            this.Controls.Add(this.dgvPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmStartScreen";
            this.Text = "High School Football Stat Tracker";
            this.Load += new System.EventHandler(this.frmStartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.grpSearchFilter.ResumeLayout(false);
            this.grpSearchFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
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
        private System.Windows.Forms.ErrorProvider errorProviderStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolTip toolTipStart;
        private System.Windows.Forms.RadioButton radSimilarMatch;
        private System.Windows.Forms.RadioButton radExactMatch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboStanding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuItemShowAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
    }
}

