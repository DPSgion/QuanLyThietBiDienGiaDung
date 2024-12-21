using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class BanHang
    {
        private string _maBanHang;
        private DateTime _ngayBanHang;
        private KhachHang _khachMua;
        private List<SanPham> _sanPhamBan;

        public string MaBanHang { get => _maBanHang; set => _maBanHang = value; }
        public DateTime NgayBanHang { get => _ngayBanHang; set => _ngayBanHang = value; }
        public KhachHang KhachMua { get => _khachMua; set => _khachMua = value; }
        public List<SanPham> SanPhamBan { get => _sanPhamBan; set => _sanPhamBan = value; }
    
        public BanHang()
        {
            _maBanHang = "";
            _ngayBanHang = DateTime.Now;
            _khachMua = new KhachHang();
            _sanPhamBan = new List<SanPham>();
        }
        public BanHang(string maBH, DateTime ngayBan, KhachHang khachMua, List<SanPham> spBan)
        {
            _maBanHang = maBH;
            _ngayBanHang = ngayBan;
            _khachMua = khachMua;
            _sanPhamBan = spBan;
        }
    }
}
