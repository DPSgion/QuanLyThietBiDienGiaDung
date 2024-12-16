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
        private SanPham tim(string sp)
        {
            foreach (SanPham i in _dsSanPham)
            {
                if (sp == i.MaSP)
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

        public bool suaSanPham(SanPham a, SanPham b)
        {
            SanPham temp = tim(a.MaSP);
            if (temp != null)
            {
                temp.MaSP = b.MaSP;
                temp.TenSP = b.TenSP;
                temp.LoaiHang = b.LoaiHang;
                temp.Hang = b.Hang;
                temp.SoLuong = b.SoLuong;
                temp.Tskt = b.Tskt;
                temp.GiaNhap = b.GiaNhap;
                temp.GiaBan = b.GiaBan;

                return true;
            }
            return false;
        }
        public bool suaGiaSanPham(string maGoc, double giaBanMoi)
        {
            SanPham temp = tim(maGoc);
            if (temp != null)
            {
                temp.GiaBan = giaBanMoi;
                return true;
            }

            return false;
        }


        private bool checkTrungMaSP(string maSP)
        {
            foreach (SanPham i in _dsSanPham)
            {
                if (maSP == i.MaSP)
                {
                    return true;
                }
            }
            return false;

        }

        public bool xoaSanPham(string ma)
        {
            SanPham temp = tim(ma);
            if (temp != null)
            {
                _dsSanPham.Remove(temp);
                return true;
            }
            return false;
        }

         
    }
}
