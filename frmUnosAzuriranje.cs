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
    public partial class frmUnosAzuriranje : Form
    {
        private DataTable tabela;
        public frmUnosAzuriranje()
        {
            InitializeComponent();
        }

        private void frmUnosAzuriranje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kafeterijaDataSet.MENI' table. You can move, or remove it, as needed.
            this.mENITableAdapter.Fill(this.kafeterijaDataSet.MENI);
            // TODO: This line of code loads data into the 'kafeterijaDataSet.STAVKA_MENIJA' table. You can move, or remove it, as needed.
            this.sTAVKA_MENIJATableAdapter.Fill(this.kafeterijaDataSet.STAVKA_MENIJA);
            // TODO: This line of code loads data into the 'kafeterijaDataSet.MENI' table. You can move, or remove it, as needed.
            this.mENITableAdapter.Fill(this.kafeterijaDataSet.MENI);
            // TODO: This line of code loads data into the 'kafeterijaDataSet.viewSveStavkeMeni' table. You can move, or remove it, as needed.
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            char []c = txtCena.Text.ToCharArray() ;
            foreach(char br in c)
            {
                if (!Char.IsDigit(br))
                {
                    txtCena.Clear();
                    MessageBox.Show("Cena mora biti broj");
                    return;
                }
            }

        }

        private void dodajStavku_Click(object sender, EventArgs e)
        {
            tabela = new DataTable();
            if (cmbMeni.SelectedIndex >= 0)
            {
                String connStr = @"Data Source=DESKTOP-QGB7NKS\SQLEXPRESS01;Initial Catalog=Kafeterija;Integrated Security=True";
                //String query = "select nazivStavke, cenaStavke, opisStavke from stavka_menija where idMenija=" + id;
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO stavka_menija(idmenija, nazivStavke,cenaStavke, opisStavke)" +
                    " VALUES(@id,@naziv, @cena, @opis)";
                cmd.Parameters.AddWithValue("@id", cmbMeni.SelectedValue);
                cmd.Parameters.AddWithValue("@naziv", txtNaziv.Text);
                cmd.Parameters.AddWithValue("@cena", float.Parse(txtCena.Text));
                cmd.Parameters.AddWithValue("@opis", txtOpis.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                cmd.CommandText = "select * from stavka_menija";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(tabela);
                sTAVKA_MENIJADataGridView.DataSource = tabela;
                sda.Dispose();
                conn.Close();
                MessageBox.Show("Uspesno ste dodali stavku");
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form frm = new frmMeni();
            frm.Show();
        }

        private void sTAVKA_MENIJABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTAVKA_MENIJABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kafeterijaDataSet);

        }
    }
}
