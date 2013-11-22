using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public static class HoaDonBUS
    {
        public static bool ThemHD(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.ThemHD(hdDTO);
        }

        public static bool ThemCT(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.ThemCT(hdDTO);
        }

        public static string LayMaHDTuDong(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayMaHDTuDong(hdDTO);
        }

        public static DataSet LayDanhSachKH(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayDanhSachKH(hdDTO);
        }

        public static DataSet LayDanhSachNV(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayDanhSachNV(hdDTO);
        }

        public static string LayDiaChiKH(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayDiaChiKH(hdDTO);
        }

        public static DataSet LayDanhSachPhong(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayDanhSachPhong(hdDTO);
        }

        public static string LayLoaiPhong(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayLoaiPhong(hdDTO);
        }

        public static string LayGiaVNPhong(HoaDonDTO hdDTO)
        {
            //kiem tra du lieu truoc khi them
            return HoaDonDAO.LayGiaVNPhong(hdDTO);
        }
    }
}
