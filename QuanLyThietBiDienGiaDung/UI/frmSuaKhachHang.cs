using QuanLyThietBiDienGiaDung.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienGiaDung.UI
{
    public partial class frmSuaKhachHang : Form
    {
        private QuanLyKhachHang quanLyKhachHang;

        public frmSuaKhachHang()
        {
            InitializeComponent();
        }
        public frmSuaKhachHang(string maKH)
        {
            InitializeComponent();

            txtMaKhachHang.Text = maKH;
        }

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            quanLyKhachHang = new QuanLyKhachHang();
            lenThongTin(txtMaKhachHang.Text);
        }


        private void lenThongTin(string maSP)
        {
            KhachHang kh = timKhachHangQuaMaKhachHang(maSP);
            if (kh != null)
            {
                txtTenKhachHang.Text = kh.TenKhachHang;
                txtSDT.Text = kh.SdtKhachHang;
                txtDiaChi.Text = kh.DiaChiKhachHang;
            }
        }
        private KhachHang timKhachHangQuaMaKhachHang(string maKH)
        {
            foreach (KhachHang kh in quanLyKhachHang.getDSKhachHang())
            {
                if (kh.MaKhachHang == maKH)
                {
                    return kh;
                }
            }
            return null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang duLieuCu = timKhachHangQuaMaKhachHang(txtMaKhachHang.Text);

            if (duLieuCu != null)
            {
                duLieuCu.TenKhachHang = txtTenKhachHang.Text;
                duLieuCu.SdtKhachHang = txtSDT.Text;
                duLieuCu.DiaChiKhachHang = txtDiaChi.Text;

                MessageBox.Show("Đã sửa thông tin khách hàng", "Thông báo", MessageBoxButtons.OK);

                this.Close();
            }
            else
            {
                MessageBox.Show("Không sửa được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
