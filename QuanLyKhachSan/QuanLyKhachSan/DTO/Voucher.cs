using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Voucher
    {
        public Voucher(string mavoucher, string ten, string ngay, int giatri)
        {
            this.MAVOUCHER = mavoucher;
            this.TENVOUCHER = ten;
            this.THOIGIANHIEULUC = ngay;
            this.GIATRI = giatri;
        }

        public static DataTable kiemtravoucher(string mavoucher)
        {
            return VoucherDAO.Instance.CheckVoucher(mavoucher);
        }

        private int giatri;
        public int GIATRI
        {
            get { return giatri; }
            set { giatri = value; }
        }

        private string thoigianhieuluc;
        public string THOIGIANHIEULUC
        {
            get { return thoigianhieuluc; }
            set { thoigianhieuluc = value; }
        }

        private string tenvoucher;
        public string TENVOUCHER
        {
            get { return tenvoucher; }
            set { tenvoucher = value; }
        }

        private string mavoucher;
        public string MAVOUCHER
        {
            get { return mavoucher; }
            set { mavoucher = value; }
        }
    }
}
