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
        private string endTime;

        public ReserveForm(int adminId)
        {
            InitializeComponent();
            admin = db.Admins.Find(adminId);
            FillCmbUniqueId();
            FillCmbBookName();
            FillDgvReserves();
            FillCmbSearch();
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
                GrbBookCrud.Size = new Size(285, 290);
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

        #region Read
        private void FillDgvReserves()
        {
            DgvReserves.Rows.Clear();
            foreach (BookReserve br in db.BookReserves.ToList())
            {
                if (br.EndTime == null)
                {
                    endTime = Math.Ceiling(br.StartTime.Value.AddDays(30).Subtract(DateTime.Now).TotalDays).ToString() + " sonra";
                }
                else
                {
                    endTime = br.EndTime.Value.ToString("dd.MM.yy");
                }
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
        #endregion

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
            book = db.Books.Find(reserve.BookId);
            book.Count--;
            db.BookReserves.Add(reserve);
            db.SaveChanges();
            FillDgvReserves();
            Reset();
        }
        #endregion

        #region Finish Reserve
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
            GrbBookCrud.Size = new Size(285, 290);
            BtnEnd.Enabled = false;
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
            if (reserve.EndTime > reserve.StartTime.Value.AddDays(30))
            {
                reserve.Penalty = Convert.ToDecimal(reserve.EndTime.Value.Subtract(reserve.StartTime.Value.AddDays(30)).TotalDays);
            }
            else
            {
                reserve.Penalty = 0;
            }
            FillDgvReserves();
            Reset();
        }
        #endregion

        private void Reset()
        {
            TxtUniqueId.Visible = false;
            CmbUniqueId.Visible = true;
            LblBookName.Location = new Point(6, 68);
            CmdBookName.Location = new Point(121, 62);
            PnlButtons.Location = new Point(6, 92);
            PnlUser.Visible = false;
            PnlUser.Location = new Point(9, 144);
            PnlDateTime.Visible = false;
            PnlDateTime.Location = new Point(6, 144);
            BtnBookReservation.Visible = true;
            BtnEnd.Visible = false;
            BtnEnd.Enabled = false;
            GrbBookCrud.Size = new Size(285, 169);

            TxtPenalty.ResetText();
            TxtStartTime.ResetText();
            TxtUniqueId.ResetText();
            CmbUniqueId.ResetText();
            CmdBookName.ResetText();
            TxtName.ResetText();
            TxtPhone.ResetText();
            TxtSurname.ResetText();
            CmbSearchBook.ResetText();
            CmbSearchId.ResetText();
        }

        private void ReserveForm_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void FillCmbSearch()
        {
            foreach (Book book in db.Books.ToList())
            {
                CmbSearchBook.Items.Add(book.Name);

            }
            foreach (User user in db.Users.ToList())
            {
                CmbSearchId.Items.Add(user.UserUniqueId);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvReserves.Rows.Clear();
            int? UserId = null;
            if (!string.IsNullOrEmpty(CmbSearchId.Text))
            {
                UserId = db.Users.FirstOrDefault(u => u.UserUniqueId == CmbSearchId.Text).Id;
            }
            int? BookId = null;
            if (!string.IsNullOrEmpty(CmbSearchBook.Text))
            {
                BookId = db.Books.FirstOrDefault(b => b.Name == CmbSearchBook.Text).Id;
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
                }
                else
                {
                    endTime = br.EndTime.Value.ToString("dd.MM.yy");
                }
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }

}