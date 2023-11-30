using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fVeSinh : Form
    {
        public DataTable data;
        public fVeSinh()
        {
            InitializeComponent();
            show_Room();
        }

        private void đăngXuátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_Room()
        {
            this.data = Phong.getPhongCanVeSinh();
            DataColumn checkBoxColumn = new DataColumn("CLEANED", typeof(bool));
            data.Columns.Add(checkBoxColumn);
            this.dgv_Room.DataSource = data;

            for (int i = 0; i < this.dgv_Room.Columns.Count - 1; i++)
            {
                this.dgv_Room.Columns[i].ReadOnly = true;
            }
            if (this.dgv_Room.Rows.Count < 1)
            {
                MessageBox.Show("Không có phòng nào cần vệ sinh");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgv_Room.Rows)
            {
                if (row.Cells[this.dgv_Room.Columns.Count - 1].Value.ToString() == "True")
                {
                    Phong.CapNhatTinhTrangVeSinhPhong(row.Cells[0].Value.ToString());
                }
            }
            MessageBox.Show("Cập nhật thành công");
            this.show_Room();
        }
    }
}
