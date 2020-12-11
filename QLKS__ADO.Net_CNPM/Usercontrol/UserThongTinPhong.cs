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
    public partial class UserThongTinPhong : UserControl
    {

        string MaPhong;
        DataTable DTP = null;
        BLPhong BLP = null;
        public UserThongTinPhong(string MaPhong)
        {
            InitializeComponent();
            this.MaPhong = MaPhong;
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                BLP = new BLPhong();
                DTP = new DataTable();
                DTP.Clear();
                DataSet ds = BLP.ThongTinPhong(MaPhong);
                DTP = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                txtMaPhong.Text = (string)DTP.Rows[0].ItemArray[0];
                txtTen.Text = (string)DTP.Rows[0].ItemArray[1];
                txtGia.Text = DTP.Rows[0].ItemArray[2].ToString();
                txtTinhTrang.Text = (string)DTP.Rows[0].ItemArray[3];
                txtSoNguoiToiDa.Text = DTP.Rows[0].ItemArray[4].ToString();
                txtKhuyenMai.Text = (string)DTP.Rows[0].ItemArray[5];
                txtMota.Text = (string)DTP.Rows[0].ItemArray[6];

            }
            catch (SqlException)
            {
               
            }
        }

        private void userThongTinKH2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
