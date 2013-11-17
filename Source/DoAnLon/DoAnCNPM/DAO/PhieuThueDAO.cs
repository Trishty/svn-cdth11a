using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public static class PhieuThueDAO
    {
        public static bool ThemPT(PhieuThueDTO ptDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "insert into PhieuThuePhong(MaPhieuThue, MaPhong, NgayThuePhong, NgayTraPhong) values ('"
            + ptDTO.MaPT + "','" + ptDTO.Phong + "','" + ptDTO.NgayThue + "','" 
            + ptDTO.NgayTra + "')";
            return DataProvider.ExecuteNonQuery(strsql, con);
        }
    }
}
