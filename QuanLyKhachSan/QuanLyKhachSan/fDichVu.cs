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
    public partial class fDichVu : Form
    {
        public static string taikhoan;
        public fDichVu()
        {
            InitializeComponent();
            txbNhanVien.Text = taikhoan;
            LoadPhongDangChoThueIntoCombobox(cbSoPhong);
        }

        void LoadPhongDangChoThueIntoCombobox(ComboBox cb)
        {
            cb.DataSource = Phong.getMaPhongDangChoThue();
            cb.DisplayMember = "SoPhong";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbDichVu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sophong = cbSoPhong.Text;
            string thoigianbatdau = dtpkBatDau.Value.ToString().Substring(0, 19);
            string thoigianketthuc = dtpkKetThuc.Value.ToString().Substring(0, 19);
            int soluong = int.Parse(nmSoLuong.Value.ToString());
            string nhanvienthuchien = txbNhanVien.Text;
            string madichvu = DichVu.getMaDV(cbDichVu.Text);

            DangKyDichVu dkdv = new DangKyDichVu(sophong, madichvu, thoigianbatdau, thoigianketthuc, soluong, "", nhanvienthuchien);

            if (DangKyDichVu.ThemDangKyDichVuBP(dkdv))
            {
                MessageBox.Show("Thêm phiếu sử dụng thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }
    }
}
