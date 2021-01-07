
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MA_HOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGAYTHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENCOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_HOADON,
            this.TENDANGNHAP,
            this.HOTEN_KH,
            this.CMND_KH,
            this.NGAYLAP,
            this.MA_PHONG,
            this.SONGAYTHUE,
            this.TIENTHUE,
            this.TIENDV,
            this.TIENCOC,
            this.GIAMGIA_KH,
            this.TONGTIEN});
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 114);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(1419, 548);
            this.dgvHoaDon.TabIndex = 69;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // MA_HOADON
            // 
            this.MA_HOADON.DataPropertyName = "MA_HOADON";
            this.MA_HOADON.HeaderText = "Mã hóa đơn";
            this.MA_HOADON.MinimumWidth = 6;
            this.MA_HOADON.Name = "MA_HOADON";
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.DataPropertyName = "TENDANGNHAP";
            this.TENDANGNHAP.HeaderText = "Nhân Viên";
            this.TENDANGNHAP.MinimumWidth = 6;
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            // 
            // HOTEN_KH
            // 
            this.HOTEN_KH.DataPropertyName = "HOTEN_KH";
            this.HOTEN_KH.HeaderText = "Họ tên ";
            this.HOTEN_KH.MinimumWidth = 6;
            this.HOTEN_KH.Name = "HOTEN_KH";
            // 
            // CMND_KH
            // 
            this.CMND_KH.DataPropertyName = "CMND_KH";
            this.CMND_KH.HeaderText = "CMND";
            this.CMND_KH.MinimumWidth = 6;
            this.CMND_KH.Name = "CMND_KH";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày thanh toán";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // MA_PHONG
            // 
            this.MA_PHONG.DataPropertyName = "MA_PHONG";
            this.MA_PHONG.HeaderText = "Mã Phòng";
            this.MA_PHONG.MinimumWidth = 6;
            this.MA_PHONG.Name = "MA_PHONG";
            // 
            // SONGAYTHUE
            // 
            this.SONGAYTHUE.DataPropertyName = "SONGAYTHUE";
            this.SONGAYTHUE.HeaderText = "Số ngày thuê";
            this.SONGAYTHUE.MinimumWidth = 6;
            this.SONGAYTHUE.Name = "SONGAYTHUE";
            // 
            // TIENTHUE
            // 
            this.TIENTHUE.DataPropertyName = "TIENTHUE";
            this.TIENTHUE.HeaderText = "Tiền thuê";
            this.TIENTHUE.MinimumWidth = 6;
            this.TIENTHUE.Name = "TIENTHUE";
            // 
            // TIENDV
            // 
            this.TIENDV.DataPropertyName = "TIENDV";
            this.TIENDV.HeaderText = "Tiền DV";
            this.TIENDV.MinimumWidth = 6;
            this.TIENDV.Name = "TIENDV";
            // 
            // TIENCOC
            // 
            this.TIENCOC.DataPropertyName = "TIENCOC";
            this.TIENCOC.HeaderText = "Tiền cọc";
            this.TIENCOC.MinimumWidth = 6;
            this.TIENCOC.Name = "TIENCOC";
            // 
            // GIAMGIA_KH
            // 
            this.GIAMGIA_KH.DataPropertyName = "GIAMGIA_KH";
            this.GIAMGIA_KH.HeaderText = "Giảm Giá";
            this.GIAMGIA_KH.MinimumWidth = 6;
            this.GIAMGIA_KH.Name = "GIAMGIA_KH";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.FineIcon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(695, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 63);
            this.btnTimKiem.TabIndex = 111;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(696, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 110;
            this.label6.Text = "Tìm Kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(565, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 107;
            this.label4.Text = "Xóa";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.EraseIcon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(541, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 63);
            this.btnXoa.TabIndex = 99;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(808, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 22);
            this.txtTimKiem.TabIndex = 112;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(808, 74);
            this.txtDate.Mask = "0000-00-00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(108, 22);
            this.txtDate.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(937, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 114;
            this.label1.Text = "YYYY-MM-DD";
            // 
            // btnReLoad
            // 
            this.btnReLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReLoad.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.ReloadIcon;
            this.btnReLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(383, 33);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(96, 63);
            this.btnReLoad.TabIndex = 115;
            this.btnReLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReLoad.UseVisualStyleBackColor = false;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(393, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 116;
            this.label5.Text = "ReLoad";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1443, 664);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDANGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGAYTHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENCOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Label label5;
    }
}