using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public static class PhieuThueBUS
    {
        public static bool ThemPT(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.ThemPT(ptDTO);
        }

        public static bool ThemKH(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.ThemKH(ptDTO);
        }

        public static bool XoaPT(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.XoaPT(ptDTO);
        }

        public static string LayMaTuPhieuDong(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.LayMaTuPhieuDong(ptDTO);
        }

        public static string LayMaTuKHDong(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.LayMaTuKHDong(ptDTO);
        }

        public static DataSet LayDanhSachPhong(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.LayDanhSachPhong(ptDTO);
        }

        public static DataSet LayDanhLoaiKhach(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.LayDanhLoaiKhach(ptDTO);
        }

        public static DataSet LayDanhSachPhieuThue(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.LayDanhSachPhieuThue(ptDTO);
        }

        public static DataSet LayThongTinPhieuThue(PhieuThueDTO ptDTO)
        {
            return PhieuThueDAO.LayThongTinPhieuThue(ptDTO);
        }
    }
}
