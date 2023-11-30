using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fBuongPhong : Form
    {
        public static string taikhoan;
        string nhungvatdung = "";
        public fBuongPhong()
        {
            InitializeComponent();
            LoadRoom();
            txbNhanVien.Text = taikhoan;
        }

        #region Method
        void LoadRoom()
        {
            flpRoom.Controls.Clear();
            List<Phong> roomList = Phong.getPhong();
            foreach (Phong item in roomList)
            {
                Button btn = new Button() { Width = PhongDAO.TableWidth, Height = PhongDAO.TableHeight };
                btn.Text = item.SOPHONG + Environment.NewLine + item.TINHTRANGPHONG;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TINHTRANGPHONG)
                {
                    case "Đang cho thuê":
                        btn.BackColor = Color.Tomato;
                        break;
                    case "Đợi kiểm tra":
                        btn.BackColor = Color.LightPink;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }

                flpRoom.Controls.Add(btn);
            }
        }

        void LoadItem()
        {
            flpItem.Controls.Clear();
            List<VatDung> itemList = VatDung.getItem(txbSoPhong.Text);
            foreach (VatDung item in itemList)
            {
                CheckBox chb = new CheckBox();
                chb.Text = item.TEN;
                chb.CheckedChanged += chb_Checked;
                chb.Tag = item;

                flpItem.Controls.Add(chb);
            }
        }

        #endregion
        #region Events
        void btn_Click (object sender, EventArgs e)
        {
            nhungvatdung = "";
            btnLapBienBan.Tag = (sender as Button).Tag;
            Phong room = btnLapBienBan.Tag as Phong;
            txbSoPhong.Text = room.SOPHONG;
            
            // Load Item có trong phòng
            LoadItem();
            //int tableID = ((sender as Button).Tag as Table).ID;
        }

        void chb_Checked(object sender, EventArgs e)
        {
            lblvatdung.Tag = (sender as CheckBox).Tag;
            VatDung vatdung = lblvatdung.Tag as VatDung;
            if (nhungvatdung.Contains(vatdung.TEN)==false)
            {
                nhungvatdung += vatdung.TEN;
                nhungvatdung += "x";
            }
        }

        private void đăngXuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themdichvuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDichVu f = new fDichVu();
            f.ShowDialog();
        }
        #endregion

        private void btnLap_Click(object sender, EventArgs e)
        {
            Phong room = btnLapBienBan.Tag as Phong;
            string id;
            string status;
            if (room == null)
            {
                id = "";
                status = "";
            }
            else
            {
                id = room.SOPHONG;
                status = room.TINHTRANGPHONG;
            }
            if (id != "" && status == "Đợi kiểm tra")
            {
                string mabienban = txbMaBienBan.Text;
                if(mabienban == "")
                {
                    MessageBox.Show("Mã biên bản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nhanvienkiemtra = txbNhanVien.Text;
                string thoigiankiemtra = dtpkThoiGian.Value.ToString().Substring(0, 19);
                string sophong = txbSoPhong.Text;
                string nhanxetchung = txbNhanXet.Text;

                BienBan bb = new BienBan(mabienban, sophong, nhanvienkiemtra, thoigiankiemtra, nhanxetchung);

                if(BienBan.ThemBienBan(bb))
                {
                    MessageBox.Show("Thêm biên bản thành công");
                    LoadRoom();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
                string[] vatdung = nhungvatdung.Split('x');
                for (int i = 0; i < vatdung.Length - 1; i++)
                {
                    ChiTietBienBanKiemTraPhong ct = new ChiTietBienBanKiemTraPhong(mabienban, VatDung.getMaVD(vatdung[i]));
                    ChiTietBienBanKiemTraPhong.ThemChiTietBienBan(ct);
                }
            }
            else
            {
                if (id == "")
                {
                    MessageBox.Show("Bạn chưa chọn phòng để lập biên bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Phòng chưa có tình trạng là \"Đợi kiểm tra\"", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
