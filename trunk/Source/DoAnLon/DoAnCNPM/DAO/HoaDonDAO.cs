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

        public static bool XoaHD(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "update HoaDonThanhToan set"
            + " TrangThai = '" + hdDTO.TrangThai
            + "' where MaHD = " + hdDTO.MaHD;
            return DataProvider.ExecuteNonQuery(strsql, con);
        }

        public static string LayMaHDTuDong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select max(MaHD) from HoaDonThanhToan";
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static DataSet LayDanhSachHD(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "Select * from HoaDonThanhToan";
            return DataProvider.GetDataSet(strsql, con);
        }

        public static DataSet LayDanhSachKH(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "Select * from KhachHang";
            return DataProvider.GetDataSet(strsql, con);
        }

        public static DataSet LayDanhSachNV(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "Select * from NhanVien";
            return DataProvider.GetDataSet(strsql, con);
        }

        public static DataSet LayDanhSachPhong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "Select * from Phong";
            return DataProvider.GetDataSet(strsql, con);
        }

        public static string LayLoaiPhong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select MaLP from Phong where MaPhong = "
                + hdDTO.MaLP;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayLoaiKhach(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select MaLK from KhachHang where MaKH = "
                + hdDTO.MaKH;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayGiaVNPhong(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select GiaVN from LoaiPhong where MaLP = "
                + hdDTO.MaLP;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayHeSo(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select HeSo from LoaiKhach where MaLK = "
                + hdDTO.MaLK;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayTyLePhuThuMax(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select TyLePhuThuMax from LoaiPhong where MaLP = "
                + hdDTO.MaLP;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayTyLePhuThuMin(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select TyLePhuThuMin from LoaiPhong where MaLP = "
                + hdDTO.MaLP;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static DataSet LayThongTinHoaDon(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select * from HoaDonThanhToan where MaHD = "
                + hdDTO.MaHD;
            return DataProvider.GetDataSet(strsql, con);
        }

        public static string LayTenKhachHang(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select TenKH from KhachHang where MaKH = "
                + hdDTO.MaKH;
            return DataProvider.ExecuteScalar(strsql, con);
        }

        public static string LayTenNhanVien(HoaDonDTO hdDTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strsql = "select TenNV from NhanVien where TenDN = '"
                + hdDTO.TenDN + "'";
            return DataProvider.ExecuteScalar(strsql, con);
        }
    }
}
