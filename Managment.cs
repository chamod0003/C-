using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Login
{
    public partial class Managment : Form
    {
        public Managment()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_User manage_user = new Manage_User();
            manage_user.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          Manage_vehicle manage_Vehicle=new Manage_vehicle();
            manage_Vehicle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicle_Orders vehicle_Orders = new Vehicle_Orders();
            vehicle_Orders.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
            this.Hide();
        }
    }
}
