
namespace QuanLyQuanCafe
{
    partial class UCGhiNhanGopY
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
            this.txbMaPhieu = new System.Windows.Forms.TextBox();
            this.txbNoiDung = new System.Windows.Forms.TextBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpkThoiGian = new System.Windows.Forms.DateTimePicker();
            this.nmMucDoHaiLong = new System.Windows.Forms.NumericUpDown();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.dtgvGopY = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmMucDoHaiLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGopY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi nhận góp ý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mức độ hài lòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời gian ghi nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khách hàng";
            // 
            // txbMaPhieu
            // 
            this.txbMaPhieu.Location = new System.Drawing.Point(253, 53);
            this.txbMaPhieu.Name = "txbMaPhieu";
            this.txbMaPhieu.Size = new System.Drawing.Size(100, 20);
            this.txbMaPhieu.TabIndex = 7;
            // 
            // txbNoiDung
            // 
            this.txbNoiDung.Location = new System.Drawing.Point(253, 97);
            this.txbNoiDung.Name = "txbNoiDung";
            this.txbNoiDung.Size = new System.Drawing.Size(364, 20);
            this.txbNoiDung.TabIndex = 8;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(253, 234);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(121, 21);
            this.cbMaKH.TabIndex = 9;
            // 
            // dtpkThoiGian
            // 
            this.dtpkThoiGian.Location = new System.Drawing.Point(253, 190);
            this.dtpkThoiGian.Name = "dtpkThoiGian";
            this.dtpkThoiGian.Size = new System.Drawing.Size(200, 20);
            this.dtpkThoiGian.TabIndex = 10;
            // 
            // nmMucDoHaiLong
            // 
            this.nmMucDoHaiLong.Location = new System.Drawing.Point(253, 140);
            this.nmMucDoHaiLong.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmMucDoHaiLong.Name = "nmMucDoHaiLong";
            this.nmMucDoHaiLong.Size = new System.Drawing.Size(120, 20);
            this.nmMucDoHaiLong.TabIndex = 11;
            this.nmMucDoHaiLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(317, 283);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(93, 36);
            this.btnGhiNhan.TabIndex = 12;
            this.btnGhiNhan.Text = "Ghi Nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.btnGhiNhan_Click);
            // 
            // dtgvGopY
            // 
            this.dtgvGopY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGopY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGopY.Location = new System.Drawing.Point(4, 338);
            this.dtgvGopY.Name = "dtgvGopY";
            this.dtgvGopY.Size = new System.Drawing.Size(712, 150);
            this.dtgvGopY.TabIndex = 15;
            // 
            // UCGhiNhanGopY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvGopY);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.nmMucDoHaiLong);
            this.Controls.Add(this.dtpkThoiGian);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.txbNoiDung);
            this.Controls.Add(this.txbMaPhieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCGhiNhanGopY";
            this.Size = new System.Drawing.Size(719, 488);
            ((System.ComponentModel.ISupportInitialize)(this.nmMucDoHaiLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGopY)).EndInit();
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
        private System.Windows.Forms.TextBox txbMaPhieu;
        private System.Windows.Forms.TextBox txbNoiDung;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.DateTimePicker dtpkThoiGian;
        private System.Windows.Forms.NumericUpDown nmMucDoHaiLong;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.DataGridView dtgvGopY;
    }
}
