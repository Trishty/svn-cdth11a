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
            + NV_DTO.StrDiaChi + "','"
            + NV_DTO.StrDienThoai + "','"
            + NV_DTO.StrCMND + "')";

            return DataProvider.ExecuteNonQuery(strSQL, con);
        }

        public static bool XoaNhanVien(NhanVienDTO NV_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();

            string strSQL = "delete from nhanvien where tendn = '" + NV_DTO.StrTenDangNhap.ToString() + "'";

            return DataProvider.ExecuteNonQuery(strSQL, con);
        }

        public static bool SuaNhanVien(NhanVienDTO NV_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();

            string strSQL = "update NhanVien set MatKhau = '"
            + NV_DTO.StrMatKhau + "', TenNV = N'"
            + NV_DTO.StrHoTen + "', DiaChi = N'"
            + NV_DTO.StrDiaChi + "', DienThoai = '"
            + NV_DTO.StrDienThoai + "', CMND = '"
            + NV_DTO.StrCMND + "' where TenDN = '"
            + NV_DTO.StrTenDangNhap + "'";
            
            return DataProvider.ExecuteNonQuery(strSQL, con);
        }
    }
}
