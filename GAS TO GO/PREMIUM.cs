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
    public partial class PREMIUM : Form
    {
        public PREMIUM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            txtInput.Text += num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 2;
            txtInput.Text += num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 3;
            txtInput.Text += num.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int num = 4;
            txtInput.Text += num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 5;
            txtInput.Text += num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 6;
            txtInput.Text += num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 7;
            txtInput.Text += num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = 8;
            txtInput.Text += num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 9;
            txtInput.Text += num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = 0;
            txtInput.Text += num.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PROGRESS frm = new PROGRESS();
            this.Hide();
            frm.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            PROGRESS frm = new PROGRESS();
            this.Hide();
            frm.ShowDialog();
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            double Liter;
            double Price = 63.50;
            double Amt;

            Liter = Convert.ToDouble(txtInput.Text);
            Amt = Liter * Price;
            txtAmt.Text = Amt.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PROGRESS frm = new PROGRESS();
            this.Hide();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num = 1;
            txtInput.Text += num.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int num = 2;
            txtInput.Text += num.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int num = 3;
            txtInput.Text += num.ToString();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            int num = 4;
            txtInput.Text += num.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int num = 5;
            txtInput.Text += num.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int num = 6;
            txtInput.Text += num.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            int num = 7;
            txtInput.Text += num.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int num = 8;
            txtInput.Text += num.ToString();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int num = 9;
            txtInput.Text += num.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int num = 0;
            txtInput.Text += num.ToString();
        }
    }
}
