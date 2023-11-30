using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DoiTac
    {
        public DoiTac(string madoitac, string tencongty, string tennguoidaidien, string diachi, string email, string sdt)
        {
            this.MADOITAC = madoitac;
            this.TENCONGTY = tencongty;
            this.TENNGUOIDAIDIEN = tennguoidaidien;
            this.DIACHI = diachi;
            this.EMAIL = email;
            this.SODIENTHOAI = sdt;
        }

        public static DataTable getDoiTac(string matour)
        {
            return DoiTacDAO.Instance.GetListDoiTac(matour);
        }

        private string sodienthoai;

        public string SODIENTHOAI
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        private string email;

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        private string diachi;

        public string DIACHI
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string tennguoidaidien;

        public string TENNGUOIDAIDIEN
        {
            get { return tennguoidaidien; }
            set { tennguoidaidien = value; }
        }

        private string tencongty;

        public string TENCONGTY
        {
            get { return tencongty; }
            set { tencongty = value; }
        }

        private string madoitac;

        public string MADOITAC
        {
            get { return madoitac; }
            set { madoitac = value; }
        }
    }
}
