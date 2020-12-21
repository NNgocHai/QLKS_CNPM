
namespace QLKS__ADO.Net_CNPM.Forms
{
    partial class FrmMaKhuyenMai
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
            this.textNhanPhong = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnContinune = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNhanPhong
            // 
            this.textNhanPhong.AutoSize = true;
            this.textNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textNhanPhong.ForeColor = System.Drawing.Color.Firebrick;
            this.textNhanPhong.Location = new System.Drawing.Point(133, 80);
            this.textNhanPhong.Name = "textNhanPhong";
            this.textNhanPhong.Size = new System.Drawing.Size(158, 25);
            this.textNhanPhong.TabIndex = 26;
            this.textNhanPhong.Text = "Mã Khyến Mãi:";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(326, 80);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(276, 22);
            this.txtMaKM.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(-1, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 69);
            this.btnBack.TabIndex = 31;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.Capture;
            this.btnCheck.Location = new System.Drawing.Point(626, 44);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(84, 72);
            this.btnCheck.TabIndex = 30;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnContinune
            // 
            this.btnContinune.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinune.Image = global::QLKS__ADO.Net_CNPM.Properties.Resources.Continune3;
            this.btnContinune.Location = new System.Drawing.Point(682, 201);
            this.btnContinune.Name = "btnContinune";
            this.btnContinune.Size = new System.Drawing.Size(120, 69);
            this.btnContinune.TabIndex = 29;
            this.btnContinune.UseVisualStyleBackColor = false;
            this.btnContinune.Click += new System.EventHandler(this.btnContinune_Click);
            // 
            // FrmMaKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnContinune);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.textNhanPhong);
            this.Name = "FrmMaKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mã khuyến mãi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textNhanPhong;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.Button btnContinune;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBack;
    }
}