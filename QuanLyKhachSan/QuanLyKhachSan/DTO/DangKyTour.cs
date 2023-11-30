using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DangKyTour
    {
        public DangKyTour(string sophong, string matour, string thoigian)
        {
            this.SOPHONG = sophong;
            this.MATOUR = matour;
            this.THOIGIANBATDAU = thoigianbatdau;
        }

        public static bool ThemDangKyTour(DangKyTour d)
        {
            return DangKyTourDAO.Instance.InsertDangKyTour(d.SOPHONG, d.MATOUR, d.THOIGIANBATDAU);
        }

        private string thoigianbatdau;

        public string THOIGIANBATDAU
        {
            get { return thoigianbatdau; }
            set { thoigianbatdau = value; }
        }

        private string matour;

        public string MATOUR
        {
            get { return matour; }
            set { matour = value; }
        }

        private string sophong;

        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }
    }
}
