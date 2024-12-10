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

namespace QuanLyThietBiDienGiaDung
{
    public partial class frmThemMatHangMoi : Form
    {
        private QuanLyLoaiHang quanLyLH = new QuanLyLoaiHang();

        public string MaSP { get; private set; }
        public string TenSP { get; private set; }
        public string LoaiHang { get; private set; }
        public string Hang { get; private set; }
        public string TSKT { get; private set; }
        public string GiaNhap { get; private set; }
        public string GiaBan { get; private set; }

        public frmThemMatHangMoi()
        {
            InitializeComponent();
        }
        private void frmThemMatHangMoi_Load(object sender, EventArgs e)
        {
            CapNhatGoiY();
            cboLoaiHang.Text = cboLoaiHang.Items[0].ToString();
        }

        private void CapNhatGoiY()
        {
            foreach (LoaiHang n in quanLyLH.getDSLoaiHang())
            {
                cboLoaiHang.Items.Insert(cboLoaiHang.Items.Count, n.TenLoaiHang);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtTenSP.Text) ||
                string.IsNullOrEmpty(txtHang.Text) || string.IsNullOrEmpty(txtTSKT.Text) ||
                string.IsNullOrEmpty(txtGiaNhap.Text) || string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MaSP = txtMaSP.Text;
                TenSP = txtTenSP.Text;
                LoaiHang = cboLoaiHang.Text;
                Hang = txtHang.Text;
                TSKT = txtTSKT.Text;
                GiaNhap = txtGiaNhap.Text;
                GiaBan = txtGiaBan.Text;

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
