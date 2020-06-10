using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room
{
    public partial class ManageFoodMenu : Form
    {
        public ManageFoodMenu()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminmenu = new AdminMenu();
            adminmenu.Show();
            adminmenu.Show();
        }

        private void ManageFoodMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
