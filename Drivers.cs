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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace User_Login
{
    public partial class Drivers : Form
    {
        private SqlConnection connection;
        private SqlCommand sqlCommand;

        public Drivers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Driver_Details VALUES  (@Driver_ID,@Driver_Name,@tel_no)", conn);
            cmd.Parameters.AddWithValue("@Driver_ID", int.Parse( textBox1.Text));
            cmd.Parameters.AddWithValue("@Driver_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@tel_no", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();




            conn.Close();
            MessageBox.Show("Suceesfully");


        }

        private void driver_DetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driver_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet4);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                this.driver_DetailsTableAdapter.Connection = connection;
                this.driver_DetailsTableAdapter.Fill(this.loginDBDataSet4.Driver_Details);
            }
        }

        private void driver_DetailsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.driver_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet4);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Driver_Details SET Driver_ID=@Driver_ID,Driver_Name=@Driver_Name,tel_no=@tel_no ", conn);
            cmd.Parameters.AddWithValue("@Driver_ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Driver_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@tel_no", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();




            conn.Close();
            MessageBox.Show("Suceesfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE Driver_Details  WHERE  Driver_ID=@Driver_ID", conn);
            cmd.Parameters.AddWithValue("@Driver_ID", int.Parse(textBox1.Text));
            
            cmd.ExecuteNonQuery();




            conn.Close();
            MessageBox.Show("Suceesfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Driver_Details ", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            driver_DetailsDataGridView.DataSource = dataTable;

            cmd.ExecuteNonQuery();




            conn.Close();
            MessageBox.Show("Suceesfully");
        }
    }
}

