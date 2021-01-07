
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmKhachHang
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tctMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.EraseIcon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(565, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 63);
            this.btnXoa.TabIndex = 101;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(948, 227);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(236, 22);
            this.txtTimKiem.TabIndex = 121;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(1113, 25);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(236, 22);
            this.txtTinhTrang.TabIndex = 121;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1015, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 117;
            this.label15.Text = "Tình trạng";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyBo.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ExitIcon1;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(429, 189);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(96, 63);
            this.btnHuyBo.TabIndex = 105;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.SaveIcon;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(701, 189);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 63);
            this.btnLuu.TabIndex = 104;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReLoad.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ReloadIcon;
            this.btnReLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(31, 189);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(96, 63);
            this.btnReLoad.TabIndex = 103;
            this.btnReLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.repairIcon;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(292, 189);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 63);
            this.btnSua.TabIndex = 100;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.addIcon1;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(165, 189);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 63);
            this.btnThem.TabIndex = 102;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(207, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(317, 22);
            this.txtDiaChi.TabIndex = 124;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(697, 64);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(206, 22);
            this.txtCMND.TabIndex = 123;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(207, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(317, 22);
            this.txtTen.TabIndex = 120;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(208, 22);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(317, 22);
            this.txtMa.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(612, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 116;
            this.label12.Text = "Giới tính";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 115;
            this.label11.Text = "Địa chỉ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "SDT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 114;
            this.label7.Text = "CMND";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tctMatKhau
            // 
            this.tctMatKhau.AutoSize = true;
            this.tctMatKhau.Location = new System.Drawing.Point(159, 66);
            this.tctMatKhau.Name = "tctMatKhau";
            this.tctMatKhau.Size = new System.Drawing.Size(33, 17);
            this.tctMatKhau.TabIndex = 113;
            this.tctMatKhau.Text = "Tên";
            this.tctMatKhau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Mã khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(453, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 111;
            this.label10.Text = "Hủy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(734, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 110;
            this.label9.Text = "Lưu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(598, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 109;
            this.label4.Text = "Xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(173, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 108;
            this.label3.Text = "Thêm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(307, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 107;
            this.label8.Text = "Sửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(41, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 106;
            this.label5.Text = "ReLoad";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_KH,
            this.HOTEN_KH,
            this.DIACHI_KH,
            this.SDT_KH,
            this.CMND_KH,
            this.GIOITINH_KH,
            this.TINHTRANG});
            this.dgvKhachHang.Location = new System.Drawing.Point(4, 279);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1430, 362);
            this.dgvKhachHang.TabIndex = 99;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            // 
            // MA_KH
            // 
            this.MA_KH.DataPropertyName = "MA_KH";
            this.MA_KH.HeaderText = "Mã khách hàng";
            this.MA_KH.MinimumWidth = 6;
            this.MA_KH.Name = "MA_KH";
            // 
            // HOTEN_KH
            // 
            this.HOTEN_KH.DataPropertyName = "HOTEN_KH";
            this.HOTEN_KH.HeaderText = "Tên";
            this.HOTEN_KH.MinimumWidth = 6;
            this.HOTEN_KH.Name = "HOTEN_KH";
            // 
            // DIACHI_KH
            // 
            this.DIACHI_KH.DataPropertyName = "DIACHI_KH";
            this.DIACHI_KH.HeaderText = "Địa chỉ";
            this.DIACHI_KH.MinimumWidth = 6;
            this.DIACHI_KH.Name = "DIACHI_KH";
            // 
            // SDT_KH
            // 
            this.SDT_KH.DataPropertyName = "SDT_KH";
            this.SDT_KH.HeaderText = "SDT";
            this.SDT_KH.MinimumWidth = 6;
            this.SDT_KH.Name = "SDT_KH";
            // 
            // CMND_KH
            // 
            this.CMND_KH.DataPropertyName = "CMND_KH";
            this.CMND_KH.HeaderText = "CMND";
            this.CMND_KH.MinimumWidth = 6;
            this.CMND_KH.Name = "CMND_KH";
            // 
            // GIOITINH_KH
            // 
            this.GIOITINH_KH.DataPropertyName = "GIOITINH_KH";
            this.GIOITINH_KH.HeaderText = "Giới tính";
            this.GIOITINH_KH.MinimumWidth = 6;
            this.GIOITINH_KH.Name = "GIOITINH_KH";
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.MinimumWidth = 6;
            this.TINHTRANG.Name = "TINHTRANG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(830, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 126;
            this.label6.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.FineIcon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(829, 189);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 63);
            this.btnTimKiem.TabIndex = 127;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinh.Location = new System.Drawing.Point(697, 109);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(206, 24);
            this.txtGioiTinh.TabIndex = 131;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(697, 24);
            this.txtSDT.Mask = "0000 000 000";
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(206, 22);
            this.txtSDT.TabIndex = 132;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1443, 664);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tctMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvKhachHang);
            this.KeyPreview = true;
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKhachHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tctMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox txtGioiTinh;
        private System.Windows.Forms.MaskedTextBox txtSDT;
    }
}