using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HNDuty.DBTool
{
    public class DBUtility
    {
        private string DBLink = ConfigurationManager.ConnectionStrings["HNDuty"].ConnectionString;  //連線資料庫字串


        /// <summary> 搜尋語法 </summary>
        /// <param name="SQL"></param>
        /// <returns></returns>
        protected DataSet ExecuteSearch(string SQL)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(this.DBLink);
            SqlDataAdapter data = new SqlDataAdapter(SQL, conn);
            data.Fill(ds);
            return ds;
        }


        protected int ExecuteInsUpdDel(string SQL)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(this.DBLink);
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

    }
}