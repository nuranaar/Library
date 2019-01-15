namespace LibraryWFA.Forms
{
    partial class BooksForm
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
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NudCount = new System.Windows.Forms.NumericUpDown();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PcbBooks = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvBooks.Location = new System.Drawing.Point(341, 80);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.Size = new System.Drawing.Size(287, 171);
            this.DgvBooks.TabIndex = 0;
            this.DgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sayi";
            this.Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NudCount);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.BtnDel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitab";
            // 
            // NudCount
            // 
            this.NudCount.Location = new System.Drawing.Point(101, 63);
            this.NudCount.Name = "NudCount";
            this.NudCount.Size = new System.Drawing.Size(164, 20);
            this.NudCount.TabIndex = 25;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUpdate.Location = new System.Drawing.Point(9, 118);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(112, 34);
            this.BtnUpdate.TabIndex = 23;
            this.BtnUpdate.Text = "Yenile";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(85, 118);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 34);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "Elave et";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(153, 118);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(112, 34);
            this.BtnDel.TabIndex = 24;
            this.BtnDel.Text = "Sil";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Visible = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayi:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(101, 19);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(164, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitabin adi:";
            // 
            // PcbBooks
            // 
            this.PcbBooks.Image = global::LibraryWFA.Properties.Resources.books;
            this.PcbBooks.Location = new System.Drawing.Point(21, 12);
            this.PcbBooks.Name = "PcbBooks";
            this.PcbBooks.Size = new System.Drawing.Size(48, 48);
            this.PcbBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBooks.TabIndex = 26;
            this.PcbBooks.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kitablar";
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(548, 257);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(80, 47);
            this.BtnHome.TabIndex = 27;
            this.BtnHome.Text = "Ana Sehife";
            this.BtnHome.UseVisualStyleBackColor = true;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 316);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.PcbBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvBooks);
            this.Name = "BooksForm";
            this.Text = "Books";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BooksForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PcbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.NumericUpDown NudCount;
        private System.Windows.Forms.Button BtnHome;
    }
}