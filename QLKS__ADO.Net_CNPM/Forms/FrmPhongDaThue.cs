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
        public UserThanhToan userThanhToan = null;

        public int ClickbtnThanhToan = -1;
        int IsXoaPTP = 0;
        public int IsThanhToan = 0;

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
            userThanhToan = new UserThanhToan(MaPhong, User);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (ClickbtnThanhToan == 1)
            {
                userThanhToan.XoaHoaDon();
                ClickbtnThanhToan = -1;
            }
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
            if (ClickbtnThanhToan == 1)
            {
                userThanhToan.XoaHoaDon();
                ClickbtnThanhToan = -1;
            }
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
            if (ClickbtnThanhToan == 1)
            {
                userThanhToan.XoaHoaDon();
                ClickbtnThanhToan = -1;
                userThanhToan.LoadData();
            }
            else
                userThanhToan.LoadData();

            if (!pnlForm.Controls.Contains(userThanhToan))
            {
                
                pnlForm.Controls.Add(userThanhToan);
                userThanhToan.Dock = DockStyle.Fill;
                userThanhToan.BringToFront();
            }
            else
                userThanhToan.BringToFront();
            if (ClickbtnThanhToan == -1)
                ClickbtnThanhToan = 1;
        }

        private void btnThongTinPhong_Click(object sender, EventArgs e)
        {
            if (ClickbtnThanhToan == 1)
            {
                userThanhToan.XoaHoaDon();
                ClickbtnThanhToan = -1;
            }
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
            userThuePhong = new UserThuePhong(MaPhong);
            userThuePhong.PropertyChanged += Cntr_PropertyChanged;
            if (ClickbtnThanhToan == 1)
            {
                userThanhToan.XoaHoaDon();
                ClickbtnThanhToan = -1;
            }
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
            try
            {
                IsXoaPTP = userThuePhong.IsXoaPTP; //cntr is the instance of UserControl1
                if (IsXoaPTP == 1)
                {
                    frmMain.LoadData(frmMain.LoadAll());
                    this.Close();
                }
                else { }
            }
            catch { }
            try
            {
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
            catch { }
        }


        private void FrmPhongDaThue_Load(object sender, EventArgs e)
        {
            
            userThanhToan.PropertyChanged += Cntr_PropertyChanged;
        }

        private void FrmPhongDaThue_Leave(object sender, EventArgs e)
        {
        }
    }
}
