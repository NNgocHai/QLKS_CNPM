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
        SqlCommand cmd = null;
        public BLMain()
        {
            cmd= new SqlCommand();
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
            return db.ExecuteQueryDataSet(cmd, "PHONG_LayPhong");
        }
        public DataSet TimKiemNhanh(string TuKhoa)
        {
            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = TuKhoa;
            return db.ExecuteQueryDataSet(cmd, "TimKiemNhanh_Phong");
        }
        public DataSet TimKiem(string Gia,string TinhTrang, string SoNguoi,string KhuyenMai,string MoTa)
        {
            if(Gia != "")
                cmd.Parameters.Add("@Gia", SqlDbType.NVarChar).Value = Gia;
            else
                cmd.Parameters.Add("@Gia", SqlDbType.NVarChar).Value = DBNull.Value;
            if (TinhTrang != "")
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = TinhTrang;
            else
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = DBNull.Value;
            if (SoNguoi != "")
                cmd.Parameters.Add("@SoNguoi", SqlDbType.NVarChar).Value = SoNguoi;
            else
                cmd.Parameters.Add("@SoNguoi", SqlDbType.NVarChar).Value = DBNull.Value;
            if (KhuyenMai != "")
                cmd.Parameters.Add("@KhuyenMai", SqlDbType.NVarChar).Value = KhuyenMai;
            else
                cmd.Parameters.Add("@KhuyenMai", SqlDbType.NVarChar).Value = DBNull.Value;
            if (MoTa != "")
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = MoTa;
            else
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = DBNull.Value;

            return db.ExecuteQueryDataSet(cmd, "TIMKIEM_PHONG");
        }
        public List<string> LayTinhTrang()
        {
            List<string> dsTinhTrang = new List<string>();
            dsTinhTrang.Clear();
            SqlDataReader reader = db.MyExcuteProcReader(cmd, "PHONG_LayTinhTrang");
            while (reader.Read())
            {
                dsTinhTrang.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsTinhTrang;
        }
        public List<string> LayGia()
        {
            List<string> dsGia = new List<string>();
            dsGia.Clear();
            SqlDataReader reader = db.MyExcuteProcReader(cmd, "PHONG_LayGia");
            while (reader.Read())
            {
                dsGia.Add(reader.GetInt32(0).ToString());
            }
            db.myDispose();
            reader.Dispose();
            return dsGia;
        }
        public List<string> LaySoNguoi()
        {
            List<string> dsGia = new List<string>();
            dsGia.Clear();
            SqlDataReader reader = db.MyExcuteProcReader(cmd, "PHONG_LaySoNguoi");
            while (reader.Read())
            {
                dsGia.Add(reader.GetInt32(0).ToString());
            }
            db.myDispose();
            reader.Dispose();
            return dsGia;
        }
        public List<string> LayKhuyenMai()
        {
            List<string> dsKhuyenMai = new List<string>();
            dsKhuyenMai.Clear();
            SqlDataReader reader = db.MyExcuteProcReader(cmd, "PHONG_LayKhuyenMai");
            while (reader.Read())
            {
                dsKhuyenMai.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsKhuyenMai;
        }
        public List<string> LayMoTa()
        {
            List<string> dsMoTa = new List<string>();
            dsMoTa.Clear();
            SqlDataReader reader = db.MyExcuteProcReader(cmd, "PHONG_LayMoTa");
            while (reader.Read())
            {
                dsMoTa.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsMoTa;
        }
    }
}
