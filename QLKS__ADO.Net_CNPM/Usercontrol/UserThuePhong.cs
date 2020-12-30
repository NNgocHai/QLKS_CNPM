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
    public partial class UserThuePhong : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int isThuePhong = 0; // sử dụng cho phòng trống
        private int isXoaPTP = 0;//Sử dụng cho phòng đã thuê

        public int IsThuePhong
        {
            get { return isThuePhong; }
            set
            {
                if (value != isThuePhong)
                {
                    isThuePhong = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(IsThuePhong.ToString()));
                    }
                }
            }
        }
        public int IsXoaPTP
        {
            get { return isXoaPTP; }
            set
            {
                if (value != isXoaPTP)
                {
                    isXoaPTP = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(IsXoaPTP.ToString()));
                    }
                }
            }
        }
        DataTable DTPTP = null;
        bool Them;
        string err;
        BLPhieuNhanPhong BLPTP = null;

        string MaPhong;
        public UserThuePhong(string MaPhong)
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
            this.cbbPDP.Enabled = false;
        }
        public void Default_txt()
        {

            this.txtPTP.ResetText();
            this.cbbPDP.ResetText();
            this.cbbMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtMaPhong.ResetText();
            this.dtNgayTraDK.Value = DateTime.Now;

        }
        private void LoadData()
        {
            LoadMAKH();
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
                var TTHopLe = BLPTP.KiemTraThemPTP(cbbPDP.Text, cbbMaKH.Text);
                if (TTHopLe.Equals(true))
                {
                    try
                    {
                        BLPTP = new BLPhieuNhanPhong();
                        if (BLPTP.ThemPTP(this.cbbPDP.Text, this.cbbMaKH.Text, this.MaPhong, this.dtNgayTraDK.Value, ref err))
                        {
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                            Default_Button();
                            IsThuePhong = 1;
                            IsXoaPTP = 0;
                        }
                        else
                        {
                            MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BLPTP = new BLPhieuNhanPhong();
                            BLPTP.XoaPhieuKhongCoCTPTP(ref err);

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
                var TTHopLe = BLPTP.KiemTraThemPTP(cbbPDP.Text, cbbMaKH.Text);
                if (TTHopLe.Equals(true) || (this.cbbPDP.Text == DTPTP.Rows[0].ItemArray[1].ToString()
                    && this.cbbMaKH.Text == DTPTP.Rows[0].ItemArray[2].ToString()))
                {

                    try
                    {
                        BLPTP = new BLPhieuNhanPhong();
                        if (BLPTP.CapNhatPhieuThuePhong(this.txtPTP.Text, this.cbbPDP.Text, this.cbbMaKH.Text, dtNgayTraDK.Value, ref err))
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

            this.cbbMaKH.Focus();
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
                        IsThuePhong = 0;
                        IsXoaPTP = 1;
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
                this.cbbMaKH.Focus();
            }
            else
                MessageBox.Show("Phong Da co Nguoi Thue", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void dgvPTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLPTP = new BLPhieuNhanPhong();
            try
            {
                int r = dgvPTP.CurrentCell.RowIndex;
                this.cbbPDP.Text = dgvPTP.Rows[r].Cells[1].Value.ToString().Trim();
                this.txtPTP.Text = dgvPTP.Rows[r].Cells[0].Value.ToString().Trim();
                this.cbbMaKH.Text = dgvPTP.Rows[r].Cells[2].Value.ToString().Trim();
                this.txtTenKH.Text = dgvPTP.Rows[r].Cells[3].Value.ToString().Trim();
                this.txtMaPhong.Text = dgvPTP.Rows[r].Cells[4].Value.ToString().Trim();
                this.dtNgayTraDK.Value = (DateTime)dgvPTP.Rows[r].Cells[6].Value;
            }
            catch
            {
                this.txtPTP.Text = "";
                this.cbbPDP.Text = "";
                this.cbbMaKH.Text = "";
                this.txtTenKH.Text = "";
                this.txtMaPhong.Text = "";

            }
        }

        private void btnPDP_Click(object sender, EventArgs e)
        {
            using (FrmPhieuDatPhong frmpdp = new FrmPhieuDatPhong())
            {
                frmpdp.ShowDialog();
                this.cbbPDP.Text = frmpdp.MaPDP_focused;
                this.cbbMaKH.Text = frmpdp.MaKH_focused;
            }
        }

        private void UserThuePhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
