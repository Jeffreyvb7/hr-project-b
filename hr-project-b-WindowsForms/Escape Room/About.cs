using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Room
{ 
    // test 123
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void aboutButton1_Click(object sender, EventArgs e)
        {
            aboutCompanyName.Text = "Nemo is cool";
        }
    }
}
