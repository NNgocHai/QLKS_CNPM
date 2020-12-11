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
    public partial class UserThongTinKH : UserControl
    {
        string MaPhong;
        DataTable DTKH = null;
        BLKhachHang BLKH = null;
        public UserThongTinKH(string MaPhong)
        {
            InitializeComponent();
            this.MaPhong = MaPhong;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                BLKH = new BLKhachHang();
                DTKH = new DataTable();
                DTKH.Clear();
                DataSet ds = BLKH.ThongTinKhachHang(MaPhong);
                DTKH = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                if (DTKH.Rows.Count > 0)
                {
                    txtMaKH.Text = DTKH.Rows[0].ItemArray[0].ToString();
                    txtTenKH.Text = DTKH.Rows[0].ItemArray[1].ToString();
                    txtDiaChi.Text = DTKH.Rows[0].ItemArray[2].ToString();
                    txtSDT.Text = DTKH.Rows[0].ItemArray[3].ToString();
                    txtCMND.Text = DTKH.Rows[0].ItemArray[4].ToString();
                    txtGioiTinh.Text = DTKH.Rows[0].ItemArray[5].ToString();
                    txtTinhTrang.Text = DTKH.Rows[0].ItemArray[6].ToString();
                }
               /* else
                    MessageBox.Show("Phòng không có người");*/

            }
            catch (SqlException)
            {

            }
        }

        private void UserThongTinKH_Load(object sender, EventArgs e)
        {

        }
    }
}
