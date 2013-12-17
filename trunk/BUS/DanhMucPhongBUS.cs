using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DanhMucPhongBUS
    {
        public static int LayMaPhongTuDong()
        {
            return DanhMucPhongDAO.LayMaPhongTuDong();
        }

        public static DataSet LayDanhSachLoaiPhong()
        {
            return DanhMucPhongDAO.LayDanhSachLoaiPhong();
        }

        public static bool ThemPhong(DanhMucPhongDTO dmDTO)
        {
            return DanhMucPhongDAO.ThemPhong(dmDTO);
        }

        public static DataSet LayDanhSachPhong()
        {
            return DanhMucPhongDAO.LayDanhSachPhong();
        }

        public static DataSet LayThongTinPhong(DanhMucPhongDTO dmDTO)
        {
            return DanhMucPhongDAO.LayThongTinPhong(dmDTO);
        }

        public static bool SuaPhong(DanhMucPhongDTO dmDTO)
        {
            return DanhMucPhongDAO.SuaPhong(dmDTO);
        }

        public static string LayTenPhong(DanhMucPhongDTO dmDTO)
        {
            return DanhMucPhongDAO.LayTenPhong(dmDTO);
        }
    }
}
