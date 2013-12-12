using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public static class DangNhapDAO
    {
        public static string dKiemTraDanhNhap(DangNhapDTO dn)
        {
            OleDbConnection con = DataProvider.ConnectionString1();
            string sql = "select Count(*) from NhanVien where TenDN = '" + dn.TenDN + "' and MatKhau = '"+dn.MatKhau+"'";
            return DataProvider.ExecuteScalar1(sql, con);
        }
    }
}
