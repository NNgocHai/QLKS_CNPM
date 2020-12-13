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
    public partial class UserSuDungDV : UserControl
    {
        DataTable Data = null;
        BLSuDungDV BLSDDV = null;
        BLDichVu BLDV = null;
        string MaPhong;
        string MaDV;
        string Gia;
        public UserSuDungDV(string MaPhong)
        {
            InitializeComponent();
            this.MaPhong = MaPhong;
        }

        private void UserSuDungDV_Load(object sender, EventArgs e)
        {
            LoadDataDVSD();
            LoadDataTTDV();
        }
        private void LoadDataDVSD()
        {
            try
            {
                BLSDDV = new BLSuDungDV();
                Data = new DataTable();
                Data.Clear();
                DataSet ds = BLSDDV.ThongTinHDDV(MaPhong);
                Data = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvDVSD.DataSource = Data;
                //dgvDichVu_CellClick(null, null);

            }
            catch (SqlException)
            {

            }
        }
        private void LoadDataTTDV()
        {
            try
            {

                BLDV = new BLDichVu();
                Data = new DataTable();
                Data.Clear();
                DataSet ds = BLDV.LayDichVu();
                Data = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvDichVu.DataSource = Data;
                dgvDichVu_CellClick(null, null);

            }
            catch (SqlException)
            {

            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BLSDDV = new BLSuDungDV();

                int r = dgvDichVu.CurrentCell.RowIndex;
                MaDV = dgvDichVu.Rows[r].Cells[2].Value.ToString().Trim();
                Gia = dgvDichVu.Rows[r].Cells[4].Value.ToString().Trim();
                object Kiemtra = BLSDDV.CheckForAddata(MaPhong, MaDV);
                if (dgvDichVu.Columns[e.ColumnIndex].Name.ToString() == "Them")
                {
                    BLSDDV = new BLSuDungDV();
                    if (Kiemtra.Equals(0))
                    {
                        BLSDDV.OrderForThem(MaPhong, MaDV);
                    }
                    else if (Kiemtra.Equals(1))
                    {
                        BLSDDV.OrderForThemTonTaiDV(MaPhong, MaDV, Gia);
                    }
                    else
                    {
                        BLSDDV.OrderForThemKhongTonTaiDV(MaPhong, MaDV, Gia);
                    }
                    LoadDataDVSD();

                }
                if (dgvDichVu.Columns[e.ColumnIndex].Name.ToString() == "Giam")
                {
                    BLSDDV = new BLSuDungDV();

                    if (Kiemtra.Equals(0))
                    {
                        // BLSDDV.OrderForThem(MaPhong, MaDV);
                    }
                    else if (Kiemtra.Equals(1))
                    {
                        BLSDDV.OrderForXoaTonTaiDV(MaPhong, MaDV, Gia);
                    }
                    else
                    {
                        //BLSDDV.OrderForThemKhongTonTaiDV(MaPhong, MaDV, Gia);
                    }
                    LoadDataDVSD();
                }
            }
            catch { }
        }

        private void dgvDVSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
