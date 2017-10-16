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
    public partial class FormSettings : Form
    {
        KONEKSIDB md = new KONEKSIDB();
        string idHarga;
        public FormSettings()
        {
            InitializeComponent();
        }

        void viewData()
        {
            DataSet data = md.getDataHarga();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "harga";
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            viewData();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbService.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            idHarga = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClassHarga m = new ClassHarga();
            m.Jenis_hrg = cbService.Text;
            m.Total_hrg = tbHarga.Text;

            md.insertHarga(m);
            viewData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassHarga m = new ClassHarga();
            m.Jenis_hrg = cbService.Text;
            m.Total_hrg = tbHarga.Text;

            md.updateHarga(m, idHarga);
            viewData();
        }
    }
}
