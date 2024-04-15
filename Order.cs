using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace User_Login
{
    public partial class Order : Form
    {
        private string destination;

        public Order(string username, string id)
        {
            InitializeComponent();
            label3.Text = username;
            label11.Text = id;


            label6.Text = ((InterFace)Application.OpenForms["InterFace"]).Location;
            label8.Text = ((InterFace)Application.OpenForms["InterFace"]).Destination;


        }
        SqlConnection ABN = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\Vehicle_Orders.mdf"";Integrated Security=True;Connect Timeout=30");
        public Order(string destination)
        {
            this.destination = destination;
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Order_Load(object sender, EventArgs e)
        {
           


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ABN.State != ConnectionState.Open)
            {
                try
                {


                    ABN.Open();
                    string vehicleid = "Select * FROM order_vehicle WHERE vehicleid='" + label11.Text.Trim() + "'";
                    using (SqlCommand checkuser = new SqlCommand(vehicleid, ABN))
                    {


                        SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("May be order this vehicle or not compelete the blanks ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            string insertdata = "INSERT INTO order_vehicle(userid, vehicleid, pickup_loc, destination, passenger, date_order,driver_need) " + "VALUES  (@userid, @vehicleid, @pickup_loc, @destination, @passenger, @date_order,@driver_need)";
                            DateTime date = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertdata, ABN))
                            {
                                cmd.Parameters.AddWithValue("@userid", label3.Text.Trim());
                                cmd.Parameters.AddWithValue("@vehicleid", label11.Text.Trim());
                                cmd.Parameters.AddWithValue("@pickup_loc", label6.Text.Trim());
                                cmd.Parameters.AddWithValue("@destination", label8.Text.Trim());
                                cmd.Parameters.AddWithValue("@passenger", textBox2.Text.Trim());
                                cmd.Parameters.AddWithValue("@date_order", dateTimePicker1.Value);
                                cmd.Parameters.AddWithValue("@driver_need", comboBox1.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Register Successfull", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();

                            }
                        }




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex, "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ABN.Close();
                }

            }

        }
    
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

