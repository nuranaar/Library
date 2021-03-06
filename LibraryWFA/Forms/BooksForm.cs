﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryWFA.Models;
using LibraryWFA.Forms;

namespace LibraryWFA.Forms
{
    public partial class BooksForm : Form
    {
        LibraryEntities db = new LibraryEntities();
        private Admin Admin;
        private int AdminId;
        private Book book;
        int BookId;
        public BooksForm(int adminId)
        {
            AdminId = adminId;
            Admin = db.Admins.Find(adminId);
            InitializeComponent();
            FillDgvBooks();
            IfAdminBoss();
            FillCmbBook();
        }

        //admin eyer bosdursa
        private void IfAdminBoss()
        {
            BtnDel.Enabled = true;
            BtnUpdate.Enabled = true;
        }

        #region Creat Book
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtName.Text)|| NudCount.Value==0)
            {
                MessageBox.Show("Xanalari doldurun!");
                return;
            }

            book = new Book()
            {
                Name = TxtName.Text,
                Count = Convert.ToInt32(NudCount.Value)
            };
            db.Books.Add(book);
            db.SaveChanges();
            FillDgvBooks();
            Reset();
        }
        #endregion

        #region Read Book
        private void FillDgvBooks()
        {
            DgvBooks.Rows.Clear();
            foreach (Book book in db.Books.ToList())
            {
                DgvBooks.Rows.Add(book.Id, book.Name, book.Count);
            }
        }

        #endregion

        #region Update And Delet Book

        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Visible = false;
            BtnDel.Visible = true;
            BtnUpdate.Visible = true;

            BookId = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());

            book = db.Books.Find(BookId);

            TxtName.Text = book.Name;
            NudCount.Value = Convert.ToDecimal(book.Count);
            
        }
        

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtName.Text) || NudCount.Value == 0)
            {
                MessageBox.Show("Xanalari doldurun!");
                return;
            }
            book = db.Books.Find(BookId);
            book.Name = TxtName.Text;
            book.Count = Convert.ToInt32(NudCount.Value);
           
            db.SaveChanges();
            MessageBox.Show("Yenilendi");
            FillDgvBooks();
            Reset();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            book = db.Books.Find(BookId);
            DialogResult r = MessageBox.Show("Bu kitabi silmək istəyirsiniz mi?", "Silmək", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                MessageBox.Show("Silindi");
                FillDgvBooks();
                Reset();

            }
        }
        #endregion

        private void Reset()
        {
            BtnAdd.Visible = true;
            BtnDel.Visible = false;
            BtnUpdate.Visible = false;
            TxtName.ResetText();
            NudCount.Value=0;
            CmbBookName.ResetText();
        }

        private void FillCmbBook()
        {
            foreach (Book b in db.Books.ToList())
            {
                CmbBookName.Items.Add(b.Name);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvBooks.Rows.Clear();
            if (!string.IsNullOrEmpty(CmbBookName.Text))
            {
                book = db.Books.FirstOrDefault(b => b.Name == CmbBookName.Text);
            }
            DgvBooks.Rows.Add(book.Id, book.Name, book.Count);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
            FillDgvBooks();
        }
    }
}
