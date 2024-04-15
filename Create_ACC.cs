using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Data.SqlClient;
using System.Data.Common;

namespace User_Login
{
    public partial class Create_ACC : Form
    {
        public Create_ACC()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            if(conn.State!= ConnectionState.Open)
            {
                try
                {
                    if (NIC_textBox.Text == "" || User_Name_textBox.Text == "" || Password_textBox.Text == "" || textBox1.Text == "" || Phone_Textbox.Text == "")
                    {
                        MessageBox.Show("Fill the All field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    }
                    else
                    {
                        if (Password_textBox.Text == textBox1.Text)
                        {
                            conn.Open();
                            string User_Name = "Select * FROM admin WHERE UserName='" + User_Name_textBox.Text.Trim() + "'";
                            using (SqlCommand checkuser = new SqlCommand(User_Name, conn))
                            {


                                SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                                DataTable table = new DataTable();
                                adapter.Fill(table);
                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show("Register Unsuccessfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                                else
                                {
                                    string insertdata = "INSERT INTO admin (NIC_Number, UserName, Pass_word, Re_password, tel_no, Gender) " + "VALUES (@NIC_Number,@UserName,@Pass_word,@Re_password,@tel_no,@Gender)";
                                    DateTime date = DateTime.Today;
                                    using (SqlCommand cmd = new SqlCommand(insertdata, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@NIC_Number", NIC_textBox.Text.Trim());
                                        cmd.Parameters.AddWithValue("@UserName", User_Name_textBox.Text.Trim());
                                        cmd.Parameters.AddWithValue("@Pass_word", Password_textBox.Text.Trim());
                                        cmd.Parameters.AddWithValue("@Re_password", textBox1.Text.Trim());
                                        cmd.Parameters.AddWithValue("@tel_no", Phone_Textbox.Text.Trim());
                                        cmd.Parameters.AddWithValue("@Gender", comboBox1.Text.Trim());
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Register Successfull", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Close();
                                        Login loginForm = new Login();
                                        loginForm.Show();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("check your password", "Cautation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex, "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                    
            }
            
        }

        private void Create_ACC_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show(); 
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            NIC_textBox.Text = "";
            Password_textBox.Text = "";
            Phone_Textbox.Text = "";
            User_Name_textBox.Text = "";
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                login_eye.BringToFront();
                textBox1.PasswordChar = '\0';
            }
            else if (textBox1.PasswordChar == '\0')
            {
                login_eye.BringToFront();
                textBox1.PasswordChar = '*';
            }
        }
    }
    
}
