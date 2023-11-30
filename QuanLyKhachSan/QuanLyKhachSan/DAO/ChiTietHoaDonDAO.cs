using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDAO(); return instance; }
            private set { instance = value; }
        }

        private ChiTietHoaDonDAO()
        {

        }

        public DataTable LoadMaDVFromPhong(string sophong)
        {
            string query = "USP_GetMaDVFromPhong @sophong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { sophong });
            return data;
        }

        public bool InsertChiTietHoaDon(string mahoadon, string sophong, string madichvu, int soluong)
        {
            string query = string.Format("INSERT INTO ChiTietHoaDon VALUES ('{0}', '{1}', '{2}', {3})", mahoadon, sophong, madichvu, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
