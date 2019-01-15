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
    public partial class LoginsForm : Form
    {
        LibraryEntities db = new LibraryEntities();
        private Admin admin;
        private Admin ad;
        private int AdminId;
        int LogId;
        public LoginsForm(int adminId)
        {
            AdminId = adminId;
            InitializeComponent();
            admin = db.Admins.Find(adminId);
            Admin();
        }
        private void Admin()
        {
            lblAdminIcon.Text = admin.Name + " " + admin.Surname;
            PcbAdmin.Image = Resources.boss2;
            FIllDgvLogins();    
        }

        

        #region Create login
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtLogin.Text)|| string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtPhone.Text) || string.IsNullOrEmpty(TxtPw.Text) || string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show("Xanalari doldurun");
            }
            Admin ad = new Admin()
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = TxtPhone.Text,
                Login = TxtLogin.Text,
                Password = TxtPw.Text,
                IsBoss = CkbIsBoss.Checked
            };

            db.Admins.Add(ad);
            db.SaveChanges();
            MessageBox.Show("Elave olundu");
            FIllDgvLogins();

        }

        #endregion

        #region Read Logins
        private void FIllDgvLogins()
        {
            DgvLogins.Rows.Clear();
            foreach (Admin ad in db.Admins.ToList())
            {
                DgvLogins.Rows.Add(ad.Id, ad.Name, ad.Surname, ad.Phone, ad.Login, ad.Password, (ad.IsBoss == true) ? "Beli" : "Xeyir");
            }
        }


        #endregion
        #region Uptade and Delete

        private void DgvLogins_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Visible = false;
            BtnDel.Visible = true;
            BtnUpdate.Visible = true;

            LogId = Convert.ToInt32(DgvLogins.Rows[e.RowIndex].Cells[0].Value);

            ad = db.Admins.Find(LogId);
            TxtName.Text = ad.Name;
            TxtSurname.Text = ad.Surname;
            TxtPhone.Text = ad.Phone;
            TxtLogin.Text = ad.Login;
            TxtPw.Text = ad.Password;
            CkbIsBoss.Checked = Convert.ToBoolean(ad.IsBoss);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLogin.Text) || string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtPhone.Text) || string.IsNullOrEmpty(TxtPw.Text) || string.IsNullOrEmpty(TxtSurname.Text))
            {
                MessageBox.Show("Xanalari doldurun");
            }
            ad = db.Admins.Find(LogId);
            ad.Name = TxtName.Text;
            ad.Surname = TxtSurname.Text;
            ad.Phone = TxtPhone.Text;
            ad.Login = TxtLogin.Text;
            ad.Password = TxtPw.Text;
            ad.IsBoss = CkbIsBoss.Checked;
            db.SaveChanges();
            MessageBox.Show("Yenilendi");
            Reset();
            FIllDgvLogins();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            ad = db.Admins.Find(LogId);
            DialogResult r = MessageBox.Show("Bu şəxsi silmək istəyirsiniz mi?", "Silmək", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Admins.Remove(ad);
                MessageBox.Show("Silindi");
                db.SaveChanges();
                Reset();
                FIllDgvLogins();
            }

        }
        #endregion
        private void Reset()
        {
            BtnAdd.Visible = true;
            BtnDel.Visible = false;
            BtnUpdate.Visible = false;

            TxtLogin.ResetText();
            TxtName.ResetText();
            TxtPhone.ResetText();
            TxtPw.ResetText();
            TxtSurname.ResetText();
            CkbIsBoss.Checked = false;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard(AdminId);
            this.Hide();
            ds.Show();
        }
        private void LoginsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

