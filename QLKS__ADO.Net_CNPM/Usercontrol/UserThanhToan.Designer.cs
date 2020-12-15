
namespace QLKS__ADO.Net_CNPM.Usercontrol
{
    partial class UserThanhToan
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDVSD = new System.Windows.Forms.DataGridView();
            this.MAHDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.tctMatKhau = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtSoNgayThue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVSD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Thông tin dịch vụ đã sử dụng";
            // 
            // dgvDVSD
            // 
            this.dgvDVSD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDVSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDVSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVSD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDDV,
            this.MAPTP,
            this.MADV,
            this.SOLUONG,
            this.THANHTEN});
            this.dgvDVSD.Location = new System.Drawing.Point(62, 66);
            this.dgvDVSD.Name = "dgvDVSD";
            this.dgvDVSD.RowHeadersWidth = 51;
            this.dgvDVSD.RowTemplate.Height = 24;
            this.dgvDVSD.Size = new System.Drawing.Size(1031, 270);
            this.dgvDVSD.TabIndex = 104;
            // 
            // MAHDDV
            // 
            this.MAHDDV.DataPropertyName = "MA_HOADONDV";
            this.MAHDDV.HeaderText = "Mã HDDV";
            this.MAHDDV.MinimumWidth = 6;
            this.MAHDDV.Name = "MAHDDV";
            // 
            // MAPTP
            // 
            this.MAPTP.DataPropertyName = "MA_PTP";
            this.MAPTP.HeaderText = "Mã PTP";
            this.MAPTP.MinimumWidth = 6;
            this.MAPTP.Name = "MAPTP";
            // 
            // MADV
            // 
            this.MADV.DataPropertyName = "MA_DV";
            this.MADV.HeaderText = "Mã DV";
            this.MADV.MinimumWidth = 6;
            this.MADV.Name = "MADV";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONGSUDUNG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // THANHTEN
            // 
            this.THANHTEN.DataPropertyName = "THANHTIEN";
            this.THANHTEN.HeaderText = "Tiền DV";
            this.THANHTEN.MinimumWidth = 6;
            this.THANHTEN.Name = "THANHTEN";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(663, 530);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(317, 22);
            this.txtGiamGia.TabIndex = 190;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(663, 573);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(317, 22);
            this.txtTongTien.TabIndex = 188;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 187;
            this.label1.Text = "Tổng tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(180, 488);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(317, 22);
            this.txtTenKH.TabIndex = 186;
            // 
            // tctMatKhau
            // 
            this.tctMatKhau.AutoSize = true;
            this.tctMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctMatKhau.Location = new System.Drawing.Point(93, 490);
            this.tctMatKhau.Name = "tctMatKhau";
            this.tctMatKhau.Size = new System.Drawing.Size(72, 20);
            this.tctMatKhau.TabIndex = 185;
            this.tctMatKhau.Text = "Tên KH";
            this.tctMatKhau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(180, 379);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(317, 22);
            this.txtMaHD.TabIndex = 197;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 196;
            this.label4.Text = "Mã hóa đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(180, 449);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(317, 22);
            this.txtMaKH.TabIndex = 195;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 194;
            this.label5.Text = "Mã khách hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMaPTP
            // 
            this.txtMaPTP.Location = new System.Drawing.Point(180, 416);
            this.txtMaPTP.Name = "txtMaPTP";
            this.txtMaPTP.Size = new System.Drawing.Size(317, 22);
            this.txtMaPTP.TabIndex = 193;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 192;
            this.label6.Text = "Mã PTP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 198;
            this.label7.Text = "Giảm giá";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(180, 530);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(317, 22);
            this.txtNV.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 199;
            this.label8.Text = "Nhân Viên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(567, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 206;
            this.label9.Text = "Mã phòng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(663, 381);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(317, 22);
            this.txtMaPhong.TabIndex = 205;
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Location = new System.Drawing.Point(663, 416);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.Size = new System.Drawing.Size(317, 22);
            this.txtSoNgayThue.TabIndex = 204;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(531, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 203;
            this.label10.Text = "Số Ngày Thuê";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(663, 488);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(317, 22);
            this.txtTienDV.TabIndex = 202;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(540, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 201;
            this.label11.Text = "Tiền dịch vụ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTienThue
            // 
            this.txtTienThue.Location = new System.Drawing.Point(663, 451);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Size = new System.Drawing.Size(317, 22);
            this.txtTienThue.TabIndex = 208;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(559, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 207;
            this.label12.Text = "Tiền Thuê";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThanhToan.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.pay;
            this.btnThanhToan.Location = new System.Drawing.Point(915, 641);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(178, 72);
            this.btnThanhToan.TabIndex = 209;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(3, 641);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 72);
            this.btnBack.TabIndex = 210;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTienThue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtSoNgayThue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTienDV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaPTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.tctMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDVSD);
            this.Name = "UserThanhToan";
            this.Size = new System.Drawing.Size(1174, 731);
            this.Load += new System.EventHandler(this.UserThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDVSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTEN;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label tctMatKhau;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtSoNgayThue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnBack;
    }
}
