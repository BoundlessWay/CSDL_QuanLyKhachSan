using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }

        private HoaDonDAO()
        {

        }

        public bool InsertHoaDon(string mahoadon, string sophong, string mavoucher, string thoigian, int tongtien, int tiencanthanhtoan, string mabienban, string nvlt)
        {
            if(mavoucher == "")
            {
                string query = string.Format("INSERT INTO HOADON VALUES ('{0}', '{1}', {2}, '{3}', {4}, {5}, '{6}','{7}', {8})", mahoadon, sophong, "NULL", thoigian, tongtien, tiencanthanhtoan, mabienban, nvlt, "NULL");
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            else
            {
                string query = string.Format("INSERT INTO HOADON VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}','{7}', {8})", mahoadon, sophong, mavoucher, thoigian, tongtien, tiencanthanhtoan, mabienban, nvlt, "NULL");
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
        }

        public bool UpdateTinhTrangHoaDon(string mahoadon)
        {
            string query = "USP_UpdateStatusHoaDon @mahoadon";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahoadon });

            return result > 0;
        }
    }
}
