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
    class BLKhuyenMai
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLKhuyenMai()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public DataSet LayKM()
        {
            return db.ExecuteQueryDataSet(cmd, "GIAMGIA_LayKM");
        }
        public bool ThemKM(string Ma_KM, string Ten_KM, string Discount,DateTime Ngay_BD,DateTime Ngay_KT, ref string err)
        {
            cmd.Parameters.Add("@Ma_KM", SqlDbType.VarChar).Value = Ma_KM;
            cmd.Parameters.Add("@Ten_KM", SqlDbType.NVarChar).Value = Ten_KM;
            cmd.Parameters.Add("@Discount", SqlDbType.NVarChar).Value = Discount;
            cmd.Parameters.Add("@Ngay_BD", SqlDbType.DateTime).Value = Ngay_BD;
            cmd.Parameters.Add("@Ngay_KT", SqlDbType.DateTime).Value = Ngay_KT;
            return db.ExecuteProcNonQuery(cmd, "GIAMGIA_ThemKM", ref err);
        }
        public bool XoaKM(ref string err, string Ma_KM)
        {
            cmd.Parameters.Add("@Ma_KM", SqlDbType.VarChar).Value = Ma_KM;
            return db.ExecuteProcNonQuery(cmd, "GIAMGIA_XoaKM", ref err);
        }

        public bool CapNhatKhuyenMai(string Ma_KM, string Ten_KM, string Discount, DateTime Ngay_BD, DateTime Ngay_KT, ref string err)
        {
            cmd.Parameters.Add("@Ma_KM", SqlDbType.VarChar).Value = Ma_KM;
            cmd.Parameters.Add("@Ten_KM", SqlDbType.NVarChar).Value = Ten_KM;
            cmd.Parameters.Add("@Discount", SqlDbType.NVarChar).Value = Discount;
            cmd.Parameters.Add("@Ngay_BD", SqlDbType.DateTime).Value = Ngay_BD;
            cmd.Parameters.Add("@Ngay_KT", SqlDbType.DateTime).Value = Ngay_KT;
            return db.ExecuteProcNonQuery(cmd, "GIAMGIA_CapNhatKM", ref err);
        }
        public DataSet TimKiemKhuyenMai(string TuKhoa)
        {
            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = TuKhoa;
            return db.ExecuteQueryDataSet(cmd, "TIMKIEMNHANH_GIAMGIA");
        }
    }
}
