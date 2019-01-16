namespace LibraryWFA.Forms
{
    partial class LoginsForm
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
            this.lblAdminIcon = new System.Windows.Forms.Label();
            this.LblLoginIcon = new System.Windows.Forms.Label();
            this.GrbAnket = new System.Windows.Forms.GroupBox();
            this.CkbIsBoss = new System.Windows.Forms.CheckBox();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvLogins = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcbLogins = new System.Windows.Forms.PictureBox();
            this.PcbAdmin = new System.Windows.Forms.PictureBox();
            this.GrbAnket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminIcon
            // 
            this.lblAdminIcon.AutoSize = true;
            this.lblAdminIcon.Location = new System.Drawing.Point(813, 39);
            this.lblAdminIcon.Name = "lblAdminIcon";
            this.lblAdminIcon.Size = new System.Drawing.Size(106, 13);
            this.lblAdminIcon.TabIndex = 26;
            this.lblAdminIcon.Text = "AdminNameSurname";
            // 
            // LblLoginIcon
            // 
            this.LblLoginIcon.AutoSize = true;
            this.LblLoginIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginIcon.Location = new System.Drawing.Point(75, 23);
            this.LblLoginIcon.Name = "LblLoginIcon";
            this.LblLoginIcon.Size = new System.Drawing.Size(78, 24);
            this.LblLoginIcon.TabIndex = 28;
            this.LblLoginIcon.Text = "Loginler";
            // 
            // GrbAnket
            // 
            this.GrbAnket.Controls.Add(this.CkbIsBoss);
            this.GrbAnket.Controls.Add(this.TxtPw);
            this.GrbAnket.Controls.Add(this.label2);
            this.GrbAnket.Controls.Add(this.BtnUpdate);
            this.GrbAnket.Controls.Add(this.BtnAdd);
            this.GrbAnket.Controls.Add(this.BtnDel);
            this.GrbAnket.Controls.Add(this.TxtLogin);
            this.GrbAnket.Controls.Add(this.label1);
            this.GrbAnket.Controls.Add(this.TxtPhone);
            this.GrbAnket.Controls.Add(this.label3);
            this.GrbAnket.Controls.Add(this.TxtSurname);
            this.GrbAnket.Controls.Add(this.label5);
            this.GrbAnket.Controls.Add(this.TxtName);
            this.GrbAnket.Controls.Add(this.label7);
            this.GrbAnket.Location = new System.Drawing.Point(12, 73);
            this.GrbAnket.Name = "GrbAnket";
            this.GrbAnket.Size = new System.Drawing.Size(283, 331);
            this.GrbAnket.TabIndex = 30;
            this.GrbAnket.TabStop = false;
            this.GrbAnket.Text = "Admin";
            // 
            // CkbIsBoss
            // 
            this.CkbIsBoss.AutoSize = true;
            this.CkbIsBoss.Location = new System.Drawing.Point(9, 237);
            this.CkbIsBoss.Name = "CkbIsBoss";
            this.CkbIsBoss.Size = new System.Drawing.Size(69, 17);
            this.CkbIsBoss.TabIndex = 26;
            this.CkbIsBoss.Text = "Idarecidir";
            this.CkbIsBoss.UseVisualStyleBackColor = true;
            // 
            // TxtPw
            // 
            this.TxtPw.Location = new System.Drawing.Point(121, 192);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.Size = new System.Drawing.Size(144, 20);
            this.TxtPw.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Parol:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUpdate.Location = new System.Drawing.Point(9, 277);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 34);
            this.BtnUpdate.TabIndex = 20;
            this.BtnUpdate.Text = "Yenile";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(85, 277);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 34);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Elave et";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(153, 277);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(112, 34);
            this.BtnDel.TabIndex = 21;
            this.BtnDel.Text = "Sil";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Visible = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(121, 150);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(144, 20);
            this.TxtLogin.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(121, 108);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(144, 20);
            this.TxtPhone.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nomresi:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(121, 66);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(144, 20);
            this.TxtSurname.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Soyadi:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(121, 24);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(144, 20);
            this.TxtName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adi:";
            // 
            // DgvLogins
            // 
            this.DgvLogins.AllowUserToAddRows = false;
            this.DgvLogins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLogins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvLogins.Location = new System.Drawing.Point(323, 73);
            this.DgvLogins.Name = "DgvLogins";
            this.DgvLogins.Size = new System.Drawing.Size(594, 331);
            this.DgvLogins.TabIndex = 31;
            this.DgvLogins.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLogins_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Elage nomresi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Login";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Parol";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Idarecidir";
            this.Column7.Name = "Column7";
            // 
            // PcbLogins
            // 
            this.PcbLogins.Image = global::LibraryWFA.Properties.Resources.iconfinder_preferences_desktop_user_password_24269;
            this.PcbLogins.Location = new System.Drawing.Point(21, 12);
            this.PcbLogins.Name = "PcbLogins";
            this.PcbLogins.Size = new System.Drawing.Size(48, 48);
            this.PcbLogins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogins.TabIndex = 29;
            this.PcbLogins.TabStop = false;
            // 
            // PcbAdmin
            // 
            this.PcbAdmin.Image = global::LibraryWFA.Properties.Resources.Admin2;
            this.PcbAdmin.Location = new System.Drawing.Point(852, 12);
            this.PcbAdmin.Name = "PcbAdmin";
            this.PcbAdmin.Size = new System.Drawing.Size(24, 24);
            this.PcbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAdmin.TabIndex = 27;
            this.PcbAdmin.TabStop = false;
            // 
            // LoginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 470);
            this.Controls.Add(this.DgvLogins);
            this.Controls.Add(this.GrbAnket);
            this.Controls.Add(this.PcbLogins);
            this.Controls.Add(this.LblLoginIcon);
            this.Controls.Add(this.PcbAdmin);
            this.Controls.Add(this.lblAdminIcon);
            this.Name = "LoginsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logins";
            this.GrbAnket.ResumeLayout(false);
            this.GrbAnket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbAdmin;
        private System.Windows.Forms.Label lblAdminIcon;
        private System.Windows.Forms.PictureBox PcbLogins;
        private System.Windows.Forms.Label LblLoginIcon;
        private System.Windows.Forms.GroupBox GrbAnket;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvLogins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox CkbIsBoss;
    }
}