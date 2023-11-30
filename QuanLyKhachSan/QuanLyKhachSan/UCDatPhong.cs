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
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class UCDatPhong : UserControl
    {
        public UCDatPhong()
        {
            InitializeComponent();
        }

        private void BtnDatPhong_Click(object sender, EventArgs e)
        {
            String MaPhieu;
            String TenNguoidangKy;
            String CMND;
            String SDT;
            String SoPhong;
            String LoaiPhong;
            int SoNguoi;
            int SoDemLuuTru;
            String YeuCauDacBiet;
            String TenDoan;
            String DiaChi;
            String TienThanhToan30Text;
            String NgayDen;
            Int32 TienThanhToan30;

            MaPhieu = MaPhieuDKDatPhong.Text;
            TenNguoidangKy = TenNguoiDkyDatPhong.Text;
            CMND = CMNDDatPhong.Text;
            SDT = SDTDatPhong.Text;
            LoaiPhong = LPDatPhong.Text;
            SoNguoi = int.Parse(SoNguoiDangKyDatPhong.Text);
            SoDemLuuTru = int.Parse(SodemDatPhong.Text);
            YeuCauDacBiet = YeuCauDacBietDatPhong.Text;
            TenDoan = TenDoanDatPhong.Text;
            DiaChi = textBoxDiaChi.Text;
            SoPhong = soPhongDatphong.Text;
            NgayDen = dtpNgayDen.Value.ToString("MM-dd-yyyy");

            DataTable CheckIsExitSoPhong = Phong.CheckSoPhong(SoPhong);
            DataTable CheckPhieuDangKy = PhieuDangKy.CheckPhieu(MaPhieu);
            if (CheckIsExitSoPhong.Rows.Count > 0)
            {
                if (CheckPhieuDangKy.Rows.Count > 0)
                {
                    MessageBox.Show("Phiếu đăng ký đã tồn tại");
                }
                else
                {
                    TienThanhToan30Text = Phong.DocGiaPhong(SoPhong);
                    TienThanhToan30 = Convert.ToInt32(TienThanhToan30Text);
                    TienThanhToan30 = (TienThanhToan30 / 100) * 30;
                    KhachHang kh = new KhachHang(CMND, TenNguoidangKy, SDT, DiaChi);
                    KhachHang.ThemKhachHang(kh);

                    KhachHang_Phong khp = new KhachHang_Phong(CMND, SoPhong, NgayDen);
                    KhachHang_Phong.ThemKhachHang_Phong(khp);
                    
                    Phong.CapNhatPhong(SoPhong);

                    PhieuDangKy p = new PhieuDangKy(MaPhieu, CMND, LoaiPhong, SoNguoi, TenDoan, NgayDen, SoDemLuuTru, YeuCauDacBiet, TienThanhToan30, 0);
                    int result = PhieuDangKy.ThemPhieuDangKy(p);
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm Đặt phòng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Đặt phòng thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Số phòng không tồn tại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data;
            if (SoNguoiDangKyDatPhong.Text != "")
            {
                if (LPDatPhong.Text == "")
                {
                    data = Phong.DocThongTinPhong1(SoNguoiDangKyDatPhong.Text);
                }
                else
                {
                    data = Phong.DocThongTinPhong2(LPDatPhong.Text, SoNguoiDangKyDatPhong.Text);
                }

            }
            else
            {
                if (LPDatPhong.Text == "")
                {
                    data = Phong.DocThongTinPhong3();
                }
                else
                {
                    data = Phong.DocThongTinPhong4(LPDatPhong.Text);
                }

            }

            dgvDatPhong.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = PhieuDangKy.DocPhieuDangKy();
            dgvDatPhong.DataSource = data;
        }

        private void checkBoxDKDoan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDKDoan.Checked == true)
            {
                TenDoanDatPhong.Enabled = true;
                label8.Enabled = true;
            }
            else
            {
                TenDoanDatPhong.Enabled = false;
                label8.Enabled = false;
            }
        }
    }
}
