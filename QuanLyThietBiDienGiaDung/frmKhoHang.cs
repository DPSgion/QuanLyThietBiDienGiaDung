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
    public partial class frmKhoHang : Form
    {
        public frmKhoHang()
        {
            InitializeComponent();

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
    }
}
