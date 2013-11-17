using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
