using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calvculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn9.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn7.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
             txtPantalla.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e) 
        {
            txtPantalla.Text += btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = btn5.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += btn8.Text;
        }
    }
}
