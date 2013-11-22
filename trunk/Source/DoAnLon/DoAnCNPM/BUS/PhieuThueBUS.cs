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
            //kiem tra du lieu truoc khi them
            return PhieuThueDAO.ThemPT(ptDTO);
        }

        public static bool ThemKH(PhieuThueDTO ptDTO)
        {
            //kiem tra du lieu truoc khi them
            return PhieuThueDAO.ThemKH(ptDTO);
        }

        public static string LayMaTuPhieuDong(PhieuThueDTO ptDTO)
        {
            //kiem tra du lieu truoc khi them
            return PhieuThueDAO.LayMaTuPhieuDong(ptDTO);
        }

        public static string LayMaTuKHDong(PhieuThueDTO ptDTO)
        {
            //kiem tra du lieu truoc khi them
            return PhieuThueDAO.LayMaTuKHDong(ptDTO);
        }

        public static DataSet LayDanhSachPhong(PhieuThueDTO ptDTO)
        {
            //kiem tra du lieu truoc khi them
            return PhieuThueDAO.LayDanhSachPhong(ptDTO);
        }

        public static DataSet LayDanhLoaiKhach(PhieuThueDTO ptDTO)
        {
            //kiem tra du lieu truoc khi them
            return PhieuThueDAO.LayDanhLoaiKhach(ptDTO);
        }
    }
}
