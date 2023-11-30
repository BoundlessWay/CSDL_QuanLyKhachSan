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
    public partial class UCGhiNhanGopY : UserControl
    {
        public UCGhiNhanGopY()
        {
            InitializeComponent();
            LoadPhongIntoCombobox(cbMaKH);
            LoadGopy();
        }

        void LoadGopy()
        {
            dtgvGopY.DataSource = PhieuGopY.getGopY();
        }


        void LoadPhongIntoCombobox(ComboBox cb)
        {
            cb.DataSource = KhachHang.getMaKH();
            cb.DisplayMember = "CCCD";
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (txbMaPhieu.Text == "")
            {
                MessageBox.Show("Mã phiếu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string maphieu = txbMaPhieu.Text;
            string noidung = txbNoiDung.Text;
            int mucdohailong = int.Parse(nmMucDoHaiLong.Value.ToString());
            string thoigianghinhan = dtpkThoiGian.Value.ToString().Substring(0, 19);
            string khachhang = cbMaKH.Text;

            PhieuGopY phieu = new PhieuGopY(maphieu, noidung, mucdohailong, thoigianghinhan, khachhang);

            if(PhieuGopY.ThemPhieuGopY(phieu))
            {
                MessageBox.Show("Ghi nhận góp ý thành công");
                LoadGopy();
            }
            else
            {
                MessageBox.Show("Có lỗi khi ghi nhận");
            }
        }
    }
}
