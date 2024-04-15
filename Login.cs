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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
          

        }
        string username;
        





        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive - General Sir John Kotelawala Defence University\Documents\LoginDB.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            if(UName_textBox.Text=="" || Pas_textBox.Text == "")
            {
                MessageBox.Show("User Name or password error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        string selectData = "SELECT * FROM admin WHERE NIC_Number=@NIC_Number AND Pass_word=@Pass_word";
                        using (SqlCommand command = new SqlCommand(selectData,conn)) 
                        {
                            command.Parameters.AddWithValue("@NIC_Number", UName_textBox.Text);
                            command.Parameters.AddWithValue("@Pass_word", Pas_textBox.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if(dt.Rows.Count >= 1)
                            { 
                                SqlCommand command1 = new SqlCommand();


                                username = UName_textBox.Text;
                                
                                //label2.Hide();

                                HomePage HP = new HomePage(username);    
                                HP.Show();
                                this.Hide();

                                
                              


                                
                            }
                            else
                            {
                                MessageBox.Show("User Name or password error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("User Name or password error"+ex, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    { 
                        conn.Close();
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserName_textBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Show_Pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Show_Pass_checkBox.Checked)
            {
                Pas_textBox.UseSystemPasswordChar = false;

            }
            else
            {
                Pas_textBox.UseSystemPasswordChar=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_ACC CA = new Create_ACC();
            CA.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(UName_textBox.Text=="User Name")
            {
                UName_textBox.Clear();
            }
        }

        private void Password_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Pas_textBox.Text == "Password")
            {
                Pas_textBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do You Want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                this.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
