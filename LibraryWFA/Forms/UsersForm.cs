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
        LibraryDbEntities db = new LibraryDbEntities();
        int AdminId;
        public UsersForm(int adminId)
        {

            InitializeComponent();
            AdminId = adminId;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Admin admin = db.Admins.Find(AdminId);
            User user = new User()
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                CreatedAdmin = admin.Id,
                
            };
            db.Users.Add(user);
            user.UserUniqueId = DateTime.Now.ToString("yydd") + (user.Id<10?"0"+user.Id.ToString():user.Id.ToString());
            TxtUniqueId.Text = user.UserUniqueId;
        }
    }
}
