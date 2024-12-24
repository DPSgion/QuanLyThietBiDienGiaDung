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
    public partial class frmQuanLyNhapHang : Form
    {
        private QuanLyNhapHang quanLyNhapHang;
        private BindingSource bdNhapHang = new BindingSource();
        private BindingSource bdSanPham = new BindingSource();

        private string _manhaphang = "";

        public frmQuanLyNhapHang()
        {
            InitializeComponent();
        }
        private void frmQuanLyNhapHang_Load(object sender, EventArgs e)
        {
            quanLyNhapHang = new QuanLyNhapHang();

            hienThiPhieuNhapHang(quanLyNhapHang.getDSPhieuNhapHang());
            capNhatGoiYMaNhapHang();
        }
        private void hienThiPhieuNhapHang(List<PhieuNhapHang> dsPhieuNhap)
        {
            bdNhapHang.DataSource = dsPhieuNhap;
            dgvNhapHang.DataSource = bdNhapHang;
            bdNhapHang.ResetBindings(false);

        }
        private void dgvNhapHang_Qua_dgvSP(List<SanPham> dsSP)
        {
            bdSanPham.DataSource = dsSP;
            dgvSPNhapHang.DataSource = bdSanPham;
            bdSanPham.ResetBindings(false);
        }


        private void capNhatGoiYMaNhapHang()
        {
            txtMaNhapHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaNhapHang.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (PhieuNhapHang phieu in quanLyNhapHang.getDSPhieuNhapHang())
            {
                col.Add(phieu.MaNhapHang);
            }

            txtMaNhapHang.AutoCompleteCustomSource = col;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNgayNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (cboNgayNhap.Checked == true)
            {
                dtpNgayNhap.Enabled = true;
                timKiemNhapHang();
            }
            else if (cboNgayNhap.Checked == false)
            {
                dtpNgayNhap.Enabled = false;
                hienThiPhieuNhapHang(quanLyNhapHang.getDSPhieuNhapHang());
            }
        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            timKiemNhapHang();
        }
        private void txtMaNhapHang_TextChanged(object sender, EventArgs e)
        {
            timKiemNhapHang();
        }
        private void timKiemNhapHang()
        {
            List<PhieuNhapHang> loc = new List<PhieuNhapHang>();

            loc = SearchTheoMaNhapHang(quanLyNhapHang.getDSPhieuNhapHang(), txtMaNhapHang.Text);

            if (cboNgayNhap.Checked == true)
            {
                loc = locTheoNgayNhap(loc, dtpNgayNhap.Value);
            }
            

            hienThiPhieuNhapHang(loc);
        }
        private List<PhieuNhapHang> SearchTheoMaNhapHang(List<PhieuNhapHang> ds, string searchText)
        {
            List<PhieuNhapHang> temp = ds;

            if (!string.IsNullOrEmpty(searchText))
            {
                string pattern = Regex.Escape(searchText).Replace("%", ".*");
                
                var filteredItems = temp
                    .Where(item => Regex.IsMatch(item.MaNhapHang, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                return filteredItems;
            }

            // Hiển thị toàn bộ danh sách nếu không có tìm kiếm
            return temp;

        }
        private List<PhieuNhapHang> locTheoNgayNhap(List<PhieuNhapHang> ds, DateTime ngayNhap)
        {
            List<PhieuNhapHang> temp = new List<PhieuNhapHang>();

            foreach (PhieuNhapHang phieu in ds)
            {
                if (phieu.NgayNhapHang.Date == ngayNhap.Date)
                {
                    temp.Add(phieu);
                }
            }
            return temp;
        }


        private void dgvNhapHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var maNhapHangCell = dgvNhapHang.Rows[e.RowIndex].Cells[0].Value;

            _manhaphang = (maNhapHangCell != null) ? maNhapHangCell.ToString() : "";

            if (_manhaphang != "")
            {
                PhieuNhapHang phieu = timPhieu(_manhaphang);
                dgvNhapHang_Qua_dgvSP(phieu.DsSanPham);
            }
        }
        private PhieuNhapHang timPhieu(string maNhapHang)
        {
            foreach (PhieuNhapHang phieu in quanLyNhapHang.getDSPhieuNhapHang())
            {
                if (phieu.MaNhapHang == maNhapHang)
                {
                    return phieu;
                }
            }
            return null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNhapHang.Text = "";
            cboNgayNhap.Checked = false;
        }
    }
}
