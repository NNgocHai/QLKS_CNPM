using QLKS__ADO.Net_CNPM.Usercontrol;
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
    public partial class FrmPhongDaThue : Form
    {

        string MaPhong;
        string User;
        FrmMain frmMain = null;
        UserThuePhong userThuePhong = null;
        UserThanhToan userThanhToan = null;
        int IsXoaPTP = 0;
        int IsThanhToan = 0;

        public FrmPhongDaThue(FrmMain frm)
        {
            InitializeComponent();
            this.frmMain = frm;
            this.MaPhong = frm.MaPhong;
            this.User = frm.User;
            UserThongTinPhong userThongTin = new UserThongTinPhong(frm.MaPhong);
            pnlForm.Controls.Add(userThongTin);
            userThongTin.Dock = DockStyle.Fill;
            userThongTin.BringToFront();
            userThuePhong = new UserThuePhong(MaPhong);
            userThanhToan = new UserThanhToan(MaPhong, User);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            UserDatPhong userControl = new UserDatPhong(MaPhong);


            if (!pnlForm.Controls.Contains(userControl))
            {
                pnlForm.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
                userControl.BringToFront();
        }

        private void btnDVSuDung_Click(object sender, EventArgs e)
        {
            UserSuDungDV userControl = new UserSuDungDV(MaPhong);

            if (!pnlForm.Controls.Contains(userControl))
            {
                pnlForm.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
                userControl.BringToFront();

        }

        private void btnTTKH_Click(object sender, EventArgs e)
        {
            UserThongTinKH userControl = new UserThongTinKH(MaPhong);


            if (!pnlForm.Controls.Contains(userControl))
            {
                pnlForm.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
                userControl.BringToFront();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!pnlForm.Controls.Contains(userThanhToan))
            {
                pnlForm.Controls.Add(userThanhToan);
                userThanhToan.Dock = DockStyle.Fill;
                userThanhToan.BringToFront();
            }
            else
                userThanhToan.BringToFront();
            /*FrmMaKhuyenMai frm = new FrmMaKhuyenMai(MaPhong, User);
            this.Hide();
            frm.ShowDialog();
            if (frm.IsThanhToan == 1)
            {
                frmMain.LoadData(frmMain.LoadAll());
                this.Close();
            }
            else
            {
                this.Show();
                this.btnThongTinPhong_Click(null, null);
            }*/
        }

        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            UserThongTinPhong userThongTin = new UserThongTinPhong(MaPhong);


            if (!pnlForm.Controls.Contains(userThongTin))
            {
                pnlForm.Controls.Add(userThongTin);
                userThongTin.Dock = DockStyle.Fill;
                userThongTin.BringToFront();
            }
            else
                userThongTin.BringToFront();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (!pnlForm.Controls.Contains(userThuePhong))
            {
                pnlForm.Controls.Add(userThuePhong);
                userThuePhong.Dock = DockStyle.Fill;
                userThuePhong.BringToFront();
            }
            else
                userThuePhong.BringToFront();
        }
        private void Cntr_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            IsXoaPTP = userThuePhong.IsXoaPTP; //cntr is the instance of UserControl1
            if (IsXoaPTP == 1)
            {
                frmMain.LoadData(frmMain.LoadAll());
                this.Close();
            }
            else { }
            IsThanhToan = userThanhToan.IsThanhToan;
            if (IsThanhToan == 1)
            {
                frmMain.LoadData(frmMain.LoadAll());
                this.Close();
            }
            else
            {
                userThanhToan.XoaHoaDon();
            }                
        }


        private void FrmPhongDaThue_Load(object sender, EventArgs e)
        {
            userThuePhong.PropertyChanged += Cntr_PropertyChanged;
            userThanhToan.PropertyChanged += Cntr_PropertyChanged;
        }
    }
}
