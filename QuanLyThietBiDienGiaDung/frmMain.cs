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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            runTest();
        }
        private void runTest()
        {
            dgvHang.Rows[0].Cells[0].Value = "ML001";
            dgvHang.Rows[0].Cells[1].Value = "Máy lạnh 2HP";
            dgvHang.Rows[0].Cells[2].Value = "Toshiba";
            dgvHang.Rows[0].Cells[3].Value = "NCC008";
            dgvHang.Rows[0].Cells[4].Value = "- Test thử thôi\n" + "- Đang thành công\n" +
                "- Làm lạnh với công suất 900W, có thể làm lạnh 1 cây kem với thời gian 10 phút";
            dgvHang.Rows[0].Cells[5].Value = "5 năm";
            dgvHang.Rows[0].Cells[6].Value = "235";
            dgvHang.Rows[0].Cells[7].Value = "17.000.000";
        }


        private void cboTimMaSP_Enter(object sender, EventArgs e)
        {
            if (cboTimMaSP.Text == "Nhập tên sản phẩm")
            {
                cboTimMaSP.Text = "";
                cboTimMaSP.ForeColor = Color.Black;
            }
        }

        private void cboTimMaSP_Leave(object sender, EventArgs e)
        {
            if (cboTimMaSP.Text == "")
            {
                cboTimMaSP.Text = "Nhập tên sản phẩm";
                cboTimMaSP.ForeColor = Color.Silver;
            }
        }

        private void cboSuaGiaSP_Enter(object sender, EventArgs e)
        {
            if (cboSuaGiaSP.Text == "Nhập tên sản phẩm")
            {
                cboSuaGiaSP.Text = "";
                cboSuaGiaSP.ForeColor = Color.Black;
            }
        }

        private void cboSuaGiaSP_Leave(object sender, EventArgs e)
        {
            if (cboSuaGiaSP.Text == "")
            {
                cboSuaGiaSP.Text = "Nhập tên sản phẩm";
                cboSuaGiaSP.ForeColor = Color.Silver;
            }
        }


        private void rdoTimTenSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTimTenSP.Checked == true)
            {
                cboTimMaSP.Enabled = true;
                cboTimGiaSP.ResetText();
            }
            else
            {
                cboTimMaSP.Enabled = false;
            }
        }

        private void rdoTimGia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTimGia.Checked == true)
            {
                cboTimGiaSP.Enabled = true;
                cboTimMaSP.Text = "Nhập tên sản phẩm";
            }
            else
            {
                cboTimGiaSP.Enabled = false;
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

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            //string temp = dgvHang.Rows[0].Cells[0].Value.ToString();
            //frmSuaSanPham fixSP = new frmSuaSanPham(temp);

            frmSuaSanPham fixSP = new frmSuaSanPham();

            fixSP.Show();

            btnSuaSP.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoaSP.Enabled = false;

            fixSP.FormClosed += Fix_FormClosed;
        }

        private void Fix_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnSuaSP.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoaSP.Enabled = true;

        }

        
    }
}
