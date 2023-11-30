using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class DoiTacDAO
    {
        private static DoiTacDAO instance;

        public static DoiTacDAO Instance
        {
            get { if (instance == null) instance = new DoiTacDAO(); return instance; }
            private set { instance = value; }
        }

        private DoiTacDAO()
        {

        }

        public DataTable GetListDoiTac(string matour)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT DT.* from DOITAC DT, TOURDULICH T WHERE DT.MADOITAC = T.MADOITAC AND T.MATOUR = '" + matour + "'");
            return table;
        }
    }
}
