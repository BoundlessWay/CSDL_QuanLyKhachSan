using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ChiTietBienBanKiemTraPhongDAO
    {
        private static ChiTietBienBanKiemTraPhongDAO instance;

        public static ChiTietBienBanKiemTraPhongDAO Instance
        {
            get { if (instance == null) instance = new ChiTietBienBanKiemTraPhongDAO(); return instance; }
            private set { instance = value; }
        }

        private ChiTietBienBanKiemTraPhongDAO()
        {
            
        }

        public bool InsertChiTietBienBan(string mabienban, string mavatdung)
        {
            string query = string.Format("INSERT INTO ChiTietBienBanKiemTraPhong VALUES ('{0}', '{1}')", mabienban, mavatdung);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
