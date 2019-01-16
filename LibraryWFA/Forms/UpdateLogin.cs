using LibraryWFA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryWFA.Forms;
using LibraryWFA.Models;


namespace LibraryWFA.Forms
{
    public partial class UpdateLogin : Form
    {

        LibraryEntities db = new LibraryEntities();
        private Admin admin;
        private int AdminId;
        public UpdateLogin(int adminId)
        {
            InitializeComponent();
            AdminId = adminId;
            admin = db.Admins.Find(adminId);
            IfAdminBoss();
            Akkaunt();
        }
        private void IfAdminBoss()
        {
            lblAdminIcon.Text = admin.Name + " " + admin.Surname;
            if (admin.IsBoss == true)
            {
                PcbAdmin.Image = Resources.boss3;
            }

        }

        private void Akkaunt()
        {
            TxtName.Text=admin.Name;
            TxtSurname.Text = admin.Surname;
            TxtLogin.Text = admin.Login;
            TxtPhone.Text = admin.Phone;
            
        }



        #region Update akkaunt

        private void LblPwUpdate_Click(object sender, EventArgs e)
        {
            PnlNewPw.Visible = true;
            GrbInfo.Size = new Size(400, 373);
            BtnUpdate.Location = new Point(260, 320);

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            admin.Name = TxtName.Text;
            admin.Surname = TxtSurname.Text;
            admin.Login = TxtLogin.Text;
            admin.Phone = TxtPhone.Text;
            if (TxtOldPw.Text != admin.Password)
            {
                MessageBox.Show("Parolu duzgun daxil edin");
                TxtOldPw.ResetText();
                return;
            }
            else
            {
                if (TxtNewPw1.Text == TxtNewPw2.Text)
                {
                    admin.Password = TxtNewPw2.Text;
                    TxtOldPw.ResetText();
                    TxtNewPw1.ResetText();
                    TxtNewPw2.ResetText();
                }
                else
                {
                    MessageBox.Show("Yeni paroli duzgun daxil edin");
                    TxtNewPw1.ResetText();
                    TxtNewPw2.ResetText();
                    return;
                }
            }
            db.SaveChanges();
            TxtName.Text = admin.Name;
            TxtSurname.Text = admin.Surname;
            TxtLogin.Text = admin.Login;
            TxtPhone.Text = admin.Phone;
        }
        #endregion

     

        private void TxtChanged_TextChanged(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = true;
        }

    }
}
