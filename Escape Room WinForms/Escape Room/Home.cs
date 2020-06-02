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
    public partial class Home : Form
    {
        public bool adminAcess = true;
        public Home()
        {
            InitializeComponent();
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void BookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking booking = new Booking();
            booking.Show();
        }
        private void EscapeListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EscapeRooms escaperooms = new EscapeRooms();
            escaperooms.Show();
        }
        private void FoodDrinkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodDrink fooddrink = new FoodDrink();
            fooddrink.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }
        private void AdminOptions_Click(object sender, EventArgs e)
        {
        this.Hide();
        About about = new About();
        about.Show();
        }
    } 
}
