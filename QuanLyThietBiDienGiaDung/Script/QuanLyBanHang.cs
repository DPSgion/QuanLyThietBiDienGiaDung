using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class QuanLyBanHang
    {
        private List<BanHang> _dsBanHang;

        public List<BanHang> getDSBanHang()
        {
            return _dsBanHang;
        }

        public QuanLyBanHang()
        {
            //TruyCapDuLieu duLieu = TruyCapDuLieu.khoiTao();
            //_dsBanHang = duLieu.getDSBanHang();

            _dsBanHang = new List<BanHang>();
        }

        private bool tim(BanHang bh) // True => tìm thấy, False => ko tìm thấy
        {
            foreach (BanHang x in _dsBanHang)
            {
                if (x.MaBanHang == bh.MaBanHang)
                {
                    return true;
                }
            }
            return false;
        }
        private BanHang tim(string maBH)
        {
            foreach (BanHang x in _dsBanHang)
            {
                if (x.MaBanHang == maBH)
                {
                    return x;
                }
            }
            return null;
        }

        public bool themBanHang(BanHang bh)
        {
            if (!tim(bh)) // Nếu chưa có mã bán hàng thì được thêm 
            {
                _dsBanHang.Add(bh);
                return true;
            }
            return false;
        }

        public string maBanHangLonNhat()
        {
            List<BanHang> temp = new List<BanHang>();
            foreach (BanHang x in _dsBanHang)
            {
                if (x.MaBanHang.Substring(0, 2) == "BH")
                {
                    temp.Add(x);
                }
            }

            if (temp == null || !temp.Any())
            {
                return "";
            }

            return temp
                .OrderByDescending(phieu => int.Parse(phieu.MaBanHang.Substring(2)))
                .First().MaBanHang;
        }
    }
}
