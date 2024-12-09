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
    [Serializable]
    public partial class frmQuanLyLoaiHang : Form
    {
        QuanLyLoaiHang quanLyLH;

        public frmQuanLyLoaiHang()
        {
            InitializeComponent();

            
        }

        private void frmQuanLyLoaiHang_Load(object sender, EventArgs e)
        {
            quanLyLH = new QuanLyLoaiHang();
            hienThi();
        }


        private void hienThi()
        {
            dgvLH.DataSource = null;
            dgvLH.DataSource = quanLyLH.getDSLoaiHang();
            dgvLH.Refresh();
        }


        private void btnThemLH_Click(object sender, EventArgs e)
        {
            using (var form = new frmThemLoaiHang())
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
                    TruyCapDuLieu.ghiFile("tst.dat");
                }
                hienThi();
            }
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            frmSuaLoaiHang suaLH = new frmSuaLoaiHang();
            suaLH.ShowDialog();
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile("tst.dat");
            this.Close();
        }

        
    }
}
