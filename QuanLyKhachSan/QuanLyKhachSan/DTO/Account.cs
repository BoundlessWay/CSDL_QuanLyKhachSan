using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        public Account(string userName, string displayName, string password = null)
        {
            this.TaiKhoan = userName;
            this.TenHienThi = displayName;
            this.MatKhau = password;
        }

        public Account(DataRow row)
        {
            this.TaiKhoan = row["TaiKhoan"].ToString();
            this.TenHienThi = row["TenHienThi"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
        }

        public static bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        public static string getRole(string manv)
        {
            return AccountDAO.Instance.GetRole(manv);
        }

        //public static string getUsername()
        //{

        //}

        private string matkhau;
        public string MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        private string tenhienthi;
        public string TenHienThi
        {
            get { return tenhienthi; }
            set { tenhienthi = value; }
        }

        private string taikhoan;

        public string TaiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
    }
}

