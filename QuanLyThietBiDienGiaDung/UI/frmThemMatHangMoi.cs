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

        public double GiaNhap { get; private set; }
        public double GiaBan { get; private set; }

        public frmThemMatHangMoi()
        {
            InitializeComponent();
        }
        private void frmThemMatHangMoi_Load(object sender, EventArgs e)
        {
            capNhatLuaChonCbo();
            if (cboLoaiHang.Items.Count > 0)
            {
                cboLoaiHang.Text = cboLoaiHang.Items[0].ToString();
            }
            else
            {
                MessageBox.Show("Chưa có loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void capNhatLuaChonCbo()
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
                string.IsNullOrEmpty(txtGiaNhap.Text) || string.IsNullOrEmpty(txtGiaBan.Text) ||
                string.IsNullOrEmpty(cboLoaiHang.Text))
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!checkTrungMaSP(txtMaSP.Text))
                {
                    if (isNumber(txtGiaNhap.Text) && isNumber(txtGiaBan.Text))
                    {

                        MaSP = txtMaSP.Text;
                        TenSP = txtTenSP.Text;
                        LoaiHang = cboLoaiHang.Text;
                        Hang = txtHang.Text;
                        TSKT = txtTSKT.Text;
                        GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
                        GiaBan = Convert.ToDouble(txtGiaBan.Text);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Giá nhập, giá bán phải là số dương",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã số sản phẩm bị trùng",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private QuanLySanPham quanLySP = new QuanLySanPham();
        private bool checkTrungMaSP(string maSP)
        {
            foreach (SanPham i in quanLySP.getDSSanPham())
            {
                if (maSP == i.MaSP)
                {
                    return true;
                }
            }
            return false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isNumber(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number > 0; // Trả về true nếu là số dương
            }

            if (double.TryParse(input, out double doubleNumber))
            {
                return doubleNumber > 0; // Trả về true nếu là số dương
            }

            // Nếu không phải số, trả về false
            return false;
        }
    }
}
