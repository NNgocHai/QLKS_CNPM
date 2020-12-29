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
    
    class BLPhieuDatPhong
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLPhieuDatPhong()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public DataSet ThongTinPhieuDatPhong(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.ExecuteQueryDataSet(cmd, "PHIEUDATPHONG_LayThongTin");
        }
        public DataSet layPDP()
        {
            return db.ExecuteQueryDataSet(cmd, "PHIEUDATPHONG_LayPDP");
        }
        public DataSet TimKiemNhanh(string TuKhoa)
        {
            cmd.Parameters.Add("@TuKhoa", SqlDbType.VarChar).Value = TuKhoa;
            return db.ExecuteQueryDataSet(cmd, "TIMKIEMNHANH_PDP");
        }
        public bool ThemPhieuDatPhong(string MaKH, string SoNguoi, string MaPhong, DateTime NgayNhan, string TienCoc, ref string err)
        {
            cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = MaKH;
            cmd.Parameters.Add("@SoNguoi", SqlDbType.NVarChar).Value = SoNguoi;
            cmd.Parameters.Add("@MaPhong", SqlDbType.NVarChar).Value = MaPhong;
            cmd.Parameters.Add("@NgayNhan", SqlDbType.DateTime).Value = NgayNhan;
            cmd.Parameters.Add("@TienCoc", SqlDbType.NVarChar).Value = TienCoc;
            return db.ExecuteProcNonQuery(cmd, "PHIEUDATPHONG_ThemPDP", ref err);
        }
        public bool XoaPhieuDatPhong(ref string err, string MaPDP)
        {
            cmd.Parameters.Add("@MaPDP", SqlDbType.VarChar).Value = MaPDP;
            return db.ExecuteProcNonQuery(cmd, "PHIEUDATPHONG_XoaPDP", ref err);
        }
        public bool CapNhatPhieuDatPhong(string MaPDP, string MAKH, string SoNguoi, DateTime NgayNhan, string TienCoc, ref string err)

        {
            cmd.Parameters.Add("@MaPDP", SqlDbType.VarChar).Value = MaPDP;
            cmd.Parameters.Add("@MAKH", SqlDbType.VarChar).Value = MAKH;
            cmd.Parameters.Add("@SoNguoi", SqlDbType.NVarChar).Value = SoNguoi;
            cmd.Parameters.Add("@NgayNhan", SqlDbType.DateTime).Value = NgayNhan;
            cmd.Parameters.Add("@TienCoc", SqlDbType.NVarChar).Value = TienCoc;
            return db.ExecuteProcNonQuery(cmd, "PHIEUDATPHONG_CapNhatPDP", ref err);
        }
        public bool XoaPhieuKhongCoCTPDP(ref string err)
        {
            return db.ExecuteProcNonQuery(cmd, "PHIEUDATPHONG_XoaPDP_KO_CO_CTPDP", ref err);
        }


    }
}
