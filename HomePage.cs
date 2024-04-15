using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace User_Login
{
  
    public partial class HomePage : Form
    {
        private string name;

        public HomePage(string username)
        {
            InitializeComponent();
            label66.Text = username;
           
        }

        string username;
        string id;

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label77.Text;
            label77.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();


        }

        private void button23_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label86.Text;
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Automatic.Checked)
            {
                //0      ,1    ,2      ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  ,   9  , 10   ,11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 0 || i == 2 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 10)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }

            } 
           // private void Manual_CheckedChanged(object sender, EventArgs e)
            {

            }
        }

        private void seat2_CheckedChanged(object sender, EventArgs e)
        {
            if (type2.Checked)
            {
                //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
        }

        private void Manual_CheckedChanged(object sender, EventArgs e)
        {
             if (Manual.Checked)
            {
                //0      ,1    ,2      ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  ,   9  , 10,11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 1 || i == 3 || i == 9 || i == 9 || i == 11)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }

        }

        private void luxuary_CheckedChanged(object sender, EventArgs e)
        {
            if (luxuary.Checked)
            {
                                    //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 7 || i == 8 || i == 10)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
            
        }

        private void type1_CheckedChanged(object sender, EventArgs e)
        {
           if(type1.Checked)
           {
                                    //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 9)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
           }
      
        }

        private void type3_CheckedChanged(object sender, EventArgs e)
        {
            if (type3.Checked)
            {
                //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 10 || i == 11)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
        }

        private void price1_CheckedChanged(object sender, EventArgs e)
        {
            if (price1.Checked)
            {
                                    //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 9)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
        }

        private void price2_CheckedChanged(object sender, EventArgs e)
        {
            if (price2.Checked)
            {
                                    //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6  || i == 11)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
        }

        private void price3_CheckedChanged(object sender, EventArgs e)
        {
            if (price3.Checked)
            {
                //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 10 || i == 7 || i == 8)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
             if (Normal.Checked)
            {

                //0   ,1    ,  2    ,  3     ,  4  ,  5 ,  6   ,  7 ,  8  , 9  ,  10   ,   11
                Panel[] panels = { Corolla, FB15, Vitara, Celeron, Vitz, Axio, Aqua, BMW, GLX, CT100, HiAce, Caravan };

                for (int i = 0; i < panels.Length; i++)
                {
                    if (i == 0 || i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 11)
                    {
                        panels[i].Show();
                    }
                    else
                    {
                        panels[i].Hide();
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
         
            username=label66.Text;
            id=label76.Text;
            Order order= new Order(username,id);
            
        
            order.Show();
            this.Hide(); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label78.Text;
            label78.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label79.Text;
            label79.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label80.Text;
            label80.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label81.Text;
            label81.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label82.Text;
            label82.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label83.Text;
            label83.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label85.Text;
            label85.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label84.Text;
            label84.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            username = label66.Text;
            id = label87.Text;
            label87.Hide();
            Order order = new Order(username, id);


            order.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int Lkr = 5000 * 1;
                string amount=Lkr.ToString();
                label36.Text = "LKR "+amount;
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                int Lkr = 5000 * 2;
                string amount = Lkr.ToString();
                label36.Text = "LKR " + amount;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int Lkr = 5000 * 3;
                string amount = Lkr.ToString();
                label36.Text = "LKR " + amount;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int Lkr = 5000 * 4;
                string amount = Lkr.ToString();
                label36.Text = "LKR " + amount;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                int Lkr = 5000 * 5;
                string amount = Lkr.ToString();
                label36.Text = "LKR " + amount;
            }
        }

        private void Aqua_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                int Lkr = 7000 * 1;
                string amount = Lkr.ToString();
                label18.Text = "LKR " + amount;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                int Lkr = 7000 * 2;
                string amount = Lkr.ToString();
                label18.Text = "LKR " + amount;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                int Lkr = 7000 * 3;
                string amount = Lkr.ToString();
                label18.Text = "LKR " + amount;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                int Lkr = 7000 * 4;
                string amount = Lkr.ToString();
                label18.Text = "LKR " + amount;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                int Lkr = 7000 * 5;
                string amount = Lkr.ToString();
                label18.Text = "LKR " + amount;
            }
        }

        private void Vitz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                int Lkr = 5000 * 1;
                string amount = Lkr.ToString();
                label24.Text = "LKR " + amount;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                int Lkr = 5000 * 2;
                string amount = Lkr.ToString();
                label24.Text = "LKR " + amount;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                int Lkr = 5000 * 3;
                string amount = Lkr.ToString();
                label24.Text = "LKR " + amount;
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                int Lkr = 5000 * 4;
                string amount = Lkr.ToString();
                label24.Text = "LKR " + amount;
            }
            else if (comboBox3.SelectedIndex == 4)
            {
                int Lkr = 5000 * 5;
                string amount = Lkr.ToString();
                label24.Text = "LKR " + amount;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                int Lkr = 5000 * 1;
                string amount = Lkr.ToString();
                label29.Text = "LKR " + amount;
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                int Lkr = 5000 * 2;
                string amount = Lkr.ToString();
                label29.Text = "LKR " + amount;
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                int Lkr = 5000 * 3;
                string amount = Lkr.ToString();
                label29.Text = "LKR " + amount;
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                int Lkr = 5000 * 4;
                string amount = Lkr.ToString();
                label29.Text = "LKR " + amount;
            }
            else if (comboBox4.SelectedIndex == 4)
            {
                int Lkr = 5000 * 5;
                string amount = Lkr.ToString();
                label29.Text = "LKR " + amount;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                int Lkr = 5000 * 1;
                string amount = Lkr.ToString();
                label72.Text = "LKR " + amount;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                int Lkr = 5000 * 2;
                string amount = Lkr.ToString();
                label72.Text = "LKR " + amount;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                int Lkr = 5000 * 3;
                string amount = Lkr.ToString();
                label72.Text = "LKR " + amount;
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                int Lkr = 5000 * 4;
                string amount = Lkr.ToString();
                label72.Text = "LKR " + amount;
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                int Lkr = 5000 * 5;
                string amount = Lkr.ToString();
                label72.Text = "LKR " + amount;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                int Lkr = 5000 * 1;
                string amount = Lkr.ToString();
                label34.Text = "LKR " + amount;
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                int Lkr = 5000 * 2;
                string amount = Lkr.ToString();
                label34.Text = "LKR " + amount;
            }
            else if (comboBox6.SelectedIndex == 2)
            {
                int Lkr = 5000 * 3;
                string amount = Lkr.ToString();
                label34.Text = "LKR " + amount;
            }
            else if (comboBox6.SelectedIndex == 3)
            {
                int Lkr = 5000 * 4;
                string amount = Lkr.ToString();
                label34.Text = "LKR " + amount;
            }
            else if (comboBox6.SelectedIndex == 4)
            {
                int Lkr = 5000 * 5;
                string amount = Lkr.ToString();
                label34.Text = "LKR " + amount;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                int Lkr = 5000 * 1;
                string amount = Lkr.ToString();
                label74.Text = "LKR " + amount;
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                int Lkr = 5000 * 2;
                string amount = Lkr.ToString();
                label74.Text = "LKR " + amount;
            }
            else if (comboBox7.SelectedIndex == 2)
            {
                int Lkr = 5000 * 3;
                string amount = Lkr.ToString();
                label74.Text = "LKR " + amount;
            }
            else if (comboBox7.SelectedIndex == 3)
            {
                int Lkr = 5000 * 4;
                string amount = Lkr.ToString();
                label74.Text = "LKR " + amount;
            }
            else if (comboBox7.SelectedIndex == 4)
            {
                int Lkr = 5000 * 5;
                string amount = Lkr.ToString();
                label74.Text = "LKR " + amount;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                int Lkr = 10000 * 1;
                string amount = Lkr.ToString();
                label49.Text = "LKR " + amount;
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                int Lkr = 10000 * 2;
                string amount = Lkr.ToString();
                label49.Text = "LKR " + amount;
            }
            else if (comboBox8.SelectedIndex == 2)
            {
                int Lkr = 10000 * 3;
                string amount = Lkr.ToString();
                label49.Text = "LKR " + amount;
            }
            else if (comboBox8.SelectedIndex == 3)
            {
                int Lkr = 10000 * 4;
                string amount = Lkr.ToString();
                label49.Text = "LKR " + amount;
            }
            else if (comboBox8.SelectedIndex == 4)
            {
                int Lkr = 10000 * 5;
                string amount = Lkr.ToString();
                label49.Text = "LKR " + amount;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == 0)
            {
                int Lkr = 15000 * 1;
                string amount = Lkr.ToString();
                label88.Text = "LKR " + amount;
            }
            else if (comboBox9.SelectedIndex == 1)
            {
                int Lkr = 15000 * 2;
                string amount = Lkr.ToString();
                label88.Text = "LKR " + amount;
            }
            else if (comboBox9.SelectedIndex == 2)
            {
                int Lkr = 15000 * 3;
                string amount = Lkr.ToString();
                label88.Text = "LKR " + amount;
            }
            else if (comboBox9.SelectedIndex == 3)
            {
                int Lkr = 15000 * 4;
                string amount = Lkr.ToString();
                label88.Text = "LKR " + amount;
            }
            else if (comboBox9.SelectedIndex == 4)
            {
                int Lkr = 15000 * 5;
                string amount = Lkr.ToString();
                label88.Text = "LKR " + amount;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == 0)
            {
                int Lkr = 3000 * 1;
                string amount = Lkr.ToString();
                label44.Text = "LKR " + amount;
            }
            else if (comboBox10.SelectedIndex == 1)
            {
                int Lkr = 3000 * 2;
                string amount = Lkr.ToString();
                label44.Text = "LKR " + amount;
            }
            else if (comboBox10.SelectedIndex == 2)
            {
                int Lkr = 3000 * 3;
                string amount = Lkr.ToString();
                label44.Text = "LKR " + amount;
            }
            else if (comboBox10.SelectedIndex == 3)
            {
                int Lkr = 3000 * 4;
                string amount = Lkr.ToString();
                label44.Text = "LKR " + amount;
            }
            else if (comboBox10.SelectedIndex == 4)
            {
                int Lkr = 3000 * 5;
                string amount = Lkr.ToString();
                label44.Text = "LKR " + amount;
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
            {
                int Lkr = 13500 * 1;
                string amount = Lkr.ToString();
                label59.Text = "LKR " + amount;
            }
            else if (comboBox11.SelectedIndex == 1)
            {
                int Lkr = 13500 * 2;
                string amount = Lkr.ToString();
                label59.Text = "LKR " + amount;
            }
            else if (comboBox11.SelectedIndex == 2)
            {
                int Lkr = 13500 * 3;
                string amount = Lkr.ToString();
                label59.Text = "LKR " + amount;
            }
            else if (comboBox11.SelectedIndex == 3)
            {
                int Lkr = 13500 * 4;
                string amount = Lkr.ToString();
                label59.Text = "LKR " + amount;
            }
            else if (comboBox11.SelectedIndex == 4)
            {
                int Lkr = 13500 * 5;
                string amount = Lkr.ToString();
                label59.Text = "LKR " + amount;
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
            {
                int Lkr = 10000 * 1;
                string amount = Lkr.ToString();
                label64.Text = "LKR " + amount;
            }
            else if (comboBox12.SelectedIndex == 1)
            {
                int Lkr = 10000 * 2;
                string amount = Lkr.ToString();
                label64.Text = "LKR " + amount;
            }
            else if (comboBox12.SelectedIndex == 2)
            {
                int Lkr = 10000 * 3;
                string amount = Lkr.ToString();
                label64.Text = "LKR " + amount;
            }
            else if (comboBox12.SelectedIndex == 3)
            {
                int Lkr = 10000 * 4;
                string amount = Lkr.ToString();
                label64.Text = "LKR " + amount;
            }
            else if (comboBox12.SelectedIndex == 4)
            {
                int Lkr = 10000 * 5;
                string amount = Lkr.ToString();
                label64.Text = "LKR " + amount;
            }
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }
    }
}
