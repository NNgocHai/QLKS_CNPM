using QLKS__ADO.Net_CNPM.Usercontrol;
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
    public partial class FrmPhongTrong : Form
    { 
        public string MaPhong;
        FrmMain frmMain;
        public int IsNhanPhong = 0;
        UserThuePhong userThuePhong = null;

        int IsThuePhong = 0;


        public FrmPhongTrong(FrmMain frm)
        {

            InitializeComponent();
            this.frmMain = frm;
            this.MaPhong = frm.MaPhong;
            UserThongTinPhong userThongTin = new UserThongTinPhong(frm.MaPhong);
            pnlForm.Controls.Add(userThongTin);
            userThongTin.Dock = DockStyle.Fill;
            userThongTin.BringToFront();

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

       

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            userThuePhong = new UserThuePhong(MaPhong);
            userThuePhong.PropertyChanged += Cntr_PropertyChanged;
            if (!pnlForm.Controls.Contains(userThuePhong))
            {
                pnlForm.Controls.Add(userThuePhong);
                userThuePhong.Dock = DockStyle.Fill;
                userThuePhong.BringToFront();
            }
            else
                userThuePhong.BringToFront();
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

        private void userThongTinPhong1_Load(object sender, EventArgs e)
        {

        }

        private void textNhanPhong_Click(object sender, EventArgs e)
        {

        }
        private void Cntr_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            IsThuePhong = userThuePhong.IsThuePhong; //cntr is the instance of UserControl1
            if (IsThuePhong == 1)
            {
                frmMain.LoadData(frmMain.LoadAll());
                this.Close();
            }

        }
        private void FrmPhongTrong_Load(object sender, EventArgs e)
        {

            
            // press tab + tab after += and it will generate the following method automatically.
        }
    }
}
