using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class TraCuuPhongDAO
    {
        public static DataSet TraCuuPhong(TraCuuPhongDTO TCP_DTO)
        {
            SqlConnection con = DataProvider.ConnectionString();
            string strSQL = "select MaPhong, TenLP, GiaVN, TinhTrang from Phong, LoaiPhong where Phong.MaLP = LoaiPhong.MaLP and MaPhong = " + TCP_DTO.StrMaPhong;
            return DataProvider.GetDataSet(strSQL, con);
        }
    }
}
