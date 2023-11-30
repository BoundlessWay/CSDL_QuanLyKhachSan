using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class TourDuLich
    {
        public TourDuLich(string matour, string diadiem, int gia, string mota,  string madoitac)
        {
            this.MATOUR = matour;
            this.DIADIEM = DIADIEM;
            this.GIA = gia;
            this.MOTA = mota;
            this.MADOITAC = madoitac;
        }

        public static DataTable getTourDuLich(string matour)
        {
            return TourDuLichDAO.Instance.GetListTour(matour);
        }

        private string madoitac;

        public string MADOITAC
        {
            get { return madoitac; }
            set { madoitac = value; }
        }

        private string mota;

        public string MOTA
        {
            get { return mota; }
            set { mota = value; }
        }

        private int gia;

        public int GIA
        {
            get { return gia; }
            set { gia = value; }
        }

        private string diadiem;

        public string DIADIEM
        {
            get { return diadiem; }
            set { diadiem = value; }
        }

        private string matour;

        public string MATOUR
        {
            get { return matour; }
            set { matour = value; }
        }
    }
}
