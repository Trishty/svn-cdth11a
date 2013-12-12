using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public static class DangNhapBUS
    {
        public static string bKiemTraDanhNhap(DangNhapDTO dn)
        {
            return DangNhapDAO.dKiemTraDanhNhap(dn);
        }
    }
}
