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
    public partial class fLeTan : Form
    { 
        public fLeTan()
        {
            InitializeComponent();
        }

        private void FormLeTan_Load(object sender, EventArgs e)
        {
            ucDatPhong1.Show();
            ucCheckIn1.Hide();
            ucCheckOut1.Hide();
            ucDangKyDV1.Hide();
            ucDangKyTourDuLich1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucDatPhong1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Show();
            ucCheckIn1.Hide();
            ucCheckOut1.Hide();
            ucDangKyDV1.Hide();
            ucDangKyTourDuLich1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucDatPhong1.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Hide();
            ucCheckIn1.Show();
            ucCheckOut1.Hide();
            ucDangKyDV1.Hide();
            ucDangKyTourDuLich1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucCheckIn1.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Hide();
            ucCheckIn1.Hide();
            ucCheckOut1.Hide();
            ucDangKyDV1.Show();
            ucDangKyTourDuLich1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucDangKyDV1.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Hide();
            ucCheckIn1.Hide();
            ucCheckOut1.Hide();
            ucDangKyDV1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucDangKyTourDuLich1.Show();
            ucDangKyTourDuLich1.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Hide();
            ucCheckIn1.Hide();
            ucCheckOut1.Show();
            ucDangKyDV1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucDangKyTourDuLich1.Hide();
            ucCheckOut1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Hide();
            ucCheckIn1.Hide();
            ucCheckOut1.Hide();
            ucDangKyDV1.Hide();
            //ucDangKyTourDuLich1.Hide();
            ucInPhieuVanChuyen1.Hide();
            ucGhiNhanGopY1.Show();
            ucGhiNhanGopY1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;

            ucDatPhong1.Hide();
            ucCheckIn1.Hide();
            ucCheckOut1.Hide();
            ucDangKyDV1.Hide();
            ucDangKyTourDuLich1.Hide();
            ucInPhieuVanChuyen1.Show();
            ucInPhieuVanChuyen1.BringToFront();
        }

        private void đăngXuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
