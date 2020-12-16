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
    public partial class FrmDoiMatKhau : Form
    {
        BLNhanVien BLNV = null;
        string passwword;
        string User;
        string err;

        public FrmDoiMatKhau(string User)
        {
            InitializeComponent();
            this.User = User;
        }
        
        private void btnDongY_Click(object sender, EventArgs e)
        {
            BLNV = new BLNhanVien();
            passwword= BLNV.Laypassword(User).ToString();
            if (passwword == txtMatKhauCu.Text)
            {
                if (txtMatKhauMoi.Text == txtXacNhanMatKhau.Text)
                {
                    //DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
                    BLNV = new BLNhanVien();
                    BLNV.DoiMatKhau(ref err, User, txtMatKhauMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    //this.Close();
                }    
                else
                    MessageBox.Show("Xác nhận lại mật khẩu", "Thông báo");
            }
            else
                MessageBox.Show("Sai mật khẩu", "Thông báo");
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.ResetText();
            txtMatKhauMoi.ResetText();
            txtXacNhanMatKhau.ResetText();
        }
    }
}
