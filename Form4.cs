using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form4 : Form
    {
        public static Form3 f3 = new Form3();
        public static Form6 f6 = new Form6();
        //..................................

        public static int cost;
        public static string time;
        public static string time_re;


        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(900, 500);
            button1.BackColor = Color.Transparent;


            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;


            label2.Text = Form3.from + "   to   " + Form3.to;
            label3.Text = Form3.data1.ToString();



            if (Form3.retu == 1)
            { groupBox2.Visible = true; }



            if (Form3.retu == 1)
            {
                groupBox2.Visible = true;
                label4.Text = Form3.to + "  to  " + Form3.to2;
                label1.Text = Form3.data2.ToString();
            }

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cost < 155)
            { MessageBox.Show("الرجاء اختيار التذكرة"); }


            else if (Form3.retu == 1)
            {
                if (cost < 320)
                { MessageBox.Show("إختيار تذكرة العودة"); }
                else
                { f6.Show(); this.Hide(); }
            }

            else
            { f6.Show(); this.Hide(); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cost = 180;
            time = "10:00 Am";

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 3;

            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            cost = 160;
            time = "2:00 Pm";

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 3;

            button2.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cost = 155;
            time = "01:00 Am";

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 3;

            button3.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cost = cost + 165;
            time_re = "2:30 Pm";

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = Color.Blue;
            button5.FlatAppearance.BorderSize = 3;

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
