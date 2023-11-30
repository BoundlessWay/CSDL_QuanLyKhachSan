using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.DTO
{
    public class PhieuDangKy
    {
        public static int CapNhatTinhTrangThanhToan(string kq, string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.CapNhatTinhTrangThanhToan(kq, MaPhieu);
        }

        public static String LayMaKhachHang(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayMaKhachHang(MaPhieu);
        }
        public static String LaySoNguoi(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LaySoNguoi(MaPhieu);
        }
        public static String LayTenDoan(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayTenDoan(MaPhieu);
        }
        public static String LayNgayDen(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayNgayDen(MaPhieu);
        }
        public static String LaySoDemLuuTru(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LaySoDemLuuTru(MaPhieu);
        }
        public static String LayTienThanhToan30(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayTienThanhToan30(MaPhieu);
        }
        public static String LayYeuCauDacBiet(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayYeuCauDacBiet(MaPhieu);
        }
        public static String LayTinhTrangThanhToan30(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayTinhTrangThanhToan30(MaPhieu);
        }
        public static String LayLoaiPhong(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.LayLoaiPhong(MaPhieu);
        }
        //DATPHONG
        public static DataTable CheckPhieu(string MaPhieu)
        {
            return PhieuDangKyDAO.Instance.CheckPhieuDangKy(MaPhieu);
        }
        public static int ThemPhieuDangKy(PhieuDangKy p)
        {
            return PhieuDangKyDAO.Instance.ThemPhieuDangKy(p.MAPHIEUDANGKY, p.MAKHACHHANG, p.LOAIPHONG, p.SONGUOI, p.TENDOAN, p.NGAYDEN, p.SODEMLUUTRU, p.YEUCAUDACBIET, p.TIENTHOANHTOAN30);
        }
        public static DataTable DocPhieuDangKy()
        {
            return PhieuDangKyDAO.Instance.DocPhieuDangKy();
        }

        public PhieuDangKy(string maphieu, string makhachhang, string loaiphong, int songuoi, string tendoan, string ngayden, int sodemluutru, string ycdb, int tienthanhtoan30, int tinhtrangthanhtoan30)
        {
            this.MAPHIEUDANGKY = maphieu;
            this.MAKHACHHANG = makhachhang;
            this.LOAIPHONG = loaiphong;
            this.SONGUOI = songuoi;
            this.TENDOAN = tendoan;
            this.NGAYDEN = ngayden;
            this.SODEMLUUTRU = sodemluutru;
            this.YEUCAUDACBIET = ycdb;
            this.TIENTHOANHTOAN30 = tienthanhtoan30;
            this.TINHTRANGTHANHTOAN30 = tinhtrangthanhtoan30;
        }

        private int tinhtrangthanhtoan30;
        public int TINHTRANGTHANHTOAN30
        {
            get { return tinhtrangthanhtoan30; }
            set { tinhtrangthanhtoan30 = value; }
        }

        private int tienthanhtoan30;
        public int TIENTHOANHTOAN30
        {
            get { return tienthanhtoan30; }
            set { tienthanhtoan30 = value; }
        }

        private string yeucaudatbiet;
        public string YEUCAUDACBIET
        {
            get { return yeucaudatbiet; }
            set { yeucaudatbiet = value; }
        }

        private int sodemluutru;
        public int SODEMLUUTRU
        {
            get { return sodemluutru; }
            set { sodemluutru = value; }
        }

        private string ngayden;
        public string NGAYDEN
        {
            get { return ngayden; }
            set { ngayden = value; }
        }

        private string tendoan;
        public string TENDOAN
        {
            get { return tendoan; }
            set { tendoan = value; }
        }

        private int songuoi;
        public int SONGUOI
        {
            get { return songuoi; }
            set { songuoi = value; }
        }

        private string loaiphong;
        public string LOAIPHONG
        {
            get { return loaiphong; }
            set { loaiphong = value; }
        }

        private string makhachhang;
        public string MAKHACHHANG
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }

        private string maphieudangky;
        public string MAPHIEUDANGKY
        {
            get { return maphieudangky; }
            set { maphieudangky = value; }
        }
    }
}
