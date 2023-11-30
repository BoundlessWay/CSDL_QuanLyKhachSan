using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.DTO
{
    public class PhieuVanChuyen
    {
        public PhieuVanChuyen(string MaKhachHang, string SoPhong, string ThoiGian, string Bellman, int SoLuong, string Mota)
        {
            this.MAKHACHHANG = MaKhachHang;
            this.SOPHONG = SoPhong;
            this.THOIGIAN = ThoiGian;
            this.BELLMAN = Bellman;
            this.SOLUONGHANHLY = SoLuong;
            this.MOTA = Mota;
        }

        public PhieuVanChuyen(DataRow row)
        {
            this.MAKHACHHANG = row["MaKhachHang"].ToString();
            this.SOPHONG = row["SoPhong"].ToString();
            this.THOIGIAN = row["ThoiGian"].ToString();
            this.BELLMAN = row["NVBellman"].ToString();
            this.SOLUONGHANHLY = (int)row["SoLuongHanhLy"];
            this.MOTA = row["MoTa"].ToString();
        }

        public static bool checkExist(string makh, string sophong, string time)
        {
            DataTable data = PhieuVanChuyenDAO.Instance.getListPhieuVanChuyen();
            foreach (DataRow row in data.Rows)
            {
                if (makh == row[0].ToString() && sophong == row[1].ToString() && time == row[2].ToString()) return false;
            }
            return true;
        }

        public static int AddPhieuVanChuyen(string makh, string sophong, string time, string bellman = "NV004", int count = 0, string detail = "")
        {
            return PhieuVanChuyenDAO.Instance.AddPhieuVanChuyen(makh, sophong, time, bellman, count, detail);
        }

        private string MaKhachHang;
        public string MAKHACHHANG
        {
            get { return MaKhachHang; }
            set { MaKhachHang = value; }
        }

        private string SoPhong;
        public string SOPHONG
        {
            get { return SoPhong; }
            set { SoPhong = value; }
        }

        private string ThoiGian;
        public string THOIGIAN
        {
            get { return ThoiGian; }
            set { ThoiGian = value; }
        }

        private string Bellman;
        public string BELLMAN
        {
            get { return Bellman; }
            set { Bellman = value; }
        }

        private int SoLuong;
        public int SOLUONGHANHLY
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        private string Mota;
        public string MOTA
        {
            get { return Mota; }
            set { Mota = value; }
        }
    }
}
