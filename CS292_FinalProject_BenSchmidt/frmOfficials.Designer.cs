namespace CS292_FinalProject_BenSchmidt
{
    partial class frmOfficials
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cboSchool = new System.Windows.Forms.ComboBox();
            this.errorProviderOfficials = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpPlayerInformation = new System.Windows.Forms.GroupBox();
            this.cboStanding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radRemove = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radSearch = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlayerID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayerInfoCRUD = new System.Windows.Forms.Button();
            this.chkExactMatch = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchPlayerName = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipOfficialsPage = new System.Windows.Forms.ToolTip(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOfficials)).BeginInit();
            this.grpPlayerInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome:  ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 501);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(226, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(12, 41);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(577, 150);
            this.dgvPlayers.TabIndex = 2;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 530);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(226, 23);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cboSchool
            // 
            this.cboSchool.FormattingEnabled = true;
            this.cboSchool.Location = new System.Drawing.Point(74, 95);
            this.cboSchool.Name = "cboSchool";
            this.cboSchool.Size = new System.Drawing.Size(121, 21);
            this.cboSchool.TabIndex = 9;
            this.cboSchool.SelectedIndexChanged += new System.EventHandler(this.cboSchool_SelectedIndexChanged);
            // 
            // errorProviderOfficials
            // 
            this.errorProviderOfficials.ContainerControl = this;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(301, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "label2";
            // 
            // grpPlayerInformation
            // 
            this.grpPlayerInformation.Controls.Add(this.btnPlayerInfoCRUD);
            this.grpPlayerInformation.Controls.Add(this.cboStanding);
            this.grpPlayerInformation.Controls.Add(this.label6);
            this.grpPlayerInformation.Controls.Add(this.radRemove);
            this.grpPlayerInformation.Controls.Add(this.radEdit);
            this.grpPlayerInformation.Controls.Add(this.radAdd);
            this.grpPlayerInformation.Controls.Add(this.radSearch);
            this.grpPlayerInformation.Controls.Add(this.label5);
            this.grpPlayerInformation.Controls.Add(this.txtPlayerID);
            this.grpPlayerInformation.Controls.Add(this.panel1);
            this.grpPlayerInformation.Controls.Add(this.cboPosition);
            this.grpPlayerInformation.Controls.Add(this.cboSchool);
            this.grpPlayerInformation.Controls.Add(this.label3);
            this.grpPlayerInformation.Controls.Add(this.label2);
            this.grpPlayerInformation.Location = new System.Drawing.Point(363, 197);
            this.grpPlayerInformation.Name = "grpPlayerInformation";
            this.grpPlayerInformation.Size = new System.Drawing.Size(226, 270);
            this.grpPlayerInformation.TabIndex = 11;
            this.grpPlayerInformation.TabStop = false;
            this.grpPlayerInformation.Text = "Player Information";
            // 
            // cboStanding
            // 
            this.cboStanding.FormattingEnabled = true;
            this.cboStanding.Location = new System.Drawing.Point(74, 122);
            this.cboStanding.Name = "cboStanding";
            this.cboStanding.Size = new System.Drawing.Size(121, 21);
            this.cboStanding.TabIndex = 22;
            this.cboStanding.SelectedIndexChanged += new System.EventHandler(this.cboStanding_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Standing:";
            // 
            // radRemove
            // 
            this.radRemove.AutoSize = true;
            this.radRemove.Location = new System.Drawing.Point(124, 45);
            this.radRemove.Name = "radRemove";
            this.radRemove.Size = new System.Drawing.Size(65, 17);
            this.radRemove.TabIndex = 21;
            this.radRemove.Text = "Remove";
            this.radRemove.UseVisualStyleBackColor = true;
            this.radRemove.CheckedChanged += new System.EventHandler(this.radRemove_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Location = new System.Drawing.Point(41, 45);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(43, 17);
            this.radEdit.TabIndex = 20;
            this.radEdit.Text = "Edit";
            this.radEdit.UseVisualStyleBackColor = true;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radEdit_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(124, 19);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(44, 17);
            this.radAdd.TabIndex = 19;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // radSearch
            // 
            this.radSearch.AutoSize = true;
            this.radSearch.Checked = true;
            this.radSearch.Location = new System.Drawing.Point(41, 19);
            this.radSearch.Name = "radSearch";
            this.radSearch.Size = new System.Drawing.Size(59, 17);
            this.radSearch.TabIndex = 18;
            this.radSearch.TabStop = true;
            this.radSearch.Text = "Search";
            this.radSearch.UseVisualStyleBackColor = true;
            this.radSearch.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Player ID:";
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.Location = new System.Drawing.Point(74, 149);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.Size = new System.Drawing.Size(121, 20);
            this.txtPlayerID.TabIndex = 16;
            this.txtPlayerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerID_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkExactMatch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSearchPlayerName);
            this.panel1.Location = new System.Drawing.Point(9, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 58);
            this.panel1.TabIndex = 15;
            // 
            // btnPlayerInfoCRUD
            // 
            this.btnPlayerInfoCRUD.Location = new System.Drawing.Point(41, 239);
            this.btnPlayerInfoCRUD.Name = "btnPlayerInfoCRUD";
            this.btnPlayerInfoCRUD.Size = new System.Drawing.Size(135, 23);
            this.btnPlayerInfoCRUD.TabIndex = 22;
            this.btnPlayerInfoCRUD.Text = "Search for player(s)";
            this.btnPlayerInfoCRUD.UseVisualStyleBackColor = true;
            this.btnPlayerInfoCRUD.Click += new System.EventHandler(this.btnPlayerInfoCRUD_Click);
            // 
            // chkExactMatch
            // 
            this.chkExactMatch.AutoSize = true;
            this.chkExactMatch.Location = new System.Drawing.Point(57, 33);
            this.chkExactMatch.Name = "chkExactMatch";
            this.chkExactMatch.Size = new System.Drawing.Size(86, 17);
            this.chkExactMatch.TabIndex = 15;
            this.chkExactMatch.Text = "Exact Match";
            this.chkExactMatch.UseVisualStyleBackColor = true;
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
            this.cboPosition.Location = new System.Drawing.Point(74, 68);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(121, 21);
            this.cboPosition.TabIndex = 12;
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboPosition_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "School:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Position:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 200);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(345, 295);
            this.pic.TabIndex = 15;
            this.pic.TabStop = false;
            // 
            // frmOfficials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 600);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpPlayerInformation);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmOfficials";
            this.Text = "Officials\' page";
            this.Load += new System.EventHandler(this.frmOfficials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOfficials)).EndInit();
            this.grpPlayerInformation.ResumeLayout(false);
            this.grpPlayerInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cboSchool;
        private System.Windows.Forms.ErrorProvider errorProviderOfficials;
        private System.Windows.Forms.GroupBox grpPlayerInformation;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlayerID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchPlayerName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox chkExactMatch;
        private System.Windows.Forms.ToolTip toolTipOfficialsPage;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnPlayerInfoCRUD;
        private System.Windows.Forms.RadioButton radRemove;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radSearch;
        private System.Windows.Forms.ComboBox cboStanding;
        private System.Windows.Forms.Label label6;
    }
}