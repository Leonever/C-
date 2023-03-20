using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 数据库课程设计
{
    class sqlConnect
    {
        public SqlConnection conn = null;
        public sqlConnect()
        {
            if (conn == null)
            {
                conn = new SqlConnection("data source=LAPTOP-R63MC48K\\ZHANGJIANXIN;database=zhangjianxinMIS07;uid=sa;password=zjx123456;");
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
        }
        public void closeConnect()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        public DataSet Getds(string sql)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            return ds;
        }
        public int OperateData(string sql)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = sql;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.Connection = conn;
            int x = sqlcom.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        public DataSet BindDataGridView(DataGridView dgv, string sql)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            return ds;
        }
    }
}
