using System;
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
        
        private Admin admin;
        public Dashboard(int adminId)
        {
            admin = db.Admins.Find(adminId);
            InitializeComponent();
            FillCmbUniqueId();
            FillCmbBookName();
            IfAdminBoss();

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

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //kitablarin adlarinin comboBoxa yigilmasi
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

        #region Create Reserve
        
        private void BtnBookReservation_Click(object sender, EventArgs e)
        {

            BookReserve bookReserve = new BookReserve()
            {

            };



        }
        #endregion 
        // doubleClikde user formunun acilmasi

        private void PcbUsers_DoubleClick(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm(admin.Id);
            userForm.Show();
            this.Hide();
        }


        // doubleClikde book formunun acilmasi

        private void PcbBooks_DoubleClick(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm(admin.Id);
            booksForm.Show();
            this.Hide();
        }

        private void PcbLogins_Click(object sender, EventArgs e)
        {
            LoginsForm loginsForm = new LoginsForm(admin.Id);
        }

        // doubleClikde user formunun acilmasi

    }
}
