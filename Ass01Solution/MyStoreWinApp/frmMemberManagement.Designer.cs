namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.lbMemberID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtEmail_ = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.lbRoleID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTypeSearchMemberID = new System.Windows.Forms.TextBox();
            this.lbFindMemberID = new System.Windows.Forms.Label();
            this.txtTypeSearchMemberName = new System.Windows.Forms.TextBox();
            this.lbFindMember = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMemberID.Location = new System.Drawing.Point(18, 36);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.txtEmail_);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lbCity);
            this.groupBox1.Controls.Add(this.txtRoleID);
            this.groupBox1.Controls.Add(this.lbRoleID);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.lbMemberName);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Controls.Add(this.lbMemberID);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "information Member";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoad.Location = new System.Drawing.Point(697, 248);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Location = new System.Drawing.Point(454, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Location = new System.Drawing.Point(215, 248);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtEmail_
            // 
            this.txtEmail_.Location = new System.Drawing.Point(629, 131);
            this.txtEmail_.Name = "txtEmail_";
            this.txtEmail_.Size = new System.Drawing.Size(282, 27);
            this.txtEmail_.TabIndex = 13;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEmail.Location = new System.Drawing.Point(506, 134);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(629, 83);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(282, 27);
            this.txtCountry.TabIndex = 11;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCountry.Location = new System.Drawing.Point(506, 83);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 10;
            this.lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(629, 36);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(282, 27);
            this.txtCity.TabIndex = 9;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCity.Location = new System.Drawing.Point(503, 36);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 8;
            this.lbCity.Text = "City";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(141, 190);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(230, 27);
            this.txtRoleID.TabIndex = 7;
            // 
            // lbRoleID
            // 
            this.lbRoleID.AutoSize = true;
            this.lbRoleID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbRoleID.Location = new System.Drawing.Point(23, 190);
            this.lbRoleID.Name = "lbRoleID";
            this.lbRoleID.Size = new System.Drawing.Size(58, 20);
            this.lbRoleID.TabIndex = 6;
            this.lbRoleID.Text = "Role ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPassword.Location = new System.Drawing.Point(18, 138);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(141, 85);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(230, 27);
            this.txtMemberName.TabIndex = 3;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMemberName.Location = new System.Drawing.Point(18, 85);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(109, 20);
            this.lbMemberName.TabIndex = 2;
            this.lbMemberName.Text = "Member Name";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(140, 33);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(231, 27);
            this.txtMemberID.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTypeSearchMemberID);
            this.groupBox2.Controls.Add(this.lbFindMemberID);
            this.groupBox2.Controls.Add(this.txtTypeSearchMemberName);
            this.groupBox2.Controls.Add(this.lbFindMember);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find By ID and Name";
            // 
            // txtTypeSearchMemberID
            // 
            this.txtTypeSearchMemberID.Location = new System.Drawing.Point(157, 83);
            this.txtTypeSearchMemberID.Name = "txtTypeSearchMemberID";
            this.txtTypeSearchMemberID.Size = new System.Drawing.Size(214, 27);
            this.txtTypeSearchMemberID.TabIndex = 3;
            this.txtTypeSearchMemberID.TextChanged += new System.EventHandler(this.txtTypeSearchMemberID_TextChanged);
            // 
            // lbFindMemberID
            // 
            this.lbFindMemberID.AutoSize = true;
            this.lbFindMemberID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbFindMemberID.Location = new System.Drawing.Point(38, 83);
            this.lbFindMemberID.Name = "lbFindMemberID";
            this.lbFindMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbFindMemberID.TabIndex = 2;
            this.lbFindMemberID.Text = "Member ID";
            // 
            // txtTypeSearchMemberName
            // 
            this.txtTypeSearchMemberName.Location = new System.Drawing.Point(157, 37);
            this.txtTypeSearchMemberName.Name = "txtTypeSearchMemberName";
            this.txtTypeSearchMemberName.Size = new System.Drawing.Size(214, 27);
            this.txtTypeSearchMemberName.TabIndex = 1;
            this.txtTypeSearchMemberName.TextChanged += new System.EventHandler(this.txtTypeSearchMemberName_TextChanged);
            // 
            // lbFindMember
            // 
            this.lbFindMember.AutoSize = true;
            this.lbFindMember.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbFindMember.Location = new System.Drawing.Point(31, 40);
            this.lbFindMember.Name = "lbFindMember";
            this.lbFindMember.Size = new System.Drawing.Size(109, 20);
            this.lbFindMember.TabIndex = 0;
            this.lbFindMember.Text = "Member Name";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(12, 503);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.Size = new System.Drawing.Size(718, 228);
            this.dgvMemberList.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(846, 702);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 755);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMemberManagement";
            this.Text = "frmMemberManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbMemberID;
        private GroupBox groupBox1;
        private TextBox txtMemberID;
        private Label lbMemberName;
        private TextBox txtMemberName;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbRoleID;
        private TextBox txtRoleID;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Label lbEmail;
        private TextBox txtEmail_;
        private Button btnNew;
        private Button btnDelete;
        private Button btnLoad;
        private GroupBox groupBox2;
        private Label lbFindMember;
        private TextBox txtTypeSearchMemberName;
        private Label lbFindMemberID;
        private TextBox txtTypeSearchMemberID;
        private DataGridView dgvMemberList;
        private Button btnClose;
    }
}