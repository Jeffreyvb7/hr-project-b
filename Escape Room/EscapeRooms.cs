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
    public partial class EscapeRooms : Form
    {
        public EscapeRooms()
        {
            InitializeComponent();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
