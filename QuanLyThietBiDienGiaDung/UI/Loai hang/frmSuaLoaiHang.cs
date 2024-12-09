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
    public partial class frmSuaLoaiHang : Form
    {
        public string MaLoaiHang { get; private set; }
        public string TenLoaiHang { get; private set; }

        public frmSuaLoaiHang()
        {
            InitializeComponent();
        }
        public frmSuaLoaiHang(string ma, string ten)
        {
            InitializeComponent();
            txtMaLH.Text = ma;
            txtTenLH.Text = ten;
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLH.Text) || string.IsNullOrEmpty(txtTenLH.Text))
            {
                MessageBox.Show("Mã loại hàng và tên loại hàng không được để trống");
            }
            else
            {
                MaLoaiHang = txtMaLH.Text;
                TenLoaiHang = txtTenLH.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
