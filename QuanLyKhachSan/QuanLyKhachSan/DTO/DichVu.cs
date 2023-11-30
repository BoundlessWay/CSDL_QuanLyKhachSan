using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DichVu
    {
        public DichVu(string madichvu, string tendichvu, string mota, int gia, string vitri, string loaidichvu)
        {
            this.MADICHVU = madichvu;
            this.TENDICHVU = tendichvu;
            this.MOTA = mota;
            this.GIA = gia;
            this.VITRI = vitri;
            this.LOAIDICHVU = loaidichvu;
        }

        public DichVu(DataRow row)
        {
            this.MADICHVU = row["MaDichVu"].ToString();
            this.TENDICHVU = row["TenDichVu"].ToString();
            this.MOTA = row["MoTa"].ToString();
            this.GIA = (int)row["Gia"];
            this.VITRI = row["ViTri"].ToString();
            this.LOAIDICHVU = row["LoaiDichVu"].ToString();
        }

        public static string getMaDV(string tendv)
        {
            return DichVuDAO.Instance.GetMaDV(tendv);
        }

        public static DataTable getDichVu(string madichvu)
        {
            return DichVuDAO.Instance.GetDichVu(madichvu);
        }

        private string loaidichvu;

        public string LOAIDICHVU
        {
            get { return loaidichvu; }
            set { loaidichvu = value; }
        }

        private string vitri;

        public string VITRI
        {
            get { return vitri; }
            set { vitri = value; }
        }

        private int gia;

        public int GIA
        {
            get { return gia; }
            set { gia = value; }
        }

        private string mota;

        public string MOTA
        {
            get { return mota; }
            set { mota = value; }
        }

        private string tendichvu;

        public string TENDICHVU
        {
            get { return tendichvu; }
            set { tendichvu = value; }
        }

        private string madichvu;

        public string MADICHVU
        {
            get { return madichvu; }
            set { madichvu = value; }
        }
    }
}
