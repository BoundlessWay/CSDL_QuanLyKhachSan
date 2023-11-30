
namespace QuanLyQuanCafe
{
    partial class UCDangKyTourDuLich
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvDoiTac = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbMaTour = new System.Windows.Forms.ComboBox();
            this.txbNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.txbTenCongTy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpkThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txbMaDoiTac = new System.Windows.Forms.TextBox();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbSoDienThoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoiTac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng ký Tour du lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Tour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên người đại diện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên công ty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã đối tác";
            // 
            // dtgvDoiTac
            // 
            this.dtgvDoiTac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoiTac.Location = new System.Drawing.Point(0, 294);
            this.dtgvDoiTac.Name = "dtgvDoiTac";
            this.dtgvDoiTac.Size = new System.Drawing.Size(719, 67);
            this.dtgvDoiTac.TabIndex = 9;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(287, 415);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(104, 36);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbMaTour
            // 
            this.cbMaTour.FormattingEnabled = true;
            this.cbMaTour.Items.AddRange(new object[] {
            "T001",
            "T002",
            "T003",
            "T004"});
            this.cbMaTour.Location = new System.Drawing.Point(112, 73);
            this.cbMaTour.Name = "cbMaTour";
            this.cbMaTour.Size = new System.Drawing.Size(78, 21);
            this.cbMaTour.TabIndex = 11;
            this.cbMaTour.SelectedIndexChanged += new System.EventHandler(this.cbMaTour_SelectedIndexChanged);
            // 
            // txbNguoiDaiDien
            // 
            this.txbNguoiDaiDien.Location = new System.Drawing.Point(556, 74);
            this.txbNguoiDaiDien.Name = "txbNguoiDaiDien";
            this.txbNguoiDaiDien.ReadOnly = true;
            this.txbNguoiDaiDien.Size = new System.Drawing.Size(123, 20);
            this.txbNguoiDaiDien.TabIndex = 12;
            // 
            // txbTenCongTy
            // 
            this.txbTenCongTy.Location = new System.Drawing.Point(307, 73);
            this.txbTenCongTy.Name = "txbTenCongTy";
            this.txbTenCongTy.ReadOnly = true;
            this.txbTenCongTy.Size = new System.Drawing.Size(101, 20);
            this.txbTenCongTy.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Thời gian bắt đầu";
            // 
            // dtpkThoiGian
            // 
            this.dtpkThoiGian.Location = new System.Drawing.Point(460, 222);
            this.dtpkThoiGian.Name = "dtpkThoiGian";
            this.dtpkThoiGian.Size = new System.Drawing.Size(200, 20);
            this.dtpkThoiGian.TabIndex = 19;
            // 
            // txbMaDoiTac
            // 
            this.txbMaDoiTac.Location = new System.Drawing.Point(112, 128);
            this.txbMaDoiTac.Name = "txbMaDoiTac";
            this.txbMaDoiTac.ReadOnly = true;
            this.txbMaDoiTac.Size = new System.Drawing.Size(78, 20);
            this.txbMaDoiTac.TabIndex = 20;
            this.txbMaDoiTac.TextChanged += new System.EventHandler(this.txbMaDoiTac_TextChanged);
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(223, 222);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(61, 21);
            this.cbSoPhong.TabIndex = 21;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(307, 132);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.ReadOnly = true;
            this.txbDiaChi.Size = new System.Drawing.Size(372, 20);
            this.txbDiaChi.TabIndex = 22;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(112, 179);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(152, 20);
            this.txbEmail.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email";
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Location = new System.Drawing.Point(542, 181);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.ReadOnly = true;
            this.txbSoDienThoai.Size = new System.Drawing.Size(137, 20);
            this.txbSoDienThoai.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Số điện thoại";
            // 
            // UCDangKyTourDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbSoDienThoai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.cbSoPhong);
            this.Controls.Add(this.txbMaDoiTac);
            this.Controls.Add(this.dtpkThoiGian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbTenCongTy);
            this.Controls.Add(this.txbNguoiDaiDien);
            this.Controls.Add(this.cbMaTour);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dtgvDoiTac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDangKyTourDuLich";
            this.Size = new System.Drawing.Size(719, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoiTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvDoiTac;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cbMaTour;
        private System.Windows.Forms.TextBox txbNguoiDaiDien;
        private System.Windows.Forms.TextBox txbTenCongTy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpkThoiGian;
        private System.Windows.Forms.TextBox txbMaDoiTac;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbSoDienThoai;
        private System.Windows.Forms.Label label10;
    }
}
