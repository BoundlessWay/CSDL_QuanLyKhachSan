using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public class VatDungDAO
    {
        private static VatDungDAO instance;

        public static VatDungDAO Instance
        {
            get { if (instance == null) instance = new VatDungDAO(); return instance; }
            private set { instance = value; }
        }

        private VatDungDAO()
        {

        }

        public List<VatDung> LoadItemList(string sophong)
        {
            List<VatDung> itemList = new List<VatDung>();

            string query = "USP_GetItemList @sophong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { sophong });


            foreach (DataRow item in data.Rows)
            {
                VatDung vatdung = new VatDung(item);
                itemList.Add(vatdung);
            }

            return itemList;
        }

        public string GetMaVD(string tenvd)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("SELECT MAVATDUNG FROM VATDUNG WHERE TEN = N'" + tenvd + "'").ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
