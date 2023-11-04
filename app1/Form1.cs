using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn7.Text = "7";
            btn8.Text = "8";
           

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn10.Text = "10";
            btn11.Text = "11";
            btn12.Text = "12";
            btn13.Text = "13";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            btn15.Text = "15";
            btn16.Text = "16";
           
        }
    }
}
