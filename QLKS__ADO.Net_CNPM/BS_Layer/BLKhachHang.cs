using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKS__ADO.Net_CNPM.DB_Layer;
using System.Data;
using System.Data.SqlClient;

namespace QLKS__ADO.Net_CNPM.BS_Layer
{
    class BLKhachHang
    {
        DBMain db = null;
        SqlCommand cmd = null;
        public BLKhachHang()
        {
            db = new DBMain();
            cmd = new SqlCommand();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet(cmd, "KHACHHANG_LayKhachHang");
        }
        public DataSet ThongTinKhachHang(string MaPhong)
        {
            cmd.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = MaPhong;
            return db.ExecuteQueryDataSet(cmd, "KHACHHANG_ThongTinKhachHang");
        }

        public bool ThemKhachHang(string MaKH, string Ten, string DiaChi, string SDT, string CMND, string GioiTinh, string TinhTrang, ref string err)
        {
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = MaKH;
            cmd.Parameters.Add("@hotenkh", SqlDbType.NVarChar).Value = Ten;
            cmd.Parameters.Add("@diachikh", SqlDbType.NVarChar).Value = DiaChi;
            cmd.Parameters.Add("@sdtkh", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("@cmndkh", SqlDbType.NVarChar).Value = CMND;
            cmd.Parameters.Add("@gtkh", SqlDbType.NVarChar).Value = GioiTinh;
            cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = TinhTrang;
            return db.ExecuteProcNonQuery(cmd, "KHACHHANG_ThemKhachHang", ref err);
        }

        public bool CapNhatKhachHang(string MaKH, string Ten, string DiaChi, string SDT, string CMND, string GioiTinh, string TinhTrang, ref string err)
        {
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = MaKH;
            cmd.Parameters.Add("@hotenkh", SqlDbType.NVarChar).Value = Ten;
            cmd.Parameters.Add("@diachikh", SqlDbType.NVarChar).Value = DiaChi;
            cmd.Parameters.Add("@sdtkh", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("@cmndkh", SqlDbType.NVarChar).Value = CMND;
            cmd.Parameters.Add("@gtkh", SqlDbType.NVarChar).Value = GioiTinh;
            cmd.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = TinhTrang;
            return db.ExecuteProcNonQuery(cmd, "KHACHHANG_CapNhatKhachHang", ref err);
        }

        public bool XoaKhachHang(ref string err, string MaKH)
        {
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = MaKH;
            return db.ExecuteProcNonQuery(cmd, "KHACHHANG_XoaKhachHang", ref err);
        }
       
        public List<string> LayMAKH()
        {
            List<string> dsMaKH = new List<string>();
            dsMaKH.Clear();
            SqlDataReader reader = db.MyExcuteProcReader(cmd, "KHACHHANG_LayMAKH");
            while (reader.Read())
            {
                dsMaKH.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsMaKH;
        }

        public DataSet TimKiemNhanh(string TuKhoa)
        {
            cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = TuKhoa;
            return db.ExecuteQueryDataSet(cmd, "TIMKIEMNHANH_KHACHHANG");
        }


    }
}
