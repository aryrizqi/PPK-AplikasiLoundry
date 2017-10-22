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
    public partial class FormLogin : Form
    {
        KONEKSIDB kon = new KONEKSIDB();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id, pass;
            id = tbLogin.Text;
            pass = tbPassword.Text;
            if (kon.login(id, pass))
            {
                MessageBox.Show("Login success");
                Visible = false;
                MenuMaster m = new MenuMaster();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
