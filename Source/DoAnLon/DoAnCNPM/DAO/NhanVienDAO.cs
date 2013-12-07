using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static DataSet HienThiDanhSachSinhVien(NhanVienDTO NV_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strSQL = "select * from NhanVien";
            return DataProvider.GetDataSet(strSQL, con);
        }

        public static bool ThemNhanVien(NhanVienDTO NV_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();

            string strSQL = "insert into NhanVien values ('"
            + NV_DTO.StrTenDangNhap + "','"
            + NV_DTO.StrMatKhau + "','"
            + NV_DTO.StrHoTen + "','"
            + NV_DTO.StrChucVu + "','"
            + NV_DTO.StrDiaChi + "','"
            + NV_DTO.StrDienThoai + "','"
            + NV_DTO.StrCMND + "')";

            return DataProvider.ExecuteNonQuery(strSQL, con);
        }
    }
}
