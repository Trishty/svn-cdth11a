using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public static class ThayDoiQuyDinhBUS
    {
        public static DataSet bLayDanhSachLoaiKhach()
        {
            return ThayDoiQuyDinhDAO.dLayDanhSachLoaiKhach();
        }

        public static bool bSuaSoLuongPhong(ThayDoiQuyDinhDTO tdqd)
        {
            return ThayDoiQuyDinhDAO.dSuaSoLuongPhong(tdqd);
        }

        public static bool bSuaSLKhachToiDa(ThayDoiQuyDinhDTO tdqd)
        {
            return ThayDoiQuyDinhDAO.dSuaSLKhachToiDa(tdqd);
        }

        public static bool bSuaGiaVN(ThayDoiQuyDinhDTO tdqd)
        {
            return ThayDoiQuyDinhDAO.dSuaGiaVN(tdqd);
        }

        public static bool bSuaGiaNN(ThayDoiQuyDinhDTO tdqd)
        {
            return ThayDoiQuyDinhDAO.dSuaGiaNN(tdqd);
        }

        public static bool bSuaTyLePhuThu(ThayDoiQuyDinhDTO tdqd)
        {
            return ThayDoiQuyDinhDAO.dSuaTyLePhuThu(tdqd);
        }
        public static bool bSuaHeSoLoaiKhach(int iMaLK, int iHeSo)
        {
            return ThayDoiQuyDinhDAO.dSuaHeSoLoaiKhach(iMaLK, iHeSo);
        }
    }
}
