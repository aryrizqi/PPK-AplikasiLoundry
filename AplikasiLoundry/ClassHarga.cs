using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiLoundry
{
    class ClassHarga
    {
        private string jenis_hrg, total_hrg;

        public string Jenis_hrg
        {
            get
            {
                return jenis_hrg;
            }
            set
            {
                jenis_hrg = value;
            }
        }

        public string Total_hrg
        {
            get
            {
                return total_hrg;
            }
            set
            {
                total_hrg = value;
            }
        }
    }
}
