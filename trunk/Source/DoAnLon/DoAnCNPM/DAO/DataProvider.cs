using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public static class DataProvider
    {
        public static OleDbConnection ketnoividu()
        {
            string strcon = "provider = microsoft.ace.oledb.12.0; data source = vidu.accdb";
            OleDbConnection con = new OleDbConnection(strcon);
            con.Open();
            return con;
        }

        public static DataTable LayBang(string strsql, OleDbConnection con)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(strsql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static bool executenonquery(string strsql, OleDbConnection con)
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
    }
}
