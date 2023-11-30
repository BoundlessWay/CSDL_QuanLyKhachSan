using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDon
    {
        public HoaDon(string mahoadon, string sophong, string mavoucher, string thoigian, int tongtien, int tiencanthanhtoan, string mabienban, string nvlt)
        {
            this.MAHD = mahoadon;
            this.SOPHONG = sophong;
            this.MAVC = mavoucher;
            this.THOIGIAN = thoigian;
            this.TONGTIEN = tongtien;
            this.TIENCANTHANHTOAN = tiencanthanhtoan;
            this.MABIENBAN = mabienban;
            this.NHANVIENLETAN = nvlt;
            this.TINHTRANG = tinhtrang;
        }

        public static bool ThemHoaDon(HoaDon h)
        {
            return HoaDonDAO.Instance.InsertHoaDon(h.MAHD, h.SOPHONG, h.MAVC, h.THOIGIAN, h.TONGTIEN, h.TIENCANTHANHTOAN, h.MABIENBAN, h.NHANVIENLETAN);
        }

        public static bool CapNhatTinhTrangHoaDon(string mahoadon)
        {
            return HoaDonDAO.Instance.UpdateTinhTrangHoaDon(mahoadon);
        }

        private string tinhtrang;
        public string TINHTRANG
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        private string nhanvienletan;
        public string NHANVIENLETAN
        {
            get { return nhanvienletan; }
            set { nhanvienletan = value; }
        }

        private string mabienban;
        public string MABIENBAN
        {
            get { return mabienban; }
            set { mabienban = value; }
        }

        private int tiencanthanhtoan;
        public int TIENCANTHANHTOAN
        {
            get { return tiencanthanhtoan; }
            set { tiencanthanhtoan = value; }
        }

        private int tongtien;
        public int TONGTIEN
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        private string thoigian;
        public string THOIGIAN
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private string mavc;
        public string MAVC
        {
            get { return mavc; }
            set { mavc = value; }
        }

        private string sophong;
        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }

        private string mahd;
        public string MAHD
        {
            get { return mahd; }
            set { mahd = value; }
        }
    }
}
