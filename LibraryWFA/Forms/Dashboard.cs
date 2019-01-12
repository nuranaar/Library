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
    public partial class Dashboard : Form
    {
        LibraryDbEntities db = new LibraryDbEntities();
        public Dashboard(int AdminId)
        {

            InitializeComponent();
            FillCmbUniqueId();
            FillCmbBookName();
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
        //muwterilerin unique kodlarini comboBoxa yigilmasi
        private void FillCmbUniqueId()
        {
            foreach (User user in db.Users.ToList())
            {
                CmbUniqueId.Items.Add(user.UserUniqueId);
            }
        }

        private void BtnBookReservation_Click(object sender, EventArgs e)
        {

            BookReserve bookReserve = new BookReserve()
            {

            };



        }
    }
}
