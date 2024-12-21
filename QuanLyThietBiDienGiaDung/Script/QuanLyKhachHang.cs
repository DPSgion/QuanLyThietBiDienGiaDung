using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class QuanLyKhachHang
    {

        private List<KhachHang> _dsKhachHang;

        public List<KhachHang> getDSKhachHang()
        {
            return _dsKhachHang;
        }
        public QuanLyKhachHang()
        {
            //TruyCapDuLieu duLieu = TruyCapDuLieu.khoiTao();
            //_dsKhachHang = duLieu.getDSKhachHang();

            _dsKhachHang = new List<KhachHang>();
        }

        private bool tim(KhachHang kh) // True => tìm thấy, False => ko tìm thấy
        {
            foreach (KhachHang x in _dsKhachHang)
            {
                if (kh.MaKhachHang == x.MaKhachHang)
                {
                    return true;
                }
            }
            return false;
        }
        private KhachHang tim(string maKhachHang)
        {
            foreach (KhachHang x in _dsKhachHang)
            {
                if (x.MaKhachHang == maKhachHang)
                {
                    return x;
                }
            }
            return null;
        }

        public bool themKhachHang(KhachHang kh)
        {
            if (!tim(kh))
            {
                _dsKhachHang.Add(kh);
                return true;
            }
            return false;
        }
        public bool suaKhachHang(KhachHang duLieuCu, KhachHang duLieuMoi)
        {
            KhachHang temp = tim(duLieuCu.MaKhachHang);
            if (temp != null)
            {
                temp.SdtKhachHang = duLieuMoi.SdtKhachHang;
                temp.TenKhachHang = duLieuMoi.TenKhachHang;
                temp.DiaChiKhachHang = duLieuMoi.DiaChiKhachHang;

                return true;
            }
            return false;
        }
        public bool xoaKhachHang(string maKhachHang)
        {
            KhachHang temp = tim(maKhachHang);
            if (temp != null)
            {
                _dsKhachHang.Remove(temp);
                return true;
            }
            return false;
        }

    }
}
