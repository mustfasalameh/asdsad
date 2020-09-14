using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form8 : Form
    {

        public static int details; //Check the details


        public Form8()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

            label2.Text = Form4.cost.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;

            }

            else
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6.f9.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6.f9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" A message has been sent to your email", " Ticket has been reserved", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (MessageBox.Show(" Want to see details ? ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form10 f10 = new Form10();
                    f10.Show();
                    this.Hide();
                }


            }



        }




    }




}

