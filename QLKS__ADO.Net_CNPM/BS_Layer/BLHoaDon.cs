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
    class BLHoaDon
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLHoaDon()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet(cmd, "HOADON_LayHoaDon");
        }
        public DataSet TimKiem(string TuKhoa,string stringDate )
        {
            if (TuKhoa == "")
                cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = TuKhoa;
            if (stringDate == "    -  -")
                cmd.Parameters.Add("@stringDate", SqlDbType.NVarChar).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@stringDate", SqlDbType.NVarChar).Value = stringDate;

            return db.ExecuteQueryDataSet(cmd, "TIMKIEMNHANH_HOADON");
        }
        public bool XoaHoaDon(ref string err, string MaHD)
        {
            cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = MaHD;
            return db.ExecuteProcNonQuery(cmd, "HOADON_XoaHoaDon", ref err);
        }
    }
}
