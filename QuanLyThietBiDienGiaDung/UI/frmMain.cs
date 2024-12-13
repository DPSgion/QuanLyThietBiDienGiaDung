﻿using QuanLyThietBiDienGiaDung.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienGiaDung
{
    public partial class frmMain : Form
    {
        QuanLySanPham quanLySP;
        BindingSource bdKhoHang = new BindingSource();


        private string maSP_khoHang = "";
        private string tenSP_khoHang = "";
        private string loaiHang_khoHang = "";
        private string hang_khoHang = "";
        private string tskt_khoHang = "";
        private int soLuong_khoHang = 0;
        private double giaNhap_khoHang = 0;
        private double giaBan_khoHang = 0;

        public frmMain()
        {
            InitializeComponent();

            //runTest();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.docFile("tst.dat");
            quanLySP = new QuanLySanPham();

            bdKhoHang.DataSource = quanLySP.getDSSanPham();
            dgvHang.DataSource = bdKhoHang;


            CapNhatGoiY_TxtTimMaSP();
            cboTimGiaSP.Text = cboTimGiaSP.Items[0].ToString();

            hienThi(quanLySP.getDSSanPham());

        }
        private void hienThi(List<SanPham> ds)
        {
            bdKhoHang.DataSource = ds;
            dgvHang.DataSource = bdKhoHang;
            bdKhoHang.ResetBindings(false);
        }

        private void thêmSảnPhẩmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            using (frmThemMatHangMoi SPmoi = new frmThemMatHangMoi())
            {
                if (SPmoi.ShowDialog() == DialogResult.OK)
                {
                    string masp = SPmoi.MaSP;
                    string tensp = SPmoi.TenSP;
                    string loaihang = SPmoi.LoaiHang;
                    string hang = SPmoi.Hang;
                    string tskt = SPmoi.TSKT;
                    double gianhap = SPmoi.GiaNhap;
                    double giaban = SPmoi.GiaBan;

                    SanPham temp = new SanPham(masp, tensp, loaihang, hang, tskt, 0, gianhap, giaban);

                    if (!quanLySP.themSanPham(temp))
                    {
                        MessageBox.Show("Bị trùng mã sản phẩm");
                        return;
                    }
                }
                hienThi(quanLySP.getDSSanPham());
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSP_khoHang))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!quanLySP.xoaSanPham(maSP_khoHang))
                    {
                        MessageBox.Show("Xóa không được", "Thông báo");
                    }
                }
                hienThi(quanLySP.getDSSanPham());
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            SanPham a = new SanPham();
            a.MaSP = maSP_khoHang;

            using (frmSuaSanPham fixSP = new frmSuaSanPham(maSP_khoHang, tenSP_khoHang, loaiHang_khoHang, hang_khoHang,
                tskt_khoHang, soLuong_khoHang, giaNhap_khoHang, giaBan_khoHang))
            {
                if (fixSP.ShowDialog() == DialogResult.OK)
                {

                    string masp = fixSP.MaSP;
                    string tensp = fixSP.TenSP;
                    string loaihang = fixSP.LoaiHang;
                    string hang = fixSP.Hang;
                    string tskt = fixSP.TSKT;
                    int soluong = fixSP.SoLuong;
                    double gianhap = fixSP.GiaNhap;
                    double giaban = fixSP.GiaBan;

                    SanPham temp = new SanPham(masp, tensp, loaihang, hang, tskt, soluong,
                        gianhap, giaban);

                    if (!quanLySP.suaSanPham(a, temp))
                    {
                        MessageBox.Show("Ko sửa đc");
                    }

                    hienThi(quanLySP.getDSSanPham());
                }
            }

        }

        private void CapNhatGoiY_TxtTimMaSP()
        {

            txtTimMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (SanPham n in quanLySP.getDSSanPham())
            {
                col.Add(n.TenSP);
            }

            txtTimMaSP.AutoCompleteCustomSource = col;

        }

        private List<SanPham> SearchTheoTen(string searchText)
        {
            List<SanPham> temp = quanLySP.getDSSanPham();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo pattern
                string pattern = Regex.Escape(searchText).Replace("%", ".*");
                //string pattern = searchText;
                // Lọc danh sách
                var filteredItems = temp
                    .Where(item => Regex.IsMatch(item.TenSP, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                // Hiển thị kết quả
                return filteredItems;
            }

            // Hiển thị toàn bộ danh sách nếu không có tìm kiếm
            return temp;
            
        }

        private void runTest()
        {
            dgvHang.Rows[0].Cells[0].Value = "ML001";
            dgvHang.Rows[0].Cells[1].Value = "Máy lạnh 2HP";
            dgvHang.Rows[0].Cells[2].Value = "Máy lạnh";
            dgvHang.Rows[0].Cells[3].Value = "Toshiba";
            dgvHang.Rows[0].Cells[4].Value = "- Test thử thôi\n" + "- Đang thành công\n" +
                "- Làm lạnh với công suất 900W, có thể làm lạnh 1 cây kem với thời gian 10 phút";
            dgvHang.Rows[0].Cells[5].Value = "235";
            dgvHang.Rows[0].Cells[6].Value = "300.000.000";
            dgvHang.Rows[0].Cells[7].Value = "340.000.000";
        }


        private void txtTimMaSP_Enter(object sender, EventArgs e)
        {
            if (txtTimMaSP.Text == "Nhập tên sản phẩm")
            {
                txtTimMaSP.Text = "";
                txtTimMaSP.ForeColor = Color.Black;
            }
        }
        private void txtTimMaSP_Leave(object sender, EventArgs e)
        {
            if (txtTimMaSP.Text == "")
            {
                txtTimMaSP.Text = "Nhập tên sản phẩm";
                txtTimMaSP.ForeColor = Color.Silver;
            }
        }

        private void txtGiaTenSP_Enter(object sender, EventArgs e)
        {
            if (txtGiaTenSP.Text == "Nhập tên sản phẩm")
            {
                txtGiaTenSP.Text = "";
                txtGiaTenSP.ForeColor = Color.Black;
            }
        }

        private void txtGiaTenSP_Leave(object sender, EventArgs e)
        {
            if (txtGiaTenSP.Text == "")
            {
                txtGiaTenSP.Text = "Nhập tên sản phẩm";
                txtGiaTenSP.ForeColor = Color.Silver;
            }
        }




        private void btnXoaSP_MouseEnter(object sender, EventArgs e)
        {
            btnXoaSP.BackColor = Color.Red;
            btnXoaSP.ForeColor = Color.White;
        }

        private void btnXoaSP_MouseLeave(object sender, EventArgs e)
        {
            btnXoaSP.BackColor = SystemColors.Control;
            btnXoaSP.ForeColor = Color.Black;
        }

        

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang nhapHang = new frmNhapHang();
            nhapHang.Show();

            btnSuaSP.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoaSP.Enabled = false;
            btnNhapHang.Enabled = false;

            nhapHang.FormClosed += Fix_FormClosed;
        }

        private void Fix_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnSuaSP.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoaSP.Enabled = true;
            btnNhapHang.Enabled = true;

        }

        private void tbtnThongTinNhanh_CheckedChanged(object sender, EventArgs e)
        {
            if (tbtnThongTinNhanh.Checked == true)
            {
                groThongTinNhanh.Visible = true;
            }
            else
            {
                groThongTinNhanh.Visible = false;
            }
        }

        private void btnTraGop_Click(object sender, EventArgs e)
        {
            frmTraGop traGop = new frmTraGop();
            traGop.ShowDialog();
        }

        private void SetControlsEnabled(RadioButton selectedRadioButton)
        {
            txtTenKH_KH.Enabled = false;
            txtSDT_KH.Enabled = false;
            txtMaKH_KH.Enabled = false;
            txtDiaChi_KH.Enabled = false;

            if (selectedRadioButton == rdoTenKH_KH)
                txtTenKH_KH.Enabled = true;
            else if (selectedRadioButton == rdoSDT_KH)
                txtSDT_KH.Enabled = true;
            else if (selectedRadioButton == rdoMaKH_KH)
                txtMaKH_KH.Enabled = true;
            else if (selectedRadioButton == rdoDiaChi_KH)
                txtDiaChi_KH.Enabled = true;
        }

        private void rdoTenKH_KH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTenKH_KH.Checked)
            {
                SetControlsEnabled(rdoTenKH_KH);
            }
                
        }
        private void rdoSDT_KH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSDT_KH.Checked)
            {
                SetControlsEnabled(rdoSDT_KH);
            }
                
        }
        private void rdoMaKH_KH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMaKH_KH.Checked)
            {
                SetControlsEnabled(rdoMaKH_KH);
            }
                
        }
        private void rdoDiaChi_KH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDiaChi_KH.Checked)
            {
                SetControlsEnabled(rdoDiaChi_KH);
            }
                
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang themLH = new frmThemLoaiHang();
            themLH.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemMatHangMoi themMHmoi = new frmThemMatHangMoi();
            themMHmoi.Show();
        }

        private void loạiHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiHang QLLH = new frmQuanLyLoaiHang();
            QLLH.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhapHang QLNH = new frmQuanLyNhapHang();
            QLNH.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyXuatHang QLXH = new frmQuanLyXuatHang();
            QLXH.Show();
        }

        private void btnReset_KH_Click(object sender, EventArgs e)
        {
            rdoTenKH_KH.Checked = false;
            rdoMaKH_KH.Checked = false;
            rdoSDT_KH.Checked = false;
            rdoDiaChi_KH.Checked = false;

            txtTenKH_KH.Enabled = true;
            txtMaKH_KH.Enabled = true;
            txtSDT_KH.Enabled = true;
            txtDiaChi_KH.Enabled = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TruyCapDuLieu.ghiFile("tst.dat");
        }

        private void dgvHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị từ các cột trong dòng được chọn
            var maCellValue = dgvHang.Rows[e.RowIndex].Cells["colMaSP"].Value;
            var tenCellValue = dgvHang.Rows[e.RowIndex].Cells["colTenSP"].Value;
            var loaiCellValue = dgvHang.Rows[e.RowIndex].Cells["colLoaiHang"].Value;
            var hangCellValue = dgvHang.Rows[e.RowIndex].Cells["colHang"].Value;
            var tsktCellValue = dgvHang.Rows[e.RowIndex].Cells["colTSKT"].Value;
            var soLuongCellValue = dgvHang.Rows[e.RowIndex].Cells["colSL"].Value;
            var giaNhapCellValue = dgvHang.Rows[e.RowIndex].Cells["colGiaNhap"].Value;
            var giaBanCellValue = dgvHang.Rows[e.RowIndex].Cells["colGiaBan"].Value;

            // Kiểm tra nếu giá trị không phải null trước khi gán
            maSP_khoHang = maCellValue != null ? maCellValue.ToString() : string.Empty;
            tenSP_khoHang = tenCellValue != null ? tenCellValue.ToString() : string.Empty;
            loaiHang_khoHang = loaiCellValue != null ? loaiCellValue.ToString() : string.Empty;
            hang_khoHang = hangCellValue != null ? hangCellValue.ToString() : string.Empty;
            tskt_khoHang = tsktCellValue != null ? tsktCellValue.ToString() : string.Empty;
            soLuong_khoHang = soLuongCellValue != null ? Convert.ToInt32(soLuongCellValue.ToString()) : 0;
            giaNhap_khoHang = giaNhapCellValue != null ? Convert.ToDouble(giaNhapCellValue.ToString()) : 0;
            giaBan_khoHang = giaBanCellValue != null ? Convert.ToDouble(giaBanCellValue.ToString()) : 0;
        }

        private void btnTim_KhoHang_Click(object sender, EventArgs e)
        {
            List<SanPham> locTheoTenSP = new List<SanPham>();
            if (string.IsNullOrEmpty(txtTimMaSP.Text)){
                locTheoTenSP = quanLySP.getDSSanPham();
            }
            else
            {
                locTheoTenSP = SearchTheoTen(txtTimMaSP.Text);
            }
            List<SanPham> theoGia = locTheoGia(locTheoTenSP);
            hienThi(theoGia);

        }
        private void btnReset_KhoHang_Click(object sender, EventArgs e)
        {
            txtTimMaSP.Text = "Nhập tên sản phẩm";
            txtTimMaSP.ForeColor = Color.Silver;

            cboTimGiaSP.Text = cboTimGiaSP.Items[0].ToString();

            hienThi(quanLySP.getDSSanPham());
        }

        private List<SanPham> locTheoGia(List<SanPham> ds)
        {
            List<SanPham> temp = new List<SanPham>();

            string khoangGia = cboTimGiaSP.Text;


            switch (khoangGia)
            {
                case "All":
                    temp = ds;
                    break;
                case "0k - 500k":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 0 && sp.GiaBan <= 500000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "500k - 1tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 500000 && sp.GiaBan <= 1000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "1tr - 5tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 1000000 && sp.GiaBan <= 5000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "5tr - 10tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 5000000 && sp.GiaBan <= 10000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "10tr - 20tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 10000000 && sp.GiaBan <= 20000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "20tr - 50tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 20000000 && sp.GiaBan <= 50000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "50tr - 100tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan >= 50000000 && sp.GiaBan <= 100000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                case "> 100tr":
                    foreach (SanPham sp in ds)
                    {
                        if (sp.GiaBan > 100000000)
                        {
                            temp.Add(sp);
                        }
                    }
                    break;
                default:
                    temp = ds;
                    break;
            }

            return temp;
        }



        // Loại hàng
        private void capNhatLuaChonCbo()
        {

        }

        private void rdoTimGia_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
