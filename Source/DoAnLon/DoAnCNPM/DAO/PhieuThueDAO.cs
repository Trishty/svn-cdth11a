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
            string strsql = "insert into PhieuThuePhong"
            + "(MaPhieuThue, MaPhong, NgayThuePhong, NgayTraPhong) values ("
            + ptDTO.MaPT + "," + ptDTO.Phong + ",'" + ptDTO.NgayThue + "','" 
            + ptDTO.NgayTra + "')";
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static bool ThemKH(PhieuThueDTO ptDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "insert into KhachHang"
            + "(MaKH, TenKH, GiayToTuyThan, GioiTinh, DiaChi, SoDT, MaLK, MaPhieuThue)"
            + " values (" + ptDTO.MaKH + ",'" + ptDTO.KhachHang + "'," 
            + ptDTO.CMND + ",'" + ptDTO.GioiTinh + "','" + ptDTO.DiaChi + "'," 
            + ptDTO.DienThoai + "," + ptDTO.LoaiKhach + "," + ptDTO.MaPT + ")";
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static string LayMaTuPhieuDong(PhieuThueDTO ptDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select max(MaPhieuThue) from PhieuThuePhong";
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayMaTuKHDong(PhieuThueDTO ptDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select max(MaKH) from KhachHang";
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static DataSet LayDanhSachPhong(PhieuThueDTO ptDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strTenBang = "Select * from Phong";
            return DataProvider.GetDataSet(strTenBang, con);
        }

        public static DataSet LayDanhLoaiKhach(PhieuThueDTO ptDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strTenBang = "Select * from LoaiKhach";
            return DataProvider.GetDataSet(strTenBang, con);
        }
    }
}
