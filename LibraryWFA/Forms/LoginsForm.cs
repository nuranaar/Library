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
    public partial class LoginsForm : Form
    {
        LibraryEntities db = new LibraryEntities();

        public LoginsForm(int adminId)
        {
            InitializeComponent();
        }
    }
}
