using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class ThongTin
    {
        public ThongTin(string tenkhachhang, string loaiphongthue, int songuoi, string tendoan, string ngayden, int sodem, string ycdb, int sotienthanhtoantruoc, int tinhtrangthanhtoan)
        {
            this.TENKHACHHANG = tenkhachhang;
            this.LOAIPHONGTHUE = loaiphongthue;
            this.SONGUOI = songuoi;
            this.TENDOAN = tendoan;
            this.ngayden = ngayden;
            this.sodem = sodem;
            this.YEUCAUDATBIET = ycdb;
            this.SOTIENTHANHTOANTRUOC = sotienthanhtoantruoc;
            this.TINHTRANGTHANHTOANTRUOC = tinhtrangthanhtoan;
        }

        public static DataTable LoadThongtin(string sophong)
        {
            return ThongTinDAO.Instance.LoadThongtin(sophong);
        }

        private int tinhtrangthanhtoan;
        public int TINHTRANGTHANHTOANTRUOC
        {
            get { return tinhtrangthanhtoan; }
            set { tinhtrangthanhtoan = value; }
        }

        private int sotienthanhtoantruoc;
        public int SOTIENTHANHTOANTRUOC
        {
            get { return sotienthanhtoantruoc; }
            set { sotienthanhtoantruoc = value; }
        }

        private string yeucaudatbiet;
        public string YEUCAUDATBIET
        {
            get { return yeucaudatbiet; }
            set { yeucaudatbiet = value; }
        }

        private int sodem;
        public int SODEM
        {
            get { return sodem; }
            set { sodem = value; }
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

        private string loaiphongthue;
        public string LOAIPHONGTHUE
        {
            get { return loaiphongthue; }
            set { loaiphongthue = value; }
        }

        private string tenkhachhang;
        public string TENKHACHHANG
        {
            get { return tenkhachhang; }
            set { tenkhachhang = value; }
        }
    }
}
