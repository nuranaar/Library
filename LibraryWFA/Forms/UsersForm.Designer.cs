namespace LibraryWFA.Forms
{
    partial class UsersForm
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
            this.GrbAnket = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.TxtUniqueId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbSearchAdmin = new System.Windows.Forms.ComboBox();
            this.CmbSearchId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GrbAnket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbAnket
            // 
            this.GrbAnket.Controls.Add(this.BtnUpdate);
            this.GrbAnket.Controls.Add(this.BtnAdd);
            this.GrbAnket.Controls.Add(this.BtnDel);
            this.GrbAnket.Controls.Add(this.TxtUniqueId);
            this.GrbAnket.Controls.Add(this.label1);
            this.GrbAnket.Controls.Add(this.TxtPhone);
            this.GrbAnket.Controls.Add(this.label3);
            this.GrbAnket.Controls.Add(this.TxtSurname);
            this.GrbAnket.Controls.Add(this.label5);
            this.GrbAnket.Controls.Add(this.TxtName);
            this.GrbAnket.Controls.Add(this.label7);
            this.GrbAnket.Location = new System.Drawing.Point(12, 157);
            this.GrbAnket.Name = "GrbAnket";
            this.GrbAnket.Size = new System.Drawing.Size(283, 255);
            this.GrbAnket.TabIndex = 4;
            this.GrbAnket.TabStop = false;
            this.GrbAnket.Text = "Musteri";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUpdate.Location = new System.Drawing.Point(9, 193);
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
            this.BtnAdd.Location = new System.Drawing.Point(85, 193);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 34);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Elave et";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(153, 193);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(112, 34);
            this.BtnDel.TabIndex = 21;
            this.BtnDel.Text = "Sil";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Visible = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // TxtUniqueId
            // 
            this.TxtUniqueId.Location = new System.Drawing.Point(121, 147);
            this.TxtUniqueId.Name = "TxtUniqueId";
            this.TxtUniqueId.Size = new System.Drawing.Size(144, 20);
            this.TxtUniqueId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Musterini kodu:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(121, 106);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(144, 20);
            this.TxtPhone.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Musterini nomresi:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(121, 65);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(144, 20);
            this.TxtSurname.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Musterini soyadi:";
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
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Musterini adi:";
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvUsers.Location = new System.Drawing.Point(313, 157);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.Size = new System.Drawing.Size(556, 255);
            this.DgvUsers.TabIndex = 5;
            this.DgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUsers_RowHeaderMouseClick);
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
            this.Column5.HeaderText = "Kod";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Qeydiyyata salan wexs";
            this.Column6.Name = "Column6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Musteriler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryWFA.Properties.Resources.usersIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbSearchAdmin);
            this.groupBox1.Controls.Add(this.CmbSearchId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 71);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axraris";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::LibraryWFA.Properties.Resources.search;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Location = new System.Drawing.Point(682, 14);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(48, 48);
            this.BtnSearch.TabIndex = 37;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackgroundImage = global::LibraryWFA.Properties.Resources.reset;
            this.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Location = new System.Drawing.Point(746, 14);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(48, 48);
            this.BtnReset.TabIndex = 36;
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(311, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Qeydiyyata salan wexsin ad:";
            // 
            // CmbSearchAdmin
            // 
            this.CmbSearchAdmin.FormattingEnabled = true;
            this.CmbSearchAdmin.Location = new System.Drawing.Point(467, 28);
            this.CmbSearchAdmin.Name = "CmbSearchAdmin";
            this.CmbSearchAdmin.Size = new System.Drawing.Size(144, 21);
            this.CmbSearchAdmin.TabIndex = 33;
            // 
            // CmbSearchId
            // 
            this.CmbSearchId.FormattingEnabled = true;
            this.CmbSearchId.Location = new System.Drawing.Point(107, 28);
            this.CmbSearchId.Name = "CmbSearchId";
            this.CmbSearchId.Size = new System.Drawing.Size(144, 21);
            this.CmbSearchId.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Musterini kodu:";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.GrbAnket);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.GrbAnket.ResumeLayout(false);
            this.GrbAnket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbAnket;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtUniqueId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbSearchAdmin;
        private System.Windows.Forms.ComboBox CmbSearchId;
        private System.Windows.Forms.Label label6;
    }
}