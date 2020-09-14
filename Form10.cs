using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace online_system
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            label17.Text = Form1.name;
            label19.Text = Form1.email;
            
            label20.Text = Form3.passing.ToString();

            if (Form3.retu == 1)
            {

                label13.Text = "Reutern";

                label12.Visible = true;
                label22.Visible = true;

                label10.Visible = true;
                label27.Visible = true;


                label19.Visible = true;
                label23.Visible = true;

                label22.Text = Form3.to;
                label27.Text = Form3.to2;
                label23.Text = Form3.data2.ToString();

            }

            if (Form3.business == 1)
            {
                label15.Text = "Business";



            }

            label21.Text = Form3.from;
            label26.Text = Form3.to;
            label25.Text = Form3.data1.ToString();
            

            label24.Text = Form7.se4;





        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
