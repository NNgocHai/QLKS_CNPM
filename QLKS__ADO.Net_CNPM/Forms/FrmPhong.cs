﻿using QLKS__ADO.Net_CNPM.BS_Layer;
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
    public partial class FrmPhong : Form
    {
        DataTable DTP = null;
        bool Them;
        string err;
        BLPhong BLP = null;
        FrmMain frmMain;
        string PhanQuyen;
        public FrmPhong(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.PhanQuyen = frmMain.PhanQuyen;
        }
        public void Default_Button()
        {
            if (PhanQuyen == "Admin")
            {
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
            }
            else
            {
                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
            }
        }
        public void Default_txt()
        {
            this.txtGia.ResetText();
            this.txtKhuyenMai.ResetText();
            this.txtMaPhong.ResetText();
            this.txtSoNguoiToiDa.ResetText();
            this.txtTen.ResetText();
            this.cbboxTrinhTrang.Text = "No";
            this.txtMota.ResetText();

        }
        private void LoadData()
        {
            try
            {
                BLP = new BLPhong();
                DTP = new DataTable();
                DTP.Clear();
                DataSet ds = BLP.LayPhong();
                DTP = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvPhong.DataSource = DTP;
                Default_txt();
                Default_Button();
                dgvPhong_CellClick(null, null);
                frmMain.LoadData(frmMain.LoadAll());
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng PHONG. Lỗi rồi!!!");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                BLPhong BLP = new BLPhong();
                DTP = new DataTable();
                DTP.Clear();
                DataSet ds = new DataSet();
                ds = BLP.TimKiemPhong(txtTimKiemPhong.Text);
                DTP = ds.Tables[0];
                dgvPhong.DataSource = DTP;    
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Default_txt();
            Default_Button();
            this.txtMaPhong.Enabled = true;
            dgvPhong_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BLP = new BLPhong();
            if (Them)
            {
                if (this.txtMaPhong.Text == "" || txtTen.Text==""|| txtGia.Text==""|| cbboxTrinhTrang.Text==""|| txtSoNguoiToiDa.Text==""|| txtKhuyenMai.Text==""|| txtMota.Text=="")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMaPhong.Focus();
                }
                else
                {
                    try
                    {//(string MaPhong, string Ten, string TinhTrang, string SoNguoiToiDa, string Gia, string KhuyenMai, ref string err)
                        if (BLP.ThemPhong(this.txtMaPhong.Text, this.txtTen.Text, this.txtGia.Text, this.cbboxTrinhTrang.Text, this.txtSoNguoiToiDa.Text, this.txtKhuyenMai.Text, this.txtMota.Text, ref err))
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
                if (txtTen.Text == "" || txtGia.Text == "" || cbboxTrinhTrang.Text == "" || txtSoNguoiToiDa.Text == "" || txtKhuyenMai.Text == "" || txtMota.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMaPhong.Focus();
                }
                else
                {
                    try
                    {
                        if (BLP.CapNhatPhong(this.txtMaPhong.Text, this.txtTen.Text, this.txtGia.Text, this.cbboxTrinhTrang.Text, this.txtSoNguoiToiDa.Text, this.txtKhuyenMai.Text, this.txtMota.Text, ref err))
                        {
                            LoadData();
                            MessageBox.Show("Đã sửa xong!");
                            Default_Button();
                            this.txtMaPhong.Enabled = true;

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
            dgvPhong_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaPhong.Enabled = false;
            this.txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BLP = new BLPhong();
            try
            {
                if (txtMaPhong.Text != "")
                {
                    DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "xác nhận", MessageBoxButtons.YesNoCancel);
                    if (DL == DialogResult.Yes)
                    {
                        int r = dgvPhong.CurrentCell.RowIndex;
                        if (BLP.XoaPhong(ref err, this.txtMaPhong.Text))
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

            this.txtMaPhong.Focus();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadData();
           
            
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLP = new BLPhong();
            try
            {
                //Thứ tự dòng hiện hành
                int r = dgvPhong.CurrentCell.RowIndex;
                //Chuyển thông tin lên panel
                this.txtMaPhong.Text = dgvPhong.Rows[r].Cells[0].Value.ToString().Trim();
                this.txtTen.Text = dgvPhong.Rows[r].Cells[1].Value.ToString().Trim();
                this.txtGia.Text = dgvPhong.Rows[r].Cells[2].Value.ToString().Trim();
                this.cbboxTrinhTrang.Text = dgvPhong.Rows[r].Cells[3].Value.ToString().Trim();
                this.txtSoNguoiToiDa.Text = dgvPhong.Rows[r].Cells[4].Value.ToString().Trim();
                this.txtKhuyenMai.Text = dgvPhong.Rows[r].Cells[5].Value.ToString().Trim();
                this.txtMota.Text = dgvPhong.Rows[r].Cells[6].Value.ToString().Trim();

            }
            catch
            {
                this.txtMaPhong.Text = "";
                this.txtTen.Text = "";
                this.cbboxTrinhTrang.Text = "";
                this.txtSoNguoiToiDa.Text = "";
                this.txtGia.Text = "";
                this.txtKhuyenMai.Text = "";
                this.txtMota.Text = "";
            }
        }
    }
}
