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
    public partial class UCInPhieuVanChuyen : UserControl
    {
        public UCInPhieuVanChuyen()
        {
            InitializeComponent();
            getInfo();
        }

        private void getInfo()
        {
            DataRow row = KhachHang_Phong.getKhachHang_PhongVuaDangKi();
            if (row is null) return;
            else
            {
                this.tb_customer.Text = row[0].ToString();
                this.tb_room.Text = row[1].ToString();
                this.tb_time.Text = row[2].ToString();
                this.cb_bellman.Enabled = true;
                this.tb_count.Enabled = true;
                this.tb_detail.Enabled = true;
                this.lb_nofi.Text = "";
                DataTable data = NhanVien.getMaBellman();
                this.cb_bellman.DataSource = data;
                this.cb_bellman.DisplayMember = "MaNhanVien";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.lb_nofi.Text != "") MessageBox.Show("Chưa có khách hàng đăng kí phòng");
            else
            {
                string makh = this.tb_customer.Text;
                string sophong = this.tb_room.Text;
                string time = this.tb_time.Text;
                string mabellman = this.cb_bellman.Text;
                int soluong = int.Parse(this.tb_count.Text);
                string mota = this.tb_detail.Text;
                if (!PhieuVanChuyen.checkExist(makh, sophong, time))
                {
                    MessageBox.Show("Hành lý của khách hàng đã được vận chuyển lên phòng");
                }
                else
                {

                    PhieuVanChuyen.AddPhieuVanChuyen(makh, sophong, time, mabellman, soluong, mota);
                    MessageBox.Show("Lập và in phiếu thành công");
                }

            }
        }
    }
}
