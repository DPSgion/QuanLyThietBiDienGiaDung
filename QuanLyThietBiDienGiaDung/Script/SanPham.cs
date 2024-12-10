using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class SanPham
    {
        // Attribute
        private string _maSP;
        private string _tenSP;
        private string _loaiHang;
        private string _hangSX;
        private string _tskt;
        private string _soLuong;
        private string _giaNhap;
        private string _giaBan;

        // Properties
        public string MaSP { get => _maSP; set => _maSP = value; }
        public string TenSP { get => _tenSP; set => _tenSP = value; }
        public string LoaiHang { get => _loaiHang; set => _loaiHang = value; }
        public string Hang { get => _hangSX; set => _hangSX = value; }
        public string Tskt { get => _tskt; set => _tskt = value; }
        public string SoLuong { get => _soLuong; set => _soLuong = value; }
        public string GiaNhap { get => _giaNhap; set => _giaNhap = value; }
        public string GiaBan { get => _giaBan; set => _giaBan = value; }

        // Constructor
        public SanPham()
        {
            _maSP = "";
            _tenSP = "";
            _loaiHang = "";
            _hangSX = "";
            _tskt = "";
            _soLuong = "";
            _giaNhap = "";
            _giaBan = "";
        }
        public SanPham(string ma, string ten, string loaiHang, 
            string hangsx, string tskt, string soluong, string giaNhap, string giaBan)
        {
            _maSP = ma;
            _tenSP = ten;
            _loaiHang = loaiHang;
            _hangSX = hangsx;
            _tskt = tskt;
            _soLuong = soluong;
            _giaNhap = giaNhap;
            _giaBan = giaBan;
        }



    }
}
