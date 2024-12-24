using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class PhieuNhapHang
    {
        // Attribute
        private string _maNhapHang;
        private List<SanPham> _dsSanPham;
        private DateTime _ngayNhapHang;
        private double _tongTienNhapHang;

        // Properties
        public string MaNhapHang { get => _maNhapHang; set => _maNhapHang = value; }
        public DateTime NgayNhapHang { get => _ngayNhapHang; set => _ngayNhapHang = value; }
        public double TongTienNhapHang { get => _tongTienNhapHang; set => _tongTienNhapHang = value; }
        public List<SanPham> DsSanPham { get => _dsSanPham; set => _dsSanPham = value; }
    
        // Constructor
        public PhieuNhapHang()
        {
            _maNhapHang = "";
            _dsSanPham = new List<SanPham>();
            _ngayNhapHang = DateTime.Now;
            _tongTienNhapHang = 0;
        }
        public PhieuNhapHang(string maNhap, List<SanPham> dsNhap, DateTime ngayNhap, double tongTienNhap)
        {
            _maNhapHang = maNhap;
            _dsSanPham = dsNhap;
            _ngayNhapHang = ngayNhap;
            _tongTienNhapHang = tongTienNhap;
        }
        
        // Methods
        public List<SanPham> getDSSanPhamNhapHang()
        {
            return _dsSanPham;
        }


    }
}
