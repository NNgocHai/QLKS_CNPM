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

namespace QLKS__ADO.Net_CNPM.Forms
{
    public partial class FrmHoaDon : Form
    {

        DataTable DTHD = null;
        BLHoaDon BLHD = null;
        string err;

        string MaHD;
        public FrmHoaDon()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                BLHD = new BLHoaDon();
                DTHD = new DataTable();
                DTHD.Clear();
                DataSet ds = BLHD.LayHoaDon();
                DTHD = ds.Tables[0];
                dgvHoaDon.DataSource = DTHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng HOADON. Lỗi rồi!!!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                BLHD = new BLHoaDon();
                DTHD = new DataTable();
                DTHD.Clear();
                DataSet ds = BLHD.TimKiem(txtTimKiem.Text,txtDate.Text);
                DTHD = ds.Tables[0];
                dgvHoaDon.DataSource = DTHD;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng HOADON. Lỗi rồi!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLHD = new BLHoaDon();
            try
            {
                if (MaHD != "")
                {
                    DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
                    if (DL == DialogResult.Yes)
                    {
                        int r = dgvHoaDon.CurrentCell.RowIndex;
                        if (BLHD.XoaHoaDon(ref err, MaHD))
                        {
                            LoadData();
                            MessageBox.Show("Đã xóa xong");
                        }
                        else
                        {
                            MessageBox.Show(err, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                    MessageBox.Show("Bạn chưa chọn HoaDon", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            //Chuyển thông tin lên panel
            MaHD = dgvHoaDon.Rows[r].Cells[0].Value.ToString().Trim();
        }
    }
}
