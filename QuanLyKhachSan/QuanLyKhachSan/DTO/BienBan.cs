using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BienBan
    {
        public BienBan(string mabienban, string sophong, string nhanvienkt, string thoigian, string nhanxet)
        {
            this.MABIENBAN = mabienban;
            this.SOPHONG = sophong;
            this.NHANVIENKT = nhanvienkt;
            this.THOIGIAN = thoigian;
            this.NHANXET = nhanxet;
        }

        public BienBan(DataRow row)
        {
            this.MABIENBAN = row["MaBienBan"].ToString();
            this.SOPHONG = row["SoPhong"].ToString();
            this.NHANVIENKT = row["NVBuongPhong"].ToString();
            this.THOIGIAN = row["ThoiGian"].ToString();
            this.NHANXET = row["NhanXetChung"].ToString();
        }

        public static bool ThemBienBan(BienBan bb)
        {
            BienBanDAO.Instance.UpdateTinhTrangPhong(bb.sophong);
            return BienBanDAO.Instance.InsertBienBan(bb.MABIENBAN, bb.SOPHONG, bb.NHANVIENKT, bb.THOIGIAN, bb.NHANXET);
        }

        public static string getMaBB(string sophong)
        {
            return BienBanDAO.Instance.GetMaBB(sophong);
        }

        private string nhanxet;

        public string NHANXET
        {
            get { return nhanxet; }
            set { nhanxet = value; }
        }

        private string thoigian;

        public string THOIGIAN
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private string nhanvienkt;

        public string NHANVIENKT
        {
            get { return nhanvienkt; }
            set { nhanvienkt = value; }
        }

        private string sophong;

        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }

        private string mabienban;

        public string MABIENBAN
        {
            get { return mabienban; }
            set { mabienban = value; }
        }
    }
}
