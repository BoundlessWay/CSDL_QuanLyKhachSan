using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public class DangKyDichVuDAO
    {
        private static DangKyDichVuDAO instance;

        public static DangKyDichVuDAO Instance
        {
            get { if (instance == null) instance = new DangKyDichVuDAO(); return instance; }
            private set { instance = value; }
        }

        private DangKyDichVuDAO()
        {
            
        }

        public bool InsertDangKyDichVuBP(string sophong, string madichvu, string thoigianbatdau, string thoigianketthuc, int soluong, string nvbp)
        {
            string query = string.Format("INSERT INTO DangKyDichVu VALUES (N'{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}')", sophong, madichvu, thoigianbatdau, thoigianketthuc, soluong, "NULL", nvbp);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool InsertDangKyDichVuLT(string sophong, string madichvu, string thoigianbatdau, string thoigianketthuc, int soluong, string nvlt)
        {
            //MessageBox.Show(string.Format("INSERT INTO DangKyDichVu VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}')", sophong, madichvu, thoigianbatdau, thoigianketthuc, soluong, nvlt, "NULL"));
            string query = string.Format("INSERT INTO DangKyDichVu VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', {6})", sophong, madichvu, thoigianbatdau, thoigianketthuc, soluong, nvlt, "NULL");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteDangKyDichVu(string sophong)
        {
            string query = string.Format("DELETE FROM DangKyDichVu WHERE SOPHONG = N'" + sophong + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
