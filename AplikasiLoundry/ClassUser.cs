using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiLoundry
{
    class ClassUser
    {
        private string username, password, nama, alamat, no_telp, status;
        
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

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
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

        public string No_telp
        {
            get
            {
                return no_telp;
            }
            set
            {
                no_telp = value;
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
