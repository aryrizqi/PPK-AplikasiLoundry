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
    public partial class FormHistory : Form
    {
        KONEKSIDB md = new KONEKSIDB();
        public FormHistory()
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

        string id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbIdOrder.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbPaket.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbNama.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbNoHp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbAlamat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbPengiriman.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassOrder m = new ClassOrder();
            m.Id_order = tbIdOrder.Text;
            m.Paket = cbPaket.Text;
            m.Nama = cbNama.Text;
            m.Alamat = tbAlamat.Text;
            m.No_hp = tbNoHp.Text;
            m.Pengiriman = cbPengiriman.Text;
            m.Status = cbStatus.Text;

            md.updateOrder(m, id);
            viewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            md.deleteHistory(id);
            viewData();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            viewSearch(tbIdOrder.Text);
        }
    }
}
