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
    public partial class frmKvalif : Form
    {
        public frmKvalif()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.funPretragaKvalifikacTableAdapter.Fill(this.kafeterijaDataSet.funPretragaKvalifikac, kvalifToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.funPretragaKvalifikacTableAdapter.Fill(this.kafeterijaDataSet.funPretragaKvalifikac, kvalifToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.funPretragaKvalifikacTableAdapter.Fill(this.kafeterijaDataSet.funPretragaKvalifikac, kvalifToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.funPretragaKvalifikacTableAdapter.Fill(this.kafeterijaDataSet.funPretragaKvalifikac, kvalifToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.funPretragaKvalifikacTableAdapter.Fill(this.kafeterijaDataSet.funPretragaKvalifikac, kvalifToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
