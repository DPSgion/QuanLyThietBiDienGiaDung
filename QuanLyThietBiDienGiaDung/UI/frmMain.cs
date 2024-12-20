using QuanLyThietBiDienGiaDung.Script;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThietBiDienGiaDung
{
    public partial class frmMain : Form
    {
        private QuanLyLoaiHang quanLyLoaiHang;

        QuanLySanPham quanLySP;
        
        BindingSource bdKhoHang = new BindingSource();
        BindingSource bdThongTinNhanh = new BindingSource();


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

            quanLyLoaiHang = new QuanLyLoaiHang();
            quanLySP = new QuanLySanPham();

            bdKhoHang.DataSource = quanLySP.getDSSanPham();
            dgvHang.DataSource = bdKhoHang;

            CapNhatGoiY_TxtTimTenSP();
            capNhatGoiY_TxtGiaMaSP();
            capNhatLuaChonLoaiHangCbo();
            capNhatGoiY_TxtTenSP_ThongTinNhanh();

            cboLoaiHang.Text = cboLoaiHang.Items[0].ToString();
            cboTimGiaSP.Text = cboTimGiaSP.Items[0].ToString();

            hienThi(quanLySP.getDSSanPham());
            hienThiThongTinNhanh(quanLySP.getDSSanPham());

            QuanLyNhapHang qlNH = new QuanLyNhapHang();
        }
        private void hienThi(List<SanPham> ds)
        {
            bdKhoHang.DataSource = ds;

            dgvHang.DataSource = bdKhoHang;

            hienThiThongTinNhanh(ds);

            bdKhoHang.ResetBindings(false);

        }
        private void hienThiThongTinNhanh(List<SanPham> ds)
        {
            bdThongTinNhanh.DataSource = ds;

            dgvThongTinNhanh.DataSource = bdThongTinNhanh;

            bdThongTinNhanh.ResetBindings(false);
        }


        #region Sắp xếp kho hàng
        private void dgvHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<SanPham> dsDaLoc = timKiemKhoHang();

            if (dgvHang.Columns[e.ColumnIndex].Name == "colMaSP")
            {
                List<SanPham> temp = sapXepMaSP(dsDaLoc);
                hienThi(temp);
            }
            else if (dgvHang.Columns[e.ColumnIndex].Name == "colTenSP")
            {
                List<SanPham> temp = sapXepTenSP(dsDaLoc);
                hienThi(temp);
            }
            else if (dgvHang.Columns[e.ColumnIndex].Name == "colSL")
            {
                List<SanPham> temp = sapXepSL(dsDaLoc);
                hienThi(temp);
            }
            else if (dgvHang.Columns[e.ColumnIndex].Name == "colGiaNhap")
            {
                List<SanPham> temp = sapXepGiaNhap(dsDaLoc);
                hienThi(temp);
            }
            else if (dgvHang.Columns[e.ColumnIndex].Name == "colGiaBan")
            {
                List<SanPham> temp = sapXepGiaBan(dsDaLoc);
                hienThi(temp);
            }

        }
        
        #region Sắp xếp: Press Header MaSP
        private bool statusMaSP = true; // True = tăng dần, False = giảm dần
        private List<SanPham> sapXepMaSP(List<SanPham> dsSanPham)
        {
            if (statusMaSP)
            {
                // Sắp xếp theo giá bán tăng dần
                var sortedList = dsSanPham.OrderBy(sp => sp.MaSP).ToList();
                statusMaSP = false;
                return sortedList;
            }
            else
            {
                // Sắp xếp theo giá bán giảm dần
                var sortedList = dsSanPham.OrderByDescending(sp => sp.MaSP).ToList();
                statusMaSP = true;
                return sortedList;
            }
        }
        #endregion
        #region Sắp xếp: Press Header TenSP
        private bool statusTenSP = true; // True = tăng dần, False = giảm dần
        private List<SanPham> sapXepTenSP(List<SanPham> dsSanPham)
        {
            if (statusTenSP)
            {
                // Sắp xếp theo giá bán tăng dần
                var sortedList = dsSanPham.OrderBy(sp => sp.TenSP).ToList();
                statusTenSP = false;
                return sortedList;
            }
            else
            {
                // Sắp xếp theo giá bán giảm dần
                var sortedList = dsSanPham.OrderByDescending(sp => sp.TenSP).ToList();
                statusTenSP = true;
                return sortedList;
            }
        }
        #endregion
        #region Sắp xếp: Press Header SL
        private bool statusSL = true; // True = tăng dần, False = giảm dần
        private List<SanPham> sapXepSL(List<SanPham> dsSanPham)
        {
            if (statusSL)
            {
                // Sắp xếp theo giá bán tăng dần
                var sortedList = dsSanPham.OrderBy(sp => sp.SoLuong).ToList();
                statusSL = false;
                return sortedList;
            }
            else
            {
                // Sắp xếp theo giá bán giảm dần
                var sortedList = dsSanPham.OrderByDescending(sp => sp.SoLuong).ToList();
                statusSL = true;
                return sortedList;
            }
        }
        #endregion
        #region Sắp xếp: Press Header Gia Nhap
        private bool statusGiaNhap = true; // True = tăng dần, False = giảm dần
        private List<SanPham> sapXepGiaNhap(List<SanPham> dsSanPham)
        {
            if (statusGiaNhap)
            {
                // Sắp xếp theo giá bán tăng dần
                var sortedList = dsSanPham.OrderBy(sp => sp.GiaNhap).ToList();
                statusGiaNhap = false;
                return sortedList;
            }
            else
            {
                // Sắp xếp theo giá bán giảm dần
                var sortedList = dsSanPham.OrderByDescending(sp => sp.GiaNhap).ToList();
                statusGiaNhap = true;
                return sortedList;
            }
        }
        #endregion
        #region Sắp xếp: Press Header Gia Ban
        private bool statusGiaBan = true; // True = tăng dần, False = giảm dần
        private List<SanPham> sapXepGiaBan(List<SanPham> dsSanPham)
        {
            if (statusGiaBan)
            {
                // Sắp xếp theo giá bán tăng dần
                var sortedList = dsSanPham.OrderBy(sp => sp.GiaBan).ToList();
                statusGiaBan = false; 
                return sortedList;
            }
            else
            {
                // Sắp xếp theo giá bán giảm dần
                var sortedList = dsSanPham.OrderByDescending(sp => sp.GiaBan).ToList();
                statusGiaBan = true; 
                return sortedList;
            }
        }
        #endregion
        #endregion

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
                CapNhatGoiY_TxtTimTenSP();
                capNhatGoiY_TxtGiaMaSP();
                capNhatGoiY_TxtTenSP_ThongTinNhanh();
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
                CapNhatGoiY_TxtTimTenSP();
                capNhatGoiY_TxtGiaMaSP();
                capNhatGoiY_TxtTenSP_ThongTinNhanh();
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

                    CapNhatGoiY_TxtTimTenSP();
                    capNhatGoiY_TxtGiaMaSP();
                    capNhatGoiY_TxtTenSP_ThongTinNhanh();
                    hienThi(quanLySP.getDSSanPham());
                }
            }

        }

        private void CapNhatGoiY_TxtTimTenSP()
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
            frmNhapHang nhapHang = new frmNhapHang(maSP_khoHang);
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

            hienThi(quanLySP.getDSSanPham());
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

            if (selectedRadioButton == rdoTenKH_KH)
                txtTenKH_KH.Enabled = true;
            else if (selectedRadioButton == rdoSDT_KH)
                txtSDT_KH.Enabled = true;
            else if (selectedRadioButton == rdoMaKH_KH)
                txtMaKH_KH.Enabled = true;
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

        #region Loại hàng
        private void loạiHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiHang QLLH = new frmQuanLyLoaiHang();
            QLLH.FormClosed += frmLH_FormClosed;
            QLLH.Show();
        }
        private void frmLH_FormClosed(object sender, FormClosedEventArgs e)
        {
            capNhatLuaChonLoaiHangCbo();
        }
        #endregion

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

            txtTenKH_KH.Enabled = true;
            txtMaKH_KH.Enabled = true;
            txtSDT_KH.Enabled = true;
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


            txtGiaMaSP.Text = maSP_khoHang;
            txtGiaTenSP.Text = tenSP_khoHang;
            txtGiaMoi.Text = giaBan_khoHang.ToString();
        
        }

        #region Tìm kiếm sản phẩm trong kho hàng
        private void btnTim_KhoHang_Click(object sender, EventArgs e)
        {
            List<SanPham> temp = timKiemKhoHang();

            hienThi(temp);

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
        private List<SanPham> locTheoLoaiHang(List<SanPham> ds)
        {
            List<SanPham> loc = new List<SanPham>();

            string loaiHang = cboLoaiHang.Text;

            if (loaiHang == "All")
            {
                return ds;
            }
            else
            {
                foreach (SanPham x in ds)
                {
                    if (x.LoaiHang == loaiHang)
                    {
                        loc.Add(x);
                    }
                }
            }
            return loc;

        }
        private List<SanPham> timKiemKhoHang()
        {
            List<SanPham> loc = new List<SanPham>();
            if (txtTimMaSP.Text == "Nhập tên sản phẩm")
            {
                loc = quanLySP.getDSSanPham();
            }
            else
            {
                loc = SearchTheoTen(txtTimMaSP.Text);
            }
            loc = locTheoLoaiHang(loc);
            loc = locTheoGia(loc);

            return loc;
        }

        private void txtTimMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu phím Enter được nhấn
            {
                btnTim_KhoHang_Click(sender, e);
            }
        }
        private void cboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTim_KhoHang_Click(sender, e);
        }
        private void cboTimGiaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTim_KhoHang_Click(sender, e);
        }
        #endregion

        #region Cập nhật giá (Kho hàng)
        private void txtGiaMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGiaTenSP.Text = timTenSPQuaMaSP(txtGiaMaSP.Text);
            }
        }
        private string timTenSPQuaMaSP(string maSP)
        {
            string temp = "";
            foreach (SanPham x in quanLySP.getDSSanPham())
            {
                if (x.MaSP == maSP.ToUpper())
                {
                    temp = x.TenSP;
                    break;
                }
            }
            return temp;
        }
        private void capNhatGoiY_TxtGiaMaSP()
        {
            txtGiaMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGiaMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (SanPham n in quanLySP.getDSSanPham())
            {
                col.Add(n.MaSP);
            }

            txtGiaMaSP.AutoCompleteCustomSource = col;
        }
        private bool isNumber(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number >= 0; // Trả về true nếu là số dương
            }

            if (double.TryParse(input, out double doubleNumber))
            {
                return doubleNumber >= 0; // Trả về true nếu là số dương
            }

            // Nếu không phải số, trả về false
            return false;
        }
        private void txtGiaMaSP_Leave(object sender, EventArgs e)
        {
            txtGiaMaSP.Text = txtGiaMaSP.Text.ToUpper();
            txtGiaTenSP.Text = timTenSPQuaMaSP(txtGiaMaSP.Text);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGiaMoi.Text))
            {

                if (isNumber(txtGiaMoi.Text))
                {
                    double giaMoi = Convert.ToDouble(txtGiaMoi.Text);
                    if (!quanLySP.suaGiaSanPham(txtGiaMaSP.Text.ToUpper(), giaMoi))
                    {
                        MessageBox.Show("Không sửa được. Có thể là do sai mã sản phẩm." + '\n'
                            + "Hãy kiểm tra lại",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtGiaMaSP.Text = "";
                    txtGiaTenSP.Text = "";
                    txtGiaMoi.Text = "";


                    hienThi(quanLySP.getDSSanPham());
                }
                else
                {
                    MessageBox.Show("Giá bán mới phải là số dương và không được là kí tự",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Giá bán mới không được để trống",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void capNhatLuaChonLoaiHangCbo()
        {
            foreach (LoaiHang n in quanLyLoaiHang.getDSLoaiHang())
            {
                cboLoaiHang.Items.Insert(cboLoaiHang.Items.Count, n.TenLoaiHang);
            }
        }
        private void btnReset_KhoHang_Click(object sender, EventArgs e)
        {
            txtTimMaSP.Text = "Nhập tên sản phẩm";
            txtTimMaSP.ForeColor = Color.Silver;

            cboTimGiaSP.Text = cboTimGiaSP.Items[0].ToString();
            cboLoaiHang.Text = cboLoaiHang.Items[0].ToString();

            hienThi(quanLySP.getDSSanPham());
        }

        private void txtTenSP_TTN_TextChanged(object sender, EventArgs e)
        {
            hienThiThongTinNhanh(SearchTheoTen(txtTenSP_TTN.Text));
        }
        private void capNhatGoiY_TxtTenSP_ThongTinNhanh()
        {
            txtTenSP_TTN.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenSP_TTN.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (SanPham n in quanLySP.getDSSanPham())
            {
                col.Add(n.TenSP);
            }

            txtTenSP_TTN.AutoCompleteCustomSource = col;
        }
    }
}
