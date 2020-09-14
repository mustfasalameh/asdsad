using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form3 : Form
    {
        /* public static DateTime date1;
         public static DateTime date2;
         public static int Plus_minus = 0;
         public static Form2 f2 = new Form2();
         public static Form4 f4 = new Form4();
         public static int Adult=0;
         public static int Child = 0;
         public static int Infant = 0;
         public static string one_way_to;
         public static string one_way_from;
         public static string return_to="";
         public static string return_from="";
         public static Boolean boolean = false;
         public static Boolean boolean1 = false;
         public static Boolean boolean2 = false;
         public static Boolean boolean3 = false;
         public static string temp;
         public static string Cabin_type = "";
         public static string name;*/

        public static Form2 f2 = new Form2();
        public static Form4 f4 = new Form4();
        public static string one_way_to;
        public static string name;
        public static string one_way_from;
        public static string from;
        public static string to;
        public static string from2;
        public static string to2;
        public static DateTime data1;
        public static DateTime data2;
        public static int Adult = 1;
        public static int child = 0;
        public static int infant = 0;
        public static int retu = 0;
        //public static int Economy = 0;
        public static int business = 0;
        public static int passing = 0;
        int i = 0;
        int x = 0;


        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            from = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedIndex >= 0)
            {

                comboBox3.Enabled = true;
                i = 1;
            }


        }


        private void Form3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
            radioButton4.BackColor = Color.Transparent;
            name = label2.Text;
            label2.Text = "Welcome, " + Form1.name;

            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            f2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passing = Adult + child + infant;

            if (radioButton3.Checked == true)
            {
                if (comboBox5.SelectedIndex == -1)
                { MessageBox.Show("هنالك حقول فارغه", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Hand); }

                else
                {
                    f4.Show();
                    this.Hide();
                }


            }



            else
            {
                f4.Show();
                this.Hide();
            }

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox4.SelectedIndex >= 0)
            {
                if (comboBox4.SelectedItem.ToString() == from)
                { MessageBox.Show("هذا الاختيار خاطىء", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    comboBox5.Enabled = true;
                }

            }


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem == comboBox4.SelectedItem)
            {
                MessageBox.Show("لا يجوز إختيار نفس المطار ", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Enabled = false;
            }
            else
            {
                to2 = comboBox5.SelectedItem.ToString();
                button2.Enabled = true;
            }




        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox3.SelectedItem == comboBox1.SelectedItem)
            {
                MessageBox.Show("لا يجوز اختيار نفس المطار ", "خطأ ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Enabled = false;

            }
            else
            {

                if (i == 1)
                {
                    button2.Enabled = true;
                    to = comboBox3.SelectedItem.ToString();

                }
                comboBox4.Items.Add(comboBox3.SelectedItem);


            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = true;
            if (radioButton3.Checked == true)
            { retu = 1; }
            else
            { retu = 0; }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (Adult == 50)
            { MessageBox.Show("أكبر عدد ممكن ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                Adult++;
                label17.Text = Adult.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Adult == 1)
            { MessageBox.Show("يجب أن يكون بالغ واحد على الأقل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                Adult--;
                label17.Text = Adult.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (child == 0)
            { MessageBox.Show("أقل عدد ممكن  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            else
            {
                child--;
                label18.Text = child.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (child == 50)
            { MessageBox.Show("أكبر عدد ممكن ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                child++;
                label18.Text = child.ToString();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (infant == 0)
            { MessageBox.Show("أقل عدد ممكن  ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            else
            {
                infant--;
                label19.Text = infant.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (infant == 50)
            { MessageBox.Show("أكبر عدد ممكن ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                infant++;
                label19.Text = infant.ToString();

            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            data2 = dateTimePicker2.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data1 = dateTimePicker1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            business = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
