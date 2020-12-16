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
    class BLThanhToan
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLThanhToan()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public object KT_MaKM(string MA_KM)
        {
            cmd.Parameters.Add("@MA_KM", SqlDbType.VarChar).Value = MA_KM;
            return db.MyExecuteScalar(cmd, "Select dbo.GIAMDGIA_HetHan (@MA_KM)");
        }

        public DataSet UpDateNgayTra(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.ExecuteQueryDataSet(cmd, "PHIEUTHUEPHONG_UpdateNgayTra");
        }
        public DataSet UpDateNgayTra_ChuaThanhToan(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.ExecuteQueryDataSet(cmd, "PHIEUTHUEPHONG_UpdateNgayTra_ChuaThanhToan");
        }
        public object LayMaPTP(string MaPhong)
        {          
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.MyExecuteScalar(cmd, "Select dbo.HOADON_LayMAPTP(@MaPhong)");
        }
        public DataSet LayThongTin(string MaPTP)
        {
            cmd.Parameters.Add("@MaPTP", SqlDbType.VarChar).Value = MaPTP;
            return db.ExecuteQueryDataSet(cmd, "HOADON_LayThongTin");
        }

        public DataSet ThemHD(string MaPhong,string TenDangNhap,string Ma_KMKH)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = TenDangNhap;
            cmd.Parameters.Add("@Ma_KMKH", SqlDbType.VarChar).Value = Ma_KMKH;
            return db.ExecuteQueryDataSet(cmd, "HOADON_ThemHD");
        }
        public DataSet XoaThongTin(string MaPTP)
        {
            cmd.Parameters.Add("@MaPTP", SqlDbType.VarChar).Value = MaPTP;
            return db.ExecuteQueryDataSet(cmd, "HOADON_XoaHDChuaThanhToan");
        }

    }
}
