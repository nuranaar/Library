namespace LibraryWFA
{
    partial class ReserveForm
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
            this.GrbUserCrud = new System.Windows.Forms.GroupBox();
            this.TxtUniqueId = new System.Windows.Forms.TextBox();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnBookReservation = new System.Windows.Forms.Button();
            this.PnlDateTime = new System.Windows.Forms.Panel();
            this.TxtStartTime = new System.Windows.Forms.TextBox();
            this.TxtPenalty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.PcbReserves = new System.Windows.Forms.PictureBox();
            this.LblReserveIcon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserves)).BeginInit();
            this.GrbUserCrud.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlDateTime.SuspendLayout();
            this.PnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReserves)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReserves
            // 
            this.DgvReserves.AllowUserToAddRows = false;
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
            this.DgvReserves.Location = new System.Drawing.Point(9, 77);
            this.DgvReserves.Name = "DgvReserves";
            this.DgvReserves.Size = new System.Drawing.Size(740, 290);
            this.DgvReserves.TabIndex = 28;
            this.DgvReserves.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvReserves_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Musteri";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Elage nomresi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Musterinin kodu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kitabin adi";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Verilme tarixi";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Alinma tarixi";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kitabi veren shexs";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cerime";
            this.Column9.Name = "Column9";
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
            this.GrbUserCrud.Location = new System.Drawing.Point(769, 77);
            this.GrbUserCrud.Name = "GrbUserCrud";
            this.GrbUserCrud.Size = new System.Drawing.Size(285, 290);
            this.GrbUserCrud.TabIndex = 27;
            this.GrbUserCrud.TabStop = false;
            this.GrbUserCrud.Text = "Kitabi Rezervi";
            // 
            // TxtUniqueId
            // 
            this.TxtUniqueId.Location = new System.Drawing.Point(121, 24);
            this.TxtUniqueId.Name = "TxtUniqueId";
            this.TxtUniqueId.Size = new System.Drawing.Size(144, 20);
            this.TxtUniqueId.TabIndex = 24;
            this.TxtUniqueId.Visible = false;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnEnd);
            this.PnlButtons.Controls.Add(this.BtnUpdate);
            this.PnlButtons.Controls.Add(this.BtnBookReservation);
            this.PnlButtons.Location = new System.Drawing.Point(6, 92);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(273, 70);
            this.PnlButtons.TabIndex = 23;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Enabled = false;
            this.BtnEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEnd.Location = new System.Drawing.Point(140, 19);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(108, 34);
            this.BtnEnd.TabIndex = 14;
            this.BtnEnd.Text = "Sonlandir";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Visible = false;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdate.Location = new System.Drawing.Point(27, 19);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(108, 34);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "Yenile";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            // 
            // BtnBookReservation
            // 
            this.BtnBookReservation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBookReservation.Location = new System.Drawing.Point(27, 18);
            this.BtnBookReservation.Name = "BtnBookReservation";
            this.BtnBookReservation.Size = new System.Drawing.Size(221, 34);
            this.BtnBookReservation.TabIndex = 12;
            this.BtnBookReservation.Text = "Rezerv et";
            this.BtnBookReservation.UseVisualStyleBackColor = true;
            this.BtnBookReservation.Click += new System.EventHandler(this.BtnBookReservation_Click);
            // 
            // PnlDateTime
            // 
            this.PnlDateTime.Controls.Add(this.TxtStartTime);
            this.PnlDateTime.Controls.Add(this.TxtPenalty);
            this.PnlDateTime.Controls.Add(this.label11);
            this.PnlDateTime.Controls.Add(this.label10);
            this.PnlDateTime.Location = new System.Drawing.Point(6, 144);
            this.PnlDateTime.Name = "PnlDateTime";
            this.PnlDateTime.Size = new System.Drawing.Size(273, 121);
            this.PnlDateTime.TabIndex = 10;
            this.PnlDateTime.Visible = false;
            // 
            // TxtStartTime
            // 
            this.TxtStartTime.Location = new System.Drawing.Point(115, 24);
            this.TxtStartTime.Name = "TxtStartTime";
            this.TxtStartTime.Size = new System.Drawing.Size(144, 20);
            this.TxtStartTime.TabIndex = 24;
            // 
            // TxtPenalty
            // 
            this.TxtPenalty.Location = new System.Drawing.Point(115, 73);
            this.TxtPenalty.Name = "TxtPenalty";
            this.TxtPenalty.Size = new System.Drawing.Size(144, 20);
            this.TxtPenalty.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Cerime";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Verilme tarixi";
            // 
            // PnlUser
            // 
            this.PnlUser.Controls.Add(this.TxtPhone);
            this.PnlUser.Controls.Add(this.label3);
            this.PnlUser.Controls.Add(this.TxtSurname);
            this.PnlUser.Controls.Add(this.label1);
            this.PnlUser.Controls.Add(this.TxtName);
            this.PnlUser.Controls.Add(this.label2);
            this.PnlUser.Location = new System.Drawing.Point(9, 144);
            this.PnlUser.Name = "PnlUser";
            this.PnlUser.Size = new System.Drawing.Size(270, 124);
            this.PnlUser.TabIndex = 19;
            this.PnlUser.Visible = false;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Enabled = false;
            this.TxtPhone.Location = new System.Drawing.Point(112, 85);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(144, 20);
            this.TxtPhone.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Elage nomresi:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Enabled = false;
            this.TxtSurname.Location = new System.Drawing.Point(112, 44);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(144, 20);
            this.TxtSurname.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Musterini adi:";
            // 
            // TxtName
            // 
            this.TxtName.Enabled = false;
            this.TxtName.Location = new System.Drawing.Point(112, 8);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(144, 20);
            this.TxtName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Musterini soyadi:";
            // 
            // CmbUniqueId
            // 
            this.CmbUniqueId.FormattingEnabled = true;
            this.CmbUniqueId.Location = new System.Drawing.Point(121, 23);
            this.CmbUniqueId.Name = "CmbUniqueId";
            this.CmbUniqueId.Size = new System.Drawing.Size(144, 21);
            this.CmbUniqueId.TabIndex = 13;
            this.CmbUniqueId.SelectedIndexChanged += new System.EventHandler(this.CmbUniqueId_SelectedIndexChanged);
            // 
            // CmdBookName
            // 
            this.CmdBookName.FormattingEnabled = true;
            this.CmdBookName.Location = new System.Drawing.Point(121, 62);
            this.CmdBookName.Name = "CmdBookName";
            this.CmdBookName.Size = new System.Drawing.Size(144, 21);
            this.CmdBookName.TabIndex = 9;
            this.CmdBookName.SelectedIndexChanged += new System.EventHandler(this.CmdBookName_SelectedIndexChanged);
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblBookName.Location = new System.Drawing.Point(6, 68);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(59, 13);
            this.LblBookName.TabIndex = 6;
            this.LblBookName.Text = "Kitabin adi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Musterini kodu:";
            // 
            // PcbReserves
            // 
            this.PcbReserves.Image = global::LibraryWFA.Properties.Resources.reserve;
            this.PcbReserves.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PcbReserves.Location = new System.Drawing.Point(22, 14);
            this.PcbReserves.Name = "PcbReserves";
            this.PcbReserves.Size = new System.Drawing.Size(48, 48);
            this.PcbReserves.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbReserves.TabIndex = 30;
            this.PcbReserves.TabStop = false;
            // 
            // LblReserveIcon
            // 
            this.LblReserveIcon.AutoSize = true;
            this.LblReserveIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReserveIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblReserveIcon.Location = new System.Drawing.Point(76, 27);
            this.LblReserveIcon.Name = "LblReserveIcon";
            this.LblReserveIcon.Size = new System.Drawing.Size(90, 24);
            this.LblReserveIcon.TabIndex = 29;
            this.LblReserveIcon.Text = "Rezervler";
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.PcbReserves);
            this.Controls.Add(this.LblReserveIcon);
            this.Controls.Add(this.DgvReserves);
            this.Controls.Add(this.GrbUserCrud);
            this.Name = "ReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervler";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserves)).EndInit();
            this.GrbUserCrud.ResumeLayout(false);
            this.GrbUserCrud.PerformLayout();
            this.PnlButtons.ResumeLayout(false);
            this.PnlDateTime.ResumeLayout(false);
            this.PnlDateTime.PerformLayout();
            this.PnlUser.ResumeLayout(false);
            this.PnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbReserves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox GrbUserCrud;
        private System.Windows.Forms.TextBox TxtUniqueId;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBookReservation;
        private System.Windows.Forms.Panel PnlDateTime;
        private System.Windows.Forms.TextBox TxtStartTime;
        private System.Windows.Forms.TextBox TxtPenalty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PnlUser;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUniqueId;
        private System.Windows.Forms.ComboBox CmdBookName;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PcbReserves;
        private System.Windows.Forms.Label LblReserveIcon;
    }
}