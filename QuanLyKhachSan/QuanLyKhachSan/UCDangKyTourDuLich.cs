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
    public partial class UCDangKyTourDuLich : UserControl
    {
        public UCDangKyTourDuLich()
        {
            InitializeComponent();
            LoadPhongDangChoThueIntoCombobox(cbSoPhong);
        }

        void LoadPhongDangChoThueIntoCombobox(ComboBox cb)
        {
            cb.DataSource = Phong.getMaPhongDangChoThue();
            cb.DisplayMember = "SoPhong";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cbMaTour.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tour", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DangKyTour d = new DangKyTour(cbSoPhong.Text, cbMaTour.Text, dtpkThoiGian.Value.ToString().Substring(0, 19));
            if (DangKyTour.ThemDangKyTour(d))
            {
                MessageBox.Show("Ghi nhận đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi ghi nhận");
            }
        }

        private void cbMaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = DoiTac.getDoiTac(cbMaTour.Text); 
            txbMaDoiTac.Text = table.Rows[0].ItemArray[0].ToString();
            txbTenCongTy.Text = table.Rows[0].ItemArray[1].ToString();
            txbNguoiDaiDien.Text = table.Rows[0].ItemArray[2].ToString();
            txbDiaChi.Text = table.Rows[0].ItemArray[3].ToString();
            txbEmail.Text = table.Rows[0].ItemArray[4].ToString();
            txbSoDienThoai.Text = table.Rows[0].ItemArray[5].ToString();
        }

        private void txbMaDoiTac_TextChanged(object sender, EventArgs e)
        {
            dtgvDoiTac.DataSource = TourDuLich.getTourDuLich(cbMaTour.Text);
        }
    }
}
