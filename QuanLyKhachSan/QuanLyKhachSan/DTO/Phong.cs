using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Phong
    {
        public Phong(string sophong, int songuoitoida, string loaiphong, int gia, string tinhtrangphong, string tinhtrangvesinh)
        {
            this.SOPHONG = sophong;
            this.SONGUOITOIDA = songuoitoida;
            this.LOAIPHONG = loaiphong;
            this.GIA = gia;
            this.TINHTRANGPHONG = tinhtrangphong;
            this.TINHTRANGVESINH = tinhtrangvesinh;
        }

        public Phong(DataRow row)
        {
            this.SOPHONG = row["SoPhong"].ToString();
            this.SONGUOITOIDA = (int)row["SoNguoiToiDa"];
            this.LOAIPHONG = row["LoaiPhong"].ToString();
            this.GIA = (int)row["Gia"];
            this.TINHTRANGPHONG = row["TinhTrangPhong"].ToString();
            this.TINHTRANGVESINH = row["TinhTrangVeSinh"].ToString();
        }
        public static List<Phong> getPhong()
        {
            return PhongDAO.Instance.LoadRoomList();
        }

        public static DataTable getMaPhongDangChoThue()
        {
            return PhongDAO.Instance.GetListPhongDangChoThue();
        }

        public static DataTable getMaPhongDangChoThueHoacDaKT()
        {
            return PhongDAO.Instance.GetListPhongDangChoThueHoacDaKT();
        }

        public static bool CapNhatTinhTrangPhong(string sophong)
        {
            return PhongDAO.Instance.UpdateTinhTrangPhong(sophong);
        }

        public static string laytienphong(string maphong)
        {
            return PhongDAO.Instance.GetTienPhong(maphong);
        }

        public static DataTable LoadDichVuCuaPhong(string sophong)
        {
            return PhongDAO.Instance.LoadDVFromPhong(sophong);
        }

        public static int TinhTienDV(string sophong)
        {
            return PhongDAO.Instance.TinhTienDV(sophong);
        }

        public static DataTable LoadVatDungHu(string mabienban)
        {
            return PhongDAO.Instance.LoadVatDungHu(mabienban);
        }

        public static int TinhTienVatDungHu(string mabienban)
        {
            return PhongDAO.Instance.TinhTienVatDungHu(mabienban);
        }

        public static bool CapNhatTinhTrangPhongCheckout(string sophong)
        {
            return PhongDAO.Instance.UpdatePhong(sophong);
        }

        public static DataTable CheckSoPhong(string SoPhong)
        {
            return PhongDAO.Instance.CheckSoPhong(SoPhong);
        }
        public static String DocGiaPhong(string SoPhong)
        {
            return PhongDAO.Instance.DocGiaPhong(SoPhong);
        }
        public static int CapNhatPhong(string SoPhong)
        {
            return PhongDAO.Instance.CapNhatPhong(SoPhong);
        }
        public static DataTable DocThongTinPhong1(String SoNguoiDangKyDatPhong)
        {
            return PhongDAO.Instance.DocThongTinPhong1(SoNguoiDangKyDatPhong);
        }
        public static DataTable DocThongTinPhong2(String LoaiPhong, String SoNguoiDangKyDatPhong)
        {
            return PhongDAO.Instance.DocThongTinPhong2(LoaiPhong, SoNguoiDangKyDatPhong);
        }
        public static DataTable DocThongTinPhong3()
        {
            return PhongDAO.Instance.DocThongTinPhong3();
        }
        public static DataTable DocThongTinPhong4(String LoaiPhong)
        {
            return PhongDAO.Instance.DocThongTinPhong4(LoaiPhong);
        }

        public static DataTable getPhongCanVeSinh()
        {
            return PhongDAO.Instance.GetListPhongCanVeSinh();
        }
        public static bool CapNhatTinhTrangVeSinhPhong(string sophong)
        {
            return PhongDAO.Instance.UpdateTinhTrangVsPhong(sophong);

        }

        private string tinhtrangvesinh;
        public string TINHTRANGVESINH
        {
            get { return tinhtrangvesinh; }
            set { tinhtrangvesinh = value; }
        }

        private string tinhtrangphong;
        public string TINHTRANGPHONG
        {
            get { return tinhtrangphong; }
            set { tinhtrangphong = value; }
        }

        private int gia;
        public int GIA
        {
            get { return gia; }
            set { gia = value; }
        }

        private string loaiphong;
        public string LOAIPHONG
        {
            get { return loaiphong; }
            set { loaiphong = value; }
        }

        private int songuoitoida;
        public int SONGUOITOIDA
        {
            get { return songuoitoida; }
            set { songuoitoida = value; }
        }

        private string sophong;
        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }
    }
}
