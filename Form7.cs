using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form7 : Form
    {


        public static string se1, se2, se3, se4;   // se represents the seat;


        public Form7()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { se1 = "13  "; }

            else
            { se1 = ""; }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { se2 = "16 "; }

            else
            { se2 = ""; }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { se3 = "25 "; }

            else
            { se3 = ""; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { se4 = "6"; }

            else
            { se4 = ""; }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4.f6.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (Form3.business == 1)
            {

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;


            }

        }
    }
}
