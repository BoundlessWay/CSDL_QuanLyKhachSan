
namespace QuanLyQuanCafe
{
    partial class UCInPhieuVanChuyen
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
            this.cb_bellman = new System.Windows.Forms.ComboBox();
            this.lb_nofi = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_detail = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_room = new System.Windows.Forms.TextBox();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.lb_detail = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.lb_bellman = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_room = new System.Windows.Forms.Label();
            this.lb_customer = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_bellman
            // 
            this.cb_bellman.Enabled = false;
            this.cb_bellman.FormattingEnabled = true;
            this.cb_bellman.Location = new System.Drawing.Point(347, 320);
            this.cb_bellman.Margin = new System.Windows.Forms.Padding(4);
            this.cb_bellman.Name = "cb_bellman";
            this.cb_bellman.Size = new System.Drawing.Size(479, 24);
            this.cb_bellman.TabIndex = 30;
            // 
            // lb_nofi
            // 
            this.lb_nofi.AutoSize = true;
            this.lb_nofi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nofi.ForeColor = System.Drawing.Color.Red;
            this.lb_nofi.Location = new System.Drawing.Point(329, 502);
            this.lb_nofi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nofi.Name = "lb_nofi";
            this.lb_nofi.Size = new System.Drawing.Size(269, 18);
            this.lb_nofi.TabIndex = 29;
            this.lb_nofi.Text = "Chưa có khách hàng nào đăng ki phòng";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(383, 538);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(196, 41);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Lưu và in phiếu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_detail
            // 
            this.tb_detail.Enabled = false;
            this.tb_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_detail.Location = new System.Drawing.Point(347, 453);
            this.tb_detail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_detail.Name = "tb_detail";
            this.tb_detail.Size = new System.Drawing.Size(479, 26);
            this.tb_detail.TabIndex = 27;
            // 
            // tb_count
            // 
            this.tb_count.Enabled = false;
            this.tb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_count.Location = new System.Drawing.Point(347, 385);
            this.tb_count.Margin = new System.Windows.Forms.Padding(4);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(479, 26);
            this.tb_count.TabIndex = 26;
            // 
            // tb_time
            // 
            this.tb_time.Enabled = false;
            this.tb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_time.Location = new System.Drawing.Point(347, 244);
            this.tb_time.Margin = new System.Windows.Forms.Padding(4);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(479, 26);
            this.tb_time.TabIndex = 25;
            // 
            // tb_room
            // 
            this.tb_room.Enabled = false;
            this.tb_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_room.Location = new System.Drawing.Point(347, 166);
            this.tb_room.Margin = new System.Windows.Forms.Padding(4);
            this.tb_room.Name = "tb_room";
            this.tb_room.Size = new System.Drawing.Size(479, 26);
            this.tb_room.TabIndex = 24;
            // 
            // tb_customer
            // 
            this.tb_customer.Enabled = false;
            this.tb_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer.Location = new System.Drawing.Point(347, 91);
            this.tb_customer.Margin = new System.Windows.Forms.Padding(4);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(479, 26);
            this.tb_customer.TabIndex = 23;
            // 
            // lb_detail
            // 
            this.lb_detail.AutoSize = true;
            this.lb_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detail.Location = new System.Drawing.Point(114, 456);
            this.lb_detail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_detail.Name = "lb_detail";
            this.lb_detail.Size = new System.Drawing.Size(121, 25);
            this.lb_detail.TabIndex = 22;
            this.lb_detail.Text = "Mô tả chi tiết";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.Location = new System.Drawing.Point(114, 388);
            this.lb_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(158, 25);
            this.lb_count.TabIndex = 21;
            this.lb_count.Text = "Số lượng hành lý";
            // 
            // lb_bellman
            // 
            this.lb_bellman.AutoSize = true;
            this.lb_bellman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bellman.Location = new System.Drawing.Point(114, 320);
            this.lb_bellman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_bellman.Name = "lb_bellman";
            this.lb_bellman.Size = new System.Drawing.Size(205, 25);
            this.lb_bellman.TabIndex = 20;
            this.lb_bellman.Text = "Mã nhân viên Bellman";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(114, 246);
            this.lb_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(93, 25);
            this.lb_time.TabIndex = 19;
            this.lb_time.Text = "Thời gian";
            // 
            // lb_room
            // 
            this.lb_room.AutoSize = true;
            this.lb_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_room.Location = new System.Drawing.Point(114, 169);
            this.lb_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_room.Name = "lb_room";
            this.lb_room.Size = new System.Drawing.Size(100, 25);
            this.lb_room.TabIndex = 18;
            this.lb_room.Text = "Mã phòng";
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customer.Location = new System.Drawing.Point(114, 94);
            this.lb_customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(147, 25);
            this.lb_customer.TabIndex = 17;
            this.lb_customer.Text = "Mã khách hàng";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(218, 21);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(528, 29);
            this.lb_title.TabIndex = 16;
            this.lb_title.Text = "THÔNG TIN PHIẾU VÂN CHUYỂN HÀNH LÝ";
            // 
            // UCInPhieuVanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_bellman);
            this.Controls.Add(this.lb_nofi);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_detail);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_room);
            this.Controls.Add(this.tb_customer);
            this.Controls.Add(this.lb_detail);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lb_bellman);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_room);
            this.Controls.Add(this.lb_customer);
            this.Controls.Add(this.lb_title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCInPhieuVanChuyen";
            this.Size = new System.Drawing.Size(959, 601);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_bellman;
        private System.Windows.Forms.Label lb_nofi;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_detail;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_room;
        private System.Windows.Forms.TextBox tb_customer;
        private System.Windows.Forms.Label lb_detail;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label lb_bellman;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_room;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label lb_title;
    }
}
