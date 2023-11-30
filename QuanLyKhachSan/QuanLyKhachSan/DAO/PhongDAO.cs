using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private PhongDAO()
        {

        }

        public List<Phong> LoadRoomList()
        {
            List<Phong> roomList = new List<Phong>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");

            foreach (DataRow item in data.Rows)
            {
                Phong room = new Phong(item);
                roomList.Add(room);
            }

            return roomList;
        }

        public DataTable GetListPhongDangChoThue()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT SOPHONG FROM PHONG WHERE TINHTRANGPHONG = N'Đang cho thuê'");
            return table;
        }

        public DataTable GetListPhongDangChoThueHoacDaKT()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT SOPHONG FROM PHONG WHERE TINHTRANGPHONG = N'Đang cho thuê' OR TINHTRANGPHONG = N'Đã kiểm tra'");
            return table;
        }

        public bool UpdateTinhTrangPhong(string sophong)
        {
            string query = "USP_UpdateStatusPhong @sophong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sophong });

            return result > 0;
        }

        public string GetTienPhong(string sophong)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("SELECT GIA FROM PHONG WHERE SOPHONG = '" + sophong + "'").ToString();
            }
            catch
            {
                return "0";
            }
        }

        public DataTable LoadDVFromPhong(string sophong)
        {
            string query = "USP_GetDVFromPhong @sophong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { sophong });
            return data;
        }

        public int TinhTienDV(string sophong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.TinhTien('" + sophong + "')");
            return int.Parse(data.Rows[0].ItemArray[0].ToString());
        }

        public DataTable LoadVatDungHu(string mabienban)
        {
            string query = "USP_LoadVDH @mabienban";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mabienban });
            return data;
        }

        public int TinhTienVatDungHu(string mabienban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.TinhTienVatDungHu('" + mabienban + "')");
            return int.Parse(data.Rows[0].ItemArray[0].ToString());
        }

        public bool UpdatePhong(string sophong)
        {
            string query = "USP_UpdatePhong @sophong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sophong });

            return result > 0;
        }

        public DataTable CheckSoPhong(string SoPhong)
        {
            return DataProvider.Instance.ExecuteQuery("select * from phong where SoPhong = '" + SoPhong + "';");
        }
        public String DocGiaPhong(string SoPhong)
        {
            return DataProvider.Instance.ExecuteScalar("select Gia from Phong where SoPhong = '" + SoPhong + "'").ToString();
        }

        public int CapNhatPhong(string SoPhong)
        {
            return DataProvider.Instance.ExecuteNonQuery("update Phong set TinhTrangPhong = N'Đang cho thuê' where SoPhong = '" + SoPhong + "';");
        }

        public DataTable DocThongTinPhong1(String SoNguoiDangKyDatPhong)
        {
            return DataProvider.Instance.ExecuteQuery("select* from Phong where SoPhong not in(select SoPhong from Phong where TinhTrangPhong = N'Đang cho thuê' or TinhTrangPhong = N'Đợi kiểm tra' or TinhTrangPhong = N'Đã kiểm tra') and SoNguoiToiDa >= " + SoNguoiDangKyDatPhong);
        }
        public DataTable DocThongTinPhong2(String LoaiPhong, String SoNguoiDangKyDatPhong)
        {
            return DataProvider.Instance.ExecuteQuery("select* from Phong where SoPhong not in(select SoPhong from Phong where TinhTrangPhong = N'Đang cho thuê' or TinhTrangPhong = N'Đợi kiểm tra' or TinhTrangPhong = N'Đã kiểm tra') and LoaiPhong = N'" + LoaiPhong + "' and SoNguoiToiDa >= " + SoNguoiDangKyDatPhong);
        }
        public DataTable DocThongTinPhong3()
        {
            return DataProvider.Instance.ExecuteQuery("select* from Phong where SoPhong not in(select SoPhong from Phong where TinhTrangPhong = N'Đang cho thuê' or TinhTrangPhong = N'Đợi kiểm tra' or TinhTrangPhong = N'Đã kiểm tra')");
        }
        public DataTable DocThongTinPhong4(String LoaiPhong)
        {
            return DataProvider.Instance.ExecuteQuery("select* from Phong where SoPhong not in(select SoPhong from Phong where TinhTrangPhong = N'Đang cho thuê' or TinhTrangPhong = N'Đợi kiểm tra' or TinhTrangPhong = N'Đã kiểm tra') and LoaiPhong = N'" + LoaiPhong + "'");
        }

        public DataTable GetListPhongCanVeSinh()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT SOPHONG, SONGUOITOIDA, LOAIPHONG, GIA, TINHTRANGPHONG FROM PHONG WHERE TINHTRANGVESINH = N'Cần vệ sinh'");
            return table;
        }
        public bool UpdateTinhTrangVsPhong(string sophong)
        {
            string query = "USP_UpdateCleanStatusPhong @sophong";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sophong });
            return result > 0;
        }
    }
}
