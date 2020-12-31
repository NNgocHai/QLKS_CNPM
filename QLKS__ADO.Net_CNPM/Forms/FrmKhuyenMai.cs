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
    public partial class FrmKhuyenMai : Form
    {
        DataTable DTKM = null;
        bool Them;
        string err;
        BLKhuyenMai BLKM = null;
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }
        public void Default_Button()
        {
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
           
        }
        public void Default()
        {
            this.txtTenKM.ResetText();
            this.txtMaKM.ResetText();
            this.txtDiscount.ResetText();
            this.txtTimKiem.ResetText();
            this.dateTimePicker_NgayBD.ResetText();
            this.dateTimePicker_NgayKT.ResetText();
        }
        public void LoadData()
        {
            try
            {
                DTKM = new DataTable();
                BLKM = new BLKhuyenMai();
                DTKM.Clear();
                DataSet ds = BLKM.LayKM();
                DTKM = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvKM.DataSource = DTKM;
                Default();
                Default_Button();
                dgvKM_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng DICHVU. Lỗi rồi!!!");
            }
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Default();
            Default_Button();
            this.txtMaKM.Enabled = true;
            dgvKM_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLKM = new BLKhuyenMai();
            if (Them)
            {
                if (this.txtMaKM.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMaKM.Focus();
                }
                else
                {
                    try
                    {
                        if (BLKM.ThemKM(this.txtMaKM.Text, this.txtTenKM.Text, this.txtDiscount.Text,this.dateTimePicker_NgayBD.Value,this.dateTimePicker_NgayKT.Value, ref err))
                        {
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                            Default_Button();
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
            }
            else
            {

                try
                {
                    if (BLKM.CapNhatKhuyenMai(this.txtMaKM.Text, this.txtTenKM.Text, this.txtDiscount.Text, this.dateTimePicker_NgayBD.Value, this.dateTimePicker_NgayKT.Value, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                        Default_Button();
                        this.txtMaKM.Enabled = true;

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
            dgvKM_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaKM.Enabled = false;
            this.txtTenKM.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLKM = new BLKhuyenMai();
            try
            {
                if (txtMaKM.Text != "")
                {
                    DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
                    if (DL == DialogResult.Yes)
                    {
                        int r = dgvKM.CurrentCell.RowIndex;
                        if (BLKM.XoaKM(ref err, this.txtMaKM.Text))
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
                    MessageBox.Show("Bạn chưa nhập ID", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel

            Default();
            // Cho thao tác trên các nút Lưu / Hủy / Panel

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaKM.Focus();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BLKM = new BLKhuyenMai();
            DTKM = new DataTable();
            DTKM.Clear();
            DataSet ds = BLKM.TimKiemKhuyenMai(txtTimKiem.Text);
            DTKM = ds.Tables[0];
            dgvKM.DataSource = DTKM;
        }

        private void dgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Thứ tự dòng hiện hành
                int r = dgvKM.CurrentCell.RowIndex;
                //Chuyển thông tin lên panel
                this.txtMaKM.Text = dgvKM.Rows[r].Cells[0].Value.ToString().Trim();
                this.txtTenKM.Text = dgvKM.Rows[r].Cells[1].Value.ToString().Trim();
                this.txtDiscount.Text = dgvKM.Rows[r].Cells[2].Value.ToString().Trim();
                this.dateTimePicker_NgayBD.Value = (DateTime)dgvKM.Rows[r].Cells[3].Value;
                this.dateTimePicker_NgayKT.Value = (DateTime)dgvKM.Rows[r].Cells[4].Value;
            }
            catch
            {
                this.txtMaKM.Text = "";
                this.txtTenKM.Text = "";
                this.txtDiscount.Text = "";
            }
        }

        private void dgvKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
