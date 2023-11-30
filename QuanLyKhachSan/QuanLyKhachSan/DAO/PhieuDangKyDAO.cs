using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDangKyDAO
    {
        private static PhieuDangKyDAO instance;
        public static PhieuDangKyDAO Instance
        {
            get { if (instance == null) instance = new PhieuDangKyDAO(); return instance; }
            private set { instance = value; }
        }
        public int CapNhatTinhTrangThanhToan(string kq, string MaPhieu)
        {
            return DataProvider.Instance.ExecuteNonQuery("update PhieuDangKyPhong set TinhTrangThanhToan30 = " + kq + " where MaPhieuDangKy = '" + MaPhieu + "';");
        }

        public String LayMaKhachHang(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select MaKhachHang from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LaySoNguoi(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select SoNguoi from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LayTenDoan(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select TenDoan from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LayNgayDen(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select NgayDen from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LaySoDemLuuTru(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select SoDemLuuTru from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LayTienThanhToan30(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select TienThanhToan30 from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LayYeuCauDacBiet(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select YeuCauDacBiet from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LayTinhTrangThanhToan30(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select TinhTrangThanhToan30 from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }
        public String LayLoaiPhong(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteScalar("select LoaiPhong from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';").ToString();
        }

        //DATPHONGs
        public DataTable CheckPhieuDangKy(string MaPhieu)
        {
            return DataProvider.Instance.ExecuteQuery("select * from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "';");
        }
        public int ThemPhieuDangKy(String MaPhieu, String CMND, String LoaiPhong, int SoNguoi, String TenDoan, String NgayDen, int SoDemLuuTru, String YeuCauDacBiet, int TienThanhToan30)
        {
            return DataProvider.Instance.ExecuteNonQuery("insert into PhieuDangKyPhong values('" + MaPhieu + "', '" + CMND + "', N'" + LoaiPhong + "', " + SoNguoi + ", N'" + TenDoan + "', '" + NgayDen + "', " + SoDemLuuTru + ", N'" + YeuCauDacBiet + "', " + TienThanhToan30 + ", 0);");
        }

        public DataTable DocPhieuDangKy()
        {
            return DataProvider.Instance.ExecuteQuery("select * from PhieuDangKyPhong");
        }
    }
}
