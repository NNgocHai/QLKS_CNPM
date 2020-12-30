
namespace QLKS__ADO.Net_CNPM.Usercontrol
{
    partial class UserThuePhong
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
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.txtPTP = new System.Windows.Forms.TextBox();
            this.btnPDP = new System.Windows.Forms.Button();
            this.dtNgayTraDK = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPTP = new System.Windows.Forms.DataGridView();
            this.MAPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRARDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.tctMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(233, 108);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(317, 22);
            this.txtMaPhong.TabIndex = 249;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(233, 139);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(317, 24);
            this.cbbMaKH.TabIndex = 248;
            // 
            // txtPTP
            // 
            this.txtPTP.Location = new System.Drawing.Point(233, 41);
            this.txtPTP.Name = "txtPTP";
            this.txtPTP.Size = new System.Drawing.Size(317, 22);
            this.txtPTP.TabIndex = 246;
            // 
            // btnPDP
            // 
            this.btnPDP.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.booking;
            this.btnPDP.Location = new System.Drawing.Point(576, 68);
            this.btnPDP.Name = "btnPDP";
            this.btnPDP.Size = new System.Drawing.Size(52, 54);
            this.btnPDP.TabIndex = 245;
            this.btnPDP.UseVisualStyleBackColor = true;
            this.btnPDP.Click += new System.EventHandler(this.btnPDP_Click);
            // 
            // dtNgayTraDK
            // 
            this.dtNgayTraDK.Location = new System.Drawing.Point(867, 146);
            this.dtNgayTraDK.Name = "dtNgayTraDK";
            this.dtNgayTraDK.Size = new System.Drawing.Size(200, 22);
            this.dtNgayTraDK.TabIndex = 244;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(686, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 20);
            this.label13.TabIndex = 243;
            this.label13.Text = "Ngày trả dự kiến";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 242;
            this.label7.Text = "Mã phiếu thuê";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 241;
            this.label6.Text = "Mã phiếu đặt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvPTP
            // 
            this.dgvPTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPTP,
            this.MAPDP,
            this.MAKH,
            this.HOTEN,
            this.MOPHONG,
            this.NGAYNHAN,
            this.NGAYTRARDK});
            this.dgvPTP.Location = new System.Drawing.Point(61, 324);
            this.dgvPTP.Name = "dgvPTP";
            this.dgvPTP.RowHeadersWidth = 51;
            this.dgvPTP.RowTemplate.Height = 24;
            this.dgvPTP.Size = new System.Drawing.Size(1052, 365);
            this.dgvPTP.TabIndex = 240;
            this.dgvPTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPTP_CellClick);
            // 
            // MAPTP
            // 
            this.MAPTP.DataPropertyName = "MA_PTP";
            this.MAPTP.HeaderText = "Mã PTP";
            this.MAPTP.MinimumWidth = 6;
            this.MAPTP.Name = "MAPTP";
            // 
            // MAPDP
            // 
            this.MAPDP.DataPropertyName = "MA_PDP";
            this.MAPDP.HeaderText = "Mã PDP";
            this.MAPDP.MinimumWidth = 6;
            this.MAPDP.Name = "MAPDP";
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MA_KH";
            this.MAKH.HeaderText = "MÃ KH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN_KH";
            this.HOTEN.HeaderText = "Tên KH";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // MOPHONG
            // 
            this.MOPHONG.DataPropertyName = "MA_PHONG";
            this.MOPHONG.HeaderText = "Mã phòng";
            this.MOPHONG.MinimumWidth = 6;
            this.MOPHONG.Name = "MOPHONG";
            // 
            // NGAYNHAN
            // 
            this.NGAYNHAN.DataPropertyName = "NGAYNHAN";
            this.NGAYNHAN.HeaderText = "Ngày nhận phòng";
            this.NGAYNHAN.MinimumWidth = 6;
            this.NGAYNHAN.Name = "NGAYNHAN";
            // 
            // NGAYTRARDK
            // 
            this.NGAYTRARDK.DataPropertyName = "NGAYTRA_DK";
            this.NGAYTRARDK.HeaderText = "Ngày trả dự kiến";
            this.NGAYTRARDK.MinimumWidth = 6;
            this.NGAYTRARDK.Name = "NGAYTRARDK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(536, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 239;
            this.label10.Text = "Hủy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(831, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 238;
            this.label9.Text = "Lưu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(681, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 237;
            this.label4.Text = "Xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(256, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 236;
            this.label3.Text = "Thêm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(390, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 235;
            this.label8.Text = "Sửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(138, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 234;
            this.label5.Text = "ReLoad";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyBo.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ExitIcon1;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(512, 242);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(96, 63);
            this.btnHuyBo.TabIndex = 233;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.SaveIcon;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(798, 242);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 63);
            this.btnLuu.TabIndex = 232;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReLoad.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ReloadIcon;
            this.btnReLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(128, 242);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(96, 63);
            this.btnReLoad.TabIndex = 231;
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
            this.btnSua.Location = new System.Drawing.Point(375, 242);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 63);
            this.btnSua.TabIndex = 228;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.EraseIcon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(648, 242);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 63);
            this.btnXoa.TabIndex = 229;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.addIcon1;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(248, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 63);
            this.btnThem.TabIndex = 230;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 227;
            this.label2.Text = "Mã Phòng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(233, 170);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(317, 22);
            this.txtTenKH.TabIndex = 226;
            // 
            // tctMatKhau
            // 
            this.tctMatKhau.AutoSize = true;
            this.tctMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctMatKhau.Location = new System.Drawing.Point(146, 172);
            this.tctMatKhau.Name = "tctMatKhau";
            this.tctMatKhau.Size = new System.Drawing.Size(72, 20);
            this.tctMatKhau.TabIndex = 225;
            this.tctMatKhau.Text = "Tên KH";
            this.tctMatKhau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 224;
            this.label1.Text = "Mã KH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPDP
            // 
            this.txtPDP.Location = new System.Drawing.Point(233, 71);
            this.txtPDP.Name = "txtPDP";
            this.txtPDP.Size = new System.Drawing.Size(317, 22);
            this.txtPDP.TabIndex = 250;
            // 
            // UserThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.txtPDP);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.txtPTP);
            this.Controls.Add(this.btnPDP);
            this.Controls.Add(this.dtNgayTraDK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPTP);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.tctMatKhau);
            this.Controls.Add(this.label1);
            this.Name = "UserThuePhong";
            this.Size = new System.Drawing.Size(1174, 731);
            this.Load += new System.EventHandler(this.UserThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.TextBox txtPTP;
        private System.Windows.Forms.Button btnPDP;
        private System.Windows.Forms.DateTimePicker dtNgayTraDK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRARDK;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label tctMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDP;
    }
}
