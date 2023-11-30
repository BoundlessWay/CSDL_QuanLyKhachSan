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
    public partial class UCCheckOut : UserControl
    {
        public UCCheckOut()
        {
            InitializeComponent();
        }

        private void cbSoPhong_Click(object sender, EventArgs e)
        {
            LoadPhongDangChoThueHoacDaKTIntoCombobox(cbSoPhong);
            cbSoPhong.SelectedItem = null;
        }

        void LoadPhongDangChoThueHoacDaKTIntoCombobox(ComboBox cb)
        {
            cb.DataSource = Phong.getMaPhongDangChoThueHoacDaKT();
            cb.DisplayMember = "SoPhong";
        }

        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvThongTin.DataSource = ThongTin.LoadThongtin(cbSoPhong.Text);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(cbSoPhong.Text == "")
            {
                MessageBox.Show("Chưa chọn phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Phong.CapNhatTinhTrangPhong(cbSoPhong.Text))
            {
                MessageBox.Show("Cập nhật tình trạng thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cbSoPhong.Text == "")
            {
                MessageBox.Show("Chưa chọn phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fThanhToan.sophong = cbSoPhong.Text;
            fThanhToan fthanhtoan = new fThanhToan();
            this.Hide();
            fthanhtoan.ShowDialog();
            this.Show();
            LoadPhongDangChoThueHoacDaKTIntoCombobox(cbSoPhong);
        }
    }
}
