using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLoundry
{
    public partial class FormAmbil : Form
    {
        KONEKSIDB md = new KONEKSIDB();

        public FormAmbil()
        {
            InitializeComponent();
        }

        void viewData()
        {
            DataSet data = md.getDataHistory();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "tbl_order";
        }

        void viewSearch(string idOrder)
        {
            DataSet data = md.getDataSearch(idOrder);
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "tbl_order";
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            viewData();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            viewSearch(tbIdOrder.Text);
        }

        string id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbIdOrder.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassOrder m = new ClassOrder();
            m.Status = cbStatus.Text;

            md.updateAmbil(m, id);
            viewData();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MenuMaster parentForm = (MenuMaster)this.MdiParent;
            parentForm.Visible = false;
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
