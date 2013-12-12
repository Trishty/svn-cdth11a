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
            //SqlConnection con = DataProvider.ConnectionString();
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from LoaiPhong";
            return DataProvider.GetDataSet1(sql, con);
        }
        public static DataSet dLayPhieuThuePhong(int iMaPhong)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from PhieuThuePhong where MaPhong = " + iMaPhong + "";
            return DataProvider.GetDataSet1(sql, con);
        }

        public static DataSet dAllLayPhieuThuePhong()
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from PhieuThuePhong";
            return DataProvider.GetDataSet1(sql, con);
        }

        public static DataSet dLayDSDoanhThu()
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from DoanhThu";
            return DataProvider.GetDataSet1(sql, con);
        }

        public static DataSet dLayDSMatDo()
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from MatDo";
            return DataProvider.GetDataSet1(sql, con);
        }

        public static DataSet dLayDSPhong()
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from Phong";
            return DataProvider.GetDataSet1(sql, con);
        }
        public static DataSet dLayThongTinLoaiPhong(int iMaLoaiPhong)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select * from LoaiPhong where MaLP = " + iMaLoaiPhong + "";
            return DataProvider.GetDataSet1(sql, con);
        }

        public static string dLayMaLoaiPhongTheoPhong(int iMaPhong)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select MaLP from Phong where MaPhong = " + iMaPhong + "";
            return DataProvider.ExecuteScalar1(sql, con);
        }

        public static string dLayKhachHangTheoMaPT(int iMaPT)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select TenKH from KhachHang where MaPhieuThue = " + iMaPT + "";
            return DataProvider.ExecuteScalar1(sql, con);
        }

        public static string dLayTenLoaiPhongTheoMaPhong(int iMaLP)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select TenLP from LoaiPhong where MaLP = " + iMaLP + "";
            return DataProvider.ExecuteScalar1(sql, con);
        }

        public static bool dXoaDoanThu(int iMaDT)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "delete from DoanhThu where MaDT = " + iMaDT + "";
            return DataProvider.ExecuteNonQuery1(sql, con);
        }

        public static bool dXoaMatDo(int iMaMD)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "delete from MatDo where MaMD = " + iMaMD + "";
            return DataProvider.ExecuteNonQuery1(sql, con);
        }

        public static string dMaxMaDT()
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select Max(MaDT) from DoanhThu";
            return DataProvider.ExecuteScalar1(sql, con);
        }

        public static string dMaxMaMD()
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select Max(MaMD) from MatDo";
            return DataProvider.ExecuteScalar1(sql, con);
        }
        public static bool dThemDoanhThu(int iMaDT, int iDoanhThuVND, double dDoanhThuUSD, float fTiLeDT, int iMaLP, int iThang)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "insert into DoanhThu values(" + iMaDT + "," + iDoanhThuVND + "," + dDoanhThuUSD + "," + fTiLeDT + "," + iMaLP + "," + iThang + ")";
            return DataProvider.ExecuteNonQuery1(sql, con);
        }

        public static bool dThemMatDo(int iMaMD, int iMatDoThang, float fTiLeMD, int iMaPhong, int iThang)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "insert into MatDo values(" + iMaMD + "," + iMatDoThang + "," + fTiLeMD + "," + iMaPhong + "," + iThang + ")";
            return DataProvider.ExecuteNonQuery1(sql, con);
        }

    }
}
