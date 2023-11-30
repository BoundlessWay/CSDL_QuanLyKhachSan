using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DangKyDichVu
    {
        public DangKyDichVu(string sophong, string madichvu, string thoigianbatdau, string thoigianketthuc, int soluong, string nvlt, string nvbp)
        {
            this.SOPHONG = sophong;
            this.MADICHVU = madichvu;
            this.THOIGIANBATDAU = thoigianbatdau;
            this.THOIGIANKETTHUC = thoigianketthuc;
            this.SOLUONG = soluong;
            this.NHANVIENLETAN = nvlt;
            this.NHANVIENBUONGPHONG = nvbp;
        }

        public DangKyDichVu(DataRow row)
        {
            this.SOPHONG = row["SoPhong"].ToString();
            this.MADICHVU = row["MaDichVu"].ToString();
            this.THOIGIANBATDAU = row["ThoiGianBatDau"].ToString();
            this.THOIGIANKETTHUC = row["ThoiGianKetThuc"].ToString();
            this.SOLUONG = (int)row["SoLuong"];
            this.NHANVIENLETAN = row["NVLeTan"].ToString();
            this.NHANVIENBUONGPHONG = row["NVBuongPhong"].ToString();
        }

        public static bool ThemDangKyDichVuBP(DangKyDichVu dkdv)
        {
            return DangKyDichVuDAO.Instance.InsertDangKyDichVuBP(dkdv.SOPHONG, dkdv.MADICHVU, dkdv.THOIGIANBATDAU, dkdv.THOIGIANKETTHUC, dkdv.SOLUONG, dkdv.NHANVIENBUONGPHONG);
        }

        public static bool ThemDangKyDichVuLT(DangKyDichVu dkdv)
        {
            return DangKyDichVuDAO.Instance.InsertDangKyDichVuLT(dkdv.SOPHONG, dkdv.MADICHVU, dkdv.THOIGIANBATDAU, dkdv.THOIGIANKETTHUC, dkdv.SOLUONG, dkdv.NHANVIENBUONGPHONG);
        }

        public static bool XoaDangKyDichVu(string sophong)
        {
            return DangKyDichVuDAO.Instance.DeleteDangKyDichVu(sophong);
        }

        private string nhanvienbuongphong;
        public string NHANVIENBUONGPHONG
        {
            get { return nhanvienbuongphong; }
            set { nhanvienbuongphong = value; }
        }

        private string nhanvienletan;
        public string NHANVIENLETAN
        {
            get { return nhanvienletan; }
            set { nhanvienletan = value; }
        }

        private int soluong;
        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private string thoigianketthuc;
        public string THOIGIANKETTHUC
        {
            get { return thoigianketthuc; }
            set { thoigianketthuc = value; }
        }

        private string thoigianbatdau;
        public string THOIGIANBATDAU
        {
            get { return thoigianbatdau; }
            set { thoigianbatdau = value; }
        }

        private string madichvu;
        public string MADICHVU
        {
            get { return madichvu; }
            set { madichvu = value; }
        }

        private string sophong;
        public string SOPHONG
        {
            get { return sophong; }
            set { sophong = value; }
        }
    }
}
