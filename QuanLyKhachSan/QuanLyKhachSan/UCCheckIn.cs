using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DTO;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class UCCheckIn : UserControl
    {
        public UCCheckIn()
        {
            InitializeComponent();
        }

        private void TraCuuCheckIn_Click(object sender, EventArgs e)
        {
            String MaKh;
            String LoaiPhong;
            String SoNguoi;
            String TenDoan;
            String NgayDen;
            String SoDemLuuTru;
            String TienThanhToan30;
            String YeuCauDacBiet;
            String TinhTrangThanhToan;
            String MaPhieu = textMaPhieuDkyCheckIn.Text;

            DataTable CheckPhieuDangKy = DataProvider.Instance.ExecuteQuery("select * from PhieuDangKyPhong where MaPhieuDangKy = '" + MaPhieu + "'");
            if (CheckPhieuDangKy.Rows.Count > 0)
            {
                MaKh = PhieuDangKy.LayMaKhachHang(MaPhieu);
                LoaiPhong = PhieuDangKy.LayLoaiPhong(MaPhieu);
                SoNguoi = PhieuDangKy.LaySoNguoi(MaPhieu);
                TenDoan = PhieuDangKy.LayTenDoan(MaPhieu);
                NgayDen = PhieuDangKy.LayNgayDen(MaPhieu);
                SoDemLuuTru = PhieuDangKy.LaySoDemLuuTru(MaPhieu);
                TienThanhToan30 = PhieuDangKy.LayTienThanhToan30(MaPhieu);
                YeuCauDacBiet = PhieuDangKy.LayYeuCauDacBiet(MaPhieu);
                TinhTrangThanhToan = PhieuDangKy.LayTinhTrangThanhToan30(MaPhieu);

                MaPhieuDkyCheckIn.Text = MaPhieu;
                MAKHCheckIn.Text = MaKh;
                LoaiPhongCheckIn.Text = LoaiPhong;
                SoNguoiCheckIn.Text = SoNguoi;
                textTenDoanCheckIn.Text = TenDoan;
                textNgayDenCheckIn.Text = NgayDen;
                textSoDemLuutruCheckIn.Text = SoDemLuuTru;
                textYecCauDacDBietCheckIn.Text = YeuCauDacBiet;
                textTien30CheckIn.Text = TienThanhToan30;
                if (TinhTrangThanhToan == "1")
                {
                    checkBoxDaThanhToan.Checked = true;
                    checkBoxChuaThanhToan.Checked = false;
                    tinhTrangThanhToanText.Text = "Đã thanh toán";
                }
                else
                {
                    checkBoxDaThanhToan.Checked = false;
                    checkBoxChuaThanhToan.Checked = true;
                    tinhTrangThanhToanText.Text = "Chưa thanh toán";
                }
            }
            else
            {
                MessageBox.Show("Phiếu đăng ký không tồn tại !!!");
            }
        }

        private void BtnXacNhanThanhToan30_Click(object sender, EventArgs e)
        {
            String MaPhieu = MaPhieuDkyCheckIn.Text;
            bool DaThanhToan = checkBoxDaThanhToan.Checked;
            bool ChuaThanhToan = checkBoxChuaThanhToan.Checked;
            String kq = "";
            if (DaThanhToan == true)
            {
                kq = "1";
                tinhTrangThanhToanText.Text = "Đã thanh toán";
            }
            if (ChuaThanhToan == true)
            {
                kq = "0";
                tinhTrangThanhToanText.Text = "Chưa thanh toán";
            }
            int result = PhieuDangKy.CapNhatTinhTrangThanhToan(kq, MaPhieu);
            if (result > 0)
            {
                MessageBox.Show("Đã cập nhật thanh toán !!!");
            }
            else
            {
                MessageBox.Show("Cập nhật thanh toán thất bại !!!");
            }
        }

        private void checkBoxDaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDaThanhToan.Checked == true)
            {

                checkBoxChuaThanhToan.Enabled = false;
            }
            else
            {
                checkBoxChuaThanhToan.Enabled = true;
            }
        }

        private void checkBoxChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChuaThanhToan.Checked == true)
            {

                checkBoxDaThanhToan.Enabled = false;
            }
            else
            {
                checkBoxDaThanhToan.Enabled = true;
            }
        }
    }
}
