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

namespace LibraryWFA.Forms
{
    public partial class UsersForm : Form
    {
        LibraryEntities db = new LibraryEntities();
        private Admin admin;
        private User user;
        private int AdminId;
        private int UserId;
        public UsersForm(int adminId)
        {
            AdminId = adminId;
            InitializeComponent();
            admin = db.Admins.Find(adminId);
            FillDgvUsers();
            TxtUniqueId.Enabled = false;
            FillSearchCmb();

        }


        #region Creat Users
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtName.Text)|| string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Xanalari doldurun!");

            }


             user = new User()
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                CreatedAdmin = admin.Id,
                Phone = TxtPhone.Text
                
            };
            db.Users.Add(user);
            db.SaveChanges();
            user.UserUniqueId = DateTime.Now.ToString("yydd") + (user.Id<10?"0"+user.Id.ToString():user.Id.ToString());
            db.SaveChanges();
            TxtUniqueId.Text = user.UserUniqueId;
            FillDgvUsers();
        }
        #endregion

        #region Read Users

        private void FillDgvUsers()
        {
            DgvUsers.Rows.Clear();
            foreach (User user in db.Users.ToList())
            {
                DgvUsers.Rows.Add(user.Id, user.Name, user.Surname, user.Phone, user.UserUniqueId, admin.Name + admin.Surname);
            }
        }

        #endregion

        #region Update and Delet Users

        private void DgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Visible = false;
            BtnDel.Visible = true;
            BtnUpdate.Visible = true;

            UserId = Convert.ToInt32(DgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

            user = db.Users.Find(UserId);

            TxtName.Text = user.Name;
            TxtSurname.Text = user.Surname;
            TxtPhone.Text = user.Phone;
            TxtUniqueId.Text = user.UserUniqueId;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Xanalari doldurun!");

            }
            user = db.Users.Find(UserId);

            user.Name = TxtName.Text;
            user.Surname = TxtSurname.Text;
            user.Phone = TxtPhone.Text;
            user.UserUniqueId = TxtUniqueId.Text;

            db.SaveChanges();
            MessageBox.Show("Yenilendi");
            FillDgvUsers();
            Reset();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            user = db.Users.Find(UserId);
            DialogResult r = MessageBox.Show("Bu şəxsi silmək istəyirsiniz mi?", "Silmək", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Users.Remove(user);
                MessageBox.Show("Silindi");
                db.SaveChanges();
                FillDgvUsers();
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
            TxtPhone.ResetText();
            TxtSurname.ResetText();
            TxtUniqueId.ResetText();
            CmbSearchAdmin.ResetText();
            CmbSearchId.ResetText();
        }

        private void FillSearchCmb()
        {
            foreach (User user in db.Users.ToList())
            {
                CmbSearchId.Items.Add(user.UserUniqueId);
            }
            foreach (Admin admin in db.Admins.ToList())
            {
                CmbSearchAdmin.Items.Add(admin.Name +" "+admin.Surname);
            }
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DgvUsers.Rows.Clear();
            int? adm = null;
            if (!string.IsNullOrEmpty(CmbSearchAdmin.Text))
            {
                adm = db.Admins.FirstOrDefault(a => a.Name ==  CmbSearchAdmin.Text.Split(' ')[0]).Id;
            }
            int? UserId = null;
            if (!string.IsNullOrEmpty(CmbSearchId.Text))
            {
                UserId = db.Users.FirstOrDefault(u => u.UserUniqueId == CmbSearchId.Text).Id;
            }
            List<User> users = db.Users.Where(u =>
            (UserId != null ? u.Id == UserId : true) &&
            (adm != null ? u.CreatedAdmin== adm : true)).ToList();

            foreach (User us in users)
            {
                DgvUsers.Rows.Add(us.Id, 
                    us.Name,
                    us.Surname,
                    us.Phone,
                    us.UserUniqueId, 
                    us.Admin.Name + us.Admin.Surname);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
            FillDgvUsers();
        }
    }
}
