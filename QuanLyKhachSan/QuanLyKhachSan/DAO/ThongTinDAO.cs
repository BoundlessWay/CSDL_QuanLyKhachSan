using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ThongTinDAO
    {
        private static ThongTinDAO instance;

        public static ThongTinDAO Instance
        {
            get { if (instance == null) instance = new ThongTinDAO(); return instance; }
            private set { instance = value; }
        }

        private ThongTinDAO()
        {

        }

        public DataTable LoadThongtin(string sophong)
        {
            string query = "USP_GetInfoPhong @sophong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { sophong });
            return data;
        }
    }
}
