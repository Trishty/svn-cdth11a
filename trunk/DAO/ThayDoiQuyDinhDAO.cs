using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public static class ThayDoiQuyDinhDAO
    {
        public static DataSet dLayDanhSachLoaiKhach()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select * from LoaiKhach";
            return DataProvider.GetDataSet(sql, con);
        }

        public static bool dSuaSoLuongPhong(ThayDoiQuyDinhDTO tdqd)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "update LoaiPhong set SLPhong = " + tdqd.SLPhong + " where MaLP=" + tdqd.MaLP + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dSuaSLKhachToiDa(ThayDoiQuyDinhDTO tdqd)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "update LoaiPhong set SLKhachToiDa = " + tdqd.SLKhachToiDa + " where MaLP=" + tdqd.MaLP + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dSuaGiaVN(ThayDoiQuyDinhDTO tdqd)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "update LoaiPhong set GiaVN = '" + tdqd.GiaVN + "' where MaLP=" + tdqd.MaLP + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dSuaGiaNN(ThayDoiQuyDinhDTO tdqd)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "update LoaiPhong set GiaNN = '" + tdqd.GiaNN + "' where MaLP=" + tdqd.MaLP + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dSuaTyLePhuThu(ThayDoiQuyDinhDTO tdqd)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "update LoaiPhong set TyLePhuThuMax = " + tdqd.TyLePhuThu + " where MaLP=" + tdqd.MaLP + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }

        public static bool dSuaHeSoLoaiKhach(int iMaLK, int iHeSo)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "update LoaiKhach set HeSo = " + iHeSo + " where MaLK=" + iMaLK + "";
            return DataProvider.ExecuteNonQuery(sql, con);
        }
    }
}
