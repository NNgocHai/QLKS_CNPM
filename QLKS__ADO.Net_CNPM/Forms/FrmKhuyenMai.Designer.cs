
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmKhuyenMai
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
            this.dgvKM = new System.Windows.Forms.DataGridView();
            this.MA_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_BD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tctMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimePicker_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKM
            // 
            this.dgvKM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_KM,
            this.TEN_KM,
            this.DISCOUNT,
            this.NGAY_BD,
            this.NGAY_KT});
            this.dgvKM.Location = new System.Drawing.Point(9, 291);
            this.dgvKM.Name = "dgvKM";
            this.dgvKM.RowHeadersWidth = 51;
            this.dgvKM.RowTemplate.Height = 24;
            this.dgvKM.Size = new System.Drawing.Size(1423, 361);
            this.dgvKM.TabIndex = 119;
            this.dgvKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKM_CellClick);
            this.dgvKM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKM_CellContentClick);
            // 
            // MA_KM
            // 
            this.MA_KM.DataPropertyName = "MA_KM";
            this.MA_KM.HeaderText = "Mã Khuyến mãi";
            this.MA_KM.MinimumWidth = 6;
            this.MA_KM.Name = "MA_KM";
            // 
            // TEN_KM
            // 
            this.TEN_KM.DataPropertyName = "TEN_KM";
            this.TEN_KM.HeaderText = "Tên Khuyến Mãi";
            this.TEN_KM.MinimumWidth = 6;
            this.TEN_KM.Name = "TEN_KM";
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.DataPropertyName = "DISCOUNT";
            this.DISCOUNT.HeaderText = "Discount";
            this.DISCOUNT.MinimumWidth = 6;
            this.DISCOUNT.Name = "DISCOUNT";
            // 
            // NGAY_BD
            // 
            this.NGAY_BD.DataPropertyName = "NGAY_BD";
            this.NGAY_BD.HeaderText = "Ngày bắt đầu";
            this.NGAY_BD.MinimumWidth = 6;
            this.NGAY_BD.Name = "NGAY_BD";
            // 
            // NGAY_KT
            // 
            this.NGAY_KT.DataPropertyName = "NGAY_KT";
            this.NGAY_KT.HeaderText = "Ngày kết thúc";
            this.NGAY_KT.MinimumWidth = 6;
            this.NGAY_KT.Name = "NGAY_KT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(847, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 116;
            this.label6.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(969, 201);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 30);
            this.txtTimKiem.TabIndex = 117;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(201, 119);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(186, 22);
            this.txtDiscount.TabIndex = 115;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(201, 78);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(186, 22);
            this.txtTenKM.TabIndex = 114;
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(202, 37);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(185, 22);
            this.txtMaKM.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "Discount:";
            // 
            // tctMatKhau
            // 
            this.tctMatKhau.AutoSize = true;
            this.tctMatKhau.Location = new System.Drawing.Point(87, 78);
            this.tctMatKhau.Name = "tctMatKhau";
            this.tctMatKhau.Size = new System.Drawing.Size(37, 17);
            this.tctMatKhau.TabIndex = 111;
            this.tctMatKhau.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 110;
            this.label1.Text = "Mã Khuyến mãi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(471, 171);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 109;
            this.label10.Text = "Hủy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(752, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 108;
            this.label9.Text = "Lưu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(616, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 107;
            this.label4.Text = "Xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(191, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "Thêm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(325, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 105;
            this.label8.Text = "Sửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(59, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "ReLoad";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.FineIcon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(852, 203);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 63);
            this.btnTimKiem.TabIndex = 118;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyBo.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ExitIcon1;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(447, 201);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(96, 63);
            this.btnHuyBo.TabIndex = 103;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.SaveIcon;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(719, 201);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 63);
            this.btnLuu.TabIndex = 102;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReLoad.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ReloadIcon;
            this.btnReLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(49, 201);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(96, 63);
            this.btnReLoad.TabIndex = 101;
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
            this.btnSua.Location = new System.Drawing.Point(310, 201);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 63);
            this.btnSua.TabIndex = 98;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.EraseIcon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(583, 201);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 63);
            this.btnXoa.TabIndex = 99;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.addIcon1;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(183, 201);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 63);
            this.btnThem.TabIndex = 100;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateTimePicker_NgayBD
            // 
            this.dateTimePicker_NgayBD.Location = new System.Drawing.Point(710, 37);
            this.dateTimePicker_NgayBD.Name = "dateTimePicker_NgayBD";
            this.dateTimePicker_NgayBD.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_NgayBD.TabIndex = 120;
            // 
            // dateTimePicker_NgayKT
            // 
            this.dateTimePicker_NgayKT.Location = new System.Drawing.Point(710, 78);
            this.dateTimePicker_NgayKT.Name = "dateTimePicker_NgayKT";
            this.dateTimePicker_NgayKT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_NgayKT.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 122;
            this.label7.Text = "Ngày bắt đầu KM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(574, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 123;
            this.label11.Text = "Ngày kết thúc KM:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkOrange;
            this.label12.Location = new System.Drawing.Point(1081, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 125;
            this.label12.Text = "YYYY-MM-DD";
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1443, 664);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_NgayKT);
            this.Controls.Add(this.dateTimePicker_NgayBD);
            this.Controls.Add(this.dgvKM);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTenKM);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tctMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khuyến mãi";
            this.Load += new System.EventHandler(this.FrmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKM;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tctMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayBD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayKT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_BD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_KT;
        private System.Windows.Forms.Label label12;
    }
}