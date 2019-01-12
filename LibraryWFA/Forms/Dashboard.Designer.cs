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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.GrbUserCrud = new System.Windows.Forms.GroupBox();
            this.BtnBookReservation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmdBookName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbUniqueId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrbUserCrud.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(801, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(106, 13);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "AdminNameSurname";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Musterini kodu:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 2;
            // 
            // CmbUniqueId
            // 
            this.CmbUniqueId.FormattingEnabled = true;
            this.CmbUniqueId.Location = new System.Drawing.Point(121, 23);
            this.CmbUniqueId.Name = "CmbUniqueId";
            this.CmbUniqueId.Size = new System.Drawing.Size(144, 21);
            this.CmbUniqueId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Musteriler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitablar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Loginler";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox GrbUserCrud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmdBookName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBookReservation;
        private System.Windows.Forms.ComboBox CmbUniqueId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}