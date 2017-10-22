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
    public partial class FormAdmin : Form
    {
        KONEKSIDB md = new KONEKSIDB();
        string idUser;
        public FormAdmin()
        {
            InitializeComponent();
        }

        void viewData()
        {
            DataSet data = md.getDataUser();
            dataGridView2.DataSource = data;
            dataGridView2.DataMember = "user";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            ClassUser m = new ClassUser();
            m.Username = tbUsername.Text;
            m.Password = tbPassword.Text;
            m.Nama = tbNama.Text;
            m.Alamat = rtbAlamat.Text;
            m.No_telp = tbTelp.Text;

            md.insertUser(m);
            viewData();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            viewData();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbUsername.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPassword.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbNama.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtbAlamat.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTelp.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();

            idUser = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassUser m = new ClassUser();
            m.Username = tbUsername.Text;
            m.Password = tbPassword.Text;
            m.Nama = tbNama.Text;
            m.Alamat = rtbAlamat.Text;
            m.No_telp = tbTelp.Text;

            md.updateUser(m, idUser);
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
