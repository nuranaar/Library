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

namespace LibraryWFA
    
{
    public partial class Form1 : Form
    {
        LibraryEntities db = new LibraryEntities();
        int AdminId;
        public Form1()
        {
            InitializeComponent();
            TxtLogin.Text = "nuranaar";
            TxtPw.Text = "qwerty123";
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLogin.Text) || string.IsNullOrEmpty(TxtPw.Text))
            {
                MessageBox.Show("Xanalari doldurun!");
                return;
            }
            foreach (Admin admin in db.Admins.ToList())
            {
                if (TxtLogin.Text != admin.Login || TxtPw.Text != admin.Password)
                {
                    MessageBox.Show("Login ve ya password sehvdir!");
                    return;
                }

                AdminId = admin.Id;
            }
            Dashboard dashboard = new Dashboard(AdminId);
            dashboard.Show();
            this.Hide();
        }
    }
}
