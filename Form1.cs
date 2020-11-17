using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fta3
{
    public partial class Form1 : Form
    {
        Timer t;
        bool b1 = false, b2 = false, b3 = false, b4 = false, b5 = false, b6 = false, b7 = false, b8 = false, b9 = false, b10 = false;

       

        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 1010;
            t.Tick += t_Tick;
            t.Enabled = true;
        }

       

        private void t_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = rd.Next(0,9);
            if (i == 0)
            {
                button1.BackColor = Color.Green;
                b1 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b2 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 1)
            {
                button2.BackColor = Color.Green;
                b2 = true;
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 2)
            {
                button3.BackColor = Color.Green;
                b3 = true;
                button2.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b2 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 3)
            {
                button5.BackColor = Color.Green;
                b4 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b2 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 4)
            {
                button6.BackColor = Color.Green;
                b5 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b2 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 5)
            {
                button7.BackColor = Color.Green;
                b6 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b2 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 6)
            {
                button8.BackColor = Color.Green;
                b7 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b2 = false;
                b8 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 7)
            {
                button9.BackColor = Color.Green;
                b8 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b2 = false;
                b9 = false;
                b10 = false;
            }
            else if (i == 8)
            {
                button10.BackColor = Color.Green;
                b9 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b2 = false;
                b10 = false;
            }
              else if (i == 9)
            {
                button11.BackColor = Color.Green;
                b10 = true;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Red;
                b1 = false;
                b3 = false;
                b4 = false;
                b5 = false;
                b6 = false;
                b7 = false;
                b8 = false;
                b9 = false;
                b2 = false;
            }
            else
            {
              }
            
            
            
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (b1==true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
               

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (b6 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
             

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            if (b10 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
               
              
            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (b5 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
            

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            if (b9 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
              

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (b4 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
            

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (b8 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
               

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (b3 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
             

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (b7 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
            

            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (b2 == true)
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc + 10;
                label2.Text = sc.ToString();
               
            }
            else
            {
                int sc = Convert.ToInt32(label2.Text);
                sc = sc - 10;
                label2.Text = sc.ToString();
            }
        }


    }
}
