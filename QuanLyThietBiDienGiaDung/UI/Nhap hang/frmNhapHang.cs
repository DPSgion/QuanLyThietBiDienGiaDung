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
    public partial class frmNhapHang : Form
    {
        private QuanLySanPham quanLySanPham = new QuanLySanPham();
        private QuanLyNhapHang quanLyNhapHang = new QuanLyNhapHang();

        public frmNhapHang()
        {
            InitializeComponent();
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            capNhatGoiY_MaSP_TenSP();
        }

        #region Tạo phiếu nhập mới
        private void btnTaoMaNhapHang_Click(object sender, EventArgs e)
        {
            if (quanLyNhapHang.maNhapHangLonNhat() == "")
            {
                txtMaNhapHang.Text = "NH0001";
            }
            else
            {
                txtMaNhapHang.Text = taoMaNhapHangMoi(quanLyNhapHang.maNhapHangLonNhat());
            }
        }
        private string taoMaNhapHangMoi(string maNhapTruoc)
        {
            string so0 = "";

            int maNhapHangMoi = Convert.ToInt32(maNhapTruoc.Substring(2)) + 1;

            for (int i = demSo(maNhapHangMoi); i < 4; i++)
            {
                so0 += "0";
            }

            return ("NH" + so0 + maNhapHangMoi.ToString());
        }
        private int demSo(int x)
        {
            int ans = 0;
            while (x > 0)
            {
                x /= 10;
                ans += 1;
            }
            return ans;
        }
        #endregion

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capNhatGoiY_MaSP_TenSP()
        {
            // Gợi ý mã sản phẩm
            txtMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection colMaSP = new AutoCompleteStringCollection();

            foreach (SanPham n in quanLySanPham.getDSSanPham())
            {
                colMaSP.Add(n.MaSP);
            }

            txtMaSP.AutoCompleteCustomSource = colMaSP;


            // Gợi ý tên sản phẩm
            txtTenSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection colTenSP = new AutoCompleteStringCollection();

            foreach (SanPham n in quanLySanPham.getDSSanPham())
            {
                colTenSP.Add(n.TenSP);
            }

            txtTenSP.AutoCompleteCustomSource = colTenSP;
        }


        #region Mã sản phẩm
        private bool checkMaSP()
        {
            foreach (SanPham sp in quanLySanPham.getDSSanPham())
            {
                if (txtMaSP.Text == sp.MaSP)
                {
                    return true;
                }
            }
            return false;
        }
        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMaSP.Text = txtMaSP.Text.ToUpper();
                if (LabelkhongTimThayMaSP())
                {
                    txtTenSP.Text = timTenSPQuaMaSP(txtMaSP.Text);
                }
            }
        }
        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            txtMaSP.Text = txtMaSP.Text.ToUpper();
            if (LabelkhongTimThayMaSP())
            {
                txtTenSP.Text = timTenSPQuaMaSP(txtMaSP.Text);
            }
        }
        private bool LabelkhongTimThayMaSP()
        {
            if (!checkMaSP())
            {
                lblKhongTimThayMaSP.Visible = true;
                txtMaSP.Text = "";
                return false;
            }
            lblKhongThayTenSP.Visible = false;
            lblKhongTimThayMaSP.Visible = false;
            return true;
        }
        private string timTenSPQuaMaSP(string maSP)
        {
            string temp = "";
            foreach (SanPham x in quanLySanPham.getDSSanPham())
            {
                if (x.MaSP == maSP.ToUpper())
                {
                    temp = x.TenSP;
                    break;
                }
            }
            return temp;
        }
        #endregion

        #region Tên sản phẩm
        private bool checkTenSP()
        {
            foreach (SanPham sp in quanLySanPham.getDSSanPham())
            {
                if (txtTenSP.Text.ToLower() == sp.TenSP.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (LabelkhongTimThayTenSP())
                {
                    txtMaSP.Text = timMaSPQuaTenSP(txtTenSP.Text);
                }
            }
        }
        private void txtTenSP_Leave(object sender, EventArgs e)
        {
            if (LabelkhongTimThayTenSP())
            {
                txtMaSP.Text = timMaSPQuaTenSP(txtTenSP.Text);
            }
        }
        private bool LabelkhongTimThayTenSP()
        {
            if (!checkTenSP())
            {
                lblKhongThayTenSP.Visible = true;
                txtTenSP.Text = "";
                return false;
            }
            lblKhongThayTenSP.Visible = false;
            lblKhongTimThayMaSP.Visible = false;
            return true;
        }
        private string timMaSPQuaTenSP(string tenSP)
        {
            string temp = "";
            foreach (SanPham x in quanLySanPham.getDSSanPham())
            {
                if (x.TenSP.ToLower() == tenSP.ToLower())
                {
                    temp = x.MaSP;
                    break;
                }
            }
            return temp;
        }
        #endregion



    }
}
