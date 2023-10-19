using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafeterija
{
    public partial class frmPocetna : Form
    {
        Form frm;
        Form frm2;
        Form frm3;
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void btnUAP_Click(object sender, EventArgs e)
        {
            frm = new frmUnosAzuriranje();
            frm.Show();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            frm2 = new frmUpiti();
            frm2.Show();
        }

        private void btnPP_Click(object sender, EventArgs e)
        {
            frm3 = new frmKvalif();
            frm3.Show();
        }
    }
}
