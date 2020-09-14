using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace online_system
{
    public partial class Form1 : Form
    {
        public static string name;
        public static string phone;
        public static string email;
        string err = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(900, 500);


         
        }

      

      

        // Hide the tooltip if the user starts typing again before the five-second display limit on the tooltip expires.
        void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(maskedTextBox1);
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
          
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                if (err.Contains("name")) { }
                
                else
                    err += "Please enter your name!\n";
            }
            else {

                err = "";
            }

            if (!maskedTextBox1.MaskCompleted)
            {
                if (err.Contains("number")) { }

                else
                    err += "Please enter your phone number!\n";


            }
            else
            {
                err = "";

            }

            if (textBox2.Text.Contains("@"))
            {
                if (textBox2.Text.Contains(".com"))
                {                    
                }
            }
            else
            {
                if (err.Contains("email")) { }

                else
                    err += "Please check your email address!\n";


            }



            if (err == "")
            {
                email = textBox2.Text;
                Form3.f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(err, "Try Again ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


             email = textBox2.Text; 

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Invalid Phone Number";
            toolTip1.Show("Please enter digits only!", maskedTextBox1, 0, -40, 3000);
            
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
