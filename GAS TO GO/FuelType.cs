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
    public partial class FuelType : Form
    {
        public FuelType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PREMIUM frm= new PREMIUM();
            this.Close();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UNLEADED frm = new UNLEADED();
            this.Hide();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DIESEL frm = new DIESEL();
            this.Hide();
            frm.ShowDialog();
        }

        private void FuelType_Load(object sender, EventArgs e)
        {

        }
    }
}
