
namespace QuanLyQuanCafe
{
    partial class fBuongPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucnangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themdichvuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLapBienBan = new System.Windows.Forms.Button();
            this.txbMaBienBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblvatdung = new System.Windows.Forms.Label();
            this.flpItem = new System.Windows.Forms.FlowLayoutPanel();
            this.txbNhanXet = new System.Windows.Forms.TextBox();
            this.dtpkThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txbNhanVien = new System.Windows.Forms.TextBox();
            this.txbSoPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucnangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucnangToolStripMenuItem
            // 
            this.chucnangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themdichvuToolStripMenuItem,
            this.đăngXuátToolStripMenuItem});
            this.chucnangToolStripMenuItem.Name = "chucnangToolStripMenuItem";
            this.chucnangToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chucnangToolStripMenuItem.Text = "Chức năng";
            // 
            // themdichvuToolStripMenuItem
            // 
            this.themdichvuToolStripMenuItem.Name = "themdichvuToolStripMenuItem";
            this.themdichvuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themdichvuToolStripMenuItem.Text = "Thêm dịch vụ";
            this.themdichvuToolStripMenuItem.Click += new System.EventHandler(this.themdichvuToolStripMenuItem_Click);
            // 
            // đăngXuátToolStripMenuItem
            // 
            this.đăngXuátToolStripMenuItem.Name = "đăngXuátToolStripMenuItem";
            this.đăngXuátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuátToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuátToolStripMenuItem.Click += new System.EventHandler(this.đăngXuátToolStripMenuItem_Click);
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Location = new System.Drawing.Point(13, 27);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(336, 410);
            this.flpRoom.TabIndex = 4;
            // 
            // btnLapBienBan
            // 
            this.btnLapBienBan.Location = new System.Drawing.Point(244, 364);
            this.btnLapBienBan.Name = "btnLapBienBan";
            this.btnLapBienBan.Size = new System.Drawing.Size(99, 36);
            this.btnLapBienBan.TabIndex = 5;
            this.btnLapBienBan.Text = "Lập biên bản";
            this.btnLapBienBan.UseVisualStyleBackColor = true;
            this.btnLapBienBan.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // txbMaBienBan
            // 
            this.txbMaBienBan.Location = new System.Drawing.Point(140, 15);
            this.txbMaBienBan.Name = "txbMaBienBan";
            this.txbMaBienBan.Size = new System.Drawing.Size(100, 20);
            this.txbMaBienBan.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã biên bản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblvatdung);
            this.panel1.Controls.Add(this.flpItem);
            this.panel1.Controls.Add(this.txbNhanXet);
            this.panel1.Controls.Add(this.dtpkThoiGian);
            this.panel1.Controls.Add(this.txbNhanVien);
            this.panel1.Controls.Add(this.txbSoPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLapBienBan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbMaBienBan);
            this.panel1.Location = new System.Drawing.Point(355, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 410);
            this.panel1.TabIndex = 8;
            // 
            // lblvatdung
            // 
            this.lblvatdung.AutoSize = true;
            this.lblvatdung.Location = new System.Drawing.Point(40, 156);
            this.lblvatdung.Name = "lblvatdung";
            this.lblvatdung.Size = new System.Drawing.Size(88, 13);
            this.lblvatdung.TabIndex = 17;
            this.lblvatdung.Text = "Vật dụng bị hỏng";
            // 
            // flpItem
            // 
            this.flpItem.Location = new System.Drawing.Point(14, 183);
            this.flpItem.Name = "flpItem";
            this.flpItem.Size = new System.Drawing.Size(555, 175);
            this.flpItem.TabIndex = 16;
            // 
            // txbNhanXet
            // 
            this.txbNhanXet.Location = new System.Drawing.Point(140, 121);
            this.txbNhanXet.Name = "txbNhanXet";
            this.txbNhanXet.Size = new System.Drawing.Size(379, 20);
            this.txbNhanXet.TabIndex = 15;
            // 
            // dtpkThoiGian
            // 
            this.dtpkThoiGian.Location = new System.Drawing.Point(319, 15);
            this.dtpkThoiGian.Name = "dtpkThoiGian";
            this.dtpkThoiGian.Size = new System.Drawing.Size(200, 20);
            this.dtpkThoiGian.TabIndex = 14;
            // 
            // txbNhanVien
            // 
            this.txbNhanVien.Location = new System.Drawing.Point(140, 65);
            this.txbNhanVien.Name = "txbNhanVien";
            this.txbNhanVien.ReadOnly = true;
            this.txbNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txbNhanVien.TabIndex = 13;
            // 
            // txbSoPhong
            // 
            this.txbSoPhong.Location = new System.Drawing.Point(320, 65);
            this.txbSoPhong.Name = "txbSoPhong";
            this.txbSoPhong.Size = new System.Drawing.Size(82, 20);
            this.txbSoPhong.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhận xét chung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhân viên kiểm tra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số phòng";
            // 
            // fBuongPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpRoom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fBuongPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buồng phòng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucnangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themdichvuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuátToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Button btnLapBienBan;
        private System.Windows.Forms.TextBox txbMaBienBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNhanXet;
        private System.Windows.Forms.DateTimePicker dtpkThoiGian;
        private System.Windows.Forms.TextBox txbNhanVien;
        private System.Windows.Forms.TextBox txbSoPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpItem;
        private System.Windows.Forms.Label lblvatdung;
    }
}