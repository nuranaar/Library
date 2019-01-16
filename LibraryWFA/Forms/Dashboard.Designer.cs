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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblAdminIcon = new System.Windows.Forms.Label();
            this.GrbUserCrud = new System.Windows.Forms.GroupBox();
            this.TxtUniqueId = new System.Windows.Forms.TextBox();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnBookReservation = new System.Windows.Forms.Button();
            this.PnlDateTime = new System.Windows.Forms.Panel();
            this.TxtStartTime = new System.Windows.Forms.TextBox();
            this.TxtEndTime = new System.Windows.Forms.TextBox();
            this.TxtPenalty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PnlUser = new System.Windows.Forms.Panel();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUniqueId = new System.Windows.Forms.ComboBox();
            this.CmdBookName = new System.Windows.Forms.ComboBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblReserveIcon = new System.Windows.Forms.Label();
            this.LblLoginIcon = new System.Windows.Forms.Label();
            this.LblBookIcon = new System.Windows.Forms.Label();
            this.LblUserIcon = new System.Windows.Forms.Label();
            this.DgvReserves = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcbReserves = new System.Windows.Forms.PictureBox();
            this.PcbAdmin = new System.Windows.Forms.PictureBox();
            this.PcbBooks = new System.Windows.Forms.PictureBox();
            this.PcbLogins = new System.Windows.Forms.PictureBox();
            this.PcbUsers = new System.Windows.Forms.PictureBox();
            this.GrbUserCrud.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlDateTime.SuspendLayout();
            this.PnlUser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReserves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminIcon
            // 
            resources.ApplyResources(this.lblAdminIcon, "lblAdminIcon");
            this.lblAdminIcon.Name = "lblAdminIcon";
            // 
            // GrbUserCrud
            // 
            this.GrbUserCrud.Controls.Add(this.TxtUniqueId);
            this.GrbUserCrud.Controls.Add(this.PnlButtons);
            this.GrbUserCrud.Controls.Add(this.PnlDateTime);
            this.GrbUserCrud.Controls.Add(this.PnlUser);
            this.GrbUserCrud.Controls.Add(this.CmbUniqueId);
            this.GrbUserCrud.Controls.Add(this.CmdBookName);
            this.GrbUserCrud.Controls.Add(this.LblBookName);
            this.GrbUserCrud.Controls.Add(this.label4);
            resources.ApplyResources(this.GrbUserCrud, "GrbUserCrud");
            this.GrbUserCrud.Name = "GrbUserCrud";
            this.GrbUserCrud.TabStop = false;
            // 
            // TxtUniqueId
            // 
            resources.ApplyResources(this.TxtUniqueId, "TxtUniqueId");
            this.TxtUniqueId.Name = "TxtUniqueId";
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnEnd);
            this.PnlButtons.Controls.Add(this.BtnUpdate);
            this.PnlButtons.Controls.Add(this.BtnBookReservation);
            resources.ApplyResources(this.PnlButtons, "PnlButtons");
            this.PnlButtons.Name = "PnlButtons";
            // 
            // BtnEnd
            // 
            resources.ApplyResources(this.BtnEnd, "BtnEnd");
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            resources.ApplyResources(this.BtnUpdate, "BtnUpdate");
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnBookReservation
            // 
            resources.ApplyResources(this.BtnBookReservation, "BtnBookReservation");
            this.BtnBookReservation.Name = "BtnBookReservation";
            this.BtnBookReservation.UseVisualStyleBackColor = true;
            this.BtnBookReservation.Click += new System.EventHandler(this.BtnBookReservation_Click);
            // 
            // PnlDateTime
            // 
            this.PnlDateTime.Controls.Add(this.TxtStartTime);
            this.PnlDateTime.Controls.Add(this.TxtEndTime);
            this.PnlDateTime.Controls.Add(this.TxtPenalty);
            this.PnlDateTime.Controls.Add(this.label11);
            this.PnlDateTime.Controls.Add(this.label9);
            this.PnlDateTime.Controls.Add(this.label10);
            resources.ApplyResources(this.PnlDateTime, "PnlDateTime");
            this.PnlDateTime.Name = "PnlDateTime";
            // 
            // TxtStartTime
            // 
            resources.ApplyResources(this.TxtStartTime, "TxtStartTime");
            this.TxtStartTime.Name = "TxtStartTime";
            // 
            // TxtEndTime
            // 
            resources.ApplyResources(this.TxtEndTime, "TxtEndTime");
            this.TxtEndTime.Name = "TxtEndTime";
            // 
            // TxtPenalty
            // 
            resources.ApplyResources(this.TxtPenalty, "TxtPenalty");
            this.TxtPenalty.Name = "TxtPenalty";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // PnlUser
            // 
            this.PnlUser.Controls.Add(this.TxtPhone);
            this.PnlUser.Controls.Add(this.label3);
            this.PnlUser.Controls.Add(this.TxtSurname);
            this.PnlUser.Controls.Add(this.label1);
            this.PnlUser.Controls.Add(this.TxtName);
            this.PnlUser.Controls.Add(this.label2);
            resources.ApplyResources(this.PnlUser, "PnlUser");
            this.PnlUser.Name = "PnlUser";
            // 
            // TxtPhone
            // 
            resources.ApplyResources(this.TxtPhone, "TxtPhone");
            this.TxtPhone.Name = "TxtPhone";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtSurname
            // 
            resources.ApplyResources(this.TxtSurname, "TxtSurname");
            this.TxtSurname.Name = "TxtSurname";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.Name = "TxtName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CmbUniqueId
            // 
            this.CmbUniqueId.FormattingEnabled = true;
            resources.ApplyResources(this.CmbUniqueId, "CmbUniqueId");
            this.CmbUniqueId.Name = "CmbUniqueId";
            this.CmbUniqueId.SelectedIndexChanged += new System.EventHandler(this.CmbUniqueId_SelectedIndexChanged);
            // 
            // CmdBookName
            // 
            this.CmdBookName.FormattingEnabled = true;
            resources.ApplyResources(this.CmdBookName, "CmdBookName");
            this.CmdBookName.Name = "CmdBookName";
            this.CmdBookName.SelectedIndexChanged += new System.EventHandler(this.CmdBookName_SelectedIndexChanged);
            // 
            // LblBookName
            // 
            resources.ApplyResources(this.LblBookName, "LblBookName");
            this.LblBookName.Name = "LblBookName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.PcbReserves);
            this.panel1.Controls.Add(this.LblReserveIcon);
            this.panel1.Controls.Add(this.PcbAdmin);
            this.panel1.Controls.Add(this.PcbBooks);
            this.panel1.Controls.Add(this.PcbLogins);
            this.panel1.Controls.Add(this.PcbUsers);
            this.panel1.Controls.Add(this.LblLoginIcon);
            this.panel1.Controls.Add(this.LblBookIcon);
            this.panel1.Controls.Add(this.LblUserIcon);
            this.panel1.Controls.Add(this.lblAdminIcon);
            this.panel1.Name = "panel1";
            // 
            // LblReserveIcon
            // 
            resources.ApplyResources(this.LblReserveIcon, "LblReserveIcon");
            this.LblReserveIcon.Name = "LblReserveIcon";
            // 
            // LblLoginIcon
            // 
            resources.ApplyResources(this.LblLoginIcon, "LblLoginIcon");
            this.LblLoginIcon.Name = "LblLoginIcon";
            // 
            // LblBookIcon
            // 
            resources.ApplyResources(this.LblBookIcon, "LblBookIcon");
            this.LblBookIcon.Name = "LblBookIcon";
            // 
            // LblUserIcon
            // 
            resources.ApplyResources(this.LblUserIcon, "LblUserIcon");
            this.LblUserIcon.Name = "LblUserIcon";
            // 
            // DgvReserves
            // 
            this.DgvReserves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReserves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column6,
            this.Column9});
            resources.ApplyResources(this.DgvReserves, "DgvReserves");
            this.DgvReserves.Name = "DgvReserves";
            this.DgvReserves.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvReserves_RowHeaderMouseClick);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            // 
            // PcbReserves
            // 
            this.PcbReserves.Image = global::LibraryWFA.Properties.Resources.reserve;
            resources.ApplyResources(this.PcbReserves, "PcbReserves");
            this.PcbReserves.Name = "PcbReserves";
            this.PcbReserves.TabStop = false;
            this.PcbReserves.DoubleClick += new System.EventHandler(this.PcbReserves_DoubleClick);
            // 
            // PcbAdmin
            // 
            resources.ApplyResources(this.PcbAdmin, "PcbAdmin");
            this.PcbAdmin.Image = global::LibraryWFA.Properties.Resources.Admin2;
            this.PcbAdmin.Name = "PcbAdmin";
            this.PcbAdmin.TabStop = false;
            this.PcbAdmin.DoubleClick += new System.EventHandler(this.PcbAdmin_DoubleClick);
            // 
            // PcbBooks
            // 
            this.PcbBooks.Image = global::LibraryWFA.Properties.Resources.books;
            resources.ApplyResources(this.PcbBooks, "PcbBooks");
            this.PcbBooks.Name = "PcbBooks";
            this.PcbBooks.TabStop = false;
            this.PcbBooks.DoubleClick += new System.EventHandler(this.PcbBooks_DoubleClick);
            // 
            // PcbLogins
            // 
            this.PcbLogins.Image = global::LibraryWFA.Properties.Resources.iconfinder_preferences_desktop_user_password_24269;
            resources.ApplyResources(this.PcbLogins, "PcbLogins");
            this.PcbLogins.Name = "PcbLogins";
            this.PcbLogins.TabStop = false;
            this.PcbLogins.DoubleClick += new System.EventHandler(this.PcbLogins_DoubleClick);
            // 
            // PcbUsers
            // 
            this.PcbUsers.Image = global::LibraryWFA.Properties.Resources.usersIcon1;
            resources.ApplyResources(this.PcbUsers, "PcbUsers");
            this.PcbUsers.Name = "PcbUsers";
            this.PcbUsers.TabStop = false;
            this.PcbUsers.DoubleClick += new System.EventHandler(this.PcbUsers_DoubleClick);
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvReserves);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrbUserCrud);
            this.Name = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.GrbUserCrud.ResumeLayout(false);
            this.GrbUserCrud.PerformLayout();
            this.PnlButtons.ResumeLayout(false);
            this.PnlDateTime.ResumeLayout(false);
            this.PnlDateTime.PerformLayout();
            this.PnlUser.ResumeLayout(false);
            this.PnlUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReserves)).EndInit();
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
        private System.Windows.Forms.Label LblBookName;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Panel PnlUser;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvReserves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel PnlDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPenalty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtStartTime;
        private System.Windows.Forms.TextBox TxtEndTime;
        private System.Windows.Forms.TextBox TxtUniqueId;
        private System.Windows.Forms.PictureBox PcbReserves;
        private System.Windows.Forms.Label LblReserveIcon;
    }
}