using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class VatDung
    {
        public VatDung(string mavatdung, string tenvatdung, int gia)
        {
            this.MAVATDUNG = mavatdung;
            this.TEN = tenvatdung;
            this.GIA = gia;
        }

        public VatDung(DataRow row)
        {
            this.MAVATDUNG = row["MaVatDung"].ToString();
            this.TEN = row["Ten"].ToString();
            this.GIA = (int)row["Gia"];
        }

        public static List<VatDung> getItem(string sophong)
        {
            return VatDungDAO.Instance.LoadItemList(sophong);
        }

        public static string getMaVD(string tenvd)
        {
            return VatDungDAO.Instance.GetMaVD(tenvd);
        }

        private int gia;
        public int GIA
        {
            get { return gia; }
            set { gia = value; }
        }

        private string ten;
        public string TEN
        {
            get { return ten; }
            set { ten = value; }
        }

        private string mavatdung;
        public string MAVATDUNG
        {
            get { return mavatdung; }
            set { mavatdung = value; }
        }
    }
}
