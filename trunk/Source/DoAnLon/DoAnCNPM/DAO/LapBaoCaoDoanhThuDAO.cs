using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DAO
{
    public static class LapBaoCaoDoanhThuDAO
    {
        public static DataSet dLayDanhSachLoaiPhong()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from LoaiPhong";
            return DataProvider.GetDataSet(sql, con);
        }
        public static DataSet dLayPhieuThuePhong(int iMaPhong)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from PhieuThuePhong where MaPhong = " + iMaPhong + "";
            return DataProvider.GetDataSet(sql, con);
        }

        public static DataSet dAllLayPhieuThuePhong()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from PhieuThuePhong";
            return DataProvider.GetDataSet(sql, con);
        }

        public static DataSet dLayDSDoanhThu()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from DoanhThu";
            return DataProvider.GetDataSet(sql, con);
        }

        public static DataSet dLayDSMatDo()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from MatDo";
            return DataProvider.GetDataSet(sql, con);
        }

        public static DataSet dLayDSPhong()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from Phong";
            return DataProvider.GetDataSet(sql, con);
        }
        public static DataSet dLayThongTinLoaiPhong(int iMaLoaiPhong)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from LoaiPhong where MaLP = " + iMaLoaiPhong + "";
            return DataProvider.GetDataSet(sql, con);
        }

        public static string dLayMaLoaiPhongTheoPhong(int iMaPhong)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select MaLP from Phong where MaPhong = " + iMaPhong + "";
            return DataProvider.ExecuteScalar(sql, con);
        }

        public static string dLayKhachHangTheoMaPT(int iMaPT)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select TenKH from KhachHang where MaPhieuThue = " + iMaPT + "";
            return DataProvider.ExecuteScalar(sql, con);
        }

        public static string dLayTenLoaiPhongTheoMaPhong(int iMaLP)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select TenLP from LoaiPhong where MaLP = " + iMaLP + "";
            return DataProvider.ExecuteScalar(sql, con);
        }

        public static bool dXoaDoanThu(int iMaDT)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "delete from DoanhThu where MaDT = " + iMaDT + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dXoaMatDo(int iMaMD)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "delete from MatDo where MaMD = " + iMaMD + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static string dMaxMaDT()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select Max(MaDT) from DoanhThu";
            return DataProvider.ExecuteScalar(sql, con);
        }

        public static string dMaxMaMD()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select Max(MaMD) from MatDo";
            return DataProvider.ExecuteScalar(sql, con);
        }
        public static bool dThemDoanhThu(int iMaDT, int iDoanhThuVND, double dDoanhThuUSD, float fTiLeDT, int iMaLP, int iThang)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "insert into DoanhThu values(" + iMaDT + "," + iDoanhThuVND + "," + dDoanhThuUSD + "," + fTiLeDT + "," + iMaLP + "," + iThang + ")";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dThemMatDo(int iMaMD, int iMatDoThang, float fTiLeMD, int iMaPhong, int iThang)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "insert into MatDo values(" + iMaMD + "," + iMatDoThang + "," + fTiLeMD + "," + iMaPhong + "," + iThang + ")";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

    }
}
