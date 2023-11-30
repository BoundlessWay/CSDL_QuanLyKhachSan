using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fThanhToan : Form
    {
        public static string taikhoan;
        public static string sophong;
        string soluongdv = "";
        public fThanhToan()
        {
            InitializeComponent();
            txbNhanVien.Text = taikhoan;
            txbSoPhong.Text = sophong;
            txbTienPhong.Text = Phong.laytienphong(sophong);
            dtgvDichVuSuDung.DataSource = Phong.LoadDichVuCuaPhong(sophong);
            for(int i = 0; i < dtgvDichVuSuDung.Rows.Count - 1; i++)
            {
                int soluong = int.Parse(dtgvDichVuSuDung.Rows[i].Cells[2].Value.ToString());
                soluongdv += soluong.ToString();
                soluongdv += "x";
            }
            dtgvBienBan.DataSource = Phong.LoadVatDungHu(BienBan.getMaBB(sophong));
            int tiencanthanhtoan = int.Parse(Phong.TinhTienDV(sophong).ToString());
            txbTienVatDungHu.Text = Phong.TinhTienVatDungHu(BienBan.getMaBB(sophong)).ToString();
            int tienvatdunghu = int.Parse(txbTienVatDungHu.Text);
            int tongtien = tiencanthanhtoan + tienvatdunghu;
            txbTienCanThanhToan.Text = tongtien.ToString();
            txbTongTien.Text = (int.Parse(txbTienCanThanhToan.Text) + int.Parse(txbTienPhong.Text)*0.3).ToString();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (txbMaHoaDon.Text == "")
            {
                MessageBox.Show("Mã hóa đơn không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mahoadon = txbMaHoaDon.Text;
            string sophong = txbSoPhong.Text;
            string mavoucher = txbVoucher.Text;
            //string thoigian = dtpkThoiGian.Value.ToString("MM-dd-yyyy");
            string thoigian = dtpkThoiGian.Value.ToString().Substring(0, 19);
            int tongtien = int.Parse(txbTongTien.Text);
            int tiencanthanhtoan = int.Parse(txbTienCanThanhToan.Text);
            string mabienban = BienBan.getMaBB(sophong);
            string nvletan = txbNhanVien.Text;

            HoaDon h = new HoaDon(mahoadon, sophong, mavoucher, thoigian, tongtien, tiencanthanhtoan, mabienban, nvletan);

            if (HoaDon.ThemHoaDon(h))
            {
                MessageBox.Show("Tạo hóa đơn thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi tạo");
            }

            bool check = false;
            DataTable result = ChiTietHoaDon.LoadMaDichVuCuaPhong(sophong);
            if (result.Rows.Count == 0)
            {
                return;
            }

            string[] soluong = soluongdv.Split('x');
            for (int i = 0; i < result.Rows.Count; i++)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon(txbMaHoaDon.Text, txbSoPhong.Text, result.Rows[i].ItemArray[0].ToString(), int.Parse(soluong[i]));
                if (ChiTietHoaDon.ThemChiTietHoaDon(cthd))
                {
                    check = true;
                }
            }
            if (check == true)
            {
                MessageBox.Show("Tạo chi tiết hóa đơn thành công");
            }
            else
            {
                MessageBox.Show("Tạo chi tiết hóa đơn thất bại");
            }
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            string mavoucher = txbVoucher.Text;
            if (Voucher.kiemtravoucher(mavoucher).Rows.Count > 0)
            {
                int tien = int.Parse(txbTienCanThanhToan.Text);
                int khuyenmai = int.Parse(Voucher.kiemtravoucher(mavoucher).Rows[0].ItemArray[3].ToString());
                int tongtiencuoi = tien - khuyenmai;
                txbTienCanThanhToan.Text = tongtiencuoi.ToString();
                MessageBox.Show("Áp dụng voucher thành công");
            }
            else
            {
                MessageBox.Show("Voucher không hợp lệ");
            }
        }

        private void btnCapNhatTinhTrangHD_Click(object sender, EventArgs e)
        {
            if (HoaDon.CapNhatTinhTrangHoaDon(txbMaHoaDon.Text))
            {
                MessageBox.Show("Cập nhật tình trạng hóa đơn thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
            // Xóa bảng đăng ký dịch vụ của phòng đã thanh toán
            DangKyDichVu.XoaDangKyDichVu(sophong);
        }

        private void btnCapNhatTinhTrangPhong_Click(object sender, EventArgs e)
        {
            //if (HoaDon.CapNhatTinhTrangHoaDon(txbMaHoaDon.Text))
            if(Phong.CapNhatTinhTrangPhongCheckout(sophong))
            {
                MessageBox.Show("Cập nhật tình trạng phòng và tình trạng vệ sinh thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }
    }
}
