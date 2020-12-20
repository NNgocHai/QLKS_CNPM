
namespace QLKS__ADO.Net_CNPM.Usercontrol
{
    partial class UserSuDungDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSuDungDV));
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.dgvDVSD = new System.Windows.Forms.DataGridView();
            this.MAHDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA__dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.MA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Them = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Giam = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTimKiemDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(331, 49);
            this.txtTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(353, 30);
            this.txtTenDV.TabIndex = 99;
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
            this.MA__dv,
            this.SOLUONG,
            this.THANHTEN});
            this.dgvDVSD.Location = new System.Drawing.Point(67, 420);
            this.dgvDVSD.Name = "dgvDVSD";
            this.dgvDVSD.RowHeadersWidth = 51;
            this.dgvDVSD.RowTemplate.Height = 24;
            this.dgvDVSD.Size = new System.Drawing.Size(1031, 270);
            this.dgvDVSD.TabIndex = 101;
            this.dgvDVSD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVSD_CellClick);
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
            // MA__dv
            // 
            this.MA__dv.DataPropertyName = "MA_DV";
            this.MA__dv.HeaderText = "Mã dịch vụ";
            this.MA__dv.MinimumWidth = 6;
            this.MA__dv.Name = "MA__dv";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Thông tin dịch vụ đã sử dụng";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_DV,
            this.TEN,
            this.GIADV,
            this.Them,
            this.Giam});
            this.dgvDichVu.Location = new System.Drawing.Point(222, 99);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(679, 249);
            this.dgvDichVu.TabIndex = 104;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // MA_DV
            // 
            this.MA_DV.DataPropertyName = "MA_DV";
            this.MA_DV.HeaderText = "Mã dịch vụ";
            this.MA_DV.MinimumWidth = 6;
            this.MA_DV.Name = "MA_DV";
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên dịch vụ";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            // 
            // GIADV
            // 
            this.GIADV.DataPropertyName = "GIA";
            this.GIADV.HeaderText = "Giá dịch vụ";
            this.GIADV.MinimumWidth = 6;
            this.GIADV.Name = "GIADV";
            // 
            // Them
            // 
            this.Them.HeaderText = "Thêm";
            this.Them.MinimumWidth = 6;
            this.Them.Name = "Them";
            // 
            // Giam
            // 
            this.Giam.HeaderText = "Giảm";
            this.Giam.MinimumWidth = 6;
            this.Giam.Name = "Giam";
            // 
            // btnTimKiemDV
            // 
            this.btnTimKiemDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiemDV.BackgroundImage")));
            this.btnTimKiemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDV.Location = new System.Drawing.Point(692, 36);
            this.btnTimKiemDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemDV.Name = "btnTimKiemDV";
            this.btnTimKiemDV.Size = new System.Drawing.Size(64, 56);
            this.btnTimKiemDV.TabIndex = 100;
            this.btnTimKiemDV.UseVisualStyleBackColor = true;
            this.btnTimKiemDV.Click += new System.EventHandler(this.btnTimKiemDV_Click);
            // 
            // UserSuDungDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDVSD);
            this.Controls.Add(this.btnTimKiemDV);
            this.Controls.Add(this.txtTenDV);
            this.Name = "UserSuDungDV";
            this.Size = new System.Drawing.Size(1174, 731);
            this.Load += new System.EventHandler(this.UserSuDungDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiemDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.DataGridView dgvDVSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIADV;
        private System.Windows.Forms.DataGridViewButtonColumn Them;
        private System.Windows.Forms.DataGridViewButtonColumn Giam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA__dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTEN;
    }
}
