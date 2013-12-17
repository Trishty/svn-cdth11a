﻿using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        public static DataSet HienThiDanhSachSinhVien (NhanVienDTO NV_DTO)
        {
            return NhanVienDAO.HienThiDanhSachSinhVien(NV_DTO);
        }

        public static bool ThemNhanVien(NhanVienDTO NV_DTO)
        {
            return NhanVienDAO.ThemNhanVien(NV_DTO);
        }

        public static bool XoaNhanVien(NhanVienDTO NV_DTO)
        {
            return NhanVienDAO.XoaNhanVien(NV_DTO);
        }

        public static bool SuaNhanVien(NhanVienDTO NV_DTO)
        {
            return NhanVienDAO.SuaNhanVien(NV_DTO);
        }
    }
}