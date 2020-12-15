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
        string err;
        //public static bool bIsLogin = false;
        DataTable DTP = null;
        BLMain BLM = null;
        public string User;

        public string MaPhong;
        public string TinhTrangPhong;

        public FrmMain(string User,string Quyen)
        {
            InitializeComponent();
            this.User = User;
            if (Quyen == "1")
                NhanVien();
            else if (Quyen == "2")
                Admin();
            else
                Default(); 
        }
        private void Admin()
        {
          
        }
        private void NhanVien()
        {
            btnKhachHang.Enabled = false;
            btnLoaiPhong.Enabled = false;
        }
        private void Default()
        {
            btnDangXuat.Enabled = false;
        }
        public void LoadData()
        {
            try
            {
                DTP = new DataTable();
                BLM = new BLMain();
                this.fplPhong.Controls.Clear();
                DTP.Clear();
                DataSet ds = BLM.LayPhong();
                DTP = ds.Tables[0];
                Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
                foreach (DataRow dr in DTP.Rows)
                {
                    Button btn = new Button()
                    {
                        Width = 100,
                        Height = 100,
                        Location = new Point(oldbtn.Location.X + 100, oldbtn.Location.Y)

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
        private void btn_Click(object sender, EventArgs e)
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

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadData();           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
            this.Close();
 
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.ShowDialog();
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
            FrmDichVu frmDichVu = new FrmDichVu();
            frmDichVu.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void fplPhong_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }




        private void fplPhong_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    } 
}
