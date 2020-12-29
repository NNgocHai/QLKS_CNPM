using QLKS__ADO.Net_CNPM.BS_Layer;
using QLKS__ADO.Net_CNPM.BusinessObject;
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

    public partial class FrmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public string User;
        public string PhanQuyen;
        public string MaPhong;
        public string TinhTrangPhong;

        string err;
        DataTable DTP = null;
        BLMain BLM = null;
        int IsDangNhap;
        

        public FrmMain(string User,string PhanQuyen)
        {
            InitializeComponent();
            this.User = User;
            this.PhanQuyen = PhanQuyen;
            LoadDangNhap(User, PhanQuyen);
        }
        private void defaultcbbTimKiem()
        {
            cbbMoTa.ResetText();
            cbbKhuyenMai.ResetText();
            cbbGia.ResetText();
            cbbSoNguoi.ResetText();
            cbbSoNguoi.ResetText();
            cbbTinhTrang.ResetText();
        }
        private void Admin()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnNguoiDung.Enabled = true;
            btnRestore.Enabled = true;
            btnBackup.Enabled = true;

            btnKhachHang.Enabled = true;
            btnDichVu.Enabled = true;
            btnPhong.Enabled = true;
            btnDatPhong.Enabled = true;
            btnHoaDon.Enabled = true;

            btnDoanhThu.Enabled = true;
            btnDoanhThuDV.Enabled = true;
        }
        private void NhanVien()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnNguoiDung.Enabled = false;
            btnRestore.Enabled = false;
            btnBackup.Enabled = false;

            btnKhachHang.Enabled = true;
            btnDichVu.Enabled = true;
            btnPhong.Enabled = true;
            btnDatPhong.Enabled = true;
            btnHoaDon.Enabled = false;

            btnDoanhThu.Enabled = false;
            btnDoanhThuDV.Enabled = false;

        }
        private void Default()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnDoiMatKhau.Enabled = false;            
            btnNguoiDung.Enabled = false;
            btnRestore.Enabled = false;
            btnBackup.Enabled = false;

            btnKhachHang.Enabled = false;
            btnDichVu.Enabled = false;
            btnPhong.Enabled = false;

            btnDoanhThu.Enabled = false;
            btnDoanhThuDV.Enabled = false;



            btnDangXuat.Enabled = false;
            btnDangXuat.Enabled = false;
            btnDangXuat.Enabled = false;
            btnDangXuat.Enabled = false;
        }
        public void LoadData(DataTable DTP)
        {
            LoadTinhTrang();
            LoadGia();
            LoadSoNguoi();
            LoadMoTa();
            LoadKhuyenMai();
            try
            {
                
                Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
                foreach (DataRow dr in DTP.Rows)
                {
                    Button btn = new Button()
                    {
                        Width = 110,
                        Height = 110,
                        Location = new Point(oldbtn.Location.X + 110, oldbtn.Location.Y)

                    };
                    oldbtn = btn;
                    Phong Phong = new Phong();
                    Phong.Ma_Phong = (string)dr.ItemArray[0];
                    Phong.TinhTrang = (string)dr.ItemArray[3];


                    btn.Text = "Phòng: " + Phong.Ma_Phong + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Phong.TinhTrang;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.BackgroundImage = Properties.Resources.phongicon3;
                    btn.BackgroundImageLayout = ImageLayout.Zoom;

                    btn.Click += btn_Click;
                    btn.Tag = Phong;
                    btn.BackColor = Color.White;

                    switch (Phong.TinhTrang.Length)
                    {

                        case 2:

                            btn.ForeColor = Color.Green;
                            break;
                        default:
                            {
                                btn.ForeColor = Color.Red;
                                break;
                            }
                    }
                    fplPhong.Controls.Add(btn);
                }


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng PHONG. Lỗi rồi!!!");
            }
        }

        public DataTable LoadAll()
        {
            DTP = new DataTable();
            BLM = new BLMain();
            this.fplPhong.Controls.Clear();
            DTP.Clear();
            DataSet ds = BLM.LayPhong();
            DTP = ds.Tables[0];
            return DTP;
        }
        public DataTable LoadTimKiemNhanh()
        {
            DTP = new DataTable();
            BLM = new BLMain();
            this.fplPhong.Controls.Clear();
            DTP.Clear();
            DataSet ds = BLM.TimKiemNhanh(txtTimKiem.Text);
            DTP = ds.Tables[0];
            return DTP;
        }
        public DataTable LoadTimKiem()
        {
            DTP = new DataTable();
            BLM = new BLMain();
            this.fplPhong.Controls.Clear();
            DTP.Clear();
            DataSet ds = BLM.TimKiem(cbbGia.Text,cbbTinhTrang.Text,cbbSoNguoi.Text,cbbKhuyenMai.Text,cbbMoTa.Text);
            DTP = ds.Tables[0];
            return DTP;
        }
        private void LoadTinhTrang()
        {
             BLM = new BLMain();
            List<string> dsTrangThai = new List<string>();
            dsTrangThai.Clear();
            dsTrangThai = BLM.LayTinhTrang();
            cbbTinhTrang.Items.Clear();

            foreach (string TrangThai in dsTrangThai)
            {
                cbbTinhTrang.Items.Add(TrangThai);
            }
        }
        private void LoadGia()
        {
            BLM = new BLMain();
            List<string> dsGia = new List<string>();
            dsGia.Clear();
            dsGia = BLM.LayGia();
            cbbGia.Items.Clear();

            foreach (string Gia in dsGia)
            {
                cbbGia.Items.Add(Gia);
            }
        }
        private void LoadSoNguoi()
        {
            BLM = new BLMain();
            List<string> dsSoNguoi = new List<string>();
            dsSoNguoi.Clear();
            dsSoNguoi = BLM.LaySoNguoi();
            cbbSoNguoi.Items.Clear();

            foreach (string SoNguoi in dsSoNguoi)
            {
                cbbSoNguoi.Items.Add(SoNguoi);
            }
        }
        private void LoadKhuyenMai()
        {
            BLM = new BLMain();
            List<string> dsKhuyenMai = new List<string>();
            dsKhuyenMai.Clear();
            dsKhuyenMai = BLM.LayKhuyenMai();
            cbbKhuyenMai.Items.Clear();

            foreach (string KhuyenMai in dsKhuyenMai)
            {
                cbbKhuyenMai.Items.Add(KhuyenMai);
            }
        }
        private void LoadMoTa()
        {
            BLM = new BLMain();
            List<string> dsMoTa = new List<string>();
            dsMoTa.Clear();
            dsMoTa = BLM.LayMoTa();
            cbbMoTa.Items.Clear();

            foreach (string MoTa in dsMoTa)
            {
                cbbMoTa.Items.Add(MoTa);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "1" || PhanQuyen == "2")
            {
                try
                {
                    MaPhong = ((sender as Button).Tag as Phong).Ma_Phong;
                    TinhTrangPhong = ((sender as Button).Tag as Phong).TinhTrang;
                    if (TinhTrangPhong.Length == 2)
                    {

                        FrmPhongTrong frmPhongDaDat = new FrmPhongTrong(this);
                        frmPhongDaDat.ShowDialog();
                    }
                    else
                    {
                        FrmPhongDaThue frmPhongTrong = new FrmPhongDaThue(this);
                        frmPhongTrong.ShowDialog();
                    }
                }
                catch { }
            }   
        }
        private void LoadDangNhap(string User,string  PhanQuyen)
        {
            this.User = User;
            this.PhanQuyen = PhanQuyen;
            if (PhanQuyen == "1")
                NhanVien();
            else if (PhanQuyen == "2")
                Admin();
            else
                Default();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData(LoadAll());                       
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            using (FrmDangNhap frmDangNhap = new FrmDangNhap())
            {
                //this.Hide();
                frmDangNhap.ShowDialog();
                this.IsDangNhap = frmDangNhap.IsDangNhap;
                if(IsDangNhap == 1)
                {
                    this.User = frmDangNhap.dataUser;
                    this.PhanQuyen = frmDangNhap.PhanQuyen;
                    this.LoadDangNhap(User, PhanQuyen);
                }    
            }
            rbbTrangChu_Click(null,null);
 
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien(User, PhanQuyen);
            frmNhanVien.ShowDialog();
            if (frmNhanVien.IsXoaTK == 1)
                LoadDangNhap("User", "0");
            else
            {
                this.User = frmNhanVien.User;
                this.PhanQuyen = frmNhanVien.PhanQuyen;
                this.LoadDangNhap(User, PhanQuyen);
            }
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            FrmPhong frmPhong = new FrmPhong(this);
            frmPhong.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            BLMain filebackup = new BLMain();
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog()==DialogResult.OK)
            {
                filebackup.Backup(save.FileName,ref err);
            }    
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            BLMain restore = new BLMain();
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                restore.Restore(save.FileName, ref err);

                MessageBox.Show("Khôi phục dữ liệu thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


       

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            FrmDichVu frmDichVu = new FrmDichVu(PhanQuyen);
            frmDichVu.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void fplPhong_Paint(object sender, PaintEventArgs e)
        {
            LoadData(LoadAll());
        }

        private void fplPhong_Click(object sender, EventArgs e)
        {
            LoadData(LoadAll());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.LoadDangNhap("User", "0");
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau(User))
            {
                frmDoiMatKhau.ShowDialog();
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            using (FrmDoanhThu frmDoanhThu = new FrmDoanhThu())
            {
                frmDoanhThu.ShowDialog();
            }
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            using (FrmDoanhThuDV frmDoanhThuDV = new FrmDoanhThuDV())
            {
                frmDoanhThuDV.ShowDialog();
            }
        }

        private void buttonQuiDinh_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(LoadTimKiem());
            txtTimKiem.ResetText();
        }

        private void btnTimKiemNhanh_Click(object sender, EventArgs e)
        {
            LoadData(LoadTimKiemNhanh());
            defaultcbbTimKiem();
        }

        private void rbbTrangChu_Click(object sender, EventArgs e)
        {
             

            if (!pnlMain.Controls.Contains(fplPhong))
            {
                pnlMain.Controls.Add(fplPhong);
                fplPhong.Dock = DockStyle.Fill;
                fplPhong.BringToFront();
            }
            else
                fplPhong.BringToFront();
        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData(LoadAll());
            defaultcbbTimKiem();
            txtTimKiem.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (FrmPhieuDatPhong frmPhieuDatPhong = new FrmPhieuDatPhong())
            {
                frmPhieuDatPhong.ShowDialog();
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            using (FrmHoaDon frmHoaDon = new FrmHoaDon())
            {
                frmHoaDon.ShowDialog();
                LoadData(LoadAll());
            }
        }
    } 
}
