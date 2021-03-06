﻿using QLKS__ADO.Net_CNPM.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS__ADO.Net_CNPM.BS_Layer
{
    class BLPhieuNhanPhong
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLPhieuNhanPhong()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public DataSet ThongTinPhieuThuePhong(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.ExecuteQueryDataSet(cmd, "PHIEUTHUEPHONG_LayThongTin");
        }
        //@MaPDP varchar,@MaKH varchar(10),@MaPhong varchar(10),@NgayTraDK Datetime,@NgayTraTT Datetime
        public bool ThemPTP(string MaPDP, string MAKH, string MaPhong, DateTime NgayTraDK, ref string err)
        {
            cmd.Parameters.Add("@MaPDP", SqlDbType.VarChar).Value = MaPDP;
            cmd.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = MAKH;
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            cmd.Parameters.Add("@NgayTraDK", SqlDbType.DateTime).Value = NgayTraDK;
            return db.ExecuteProcNonQuery(cmd, "PHIEUTHUEPHONG_ThemPTP", ref err);
        }
        public bool XoaPhieuThuePhong(ref string err, string MaPTP)
        {
            cmd.Parameters.Add("@MaPTP", SqlDbType.VarChar).Value = MaPTP;
            return db.ExecuteProcNonQuery(cmd, "PHIEUTHUEPHONG_XoaPTP", ref err);
        }// @MaPTP varchar(10),@MaPDP varchar(10),@MaKH varchar(10),@NgayTraDK Datetime,@NgayTraTT Datetime
        public bool CapNhatPhieuThuePhong(string MaPTP, string MaPDP, string MaKH, DateTime NgayTraDK, ref string err)

        {
            cmd.Parameters.Add("@MaPTP", SqlDbType.VarChar).Value = MaPTP;
            cmd.Parameters.Add("@MaPDP", SqlDbType.VarChar).Value = MaPDP;
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = MaKH;
            cmd.Parameters.Add("@NgayTraDK", SqlDbType.DateTime).Value = NgayTraDK;
            return db.ExecuteProcNonQuery(cmd, "PHIEUTHUEPHONG_CapNhatPTP", ref err);
        }

        public object KiemTraThemPTP(string MaPDP,string MaKH)
        {
            cmd.Parameters.Add("@MaPDP", SqlDbType.VarChar).Value = MaPDP;
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = MaKH;
            return db.MyExecuteScalar(cmd, "Select dbo.PHIEUTHUEPHONG_KiemTraPDPvsKH(@MaPDP ,@MaKH)");
        }
        public object KiemTraTonTaiPTP(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.MyExecuteScalar(cmd, "Select dbo.PHIEUTHUEPHONG_TonTaiDuyNhatMotPTP(@MaPhong)");
        }
        public bool XoaPhieuKhongCoCTPTP(ref string err)
        {
            return db.ExecuteProcNonQuery(cmd, "PHIEUTHUEPHONG_XoaPTP_KO_CO_CTPTP", ref err);
        }
    }
}
