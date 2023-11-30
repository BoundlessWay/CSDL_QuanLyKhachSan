using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class ChiTietBienBanKiemTraPhong
    {
        public ChiTietBienBanKiemTraPhong(string mabienban, string mavatdung)
        {
            this.MABIENBAN = mabienban;
            this.MAVATDUNG = mavatdung;
        }

        public static bool ThemChiTietBienBan(ChiTietBienBanKiemTraPhong ct)
        {
            return ChiTietBienBanKiemTraPhongDAO.Instance.InsertChiTietBienBan(ct.MABIENBAN, ct.MAVATDUNG);
        }

        private string mavatdung;
        public string MAVATDUNG
        {
            get { return mavatdung; }
            set { mavatdung = value; }
        }

        private string mabienban;
        public string MABIENBAN
        {
            get { return mabienban; }
            set { mabienban = value; }
        }
    }
}
