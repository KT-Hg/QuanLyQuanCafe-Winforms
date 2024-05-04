using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanCafe
{
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
        }

        private void frmTableManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            this.Hide();
            frmAdmin.ShowDialog();
            this.Show();
        }

        private void tsmAccountProfile_Click(object sender, EventArgs e)
        {
            frmAccountProfile frmAccountProfile = new frmAccountProfile();
            frmAccountProfile.ShowDialog();
            this.Show();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


