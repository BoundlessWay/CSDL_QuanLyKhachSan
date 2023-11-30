using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DAO;

namespace QuanLyQuanCafe.DTO
{
    class NhanVien
    {
        private string sodienthoai;
        public string SODIENTHOAI
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        private string hoten;
        public string HOTEN
        {
            get { return manv; }
            set { manv = value; }
        }

        private string manv;
        public string MANV
        {
            get { return manv; }
            set { manv = value; }
        }

        public static DataTable getMaBellman()
        {
            return NhanVienDAO.getMaBellman();
        }
    }
}
