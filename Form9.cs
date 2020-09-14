using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form9 : Form
    {
        public static Form8 f8 = new Form8();

        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4.f6.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4.f6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f8.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label12.Text = Form3.Adult.ToString();
            label13.Text = Form3.child.ToString();
            label14.Text = Form3.infant.ToString();
            label15.Text = Form3.from;
            label16.Text = Form3.to;
            label20.Text = Form4.time;

            label7.Text = Form3.passing.ToString();


            if (Form3.business == 1)
            { label6.Text = "Business"; }

            if (Form3.retu == 1)
            {
                label5.Text = "(Return)";
                groupBox5.Visible = true;
                label26.Text = Form3.to;
                label25.Text = Form3.to2;
                label21.Text = Form4.time_re;

            }

            if (Form3.retu == 0)
            {
                groupBox1.Width = 450;


            }




        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form4.f3.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form4.f6.Show();
            this.Hide();
        }
    }
}
