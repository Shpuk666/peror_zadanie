using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp8
{
    

    public partial class Form1 : Form
    {
        int a;
        int b;
        int c = 50;
        int d = 80;
        int f = 110;

        public Form1()

        {
             
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                a = c * b;
                label3.Text = Convert.ToString(a);
            }
            if (radioButton2.Checked == true)
            {
                a = d * b;
                label3.Text = Convert.ToString(a);
            }   
            if (radioButton3.Checked == true)
            {
                a = f * b;
                label3.Text = Convert.ToString(a);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox1.Text);
        }
    }
}
