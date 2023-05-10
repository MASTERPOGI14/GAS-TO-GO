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
    public partial class PROGRESS : Form
    {
        public PROGRESS()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PROGRESS_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = (progressBar1.Value + "%");

           if(progressBar1.Value <100 )
            {
                progressBar1.Value += 5;
            }
           else
            {
                timer1.Stop();
                RECEIPT frm = new RECEIPT();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
