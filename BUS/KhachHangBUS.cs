using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        public static DataSet HienThiDanhSachKhachHang(KhachHangDTO KH_DTO)
        {
            return KhachHangDAO.HienThiDanhSachKhachHang(KH_DTO);
        }

        public static bool ThemKhachHang(KhachHangDTO KH_DTO)
        {
            return KhachHangDAO.ThemKhachHang(KH_DTO);
        }

        public static bool XoaKhachHang(KhachHangDTO KH_DTO)
        {
            return KhachHangDAO.XoaKhachHang(KH_DTO);
        }

        public static bool SuaKhachHang(KhachHangDTO KH_DTO)
        {
            return KhachHangDAO.SuaKhachHang(KH_DTO);
        }

        public static DataSet LayDuLieuMaPhieuThue(string sql)
        {
            return KhachHangDAO.LayDuLieuMaPhieuThue(sql);
        }
    }
}
