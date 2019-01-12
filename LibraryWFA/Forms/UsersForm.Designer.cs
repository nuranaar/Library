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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtUniqueId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrbAnket.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbAnket
            // 
            this.GrbAnket.Controls.Add(this.BtnAdd);
            this.GrbAnket.Controls.Add(this.TxtUniqueId);
            this.GrbAnket.Controls.Add(this.label1);
            this.GrbAnket.Controls.Add(this.TxtPhone);
            this.GrbAnket.Controls.Add(this.label3);
            this.GrbAnket.Controls.Add(this.TxtSurname);
            this.GrbAnket.Controls.Add(this.label5);
            this.GrbAnket.Controls.Add(this.TxtName);
            this.GrbAnket.Controls.Add(this.label7);
            this.GrbAnket.Location = new System.Drawing.Point(12, 50);
            this.GrbAnket.Name = "GrbAnket";
            this.GrbAnket.Size = new System.Drawing.Size(415, 201);
            this.GrbAnket.TabIndex = 4;
            this.GrbAnket.TabStop = false;
            this.GrbAnket.Text = "Yeni Musteri";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(306, 161);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 34);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Musterini elave et";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtUniqueId
            // 
            this.TxtUniqueId.Location = new System.Drawing.Point(135, 150);
            this.TxtUniqueId.Name = "TxtUniqueId";
            this.TxtUniqueId.Size = new System.Drawing.Size(144, 20);
            this.TxtUniqueId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Musterini kodu:";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(135, 109);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(144, 20);
            this.TxtPhone.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Musterini nomresi:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(135, 68);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(144, 20);
            this.TxtSurname.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Musterini soyadi:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(135, 27);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(144, 20);
            this.TxtName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Musterini adi:";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 342);
            this.Controls.Add(this.GrbAnket);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.GrbAnket.ResumeLayout(false);
            this.GrbAnket.PerformLayout();
            this.ResumeLayout(false);

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
    }
}