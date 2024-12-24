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
    public partial class frmQuanLyXuatHang : Form
    {
        private QuanLyBanHang quanLyBanHang;
        private BindingSource bdBanHang = new BindingSource();
        private BindingSource bdSanPham = new BindingSource();

        private string _mabanhang = "";

        public frmQuanLyXuatHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyXuatHang_Load(object sender, EventArgs e)
        {
            quanLyBanHang = new QuanLyBanHang();

            hienThi(quanLyBanHang.getDSBanHang());
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
    }
}
