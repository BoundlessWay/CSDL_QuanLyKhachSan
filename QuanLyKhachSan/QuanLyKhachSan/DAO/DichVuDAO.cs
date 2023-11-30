using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }

        private DichVuDAO()
        {

        }

        public string GetMaDV(string tendv)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("SELECT MADICHVU FROM DICHVU WHERE TENDICHVU = N'" + tendv + "'").ToString();
            }
            catch
            {
                return "";
            }
        }

        public DataTable GetDichVu(string madichvu)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM DICHVU WHERE MADICHVU = '" + madichvu + "'");
            return table;
        }
    }
}
