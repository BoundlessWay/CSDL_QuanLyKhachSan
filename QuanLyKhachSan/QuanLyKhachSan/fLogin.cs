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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            fBuongPhong.taikhoan = username;
            fDichVu.taikhoan = username;
            fThanhToan.taikhoan = username;
            UCDangKyDV.taikhoan = username;
            string password = txbPassword.Text;
            if (Account.Login(username, password))
            {
                if (Account.getRole(username) == "Lễ tân")
                {
                    fLeTan f = new fLeTan();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (Account.getRole(username) == "Buồng phòng")
                {
                    fBuongPhong f = new fBuongPhong();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (Account.getRole(username) == "Nhân viên vệ sinh")
                {
                    fVeSinh f = new fVeSinh();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
