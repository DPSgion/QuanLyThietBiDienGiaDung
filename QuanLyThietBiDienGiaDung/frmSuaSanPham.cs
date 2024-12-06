using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienGiaDung
{
    public partial class frmSuaSanPham : Form
    {
        public frmSuaSanPham()
        {
            InitializeComponent();
        }
        public frmSuaSanPham(string ma)
        {
            InitializeComponent();
            txtMaSP.Text = ma;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
