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
    public partial class frmMeni : Form
    {
        public frmMeni()
        {
            InitializeComponent();
        }

        private void frmMeni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kafeterijaDataSet.MENI' table. You can move, or remove it, as needed.
            this.mENITableAdapter.Fill(this.kafeterijaDataSet.MENI);
            // TODO: This line of code loads data into the 'kafeterijaDataSet.viewMeni' table. You can move, or remove it, as needed.
          

        }

        private void mENIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mENIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kafeterijaDataSet);

        }
    }
}
