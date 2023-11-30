using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;

namespace QuanLyKhachSan.DAO
{
    public class NhanVienDAO
    {

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        private NhanVienDAO()
        {

        }

        public static DataTable getMaBellman()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT MaNhanVien  FROM NhanVien WHERE LoaiNhanVien = 'Bellman'");
            return table;
        }
    }
}
