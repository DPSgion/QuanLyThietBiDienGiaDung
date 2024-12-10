using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiDienGiaDung.Script
{
    [Serializable]
    class TruyCapDuLieu
    {
        private static TruyCapDuLieu instance = null;
        private List<LoaiHang> dsLoaiHang;
        private List<SanPham> dsSanPham;

        private TruyCapDuLieu()
        {
            dsLoaiHang = new List<LoaiHang>();
            dsSanPham = new List<SanPham>();
        }
        public static TruyCapDuLieu khoiTao()
        {
            if (instance == null)
            {
                instance = new TruyCapDuLieu();
            }
            return instance;
        }

        public List<LoaiHang> getDSLoaiHang()
        {
            return dsLoaiHang;
        }
        public List<SanPham> getDSSanPham()
        {
            return dsSanPham;
        }

        public static bool docFile(string tenfile)
        {
            try
            {
                FileStream fs = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                
                instance = (TruyCapDuLieu)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
                return false;
            }
        }

        public static bool ghiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, instance);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
