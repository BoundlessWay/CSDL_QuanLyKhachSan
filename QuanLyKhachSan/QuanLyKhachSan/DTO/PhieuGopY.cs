using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class PhieuGopY
    {
        public PhieuGopY(string maphieu, string noidung, int mucdohailong, string thoigian, string makhachhang)
        {
            this.MAPHIEU = maphieu;
            this.NOIDUNG = noidung;
            this.MUCDOHAILONG = mucdohailong;
            this.THOIGIAN = thoigian;
            this.MAKHACHHANG = makhachhang;
        }

        public PhieuGopY(DataRow row)
        {
            this.MAPHIEU = row["MaPhieu"].ToString();
            this.NOIDUNG = row["NoiDung"].ToString();
            this.MUCDOHAILONG = (int)row["MucDoHaiLong"];
            this.THOIGIAN = row["ThoiGian"].ToString();
            this.MAKHACHHANG = row["MaKhachHang"].ToString();
        }

        public static bool ThemPhieuGopY(PhieuGopY p)
        {
            return PhieuGopYDAO.Instance.InsertPhieuGopY(p.MAPHIEU, p.NOIDUNG, p.MUCDOHAILONG, p.THOIGIAN, p.MAKHACHHANG);
        }

        public static DataTable getGopY()
        {
            return PhieuGopYDAO.Instance.GetListGopY();
        }

        private string makhachhang;
        public string MAKHACHHANG
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }

        private string thoigian;
        public string THOIGIAN
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

        private int mucdohailong;
        public int MUCDOHAILONG
        {
            get { return mucdohailong; }
            set { mucdohailong = value; }
        }

        private string noidung;
        public string NOIDUNG
        {
            get { return noidung; }
            set { noidung = value; }
        }

        private string maphieu;
        public string MAPHIEU
        {
            get { return maphieu; }
            set { maphieu = value; }
        }
    }
}
