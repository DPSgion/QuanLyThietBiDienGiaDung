using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class QuanLyLoaiHang
    {
        // Attribute
        private List<LoaiHang> _dsLoaiHang;

        // Properties
        public List<LoaiHang> getDSLoaiHang()
        {
            return _dsLoaiHang;
        }

        // Constructor
        public QuanLyLoaiHang()
        {
            TruyCapDuLieu.docFile("tst.dat");
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoiTao();
            _dsLoaiHang = duLieu.getDSLoaiHang();
        }

        // Methods

        

        private bool tim(LoaiHang lh)
        {
            foreach (LoaiHang i in _dsLoaiHang)
            {
                if (lh.MaLoaiHang == i.MaLoaiHang)
                {
                    return true;
                }
            }
            return false;
        }
        private LoaiHang tim(string lh)
        {
            foreach (LoaiHang i in _dsLoaiHang)
            {
                if (lh == i.MaLoaiHang)
                {
                    return i;
                }
            }
            return null;
        }

        public bool themLoaiHang(LoaiHang a)
        {
            if (!tim(a))
            {
                _dsLoaiHang.Add(a);
                TruyCapDuLieu.ghiFile("tst.dat");
                return true;
            }
            return false;
        }

        public bool suaLoaiHang(LoaiHang a, LoaiHang b)
        {
            LoaiHang temp = tim(a.MaLoaiHang);
            if (temp != null)
            {
                temp.MaLoaiHang = b.MaLoaiHang;
                temp.TenLoaiHang = b.TenLoaiHang;
                return true;
            }
            return false;
        }

        public bool xoaLoaiHang(string maLH)
        {
            LoaiHang temp = tim(maLH);
            if (temp != null)
            {
                _dsLoaiHang.Remove(temp);
                return true;
            }
            return false;
        }

    }
}
