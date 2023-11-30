using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class KhachHang
    {
        public KhachHang(string cccd, string hoten, string sdt, string diachi)
        {
            this.CCCD = cccd;
            this.HOTEN = hoten;
            this.SDT = sdt;
            this.DIACHI = diachi;
        }

        public static DataTable getMaKH()
        {
            return KhachHangDAO.Instance.GetListMaKhachHang();
        }

        public static int ThemKhachHang(KhachHang kh)
        {
            return KhachHangDAO.Instance.ThemKhachHang(kh.CCCD, kh.HOTEN, kh.SDT, kh.DIACHI);
        }

        private string diachi;  
        public string DIACHI
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string hoten;
        public string HOTEN
        {
            get { return hoten; }
            set { hoten = value; }
        }

        private string cccd;
        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }
    }
}
