using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BienBanDAO
    {
        private static BienBanDAO instance;

        public static BienBanDAO Instance
        {
            get { if (instance == null) instance = new BienBanDAO(); return instance; }
            private set { instance = value; }
        }

        private BienBanDAO()
        {

        }

        public bool InsertBienBan(string mabienban, string sophong, string nhanvien, string thoigian, string nhanxetchung)
        {
            string query = string.Format("INSERT INTO BienBanKiemTraPhong VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}')", mabienban, sophong, nhanvien, thoigian, nhanxetchung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void UpdateTinhTrangPhong(string sophong)
        {
            string query = "UPDATE PHONG SET TINHTRANGPHONG = N'Đã kiểm tra' WHERE SOPHONG = '" + sophong + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public string GetMaBB(string sophong)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("SELECT MAX(MABIENBAN) FROM BIENBANKIEMTRAPHONG WHERE SOPHONG = '" + sophong + "'").ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
