using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Login
{

  

    public partial class InterFace : Form
    {
        private string location;
        private string destination;
      

        public InterFace()
        {
            InitializeComponent();

        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Destination 
        {
            get { return destination; }
            set { destination = value; }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.Hide();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Login HP = new Login();
            HP.Show();

            location = textBox1.Text;
            destination = textBox3.Text;

            Order order=new Order(Location);
            Order order1 = new Order(Destination);

            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}