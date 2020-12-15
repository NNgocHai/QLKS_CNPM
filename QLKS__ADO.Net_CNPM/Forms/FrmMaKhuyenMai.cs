using QLKS__ADO.Net_CNPM.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS__ADO.Net_CNPM.Forms
{
    public partial class FrmMaKhuyenMai : Form
    {
        BLThanhToan BLTT = null;


        string User;
        string MaKM;
        string MaPhong;
        string MaPTP;

        object KT;
        public FrmMaKhuyenMai(string MaPhong,string User)
        {
            InitializeComponent();
            this.User = User;
            this.MaPhong = MaPhong;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            BLTT = new BLThanhToan();
            KT= BLTT.KT_MaKM(this.txtMaKM.Text);
            if (KT.Equals(1))
            {
                MaKM = this.txtMaKM.Text;
                MessageBox.Show("Mã khuyến mãi hợp lệ", "Thông báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã khuyến mãi không hợp lệ hoặc hết hạn", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MaKM = "-1";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinune_Click(object sender, EventArgs e)
        {
            BLTT = new BLThanhToan();
            MaPTP = BLTT.LayMaPTP(MaPhong).ToString();
            BLTT = new BLThanhToan();
            BLTT.UpDateNgayTra(MaPhong);
            BLTT = new BLThanhToan();
            BLTT.ThemHD(MaPhong, User, MaKM);
            FrmThanhToan frmThanhToan = new FrmThanhToan(MaPhong,MaPTP);
            frmThanhToan.ShowDialog();
            this.Close();
        }
    }
}
