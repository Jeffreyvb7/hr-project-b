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
    public partial class Login : Form
    {
        public bool loginBool = true;
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginBool)
            {
                this.Hide();
                Home home = new Home();
                home.Show();
                
            }
            lblError.Text = "Invalid username or password, please try again.";
        }
    }
}
