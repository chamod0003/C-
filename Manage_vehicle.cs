using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace User_Login
{
    public partial class Manage_vehicle : Form
    {
        public Manage_vehicle()
        {
            InitializeComponent();
        }

        private void manage_VehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manage_VehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet1);

        }

        private void Manage_vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet2.Manage_Vehicle' table. You can move, or remove it, as needed.
            //TODO: This line of code loads data into the 'loginDBDataSet1.Manage_Vehicle' table. You can move, or remove it, as needed.

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                this.manage_VehicleTableAdapter1.Connection = connection;
                this.manage_VehicleTableAdapter1.Fill(this.loginDBDataSet2.Manage_Vehicle);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Manage_Vehicle VALUES  (@Vehicel_ID,@Vehicle_Name,@Seats,@Transmission,@KM_for_1L)", conn);
            cmd.Parameters.AddWithValue("@Vehicel_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Vehicle_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Seats", textBox3.Text);
            cmd.Parameters.AddWithValue("@Transmission", comboBox1.Text);
            cmd.Parameters.AddWithValue("@KM_for_1L", textBox4.Text);
            cmd.ExecuteNonQuery();




            conn.Close();
            MessageBox.Show("Suceesfully");


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Manage_Vehicle SET Vehicel_ID=@Vehicel_ID, Vehicle_Name= @Vehicle_Name,Seats=@Seats,Transmission=@Transmission, KM_for_1L=@KM_for_1L where Vehicel_ID=@Vehicel_ID ", conn);
            cmd.Parameters.AddWithValue("@Vehicel_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Vehicle_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Seats", textBox3.Text);
            cmd.Parameters.AddWithValue("@Transmission", comboBox1.Text);
            cmd.Parameters.AddWithValue("@KM_for_1L", textBox4.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Suceesfully Updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE Manage_Vehicle WHERE Vehicel_ID=@Vehicel_ID", conn);
            cmd.Parameters.AddWithValue("@Vehicel_ID", textBox1.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Suceesfully Deleted");



        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * From Manage_Vehicle ", conn);
            // sqlCommand.Parameters.AddWithValue("NIC_Number", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            manage_VehicleDataGridView.DataSource = dataTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * From Manage_Vehicle WHERE Vehicel_ID=@Vehicel_ID", conn);
            sqlCommand.Parameters.AddWithValue("Vehicel_ID", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            manage_VehicleDataGridView.DataSource = dataTable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Managment managment = new Managment();
            managment.Show();
            this.Close();
        }
    }
}
