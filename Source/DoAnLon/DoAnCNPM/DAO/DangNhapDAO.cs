using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public static class DangNhapDAO
    {
        public static string dKiemTraDanhNhap(DangNhapDTO dn)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string sql = "select Count(*) from NhanVien where TenDN = '" + dn.TenDN + "' and MatKhau = '"+dn.MatKhau+"'";
            return DataProvider.ExecuteScalar(sql, con);
        }
    }
}
