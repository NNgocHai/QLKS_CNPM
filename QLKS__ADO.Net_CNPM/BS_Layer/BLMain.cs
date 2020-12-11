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
    class BLMain
    {
        DBMain db = null;
        public BLMain()
        {
            db = new DBMain();
        }
        public void Backup(string fileName, ref string err)
        {
            //Trong thủ tục, hàm, view không được sử dụng use master
            string sqlString = "use master Backup database CSDL_KHACHSAN to disk ='" + fileName + ".bak'";
            db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public void Restore(string fileName, ref string err)
        {
            //Trong thủ tục, hàm, view không được sử dụng use master
            string sqlString = "use master alter database [CSDL_KHACHSAN] set single_user with rollback immediate restore database [CSDL_KHACHSAN] from disk = '" + fileName + "'with replace alter database [CSDL_KHACHSAN] set multi_user";
            db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayPhong()
        {
            SqlCommand cmd = new SqlCommand();
            return db.ExecuteQueryDataSet(cmd, "PHONG_LayPhong");
        }
    }
}
