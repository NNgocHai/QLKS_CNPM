
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmPhongTrong
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
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textNhanPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnThongTinPhong = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlMenu.Controls.Add(this.btnDatPhong);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.textNhanPhong);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnNhanPhong);
            this.pnlMenu.Controls.Add(this.btnThongTinPhong);
            this.pnlMenu.Location = new System.Drawing.Point(35, 31);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(297, 731);
            this.pnlMenu.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(132, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đặt phòng";
            // 
            // textNhanPhong
            // 
            this.textNhanPhong.AutoSize = true;
            this.textNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textNhanPhong.ForeColor = System.Drawing.Color.Firebrick;
            this.textNhanPhong.Location = new System.Drawing.Point(132, 219);
            this.textNhanPhong.Name = "textNhanPhong";
            this.textNhanPhong.Size = new System.Drawing.Size(131, 25);
            this.textNhanPhong.TabIndex = 14;
            this.textNhanPhong.Text = "Nhận Phòng";
            this.textNhanPhong.Click += new System.EventHandler(this.textNhanPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(132, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDatPhong.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.booking1;
            this.btnDatPhong.Location = new System.Drawing.Point(16, 112);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(110, 69);
            this.btnDatPhong.TabIndex = 17;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhanPhong.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.keys1;
            this.btnNhanPhong.Location = new System.Drawing.Point(16, 202);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(110, 69);
            this.btnNhanPhong.TabIndex = 6;
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnThongTinPhong
            // 
            this.btnThongTinPhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThongTinPhong.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.information4;
            this.btnThongTinPhong.Location = new System.Drawing.Point(16, 19);
            this.btnThongTinPhong.Name = "btnThongTinPhong";
            this.btnThongTinPhong.Size = new System.Drawing.Size(110, 69);
            this.btnThongTinPhong.TabIndex = 1;
            this.btnThongTinPhong.UseVisualStyleBackColor = false;
            this.btnThongTinPhong.Click += new System.EventHandler(this.btnThongTinPhong_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackgroundImage = global::QLKS__ADO.Net_CNPM.Properties.Resources.infok_vn_27fkhach_san_marguerite;
            this.pnlForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForm.Location = new System.Drawing.Point(329, 31);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1180, 734);
            this.pnlForm.TabIndex = 13;
            // 
            // FrmPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1538, 792);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlForm);
            this.Name = "FrmPhongTrong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng trống";
            this.Load += new System.EventHandler(this.FrmPhongTrong_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textNhanPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnThongTinPhong;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        //private Usercontrol.UserThongTinPhong userThongTinPhong1;
    }
}