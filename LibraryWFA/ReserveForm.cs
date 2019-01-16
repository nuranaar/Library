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


namespace LibraryWFA
{
    public partial class ReserveForm : Form
    {
        LibraryEntities db = new LibraryEntities();
        private Admin admin;
        private User User;
        private Book book;
        private int reserveId;
        private BookReserve reserve;
        public ReserveForm(int adminId)
        {
            InitializeComponent();
            admin = db.Admins.Find(adminId);
            FillCmbUniqueId();
            FillCmbBookName();
            FillDgvReserves();
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
            foreach (Book b in db.Books.Where(b => b.Name == CmdBookName.Text))
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
                if (reserve.EndTime == null)
                {
                    string endTime = Convert.ToDateTime(reserve.StartTime).AddDays(30).Subtract(DateTime.Now).ToString();
                    
                }
                DgvReserves.Rows.Add(br.Id, User.Name + User.Surname, User.Phone, User.UserUniqueId, book.Name, Convert.ToDateTime(br.StartTime).ToString("dd.MM.yy"),  admin.Name + admin.Surname, Convert.ToInt32(br.Penalty));
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
           

            reserve = new BookReserve()
            {
                UserId = User.Id,
                BookId = book.Id,
                AdminId = admin.Id,
                StartTime = STime,
            };
            FillDgvReserves();
        }
        #endregion

        private void DgvReserves_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reserveId = Convert.ToInt32(DgvReserves.Rows[e.RowIndex].Cells[0].Value);
            reserve = db.BookReserves.Find(reserveId);
            User = db.Users.Find(reserve.UserId);
            admin = db.Admins.Find(reserve.AdminId);
            book = db.Books.Find(reserve.BookId);

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
            TxtStartTime.Text = Convert.ToDateTime(reserve.StartTime).ToString("dd.MM.yy");
            TxtPenalty.Text = reserve.Penalty.ToString();
            if (reserve.EndTime == null)
            {
                BtnEnd.Enabled = true;
            }
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            reserve = db.BookReserves.Find(reserveId);
            reserve.EndTime = DateTime.Now;
        }
    }
}
