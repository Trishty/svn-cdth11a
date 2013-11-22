using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public static class HoaDonDAO
    {
        public static bool ThemHD(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "insert into HoaDonThanhToan"
            + "(MaHD, MaKH, TenDN, NgayLapHoaDon, TriGia) values ("
            + hdDTO.MaHD + "," + hdDTO.MaKH + ",'" + hdDTO.TenDN + "','"
            + hdDTO.NgayLap + "'," + hdDTO.TriGia + ")";
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static bool ThemCT(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "insert into ChiTietHoaDonThanhToan"
            + "(MaHD, MaPhong, SLKhach, SoNgayThue, DonGia) values (" 
            + hdDTO.MaHD + "," + hdDTO.Phong + "," + hdDTO.SLKhach + "," 
            + hdDTO.SoNgayThue + "," + hdDTO.DonGia + ")";
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static string LayMaHDTuDong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select max(MaHD) from HoaDonThanhToan";
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static DataSet LayDanhSachKH(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strTenBang = "KhachHang";
            return DataProvider.GetDataSet(strTenBang, con);
        }

        public static DataSet LayDanhSachNV(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strTenBang = "NhanVien";
            return DataProvider.GetDataSet(strTenBang, con);
        }

        public static string LayDiaChiKH(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select DiaChi from KhachHang where MaKH = "
                +hdDTO.MaKH;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static DataSet LayDanhSachPhong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strTenBang = "Phong";
            return DataProvider.GetDataSet(strTenBang, con);
        }

        public static string LayLoaiPhong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select MaLP from Phong where MaPhong = "
                + hdDTO.Tam;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayGiaVNPhong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select GiaVN from LoaiPhong where MaLP = "
                + hdDTO.Tam;
            return DataProvider.ExecuteScalar(strsql, con);
        }
    }
}
