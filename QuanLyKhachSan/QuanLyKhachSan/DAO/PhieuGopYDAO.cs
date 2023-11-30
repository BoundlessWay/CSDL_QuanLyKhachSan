using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class PhieuGopYDAO
    {
        private static PhieuGopYDAO instance;

        public static PhieuGopYDAO Instance
        {
            get { if (instance == null) instance = new PhieuGopYDAO(); return instance; }
            private set { instance = value; }
        }

        private PhieuGopYDAO()
        {

        }

        public bool InsertPhieuGopY(string maphieu, string noidung, int mucdohailong, string thoigian, string makhachhang)
        {
            string query = string.Format("INSERT INTO PhieuGopY VALUES ('{0}', N'{1}', {2}, '{3}', '{4}')", maphieu, noidung, mucdohailong, thoigian, makhachhang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetListGopY()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM PHIEUGOPY");
            return table;
        }
    }
}
