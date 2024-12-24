using QuanLyThietBiDienGiaDung.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienGiaDung
{
    public partial class frmQuanLyXuatHang : Form
    {

        // Mã xuất hàng và mã bán hàng là như nhau


        private QuanLyBanHang quanLyBanHang;
        private QuanLyKhachHang quanLyKhachHang;
        private BindingSource bdBanHang = new BindingSource();
        private BindingSource bdSanPham = new BindingSource();

        private string _mabanhang = "";

        public frmQuanLyXuatHang()
        {
            InitializeComponent();
        }
        private void frmQuanLyXuatHang_Load(object sender, EventArgs e)
        {
            quanLyBanHang = new QuanLyBanHang();
            quanLyKhachHang = new QuanLyKhachHang();

            hienThi(quanLyBanHang.getDSBanHang());
            goiYFull();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void hienThi(List<BanHang> dsBH)
        {
            bdBanHang.DataSource = dsBH;
            dgvBanHang.DataSource = bdBanHang;
            bdBanHang.ResetBindings(false);
        }
        private void dgvBanHang_qua_dgvSPXuatHang(List<SanPham> dsSP)
        {
            bdSanPham.DataSource = dsSP;
            dgvSPXuatHang.DataSource = bdSanPham;
            bdSanPham.ResetBindings(false);
        }

        private void dgvBanHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var mabanhangCell = dgvBanHang.Rows[e.RowIndex].Cells[0].Value;

            _mabanhang = (mabanhangCell != null) ? mabanhangCell.ToString() : "";

            if (_mabanhang != "")
            {
                BanHang bh = timBanHang(_mabanhang);
                dgvBanHang_qua_dgvSPXuatHang(bh.SanPhamBan);
            }
        }
        private BanHang timBanHang(string maBanHang)
        {
            foreach (BanHang bh in quanLyBanHang.getDSBanHang())
            {
                if (bh.MaBanHang == maBanHang)
                {
                    return bh;
                }
            }
            return null;
        }

        private void txtMaXuatHang_TextChanged(object sender, EventArgs e)
        {
            timKiemXuatHang();
        }
        private void txtTenNguoiMua_TextChanged(object sender, EventArgs e)
        {
            timKiemXuatHang();
        }
        private void txtSDTNguoiMua_TextChanged(object sender, EventArgs e)
        {
            timKiemXuatHang();
        }
        private void timKiemXuatHang()
        {
            List<BanHang> loc = SearchTheoMaBanHang(quanLyBanHang.getDSBanHang(), txtMaXuatHang.Text); // Lọc theo mã bán hàng
            loc = SearchTheoTenNguoiMua(loc, txtTenNguoiMua.Text); // Lọc theo người mua
            loc = SearchTheoSDT(loc, txtSDTNguoiMua.Text); // Lọc theo sđt

            hienThi(loc);

        }
        private List<BanHang> SearchTheoMaBanHang(List<BanHang> ds, string maBanHang)
        {
            List<BanHang> temp = ds;

            if (!string.IsNullOrEmpty(maBanHang))
            {
                string pattern = Regex.Escape(maBanHang).Replace("%", ".*");

                var filteredItems = temp
                    .Where(item => Regex.IsMatch(item.MaBanHang, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                return filteredItems;
            }

            // Hiển thị toàn bộ danh sách nếu không có tìm kiếm
            return temp;
        }
        private List<BanHang> SearchTheoTenNguoiMua(List<BanHang> ds, string tenNguoiMua)
        {
            List<BanHang> temp = ds;

            if (!string.IsNullOrEmpty(tenNguoiMua))
            {
                string pattern = Regex.Escape(tenNguoiMua).Replace("%", ".*");

                var filteredItems = temp
                    .Where(item => Regex.IsMatch(item.NguoiMua, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                return filteredItems;
            }

            // Hiển thị toàn bộ danh sách nếu không có tìm kiếm
            return temp;
        }
        private List<BanHang> SearchTheoSDT(List<BanHang> ds, string sdt)
        {
            List<BanHang> temp = ds;

            if (!string.IsNullOrEmpty(sdt))
            {
                string pattern = Regex.Escape(sdt).Replace("%", ".*");

                var filteredItems = temp
                    .Where(item => Regex.IsMatch(item.SDT, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                return filteredItems;
            }

            // Hiển thị toàn bộ danh sách nếu không có tìm kiếm
            return temp;
        }




        // Gợi ý
        private void goiYFull()
        {
            capNhatGoiYMaXuatHang();
            capNhatGoiYTenNguoiMua();
            capNhatGoiYSDTKH();
        }
        private void capNhatGoiYMaXuatHang()
        {
            txtMaXuatHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaXuatHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (BanHang bh in quanLyBanHang.getDSBanHang())
            {
                col.Add(bh.MaBanHang);
            }
            txtMaXuatHang.AutoCompleteCustomSource = col;
        }
        private void capNhatGoiYTenNguoiMua()
        {
            txtTenNguoiMua.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenNguoiMua.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (KhachHang kh in quanLyKhachHang.getDSKhachHang())
            {
                col.Add(kh.TenKhachHang);
            }
            txtTenNguoiMua.AutoCompleteCustomSource = col;
        }
        private void capNhatGoiYSDTKH()
        {
            txtSDTNguoiMua.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSDTNguoiMua.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (KhachHang kh in quanLyKhachHang.getDSKhachHang())
            {
                col.Add(kh.SdtKhachHang);
            }
            txtSDTNguoiMua.AutoCompleteCustomSource = col;
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaXuatHang.Text = "";
            dtpNgayXuat.Value = DateTime.Now;
            txtTenNguoiMua.Text = "";
            txtSDTNguoiMua.Text = "";
        }

        
    }
}
