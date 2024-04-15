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

namespace User_Login
{
    public partial class Manage_User : Form
    {
        public Manage_User()
        {
            InitializeComponent();
        }
        
        private void Manage_User_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                this.adminTableAdapter.Connection = connection;
                this.adminTableAdapter.Fill(this.loginDBDataSet.admin);
            }

        }

        private void adminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    
        }

        private void adminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * From admin WHERE NIC_Number=@NIC_Number", conn);
            sqlCommand.Parameters.AddWithValue("NIC_Number",textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            adminDataGridView.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * From admin ", conn);
           // sqlCommand.Parameters.AddWithValue("NIC_Number", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            adminDataGridView.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Managment managment = new Managment();
            managment.Show();
            this.Hide();
        }

        private void adminBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet);

        }

        private void adminBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet);

        }

        private void adminBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet);

        }

        private void adminBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet);

        }
    }
}
