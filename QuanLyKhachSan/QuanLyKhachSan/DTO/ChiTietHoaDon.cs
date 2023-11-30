using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(string mahd, string sophong, string madichvu, int soluong)
        {
            this.MAHOADON = mahd;
            this.SOPHONG = sophong;
            this.MADICHVU = madichvu;
            this.SOLUONG = soluong;
        }

        public static DataTable LoadMaDichVuCuaPhong(string sophong)
        {
            return ChiTietHoaDonDAO.Instance.LoadMaDVFromPhong(sophong);
        }

        public static bool ThemChiTietHoaDon(ChiTietHoaDon h)
        {
            return ChiTietHoaDonDAO.Instance.InsertChiTietHoaDon(h.MAHOADON, h.SOPHONG, h.MADICHVU, h.SOLUONG);
        }

        private int soluong;
        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private string madichvu;
        public string MADICHVU
        {
            get { return madichvu; }
            set { madichvu = value; }
        }

        private string sophong;
        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }

        private string mahoadon;
        public string MAHOADON
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
    }
}
