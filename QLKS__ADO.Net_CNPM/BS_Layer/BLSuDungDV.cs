using QLKS__ADO.Net_CNPM.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS__ADO.Net_CNPM.BS_Layer
{
    class BLSuDungDV
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLSuDungDV()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public DataSet ThongTinHDDV(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.ExecuteQueryDataSet(cmd, "HOADONDV_LayThongTin");
        }
        public DataSet ThongTinHDDV_TuPTP(string MaPTP)
        {
            cmd.Parameters.Add("@MaPTP", SqlDbType.VarChar).Value = MaPTP;
            return db.ExecuteQueryDataSet(cmd, "HOADONDV_LayThongTinTuPTP");
        }
        public DataSet OrderForThem(string MaPhong,string MaDV)//0
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            return db.ExecuteQueryDataSet(cmd, "HOADONDV_OrderForThem");
        }
        public DataSet OrderForThemKhongTonTaiDV(string MaPhong, string MaDV, string Gia)//2
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            cmd.Parameters.Add("@Gia", SqlDbType.VarChar).Value = Gia;
            return db.ExecuteQueryDataSet(cmd, "HOADONDV_OrderForThemKhongTonTaiDV");
        }
        public DataSet OrderForThemTonTaiDV(string MaPhong, string MaDV, string Gia)//1
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            cmd.Parameters.Add("@Gia", SqlDbType.VarChar).Value = Gia;
            return db.ExecuteQueryDataSet(cmd, "HOADONDV_OrderForThemTonTaiDV");
        }
        public DataSet OrderForXoaTonTaiDV(string MaPhong, string MaDV, string Gia)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            cmd.Parameters.Add("@Gia", SqlDbType.VarChar).Value = Gia;
            return db.ExecuteQueryDataSet(cmd, "HOADONDV_OrderForXoaTonTaiDV");
        }
        public object CheckForAddata(string MaPhong, string MaDV)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@MaDV", SqlDbType.VarChar).Value = MaDV;
            return db.MyExecuteScalar(cmd, "Select dbo.HOADONDV_CheckForAddData(@MaPhong,@MaDV)");
        }
        public object LayPhanQuyen(string TenDangNhap)
        {
            cmd.Parameters.Add("@tendn", SqlDbType.VarChar).Value = TenDangNhap;
            return db.MyExecuteScalar(cmd, "Select dbo.NHANVIEN_LayPhanQuyen(@tendn)");
        }
    }
}
