using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DanhMucPhongDAO
    {
        public static int LayMaPhongTuDong()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select max(MaPhong) from Phong";
            return Convert.ToInt32(DataProvider.ExecuteScalar(strsql, con));
        }

        public static DataSet LayDanhSachLoaiPhong()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select * from LoaiPhong";
            return DataProvider.GetDataSet(strsql, con);
        }

        public static bool ThemPhong(DanhMucPhongDTO dmDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "insert into Phong (MaPhong, MaLP, TinhTrang, GhiChu)"
            + " values(" + dmDTO.MaPhong + "," + dmDTO.LoaiPhong + ",'"
            + dmDTO.TinhTrang + "','" + dmDTO.GhiChu + "')";
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static DataSet LayDanhSachPhong()
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select * from Phong";
            return DataProvider.GetDataSet(strsql, con);
        }

        public static DataSet LayThongTinPhong(DanhMucPhongDTO dmDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select * from Phong where MaPhong = " + dmDTO.MaPhong;
            return DataProvider.GetDataSet(strsql, con);
        }

        public static bool SuaPhong(DanhMucPhongDTO dmDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "update Phong set "
            + "MaLP = " + dmDTO.LoaiPhong
            + ",TinhTrang = '" + dmDTO.TinhTrang
            + "',GhiChu = '" + dmDTO.GhiChu
            + "' where MaPhong = " + dmDTO.MaPhong;
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static string LayTenPhong(DanhMucPhongDTO dmDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select TenLP from LoaiPhong where MaLP = " + dmDTO.LoaiPhong;
            return DataProvider.ExecuteScalar(strsql, con);
        }
    }
}
