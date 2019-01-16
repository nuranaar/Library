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
using LibraryWFA.Properties;

namespace LibraryWFA.Forms
{
    public partial class Dashboard : Form
    {
        LibraryEntities db = new LibraryEntities();
        private User User;
        private Book book;
        private Admin admin;
        private int reserveId;
        private BookReserve reserve;
        public Dashboard(int adminId)
        {
            admin = db.Admins.Find(adminId);
            InitializeComponent();
            FillCmbUniqueId();
            FillCmbBookName();
            IfAdminBoss();
            FillDgvReserves();
        }

        //admin eyer bosdursa
        private void IfAdminBoss()
        {
            lblAdminIcon.Text = admin.Name + " " + admin.Surname;
            if (admin.IsBoss == true)
            {
                PcbAdmin.Image = Resources.boss2;
                PcbLogins.Visible = true;
                LblLoginIcon.Visible = true;
            }
        }
        
        private void FillCmbBookName()
        {
            foreach (Book book in db.Books.ToList())
            {
                CmdBookName.Items.Add(book.Name);
                if (book.Count == 0)
                {
                    CmdBookName.Enabled = false;
                    CmdBookName.ForeColor = SystemColors.WindowFrame;
                }
            }
        }
        
        private void FillCmbUniqueId()
        {
            foreach (User user in db.Users.ToList())
            {
                CmbUniqueId.Items.Add(user.UserUniqueId);
            }
        }
        private void CmbUniqueId_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (User user in db.Users.Where(u => u.UserUniqueId == CmbUniqueId.Text).ToList())
            {
                PnlUser.Visible = true;
                PnlDateTime.Visible = false;
                GrbUserCrud.Size = new Size(285, 290); 
                PnlUser.Location = new Point(9, 59);
                PnlButtons.Location = new Point(6, 214);
                LblBookName.Location = new Point(6, 196);
                CmdBookName.Location = new Point(121, 190);
                TxtName.Text = user.Name;
                TxtPhone.Text = user.Phone;
                TxtSurname.Text = user.Surname;
                User = user;
            }
        }
        private void CmdBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Book b in db.Books.Where(b=>b.Name==CmdBookName.Text))
            {
                book = b;
            }
        }
        private void FillDgvReserves()
        {
            DgvReserves.Rows.Clear();
            foreach (BookReserve br in db.BookReserves.ToList())
            {
                
                User = db.Users.Find(br.UserId);
                admin = db.Admins.Find(br.AdminId);
                book = db.Books.Find(br.BookId);
                DgvReserves.Rows.Add(br.Id, User.Name + User.Surname, User.Phone, User.UserUniqueId, book.Name, Convert.ToDateTime(br.StartTime).ToString("dd.MM.yy"), Convert.ToDateTime( br.EndTime).ToString("dd.MM.yy"), admin.Name + admin.Surname, Convert.ToInt32(br.Penalty));
            }
        }
        #region Create Reserve


        private void BtnBookReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmbUniqueId.Text) || string.IsNullOrEmpty(CmdBookName.Text))
            {
                MessageBox.Show("Xanalari doldurun");
            }
            DateTime STime = DateTime.Now;
            DateTime ETime = STime.AddDays(30);

            BookReserve bookReserve = new BookReserve()
            {
                UserId = User.Id,
                BookId = book.Id,
                AdminId = admin.Id,
                StartTime = STime,
                EndTime = ETime
            };


            FillDgvReserves();
        }
        #endregion

        private void DgvReserves_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reserveId = Convert.ToInt32(DgvReserves.Rows[e.RowIndex].Cells[0].Value);
            reserve = db.BookReserves.Find(reserveId);
            User = db.Users.Find(reserve.UserId);
            admin=db.Admins.Find(reserve.AdminId);
            book=db.Books.Find(reserve.BookId);

            TxtUniqueId.Visible = true;
            CmbUniqueId.Visible = false;
            LblBookName.Location = new Point(6, 196);
            CmdBookName.Location = new Point(121, 190);
            PnlButtons.Location = new Point(6, 214);
            PnlUser.Visible = false;
            PnlDateTime.Visible = true;
            PnlDateTime.Location = new Point(5, 59);
            BtnBookReservation.Visible = false;
            BtnEnd.Visible = true;
            BtnUpdate.Visible = true;

            TxtUniqueId.Text = User.UserUniqueId;
            CmdBookName.Text = book.Name;

            TxtEndTime.Text = Convert.ToDateTime(reserve.EndTime).ToString("dd.mm.yy");
            TxtStartTime.Text = Convert.ToDateTime(reserve.StartTime).ToString("dd.mm.yy");
            TxtPenalty.Text = reserve.Penalty.ToString();
        }

        // doubleClikde user formunun acilmasi
        private void PcbUsers_DoubleClick(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm(admin.Id);
            userForm.Show();

        }

        // doubleClikde book formunun acilmasi
        private void PcbBooks_DoubleClick(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm(admin.Id);
            booksForm.Show();
        }

        // doubleClikde login formunun acilmasi
        private void PcbLogins_DoubleClick(object sender, EventArgs e)
        {
            LoginsForm loginsForm = new LoginsForm(admin.Id);
            loginsForm.Show();
        }

        // doubleClikde Update akkaunt formunun acilmasi
        private void PcbAdmin_DoubleClick(object sender, EventArgs e)
        {
            UpdateLogin updateLogin = new UpdateLogin(admin.Id);
            updateLogin.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PcbReserves_DoubleClick(object sender, EventArgs e)
        {
            ReserveForm reserveForm = new ReserveForm(admin.Id);
            reserveForm.Show();
        }

        
    }
}
