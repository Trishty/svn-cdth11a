using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Data.OleDb;

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

        #region Lấy dữ liệu
        public static DataSet GetDataSet(string strSQL, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
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


        //////////////////////////////////
        #region Tạo kết nối
        public static OleDbConnection ConnectionString1()
        {
            string strcon = "provider = microsoft.jet.oledb.4.0; data source = QL_KhachSan.mdb";
            OleDbConnection con = new OleDbConnection(strcon);
            con.Open();
            return con;
        }
        #endregion

        #region Lấy bảng
        public static DataTable GetDataTable1(string strsql, OleDbConnection con)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(strsql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        #endregion

        #region Lấy dữ liệu
        public static DataSet GetDataSet1(string strSQL, OleDbConnection con)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        #endregion

        #region Lấy gia tri tra ve
        public static string ExecuteScalar1(string strsql, OleDbConnection con)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(strsql, con);
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

        #region Thực thi câu lệnh sql
        public static bool ExecuteNonQuery1(string strsql, OleDbConnection con)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(strsql, con);
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
        //////////////////////////////////
    }
}
