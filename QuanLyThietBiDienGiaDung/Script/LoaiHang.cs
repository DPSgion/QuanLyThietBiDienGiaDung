using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class LoaiHang
    {
        private string m_maLoaiHang;
        private string m_tenLoaiHang;

        public LoaiHang()
        {
            m_maLoaiHang = "";
            m_tenLoaiHang = "";
        }
        public LoaiHang(string ma, string ten)
        {
            m_maLoaiHang = ma;
            m_tenLoaiHang = ten;
        }

        public string MaLoaiHang { get => m_maLoaiHang; set => m_maLoaiHang = value; }
        public string TenLoaiHang { get => m_tenLoaiHang; set => m_tenLoaiHang = value; }
    
        
    
    }
}
