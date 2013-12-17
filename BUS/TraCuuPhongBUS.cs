using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class TraCuuPhongBUS
    {
        public static DataSet TraCuuPhong(TraCuuPhongDTO TCP_DTO)
        {
            return TraCuuPhongDAO.TraCuuPhong(TCP_DTO);
        }
    }
}
