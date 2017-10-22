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
    public partial class FormOrder : Form
    {
        //string TanggalOrder;
        KONEKSIDB md = new KONEKSIDB();

        public FormOrder()
        {
            InitializeComponent();
        }

        void ClearAll()
        {
            tbIdOrder.Text = null;
            tbNama.Text = null;
            tbNohp.Text = null;
            rtbAlamat = null;
            dtpOrder.Text = null;
            dtpRs.Text = null;
            tbBerat.Text = null;
            tbHarga.Text = null;
            tbBiaya.Text = null;
            tbTotal.Text = null;
            tbDibayar.Text = null;
            tbKembali.Text = null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string TanggalOrder = dtpOrder.Value.ToString("yyyy-MM-dd");
            string TanggalRenSelesai = dtpRs.Value.ToString("yyyy-MM-dd");

            ClassOrder m = new ClassOrder();

            if (rbDiantar.Checked)
            {
                m.Id_order = tbIdOrder.Text;
                m.Paket = cbPaket.Text;
                m.Nama = tbNama.Text;
                m.No_hp = tbNohp.Text;
                m.Alamat = rtbAlamat.Text;
                m.Tgl_order = TanggalOrder;
                m.Tgl_ren_selesai = TanggalRenSelesai;
                m.Pengiriman = rbDiantar.Text;
                m.Berat = tbBerat.Text;
                m.Harga = tbHarga.Text;
                m.Biaya_antar = tbBiaya.Text;
                m.Total_dibayar = tbTotal.Text;
                m.Uang_dibayar = tbDibayar.Text;
                m.Uang_kembali = tbKembali.Text;
                m.Status = "Progress";
            }
            else
            {
                m.Id_order = tbIdOrder.Text;
                m.Paket = cbPaket.Text;
                m.Nama = tbNama.Text;
                m.No_hp = tbNohp.Text;
                m.Alamat = rtbAlamat.Text;
                m.Tgl_order = TanggalOrder;
                m.Tgl_ren_selesai = TanggalRenSelesai;
                m.Pengiriman = rbDiambil.Text;
                m.Berat = tbBerat.Text;
                m.Harga = tbHarga.Text;
                m.Biaya_antar = tbBiaya.Text;
                m.Total_dibayar = tbTotal.Text;
                m.Uang_dibayar = tbDibayar.Text;
                m.Uang_kembali = tbKembali.Text;
                m.Status = "Progress";
            }


            md.insertOrder(m);
            MessageBox.Show("Data order berhasil ditambahkan!");
            ClearAll();
        }

        private void cbPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaket.SelectedItem.ToString() == "Cuci Kering")
            {
                tbHarga.Text = "4000";
                tbIdOrder.Text = "CK";
            }
            else if (cbPaket.SelectedItem.ToString() == "Cuci Basah")
            {
                tbHarga.Text = "5000";
                tbIdOrder.Text = "CB";
            }
            else if (cbPaket.SelectedItem.ToString() == "Cuci Setrika")
            {
                tbHarga.Text = "6000";
                tbIdOrder.Text = "CS";
            }
        }

        private void rbDiantar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDiantar.Checked)
            {
                tbBiaya.Text = "10000";
            } else
            {
                tbBiaya.Text = "0";
            }
        }

        private void tbBerat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int hrg = Int32.Parse(tbHarga.Text);
                int biaya = Int32.Parse(tbBiaya.Text);

                int berat = Int32.Parse(tbBerat.Text);
                int total = (berat * hrg) + biaya;
                tbTotal.Text = total.ToString();
            } catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void tbDibayar_TextChanged(object sender, EventArgs e)
        {
            int total = Int32.Parse(tbTotal.Text);
            try
            {
                if (Int32.Parse(tbDibayar.Text) > 0 || !string.IsNullOrEmpty(tbDibayar.Text))
                {
                    int bayar = Int32.Parse(tbDibayar.Text);
                    int kembali = bayar - total;

                    tbKembali.Text = kembali.ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

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
