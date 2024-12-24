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
    }
}
