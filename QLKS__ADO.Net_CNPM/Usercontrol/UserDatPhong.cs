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
    public partial class UserDatPhong : UserControl
    {
        DataTable DTPDP = null;
        bool Them;
        string err;
        BLPhieuDatPhong BLPDP = null;
        string MaPhong;
        public UserDatPhong(string MaPhong)
        {
            InitializeComponent();
            this.MaPhong = MaPhong;
            
        }
        public void Default_Button()
        {
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            txtMaPhong.Enabled = false;
            txtMaPDP.Enabled = false;
        }
        public void Default_txt()
        {
            this.cbbMaKH.ResetText();
            this.txtSoNguoi.ResetText();
            this.txtTienCoc.ResetText();
        }
        private void LoadMAKH()
        {
            BLKhachHang BLKH = new BLKhachHang();
            List<string> dsMaKH = new List<string>();
            dsMaKH.Clear();
            dsMaKH = BLKH.LayMAKH();
            cbbMaKH.Items.Clear();

            foreach (string MaKH in dsMaKH)
            {
                cbbMaKH.Items.Add(MaKH);
            }
        }
        private void LoadData()
        {
            LoadMAKH();
            try
            {
                BLPDP = new BLPhieuDatPhong();
                DTPDP = new DataTable();
                DTPDP.Clear();
                DataSet ds = BLPDP.ThongTinPhieuDatPhong(MaPhong);
                DTPDP = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgv_DatPhong.DataSource = DTPDP;
                Default_txt();
                Default_Button();
                dgv_DatPhong_CellClick(null, null);

            }
            catch (SqlException)
            {

            }
        }

        private void UserDatPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Default_txt();
            Default_Button();

            dgv_DatPhong_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLPDP = new BLPhieuDatPhong();
            if (Them)
            {


                try
                {
                    if (BLPDP.ThemPhieuDatPhong(this.cbbMaKH.Text, this.txtSoNguoi.Text, this.MaPhong, this.dtNgayNhanPhong.Value, this.txtTienCoc.Text, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                        Default_Button();
                    }
                    else
                    {
                        MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BLPDP = new BLPhieuDatPhong();
                        BLPDP.XoaPhieuKhongCoCTPDP(ref err);
                       
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }

            }
            else
            {

                try
                {

                    if (BLPDP.CapNhatPhieuDatPhong(this.txtMaPDP.Text, this.cbbMaKH.Text, this.txtSoNguoi.Text, dtNgayNhanPhong.Value, this.txtTienCoc.Text, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                        Default_Button();

                    }
                    else
                    {
                        MessageBox.Show(this.err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }

            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            dgv_DatPhong_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.cbbMaKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLPDP = new BLPhieuDatPhong();
            try
            {


                DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
                if (DL == DialogResult.Yes)
                {
                    int r = dgv_DatPhong.CurrentCell.RowIndex;
                    if (BLPDP.XoaPhieuDatPhong(ref err, this.txtMaPDP.Text))
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
            catch
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong Panel

            Default_txt();
            // Cho thao tác trên các nút Lưu / Hủy / Panel

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.cbbMaKH.Focus();
        }

        private void dgv_DatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLPDP = new BLPhieuDatPhong();
            try     
            {
                int r = dgv_DatPhong.CurrentCell.RowIndex;
                this.txtMaPDP.Text = dgv_DatPhong.Rows[r].Cells[0].Value.ToString().Trim();
                this.cbbMaKH.Text = dgv_DatPhong.Rows[r].Cells[1].Value.ToString().Trim();
                this.txtMaPhong.Text = dgv_DatPhong.Rows[r].Cells[2].Value.ToString().Trim();
                this.txtSoNguoi.Text = dgv_DatPhong.Rows[r].Cells[3].Value.ToString().Trim();
                this.dtNgayNhanPhong.Value = (DateTime)dgv_DatPhong.Rows[r].Cells[5].Value;
                this.txtTienCoc.Text = dgv_DatPhong.Rows[r].Cells[6].Value.ToString().Trim();

            }
            catch
            {
                this.cbbMaKH.Text = "";
                this.txtSoNguoi.Text = "";
                this.txtTienCoc.Text = "";
                this.txtMaPhong.Text = "";
                this.txtMaPDP.Text = "";

            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            using (FrmKhachHang frmkh = new FrmKhachHang())
            {
                this.Hide();
                frmkh.ShowDialog();
                this.Show();
                cbbMaKH.Text = frmkh.MaKH_focused;
            }
        }
    }
}
