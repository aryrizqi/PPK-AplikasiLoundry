using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiLoundry
{
    class ClassOrder
    {
        private string id_order, paket, nama, no_hp, alamat, tgl_order, tgl_ren_selesai, pengiriman, berat, harga, biaya_antar, total_dibayar, uang_dibayar, uang_kembali, username, tgl_selesai, tgl_ambil, status;

        public string Id_order
        {
            get
            {
                return id_order;
            }
            set
            {
                id_order = value;
            }
        }

        public string Paket
        {
            get
            {
                return paket;
            }
            set
            {
                paket = value;
            }
        }

        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }

        public string No_hp
        {
            get
            {
                return no_hp;
            }
            set
            {
                no_hp = value;
            }
        }

        public string Alamat
        {
            get
            {
                return alamat;
            }
            set
            {
                alamat = value;
            }
        }

        public string Tgl_order
        {
            get
            {
                return tgl_order;
            }
            set
            {
                tgl_order = value;
            }
        }
        public string Tgl_ren_selesai
        {
            get
            {
                return tgl_ren_selesai;
            }
            set
            {
                tgl_ren_selesai = value;
            }
        }

        public string Pengiriman
        {
            get
            {
                return pengiriman;
            }
            set
            {
                pengiriman = value;
            }
        }

        public string Berat
        {
            get
            {
                return berat;
            }
            set
            {
                berat = value;
            }
        }

        public string Harga
        {
            get
            {
                return harga;
            }
            set
            {
                harga = value;
            }
        }

        public string Biaya_antar
        {
            get
            {
                return biaya_antar;
            }
            set
            {
                biaya_antar = value;
            }
        }

        public string Total_dibayar
        {
            get
            {
                return total_dibayar;
            }
            set
            {
                total_dibayar = value;
            }
        }
        public string Uang_dibayar
        {
            get
            {
                return uang_dibayar;
            }
            set
            {
                uang_dibayar = value;
            }
        }

        public string Uang_kembali
        {
            get
            {
                return uang_kembali;
            }
            set
            {
                uang_kembali = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Tgl_selesai
        {
            get
            {
                return tgl_selesai;
            }
            set
            {
                tgl_selesai = value;
            }
        }
        public string Tgl_ambil
        {
            get
            {
                return tgl_ambil;
            }
            set
            {
                tgl_ambil = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
