using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace DAO
{
    public static class DataProvider
    {
        #region Tạo kết nối
        public static SqlConnection ConnectionString()
        {
            string strcon = "Data Source=MYSTNOVE;Initial Catalog=QL_KhachSan;Integrated Security=SSPI;UID=sa";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }
        #endregion

        #region Lấy bảng
        public static DataTable GetDataTable(string strsql, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(strsql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        #endregion

        #region Thực thi câu lệnh sql
        public static bool ExecuteNonQuery(string strsql, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strsql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Lấy giá trị trả về
        public static string ExecuteScalar(string strsql, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(strsql, con);
                string strkq = Convert.ToString(cmd.ExecuteScalar());
                con.Close();
                cmd.Dispose();
                return strkq;
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
