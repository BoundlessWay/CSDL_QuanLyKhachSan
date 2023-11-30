using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TourDuLichDAO
    {
        private static TourDuLichDAO instance;

        public static TourDuLichDAO Instance
        {
            get { if (instance == null) instance = new TourDuLichDAO(); return instance; }
            private set { instance = value; }
        }

        private TourDuLichDAO()
        {

        }

        public DataTable GetListTour(string matour)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM TOURDULICH WHERE MATOUR = '" + matour + "'");
            return table;
        }
    }
}
