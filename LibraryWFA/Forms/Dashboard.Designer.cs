namespace LibraryWFA.Forms
{
    partial class Dashboard
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
            this.GrbUserCrud = new System.Windows.Forms.GroupBox();
            this.BtnBookReservation = new System.Windows.Forms.Button();
            this.CmbUniqueId = new System.Windows.Forms.ComboBox();
            this.CmdBookName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLoginIcon = new System.Windows.Forms.Label();
            this.LblBookIcon = new System.Windows.Forms.Label();
            this.LblUserIcon = new System.Windows.Forms.Label();
            this.PcbAdmin = new System.Windows.Forms.PictureBox();
            this.PcbBooks = new System.Windows.Forms.PictureBox();
            this.PcbLogins = new System.Windows.Forms.PictureBox();
            this.PcbUsers = new System.Windows.Forms.PictureBox();
            this.GrbUserCrud.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminIcon
            // 
            this.lblAdminIcon.AutoSize = true;
            this.lblAdminIcon.Location = new System.Drawing.Point(792, 30);
            this.lblAdminIcon.Name = "lblAdminIcon";
            this.lblAdminIcon.Size = new System.Drawing.Size(106, 13);
            this.lblAdminIcon.TabIndex = 0;
            this.lblAdminIcon.Text = "AdminNameSurname";
            // 
            // GrbUserCrud
            // 
            this.GrbUserCrud.Controls.Add(this.BtnBookReservation);
            this.GrbUserCrud.Controls.Add(this.CmbUniqueId);
            this.GrbUserCrud.Controls.Add(this.CmdBookName);
            this.GrbUserCrud.Controls.Add(this.label8);
            this.GrbUserCrud.Controls.Add(this.label4);
            this.GrbUserCrud.Location = new System.Drawing.Point(35, 137);
            this.GrbUserCrud.Name = "GrbUserCrud";
            this.GrbUserCrud.Size = new System.Drawing.Size(285, 200);
            this.GrbUserCrud.TabIndex = 1;
            this.GrbUserCrud.TabStop = false;
            this.GrbUserCrud.Text = "Kitabi Rezervi";
            // 
            // BtnBookReservation
            // 
            this.BtnBookReservation.Location = new System.Drawing.Point(176, 160);
            this.BtnBookReservation.Name = "BtnBookReservation";
            this.BtnBookReservation.Size = new System.Drawing.Size(103, 34);
            this.BtnBookReservation.TabIndex = 12;
            this.BtnBookReservation.Text = "Rezerv et";
            this.BtnBookReservation.UseVisualStyleBackColor = true;
            this.BtnBookReservation.Click += new System.EventHandler(this.BtnBookReservation_Click);
            // 
            // CmbUniqueId
            // 
            this.CmbUniqueId.FormattingEnabled = true;
            this.CmbUniqueId.Location = new System.Drawing.Point(121, 23);
            this.CmbUniqueId.Name = "CmbUniqueId";
            this.CmbUniqueId.Size = new System.Drawing.Size(144, 21);
            this.CmbUniqueId.TabIndex = 13;
            // 
            // CmdBookName
            // 
            this.CmdBookName.FormattingEnabled = true;
            this.CmdBookName.Location = new System.Drawing.Point(121, 101);
            this.CmdBookName.Name = "CmdBookName";
            this.CmdBookName.Size = new System.Drawing.Size(144, 21);
            this.CmdBookName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kitabin adi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Musterini kodu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PcbAdmin);
            this.panel1.Controls.Add(this.PcbBooks);
            this.panel1.Controls.Add(this.PcbLogins);
            this.panel1.Controls.Add(this.PcbUsers);
            this.panel1.Controls.Add(this.LblLoginIcon);
            this.panel1.Controls.Add(this.LblBookIcon);
            this.panel1.Controls.Add(this.LblUserIcon);
            this.panel1.Controls.Add(this.lblAdminIcon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 2;
            // 
            // LblLoginIcon
            // 
            this.LblLoginIcon.AutoSize = true;
            this.LblLoginIcon.Location = new System.Drawing.Point(276, 66);
            this.LblLoginIcon.Name = "LblLoginIcon";
            this.LblLoginIcon.Size = new System.Drawing.Size(44, 13);
            this.LblLoginIcon.TabIndex = 21;
            this.LblLoginIcon.Text = "Loginler";
            this.LblLoginIcon.Visible = false;
            // 
            // LblBookIcon
            // 
            this.LblBookIcon.AutoSize = true;
            this.LblBookIcon.Location = new System.Drawing.Point(159, 66);
            this.LblBookIcon.Name = "LblBookIcon";
            this.LblBookIcon.Size = new System.Drawing.Size(42, 13);
            this.LblBookIcon.TabIndex = 3;
            this.LblBookIcon.Text = "Kitablar";
            // 
            // LblUserIcon
            // 
            this.LblUserIcon.AutoSize = true;
            this.LblUserIcon.Location = new System.Drawing.Point(32, 66);
            this.LblUserIcon.Name = "LblUserIcon";
            this.LblUserIcon.Size = new System.Drawing.Size(52, 13);
            this.LblUserIcon.TabIndex = 20;
            this.LblUserIcon.Text = "Musteriler";
            // 
            // PcbAdmin
            // 
            this.PcbAdmin.Image = global::LibraryWFA.Properties.Resources.Admin2;
            this.PcbAdmin.Location = new System.Drawing.Point(832, 3);
            this.PcbAdmin.Name = "PcbAdmin";
            this.PcbAdmin.Size = new System.Drawing.Size(24, 24);
            this.PcbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAdmin.TabIndex = 25;
            this.PcbAdmin.TabStop = false;
            // 
            // PcbBooks
            // 
            this.PcbBooks.Image = global::LibraryWFA.Properties.Resources.books;
            this.PcbBooks.Location = new System.Drawing.Point(156, 15);
            this.PcbBooks.Name = "PcbBooks";
            this.PcbBooks.Size = new System.Drawing.Size(48, 48);
            this.PcbBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBooks.TabIndex = 24;
            this.PcbBooks.TabStop = false;
            this.PcbBooks.DoubleClick += new System.EventHandler(this.PcbBooks_DoubleClick);
            // 
            // PcbLogins
            // 
            this.PcbLogins.Image = global::LibraryWFA.Properties.Resources.iconfinder_preferences_desktop_user_password_24269;
            this.PcbLogins.Location = new System.Drawing.Point(274, 15);
            this.PcbLogins.Name = "PcbLogins";
            this.PcbLogins.Size = new System.Drawing.Size(48, 48);
            this.PcbLogins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogins.TabIndex = 23;
            this.PcbLogins.TabStop = false;
            this.PcbLogins.Visible = false;
            this.PcbLogins.Click += new System.EventHandler(this.PcbLogins_Click);
            // 
            // PcbUsers
            // 
            this.PcbUsers.Image = global::LibraryWFA.Properties.Resources.usersIcon1;
            this.PcbUsers.Location = new System.Drawing.Point(34, 15);
            this.PcbUsers.Name = "PcbUsers";
            this.PcbUsers.Size = new System.Drawing.Size(48, 48);
            this.PcbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbUsers.TabIndex = 22;
            this.PcbUsers.TabStop = false;
            this.PcbUsers.DoubleClick += new System.EventHandler(this.PcbUsers_DoubleClick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrbUserCrud);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.GrbUserCrud.ResumeLayout(false);
            this.GrbUserCrud.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdminIcon;
        private System.Windows.Forms.GroupBox GrbUserCrud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmdBookName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBookReservation;
        private System.Windows.Forms.ComboBox CmbUniqueId;
        private System.Windows.Forms.Label LblUserIcon;
        private System.Windows.Forms.Label LblBookIcon;
        private System.Windows.Forms.Label LblLoginIcon;
        private System.Windows.Forms.PictureBox PcbUsers;
        private System.Windows.Forms.PictureBox PcbBooks;
        private System.Windows.Forms.PictureBox PcbLogins;
        private System.Windows.Forms.PictureBox PcbAdmin;
    }
}