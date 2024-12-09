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
    public partial class frmQuanLyLoaiHang : Form
    {
        public frmQuanLyLoaiHang()
        {
            InitializeComponent();
        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang themLH = new frmThemLoaiHang();
            themLH.ShowDialog();
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            frmSuaLoaiHang suaLH = new frmSuaLoaiHang();
            suaLH.ShowDialog();
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
