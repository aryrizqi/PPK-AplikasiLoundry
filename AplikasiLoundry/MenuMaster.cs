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
    public partial class MenuMaster : Form
    {
        
        public MenuMaster()
        {
            InitializeComponent();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder chOrder = new FormOrder();
            if (chOrder != null)
            {
                chOrder.MdiParent = this;
                chOrder.Show();
                chOrder.WindowState = FormWindowState.Maximized;
            }
        }

        private void ambilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAmbil chAmbil = new FormAmbil();
            if (chAmbil != null)
            {
                chAmbil.MdiParent = this;
                chAmbil.Show();
                chAmbil.WindowState = FormWindowState.Maximized;
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory chHistory = new FormHistory();
            if (chHistory != null)
            {
                chHistory.MdiParent = this;
                chHistory.Show();
                chHistory.WindowState = FormWindowState.Maximized;
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin chAdmin = new FormAdmin();
            if (chAdmin != null)
            {
                chAdmin.MdiParent = this;
                chAdmin.Show();
                chAdmin.WindowState = FormWindowState.Maximized;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings chSettings = new FormSettings();
            if (chSettings != null)
            {
                chSettings.MdiParent = this;
                chSettings.Show();
                chSettings.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
