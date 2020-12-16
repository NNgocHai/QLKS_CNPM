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
    public partial class FrmNhanPhong : Form
    {
        DataTable DTPTP = null;
        bool Them;
        string err;
        BLPhieuNhanPhong BLPTP = null;
        string MaPhong;
        public int IsThuePhong=0;
        public FrmNhanPhong(string MaPhong)
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
            this.txtPTP.Enabled = false;
            this.txtMaPhong.Enabled = false;
            this.txtTenKH.Enabled = false;
        }
        public void Default_txt()
        {
            this.txtPTP.ResetText();
            this.txtPDP.ResetText();
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtMaPhong.ResetText();
            this.dtNgayNhanPhong.Value = DateTime.Now;
            this.dtNgayTraDK.Value = DateTime.Now;

        }
        private void LoadData()
        {
            try
            {
                BLPTP = new BLPhieuNhanPhong();
                DTPTP = new DataTable();
                DTPTP.Clear();
                DataSet ds = BLPTP.ThongTinPhieuThuePhong(MaPhong);
                DTPTP = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvPTP.DataSource = DTPTP;
                Default_txt();
                Default_Button();
                dgvPTP_CellClick(null, null);

            }
            catch (SqlException)
            {

            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Default_txt();
            Default_Button();

            dgvPTP_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLPTP = new BLPhieuNhanPhong();
            if (Them)
            {
                var TTHopLe = BLPTP.KiemTraThemPTP(txtPDP.Text, txtMaKH.Text);
                if (TTHopLe.Equals(true))
                {
                    try
                    {
                        BLPTP = new BLPhieuNhanPhong();
                        if (BLPTP.ThemPTP(this.txtPDP.Text, this.txtMaKH.Text, this.MaPhong, this.dtNgayTraDK.Value, ref err))
                        {
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                            Default_Button();
                            IsThuePhong = 1;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                else
                    MessageBox.Show("Mã PDP và Mã KH chưa trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                var TTHopLe = BLPTP.KiemTraThemPTP(txtPDP.Text, txtMaKH.Text);
                if (TTHopLe.Equals(true) || (this.txtPDP.Text == DTPTP.Rows[0].ItemArray[1].ToString()
                    && this.txtMaKH.Text == DTPTP.Rows[0].ItemArray[2].ToString()))
                {

                    try
                    {
                        BLPTP = new BLPhieuNhanPhong();
                        if (BLPTP.CapNhatPhieuThuePhong(this.txtPTP.Text, this.txtPDP.Text, this.txtMaKH.Text, dtNgayTraDK.Value, ref err))
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
                else
                    MessageBox.Show("Mã PDP và Mã KH chưa trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            dgvPTP_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLPTP = new BLPhieuNhanPhong();
            try
            {


                DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
                if (DL == DialogResult.Yes)
                {
                    int r = dgvPTP.CurrentCell.RowIndex;
                    if (BLPTP.XoaPhieuThuePhong(ref err, this.txtPTP.Text))
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong");
                        this.Close();
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
            if (BLPTP.KiemTraTonTaiPTP(this.MaPhong).Equals(true))
            {
                Them = true;
                Default_txt();
                this.btnLuu.Enabled = true;
                this.btnHuyBo.Enabled = true;
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.txtMaKH.Focus();
            }
            else
                MessageBox.Show("Phong Da co Nguoi Thue", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void FrmNhanPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLPTP = new BLPhieuNhanPhong();
            try
            {
                int r = dgvPTP.CurrentCell.RowIndex;
                this.txtPDP.Text = dgvPTP.Rows[r].Cells[1].Value.ToString().Trim();
                this.txtPTP.Text = dgvPTP.Rows[r].Cells[0].Value.ToString().Trim();
                this.txtMaKH.Text = dgvPTP.Rows[r].Cells[2].Value.ToString().Trim();
                this.txtTenKH.Text = dgvPTP.Rows[r].Cells[3].Value.ToString().Trim();
                this.txtMaPhong.Text = dgvPTP.Rows[r].Cells[4].Value.ToString().Trim();
                this.dtNgayNhanPhong.Value = (DateTime)dgvPTP.Rows[r].Cells[5].Value;
                this.dtNgayTraDK.Value = (DateTime)dgvPTP.Rows[r].Cells[6].Value;
            }
            catch
            {
                this.txtPTP.Text = "";
                this.txtPDP.Text = "";
                this.txtMaKH.Text = "";
                this.txtTenKH.Text = "";
                this.txtMaPhong.Text = "";

            }
        }
    }
}
