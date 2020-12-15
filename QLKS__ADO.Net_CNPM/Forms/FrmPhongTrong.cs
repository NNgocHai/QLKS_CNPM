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

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            FrmNhanPhong frm = new FrmNhanPhong(MaPhong);
            frm.ShowDialog();
            frmMain.LoadData();
            this.Close();
/*            UserNhanPhong userControl = new UserNhanPhong(MaPhong);


            if (!pnlForm.Controls.Contains(userControl))
            {
                pnlForm.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
            else
                userControl.BringToFront();*/
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
    }
}
