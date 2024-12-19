using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class QuanLyNhapHang
    {
        private List<PhieuNhapHang> _dsPhieuNhapHang;

        public List<PhieuNhapHang> getDSPhieuNhapHang()
        {
            return _dsPhieuNhapHang;

        }
        public QuanLyNhapHang()
        {
            
            _dsPhieuNhapHang = new List<PhieuNhapHang>();
            
            //TruyCapDuLieu duLieu = TruyCapDuLieu.khoiTao();
            //_dsPhieuNhapHang = duLieu.getDSNhapHang();
            
        }

        private bool tim(PhieuNhapHang phieu)
        {
            foreach (PhieuNhapHang i in _dsPhieuNhapHang)
            {
                if (phieu.MaNhapHang == i.MaNhapHang)
                {
                    return true;
                }
            }
            return false;
        }
        private PhieuNhapHang tim(string maNhap)
        {
            foreach (PhieuNhapHang i in _dsPhieuNhapHang)
            {
                if (maNhap == i.MaNhapHang)
                {
                    return i;
                }
            }
            return null;
        }

        public bool themPhieuNhap(PhieuNhapHang phieu)
        {
            if (tim(phieu))
            {
                _dsPhieuNhapHang.Add(phieu);
                return true;
            }
            return false;
        }

        public string maNhapHangLonNhat()
        {
            List<PhieuNhapHang> temp = new List<PhieuNhapHang>();
            foreach (PhieuNhapHang x in _dsPhieuNhapHang)
            {
                if (x.MaNhapHang.Substring(0,2) == "NH")
                {
                    temp.Add(x);
                }
            }

            if (temp == null || !temp.Any())
            {
                return "";
            }

            return temp
                .OrderByDescending(phieu => int.Parse(phieu.MaNhapHang.Substring(2)))
                .First().MaNhapHang;
        }
        public bool checkTrungMaNhapHang(string maNhapHang) // True => trùng, False => không trùng
        {
            PhieuNhapHang temp = tim(maNhapHang);
            if (temp != null)
            {
                return true;
            }
            return false;
        }
    }
}
