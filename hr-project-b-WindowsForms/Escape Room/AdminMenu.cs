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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void adminMenuEditCompanyInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAbout editabout = new EditAbout();
            editabout.Show();
        }

        private void adminMenuEditEscapeRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRooms editrooms = new EditRooms();
            editrooms.Show();
        }

        private void adminMenuRemoveEscapeRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveRooms removerooms = new RemoveRooms();
            removerooms.Show();
        }

        private void adminMenuAddEscapeRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }

        private void AdminMenuManageFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageFoodMenu manageFoodMenu = new ManageFoodMenu();
            manageFoodMenu.Show();
        }
    }
}
