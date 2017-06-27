using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwality.DBConnect
{
    public class SqlHelper
    {
        static string sqlConnectString = @"Data Source = IRSDSK112\SQLEXPRESS; Initial Catalog = KwalityWallsDB; Persist Security Info=false;Integrated Security = SSPI";
        static SqlConnection conn = null;
        static SqlHelper()
        {
            conn = new SqlConnection(sqlConnectString);
        }

        private static void ConOpen()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private static void ConClose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
        public static DataTable Execute(String sqlQuery)
        {
            SqlDataAdapter sdaTemp = new SqlDataAdapter(sqlQuery, sqlConnectString);
            DataSet dsRet = new DataSet();
            sdaTemp.Fill(dsRet);
            return dsRet.Tables[0];
        }
        public static void Update(String sqlQuery)//,SqlParameter  param)
        {
            ConOpen();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            ConClose();
        }
        public static DataTable Search(String sqlQuery)//,SqlParameter  param)
        {
            ConOpen();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            ConClose();
            return data;
        }
    }
}
