using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafeterija
{
    public partial class frmUpiti : Form
    {
        private DataTable tabela;
        public frmUpiti()
        {
            InitializeComponent();
        }

        private void btnKvalif_Click(object sender, EventArgs e)
        {
            tabela = new DataTable();
            String connStr = @"Data Source=DESKTOP-QGB7NKS\SQLEXPRESS01;Initial Catalog=Kafeterija;Integrated Security=True";
            String query = "select imeZaposlenog, prezimeZaposlenog, telefonZaposlenog from zaposleni where imeZaposlenog like '" + txtKvalif.Text + "%'";
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabela);
            dataGridView1.Refresh();
            dataGridView1.DataSource = tabela;
            sda.Dispose();
            conn.Close();
        }

        private void frmUpiti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kafeterijaDataSet.MENI' table. You can move, or remove it, as needed.
            this.mENITableAdapter.Fill(this.kafeterijaDataSet.MENI);
            // TODO: This line of code loads data into the 'kafeterijaDataSet.MENI' table. You can move, or remove it, as needed.
            this.mENITableAdapter.Fill(this.kafeterijaDataSet.MENI);

        }

        private void cmbMeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabela = new DataTable();
            int id;
            if (cmbMeni.SelectedIndex >= 0)
            {
                id = Int32.Parse(cmbMeni.SelectedValue.ToString());
                String connStr = @"Data Source=DESKTOP-QGB7NKS\SQLEXPRESS01;Initial Catalog=Kafeterija;Integrated Security=True";
                String query = "select nazivStavke, cenaStavke, opisStavke from stavka_menija where idMenija="+id;
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(tabela);
                
                dgvMeni.DataSource = tabela;
                sda.Dispose();
                conn.Close();

            }
            
            
        }
    }
}
