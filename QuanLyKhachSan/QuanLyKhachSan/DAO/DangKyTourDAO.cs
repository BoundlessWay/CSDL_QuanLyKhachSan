using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DangKyTourDAO
    {
        private static DangKyTourDAO instance;

        public static DangKyTourDAO Instance
        {
            get { if (instance == null) instance = new DangKyTourDAO(); return instance; }
            private set { instance = value; }
        }

        private DangKyTourDAO()
        {

        }

        public bool InsertDangKyTour(string sophong, string matour, string thoigian)
        {
            string query = string.Format("INSERT INTO DANGKYTOUR VALUES ('{0}', '{1}', '{2}')", sophong, matour, thoigian);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
