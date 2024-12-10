using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class QuanLySanPham
    {
        private List<SanPham> _dsSanPham;

        public List<SanPham> getDSSanPham()
        {
            return _dsSanPham;
        }

        public QuanLySanPham()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoiTao();
            _dsSanPham = duLieu.getDSSanPham();
        }

        private bool tim(SanPham sp)
        {
            foreach (SanPham i in _dsSanPham)
            {
                if (sp.MaSP == i.MaSP)
                {
                    return true;
                }
            }
            return false;
        }
        private SanPham tim(string lh)
        {
            foreach (SanPham i in _dsSanPham)
            {
                if (lh == i.MaSP)
                {
                    return i;
                }
            }
            return null;
        }

        public bool themSanPham(SanPham a)
        {
            if (!tim(a))
            {
                _dsSanPham.Add(a);
                return true;
            }
            return false;
        }
    }
}
