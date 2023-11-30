using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.DTO
{
    public class KhachHang_Phong
    {
        public static int ThemKhachHang_Phong(KhachHang_Phong khp)
        {
            return KhachHang_PhongDAO.Instance.ThemKhachHang_Phong(khp.MAKHACHHANG, khp.SOPHONG, khp.THOIGIAN);
        }

        public KhachHang_Phong(string makhachhang, string sophong, string thoigian)
        {
            this.MAKHACHHANG = makhachhang;
            this.SOPHONG = sophong;
            this.THOIGIAN = thoigian;
        }

        public static DataRow getKhachHang_PhongVuaDangKi()
        {
            DataTable data = KhachHang_PhongDAO.Instance.getListKhachHang_Phong();
            if (data.Rows.Count < 1) return null;
            return data.Rows[data.Rows.Count - 1];
        }

        private string makhachhang;

        public string MAKHACHHANG
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }

        private string sophong;

        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }

        private string thoigian;

        public string THOIGIAN
        {
            get { return thoigian; }
            set { thoigian = value; }
        }
    }
}
