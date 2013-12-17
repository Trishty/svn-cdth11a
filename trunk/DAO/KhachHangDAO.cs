using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        public static DataSet HienThiDanhSachKhachHang(KhachHangDTO KH_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strSQL = "select * from KhachHang";
            return DataProvider.GetDataSet(strSQL, con);
        }

        public static bool ThemKhachHang(KhachHangDTO KH_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();

            string strSQL = "insert into KhachHang values ("
            + KH_DTO.IMaKH + ",N'"
            + KH_DTO.StrTenKH + "',"
            + KH_DTO.LGiayToTuyThan + ",'"
            + bool.Parse(KH_DTO.BGioiTinh.ToString()) + "',N'"
            + KH_DTO.StrDiaChi + "',"
            + KH_DTO.StrSoDienThoai + ","
            + KH_DTO.IMaLK + ","
            + KH_DTO.IMaPhieuThue + ")";

            return DataProvider.ExecuteNonQuery(strSQL, con);
        }

        public static bool XoaKhachHang(KhachHangDTO KH_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();

            string strSQL = "delete from KhachHang where MaKH = " + KH_DTO.IMaKH;

            return DataProvider.ExecuteNonQuery(strSQL, con);
        }

        public static bool SuaKhachHang(KhachHangDTO KH_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();

            string strSQL = "update KhachHang set TenKH = N'"
            + KH_DTO.StrTenKH + "', GiayToTuyThan = "
            + KH_DTO.LGiayToTuyThan + ", GioiTinh = '"
            + bool.Parse(KH_DTO.BGioiTinh.ToString()) + "', DiaChi = N'"
            + KH_DTO.StrDiaChi + "', SoDT = "
            + KH_DTO.StrSoDienThoai + ", MaLK = "
            + KH_DTO.IMaLK + ", MaPhieuThue = "
            + KH_DTO.IMaPhieuThue + " where MaKH = "
            + KH_DTO.IMaKH;

            return DataProvider.ExecuteNonQuery(strSQL, con);
        }

        public static DataSet LayDuLieuMaPhieuThue(string strSQL)
        {
            SqlConnection con = DataProvider.ConnectionString();
            return DataProvider.GetDataSet(strSQL, con);
        }
    }
}
