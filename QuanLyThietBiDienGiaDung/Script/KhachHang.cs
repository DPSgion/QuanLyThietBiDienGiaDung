using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class KhachHang
    {
        private string _maKhachHang;
        private string _tenKhachHang;
        private string _sdtKhachHang;
        private string _diaChiKhachHang;

        public string MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
        public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
        public string SdtKhachHang { get => _sdtKhachHang; set => _sdtKhachHang = value; }
        public string DiaChiKhachHang { get => _diaChiKhachHang; set => _diaChiKhachHang = value; }

        public KhachHang()
        {
            _maKhachHang = "";
            _tenKhachHang = "";
            _sdtKhachHang = "";
        }
        public KhachHang(string maKH, string tenKH, string sdtKH)
        {
            _maKhachHang = maKH;
            _tenKhachHang = tenKH;
            _sdtKhachHang = sdtKH;
        }


    
    }
}
