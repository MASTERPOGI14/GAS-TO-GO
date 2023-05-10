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
    public partial class CREDIT_CARD : Form
    {
        public CREDIT_CARD()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            txtCard.Text += num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 2;
            txtCard.Text += num.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 3;
            txtCard.Text += num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = 4;
            txtCard.Text += num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = 5;
            txtCard.Text += num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 6;
            txtCard.Text += num.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 7;
            txtCard.Text += num.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int num = 8;
            txtCard.Text += num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 9;
            txtCard.Text += num.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int num = 0;
            txtCard.Text += num.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtCard.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCard.Text = txtInput.Text.ToString();
            txtName.Text = "Vincent Paz";
            txtNumber.Text = "1414-2345-6789-1234";
            txtBal.Text = "4500";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
