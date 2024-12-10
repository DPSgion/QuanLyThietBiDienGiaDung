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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThietBiDienGiaDung
{
    public partial class frmSuaSanPham : Form
    {
        private QuanLyLoaiHang quanLyLH = new QuanLyLoaiHang();

        public string MaSP { get; private set; } 
        public string TenSP { get; private set; } 
        public string LoaiHang { get; private set; } 
        public string Hang { get; private set; }
        public string TSKT { get; private set; }
        public int SoLuong { get; private set; } 
        public double GiaNhap { get; private set; } 
        public double GiaBan { get; private set; } 

        public frmSuaSanPham()
        {
            InitializeComponent();
        }
        public frmSuaSanPham(string ma, string tensp, string loaihang, string hang,
             string tskt, int soluong,  double gianhap, double giaban)
        {
            InitializeComponent();
            
            txtMaSP.Text = ma;
            txtTenSP.Text = tensp;

            LoaiHang = loaihang;

            txtHang.Text = hang;
            txtSoLuong.Text = soluong.ToString();
            txtTSKT.Text = tskt;
            txtGiaNhap.Text = gianhap.ToString();
            txtGiaBan.Text = giaban.ToString();
            
        }
        private void frmSuaSanPham_Load(object sender, EventArgs e)
        {
            CapNhatGoiY();
        }

        private void cbLH(string lh)
        {
            int index = cboLoaiHang.FindStringExact(lh);
            if (index != -1) // Kiểm tra nếu tìm thấy
            {
                cboLoaiHang.SelectedIndex = index;
            }

        }

        private void CapNhatGoiY()
        {
            foreach (LoaiHang n in quanLyLH.getDSLoaiHang())
            {
                cboLoaiHang.Items.Insert(cboLoaiHang.Items.Count, n.TenLoaiHang);
            }
            cbLH(LoaiHang);
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

        private void btnSua_Click(object sender, EventArgs e)
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
                if (isNumber(txtSoLuong.Text) && isNumber(txtGiaNhap.Text) && isNumber(txtGiaBan.Text))
                {
                    MaSP = txtMaSP.Text;
                    TenSP = txtTenSP.Text;
                    LoaiHang = cboLoaiHang.Text;
                    Hang = txtHang.Text;
                    TSKT = txtTSKT.Text;
                    SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
                    GiaBan = Convert.ToDouble(txtGiaBan.Text);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Số lượng, giá nhập, giá bán phải là số dương", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
