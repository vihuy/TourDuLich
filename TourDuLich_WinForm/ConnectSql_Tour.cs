using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TourDuLich_WinForm
{
    class ConnectSql_Tour
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public SqlConnection OpenDB()
        {
            conn = new SqlConnection(@"Sever=DESKTOP-1K8OQ5U\SQLEXPRESS;database=TourDuLich");
            return conn;

        }

        public static void OpenConnection()
        {
            string sql = @"Sever=DESKTOP-1K8OQ5U\SQLEXPRESS;database=TourDuLich";
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();
            }
            catch (SqlException Ex)
            {

            }
        }
        public static void DisConnection()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public static DataTable getDataTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cmd.Dispose();
            return table;
        }
        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
