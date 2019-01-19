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
        private User User;
        private Book book;
        private Admin admin;
        private int reserveId;
        private BookReserve reserve;
        private string endTime;
        public Dashboard(int adminId)
        {
            admin = db.Admins.Find(adminId);
            InitializeComponent();
            FillCmbUniqueId();
            FillCmbBookName();
            IfAdminBoss();
            FillDgvReserves();
        }

        //admin eyer bossdursa
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
            foreach (Book b in db.Books.ToList())
            {
                CmdBookName.Items.Add(b.Name);

            }
        }

        private void FillCmbUniqueId()
        {
            foreach (User u in db.Users.ToList())
            {
                CmbUniqueId.Items.Add(u.UserUniqueId);

            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvReserves.Rows.Clear();
            int? UserId = null;
            if (!string.IsNullOrEmpty(CmbUniqueId.Text))
            {
                UserId = db.Users.FirstOrDefault(u => u.UserUniqueId == CmbUniqueId.Text).Id;
            }
            int? BookId = null;
            if (!string.IsNullOrEmpty(CmdBookName.Text))
            {
                BookId = db.Books.FirstOrDefault(b => b.Name == CmdBookName.Text).Id;
            }
            List<BookReserve> bookReserves = db.BookReserves.Where(b =>
            (UserId != null ? b.UserId == UserId : true) &&
            (BookId != null ? b.BookId == BookId : true)
            ).ToList();
            foreach (BookReserve br in bookReserves)
            {
                if (br.EndTime == null)
                {
                    endTime = Math.Ceiling(br.StartTime.Value.AddDays(30).Subtract(DateTime.Now).TotalDays).ToString() + " sonra";

                    DgvReserves.Rows.Add(br.Id,
                    br.User.Name + "" + br.User.Surname,
                    br.User.Phone,
                    br.User.UserUniqueId,
                    br.Book.Name,
                    Convert.ToDateTime(br.StartTime).ToString("dd.MM.yy"),
                    endTime,
                    br.Admin.Name + "" + br.Admin.Surname,
                    Convert.ToInt32(br.Penalty)
                    );


                }
            }
        }
        
        #region Read
        private void FillDgvReserves()
        {
            DgvReserves.Rows.Clear();
            foreach (BookReserve br in db.BookReserves.ToList())
            {
                if (br.EndTime == null)
                {
                    endTime = Math.Ceiling(br.StartTime.Value.AddDays(30).Subtract(DateTime.Now).TotalDays).ToString() + " sonra";
                    DgvReserves.Rows.Add(br.Id,
                        br.User.Name + br.User.Surname, 
                        br.User.Phone, 
                        br.User.UserUniqueId, 
                        br.Book.Name, 
                        Convert.ToDateTime(br.StartTime).ToString("dd.MM.yy"), 
                        endTime,
                        br.Admin.Name + br.Admin.Surname,
                        Convert.ToInt32(br.Penalty));
                }
            }
        }
        #endregion

        private void DgvReserves_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reserveId = Convert.ToInt32(DgvReserves.Rows[e.RowIndex].Cells[0].Value);
            reserve = db.BookReserves.Find(reserveId);
            User = db.Users.Find(reserve.UserId);
            admin = db.Admins.Find(reserve.AdminId);
            book = db.Books.Find(reserve.BookId);
            BtnSearch.Enabled = false;
            BtnEnd.Enabled = true;
            CmdBookName.Text = book.Name;
            CmbUniqueId.Text = User.UserUniqueId;
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            reserve = db.BookReserves.Find(reserveId);
            reserve.EndTime = DateTime.Now;
            book = db.Books.Find(reserve.BookId);
            book.Count++;
            if (reserve.EndTime > reserve.StartTime.Value.AddDays(30))
            {
                reserve.Penalty = Convert.ToDecimal(reserve.EndTime.Value.Subtract(reserve.StartTime.Value.AddDays(30)).TotalDays);
            }
            else
            {
                reserve.Penalty = 0;
            }
            MessageBox.Show("Reservaciya sonlandi. \n Odenilecek cerime: {0}", reserve.Penalty.ToString());
            FillDgvReserves();
            Reset();
        }

        private void Reset()
        {
            CmbUniqueId.ResetText();
            CmdBookName.ResetText();
            BtnEnd.Enabled = false;
            BtnSearch.Enabled = true;
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

        // doubleClikde Reserve formunun acilmasi
        private void PcbReserves_DoubleClick(object sender, EventArgs e)
        {
            ReserveForm reserveForm = new ReserveForm(admin.Id);
            reserveForm.Show();
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            Reset();
            FillDgvReserves();
        }

        private void PcbReset_Click(object sender, EventArgs e)
        {
            Reset();
            FillDgvReserves();
        }

        private void PcbExit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
