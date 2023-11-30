using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;

namespace QuanLyKhachSan.DAO
{
    public class KhachHang_PhongDAO
    {
        private static KhachHang_PhongDAO instance;

        public static KhachHang_PhongDAO Instance
        {
            get { if (instance == null) instance = new KhachHang_PhongDAO(); return instance; }
            private set { instance = value; }
        }
        public int ThemKhachHang_Phong(String CMND, String SoPhong, String NgayDen)
        {
            return DataProvider.Instance.ExecuteNonQuery("insert into KhachHang_Phong values('" + CMND + "', '" + SoPhong + "', '" + NgayDen + "');");
        }

        public DataTable getListKhachHang_Phong()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang_Phong");
            return table;
        }
    }
}
