using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAS_TO_GO
{
    public partial class UNLEADED : Form
    {
        public UNLEADED()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            textBox1.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 2;
            textBox1.Text = num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 3;
            textBox1.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = 4;
            textBox1.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 5;
            textBox1.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 6;
            textBox1.Text = num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 7;
            textBox1.Text = num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = 8;
            textBox1.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 9;
            textBox1.Text = num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = 0;
            textBox1.Text = num.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double Liter;
            double Price = 66.25;
            double Amt;

            Liter = Convert.ToDouble(textBox1.Text);
            Amt = Liter * Price;
            txtAmt.Text = Amt.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PROGRESS frm = new PROGRESS();
            this.Hide();
            frm.Show();
        }
    }
}
