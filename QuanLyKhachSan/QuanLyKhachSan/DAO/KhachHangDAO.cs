using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }

        private KhachHangDAO()
        {

        }

        public DataTable GetListMaKhachHang()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT CCCD FROM KHACHHANG");
            return table;
        }

        public int ThemKhachHang(String CMND, String TenNguoiDangKy, String SDT, String DiaChi)
        {
            return DataProvider.Instance.ExecuteNonQuery("insert into KhachHang values('" + CMND + "', N'" + TenNguoiDangKy + "', '" + SDT + "', N'" + DiaChi + "');");
        }
    }
}
