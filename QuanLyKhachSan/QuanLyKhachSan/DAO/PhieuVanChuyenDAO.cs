using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;

namespace QuanLyKhachSan.DAO
{
    public class PhieuVanChuyenDAO
    {
        private static PhieuVanChuyenDAO instance;

        public static PhieuVanChuyenDAO Instance
        {
            get { if (instance == null) instance = new PhieuVanChuyenDAO(); return instance; }
            private set { instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private PhieuVanChuyenDAO()
        {

        }

        public DataTable getListPhieuVanChuyen()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM PhieuVanChuyen");
            return table;
        }

        public int AddPhieuVanChuyen(string makh, string sophong, string time, string bellman, int count, string detail)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO PhieuVanChuyen VALUES ('" + makh + "', '" + sophong + "', '" + time + "', '" + bellman + "', " + count + ", N'" + detail + "')");

        }
    }
}
