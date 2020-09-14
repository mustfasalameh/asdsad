using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form6 : Form
    {
        public static Form9 f9 = new Form9();
        public static Form7 f7 = new Form7();

        public static int bag = 41;
        public static int x = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { Form4.cost = Form4.cost + 41; }
            else
            { Form4.cost = Form4.cost + 0; }

            f9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.f4.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            f7.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            f7.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Name = "ok";
        }
    }

}
