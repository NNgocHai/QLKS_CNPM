using QLKS__ADO.Net_CNPM.BS_Layer;
using QLKS__ADO.Net_CNPM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS__ADO.Net_CNPM.Usercontrol
{
    public partial class UserThanhToan : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int isThanhToan = 0;
        public int IsThanhToan
        {
            get { return isThanhToan; }
            set
            {
                if (value != isThanhToan)
                {
                    isThanhToan = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(IsThanhToan.ToString()));
                    }
                }
            }
        }
        BLThanhToan BLTT = null;
        BLSuDungDV BLSDDV = null;

        DataTable Data = null;
        string User;
        string MaKM = "-1";
        string MaPhong;
        string MaPTP;
        object KT;
        public UserThanhToan(string MaPhong, string User)
        {
            InitializeComponent();
            this.User = User;
            this.MaPhong = MaPhong;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            BLTT = new BLThanhToan();
            KT = BLTT.KT_MaKM(this.txtMaKM.Text);
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
            XoaHoaDon();
            LoadData();
            LoadDataThanhToan();


        }
        private void LoadData()
        {
            BLTT = new BLThanhToan();
            MaPTP = BLTT.LayMaPTP(MaPhong).ToString();
            BLTT = new BLThanhToan();
            BLTT.UpDateNgayTra(MaPhong);
            BLTT = new BLThanhToan();
            BLTT.ThemHD(MaPhong, User, MaKM);
        }
        private void LoadDataThanhToan()
        {
            try
            {

                BLTT = new BLThanhToan();
                Data = new DataTable();
                Data.Clear();
                DataSet ds = BLTT.LayThongTin(MaPTP);
                Data = ds.Tables[0];
                txtMaHD.Text = Data.Rows[0].ItemArray[0].ToString();
                txtMaKH.Text = (string)Data.Rows[0].ItemArray[1];
                txtMaPTP.Text = (string)Data.Rows[0].ItemArray[2];
                txtNV.Text = (string)Data.Rows[0].ItemArray[4];
                txtTongTien.Text = Data.Rows[0].ItemArray[5].ToString();
                txtGiamGia.Text = Data.Rows[0].ItemArray[6].ToString();
                txtMaPhong.Text = Data.Rows[0].ItemArray[7].ToString();
                txtSoNgayThue.Text = Data.Rows[0].ItemArray[8].ToString();
                txtTienDV.Text = Data.Rows[0].ItemArray[9].ToString();
                txtTienThue.Text = Data.Rows[0].ItemArray[10].ToString();
                txtTenKH.Text = Data.Rows[0].ItemArray[11].ToString();
                txtTienCoc.Text = Data.Rows[0].ItemArray[12].ToString();
                txtPhongKM.Text = Data.Rows[0].ItemArray[13].ToString();

            }
            catch (SqlException)
            {

            }
        }
        private void LoadDataDVSD()
        {
            try
            {
                BLSDDV = new BLSuDungDV();
                Data = new DataTable();
                Data.Clear();
                DataSet ds = BLSDDV.ThongTinHDDV_TuPTP(MaPTP);
                Data = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvDVSD.DataSource = Data;
                //dgvDichVu_CellClick(null, null);

            }
            catch (SqlException)
            {

            }
        }





        private void dgvDVSD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult DL = MessageBox.Show("Bạn có muốn thanh toán không", "xác nhận", MessageBoxButtons.YesNoCancel);
            if (DL == DialogResult.Yes)
            {
                IsThanhToan = 1;
            }
        }
        public void XoaHoaDon()
        {
            BLTT = new BLThanhToan();
            BLTT.XoaThongTin(MaPTP);
            BLTT = new BLThanhToan();
            BLTT.UpDateNgayTra_ChuaThanhToan(MaPhong);
            IsThanhToan = 0;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            XoaHoaDon();
        }

        private void UserThanhToan_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("leave");
            XoaHoaDon();
        }

        private void UserThanhToan_Load(object sender, EventArgs e)
        {
            txtMaKM.Focus();
            LoadData();
            LoadDataDVSD();
            LoadDataThanhToan();
        }
    }
}
