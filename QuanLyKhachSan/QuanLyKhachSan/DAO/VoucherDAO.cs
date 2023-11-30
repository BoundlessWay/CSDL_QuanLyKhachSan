using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;

        public static VoucherDAO Instance
        {
            get { if (instance == null) instance = new VoucherDAO(); return instance; }
            private set { instance = value; }
        }

        private VoucherDAO()
        {

        }

        public DataTable CheckVoucher(string mavoucher)
        {
            string query = "USP_KiemtraVoucher @mavoucher";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { mavoucher });
            return result;
        }
    }
}
