using QLKS__ADO.Net_CNPM.BS_Layer;
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
        DataTable Data = null;
        BLThanhToan BLTT = null;
        BLSuDungDV BLSDDV = null;
        string MaPhong;
        string MaPTP;
        int IsThanhToan = 0;
        public UserThanhToan(string MaPhong,string MaPTP)
        {
         
            InitializeComponent();
            this.MaPhong = MaPhong;
            this.MaPTP = MaPTP;
            LoadDataDVSD();
            LoadDataThanhToan();
        }

        private void UserThanhToan_Load(object sender, EventArgs e)
        {
            LoadDataDVSD();
        }
        private void LoadDataThanhToan()
        {
            try
            {
                //HD.MA_HOADON,HD.MA_KH,HD.MA_PTP,HD.NGAYLAP,HD.TENDANGNHAP,HD.TONGTIEN,
               // CTHD.GIAMGIA_KH,CTHD.MA_PHONG,CTHD.SONGAYTHUE,CTHD.TIENDV,CTHD.TIENTHUE,KH.HOTEN_KH
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
                txtGiamGia.Text =Data.Rows[0].ItemArray[6].ToString();
                txtMaPhong.Text = Data.Rows[0].ItemArray[7].ToString();
                txtSoNgayThue.Text = Data.Rows[0].ItemArray[8].ToString();
                txtTienDV.Text = Data.Rows[0].ItemArray[9].ToString();
                txtTienThue.Text = Data.Rows[0].ItemArray[10].ToString();
                txtTenKH.Text = Data.Rows[0].ItemArray[11].ToString();


                // Đưa dữ liệu lên DataGridView
                /*txtMaPhong.Text = (string)DTP.Rows[0].ItemArray[0];
                txtTen.Text = (string)DTP.Rows[0].ItemArray[1];
                txtGia.Text = DTP.Rows[0].ItemArray[2].ToString();
                txtTinhTrang.Text = (string)DTP.Rows[0].ItemArray[3];
                txtSoNguoiToiDa.Text = DTP.Rows[0].ItemArray[4].ToString();
                txtKhuyenMai.Text = (string)DTP.Rows[0].ItemArray[5];
                txtMota.Text = (string)DTP.Rows[0].ItemArray[6];*/


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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
            if (DL == DialogResult.Yes)
                IsThanhToan = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BLTT = new BLThanhToan();
            BLTT.XoaThongTin(MaPTP);
            BLTT = new BLThanhToan();
            BLTT.UpDateNgayTra_ChuaThanhToan(MaPhong);
            
        }
    }
}
