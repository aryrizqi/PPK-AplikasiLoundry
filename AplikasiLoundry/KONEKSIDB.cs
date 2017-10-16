using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AplikasiLoundry
{
    class KONEKSIDB
    {
        private MySqlCommand perintah = null;
        string konfigurasi = "server=localhost; port=3306; UID=root; PWD=; Database=aplikasi_loundry";
        MySqlConnection koneksi = new MySqlConnection();

        public KONEKSIDB()
        {
            koneksi.ConnectionString = konfigurasi;
        }

        public DataSet getDataHistory()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "SELECT id, id_order, paket, nama, no_hp, alamat, pengiriman, status FROM tbl_order";
                MySqlDataAdapter mdap = new MySqlDataAdapter(perintah);
                mdap.Fill(ds, "tbl_order");
                koneksi.Close();

            }
            catch (MySqlException)
            {
            }
            return ds;
        }

        public DataSet getDataSearch(string idOrder)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "SELECT id, id_order, paket, nama, no_hp, alamat, pengiriman, status FROM tbl_order WHERE id_order='" + idOrder + "'";
                MySqlDataAdapter mdap = new MySqlDataAdapter(perintah);
                mdap.Fill(ds, "tbl_order");
                koneksi.Close();

            }
            catch (MySqlException)
            {
            }
            return ds;
        }

        public DataSet getDataHarga()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "SELECT * FROM harga";
                MySqlDataAdapter mdap = new MySqlDataAdapter(perintah);
                mdap.Fill(ds, "harga");
                koneksi.Close();
            }
            catch (MySqlException) { }
            return ds;
        }

        public DataSet getDataUser()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "SELECT * FROM user";
                MySqlDataAdapter mdap = new MySqlDataAdapter(perintah);
                mdap.Fill(ds, "user");
                koneksi.Close();
            }
            catch (MySqlException) { }
            return ds;
        }

        public bool insertOrder(ClassOrder m)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "INSERT INTO tbl_order (id, id_order, paket, nama, no_hp, alamat, tgl_order, tgl_ren_selesai, pengiriman, berat, harga, biaya_antar, total_dibayar, uang_dibayar, uang_kembali, status) VALUES('" + "" + "','" + m.Id_order + "', '" + m.Paket + "','" + m.Nama + "', '" + m.No_hp + "', '" + m.Alamat + "', '" + m.Tgl_order + "', '" + m.Tgl_ren_selesai + "', '" + m.Pengiriman + "', '" + m.Berat + "', '" + m.Harga + "', '" + m.Biaya_antar + "', '" + m.Total_dibayar + "', '" + m.Uang_dibayar + "', '" + m.Uang_kembali + "', '" + m.Status + "')";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool insertHarga(ClassHarga m)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "INSERT INTO harga VALUES('" + "" + "','" + m.Jenis_hrg + "', '" + m.Total_hrg + "')";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool insertUser(ClassUser m)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "INSERT INTO user VALUES('" + "" + "','" + m.Username + "', '" + m.Password + "', '" + m.Nama + "', '" + m.Alamat + "', '" + m.No_telp + "')";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool updateHarga(ClassHarga m, string id)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "UPDATE harga SET jenis_harga='"+ m.Jenis_hrg +"', total_harga='" + m.Total_hrg + "' WHERE id='" + id + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool updateOrder(ClassOrder m, string id)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "UPDATE tbl_order SET id_order='" + m.Id_order + "', paket='" + m.Paket + "', nama='" + m.Nama + "', alamat='" + m.Alamat + "', no_hp='" + m.No_hp + "', pengiriman='" + m.Pengiriman + "', status='" + m.Status + "' WHERE id='" + id + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool updateAmbil(ClassOrder m, string id)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "UPDATE tbl_order SET status='" + m.Status + "' WHERE id='" + id + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool updateUser(ClassUser m, string id)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "UPDATE user SET username='" + m.Username + "', password='" + m.Password + "', nama_lengkap='" + m.Nama + "', alamat='" + m.Alamat + "', no_telp='" + m.No_telp + "' WHERE id='" + id + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();
            }
            catch (MySqlException) { }
            return stat;
        }

        public bool deleteHistory(string idOrder)
        {
            Boolean stat = false;
            try
            {
                koneksi.Open();
                perintah = new MySqlCommand();
                perintah.Connection = koneksi;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "DELETE FROM tbl_order WHERE id='" + idOrder + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                koneksi.Close();

            }
            catch (MySqlException) { }
            return stat;
        }

        public bool login(string id, string paswd)
        {
            string sql = "SELECT username, password FROM user";
            koneksi.Open();
            MySqlCommand cmd = new MySqlCommand(sql, koneksi);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (id == read.GetString(0) && paswd == read.GetString(1))
                {
                    koneksi.Close();
                    return true;
                }
            }
            koneksi.Close();
            return false;
        }
    }
}
