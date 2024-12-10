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

    public partial class frmQuanLyLoaiHang : Form
    {
        QuanLyLoaiHang quanLyLH;
        BindingSource dts = new BindingSource();

        private string ma = "";
        private string ten = "";

        public frmQuanLyLoaiHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyLoaiHang_Load(object sender, EventArgs e)
        {
            quanLyLH = new QuanLyLoaiHang();
            dts.DataSource = quanLyLH.getDSLoaiHang();
            dgvLH.DataSource = dts;

            CapNhatGoiY();
            hienThi();
        }

        private void hienThi()
        {
            dts.ResetBindings(false);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenTimKiem = txtTenLH.Text.Trim(); // Giả sử bạn có một TextBox tên txtTimKiem

            if (string.IsNullOrEmpty(tenTimKiem))
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc danh sách theo tên
            var ketQua = quanLyLH.getDSLoaiHang()
                .Where(lh => lh.TenLoaiHang.ToLower().Contains(tenTimKiem.ToLower()))
                .ToList();


            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị kết quả vào DataGridView
            dts.DataSource = ketQua;
            hienThi();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dts.DataSource = quanLyLH.getDSLoaiHang(); // Gán danh sách ban đầu
            hienThi();
        }

        private void CapNhatGoiY()
        {
            txtTenLH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenLH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            foreach (LoaiHang n in quanLyLH.getDSLoaiHang())
            {
                col.Add(n.TenLoaiHang);
            }

            txtTenLH.AutoCompleteCustomSource = col;

        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            using (frmThemLoaiHang form = new frmThemLoaiHang())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string maLoaiHang = form.MaLoaiHang;
                    string tenLoaiHang = form.TenLoaiHang;

                    LoaiHang temp = new LoaiHang(maLoaiHang, tenLoaiHang);

                    if (!quanLyLH.themLoaiHang(temp))
                    {
                        MessageBox.Show("Bị trùng mã loại hàng");
                        return;
                    }
                    //TruyCapDuLieu.ghiFile("tst.dat");
                }
                hienThi();
                CapNhatGoiY();
            }
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Không có thông tin để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                LoaiHang a = new LoaiHang(ma, ten);
                using (frmSuaLoaiHang suaLH = new frmSuaLoaiHang(ma, ten))
                {
                    if (suaLH.ShowDialog() == DialogResult.OK)
                    {
                        string maLoaiHang = suaLH.MaLoaiHang;
                        string tenLoaiHang = suaLH.TenLoaiHang;

                        LoaiHang temp = new LoaiHang(maLoaiHang, tenLoaiHang);

                        if (!quanLyLH.suaLoaiHang(a, temp))
                        {
                            return;
                        }
                        //TruyCapDuLieu.ghiFile("tst.dat");
                    }
                    hienThi();
                    CapNhatGoiY();
                }
            }
            
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ma))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!quanLyLH.xoaLoaiHang(ma))
                    {
                        MessageBox.Show("Xóa không được", "Thông báo");
                    }
                }
            }
            hienThi();
            CapNhatGoiY();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile("tst.dat");
            this.Close();
        }

        private void dgvLH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var maCellValue = dgvLH.Rows[e.RowIndex].Cells["Column1"].Value;
            var tenCellValue = dgvLH.Rows[e.RowIndex].Cells["Column2"].Value;


            // Kiểm tra nếu giá trị không phải null trước khi gán
            ma = maCellValue != null ? maCellValue.ToString() : string.Empty;
            ten = tenCellValue != null ? tenCellValue.ToString() : string.Empty;
        }

        private void frmQuanLyLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            TruyCapDuLieu.ghiFile("tst.dat");
        }
    }
}
