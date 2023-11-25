using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.DB
{
	class DBMain
	{
		string ConnStr = "Data Source=(local);Initial Catalog=STUDENT_MANAGEMENT_PROJECT;Integrated Security=True";
		SqlConnection conn = null;
		SqlCommand comm = null;
		SqlDataAdapter da = null;
		public DBMain()
		{
			conn = new SqlConnection(ConnStr);
			comm = conn.CreateCommand();

		}
		public SqlConnection OpenConnect()
		{
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
			return conn;
		}
		public void CloseConnect()
		{
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
		}
		public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
		{
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.CommandText = strSQL;
			comm.CommandType = ct;
			da = new SqlDataAdapter(comm);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return ds;
		}
		public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
		{
			bool f = false;
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.CommandText = strSQL;
			comm.CommandType = ct;
			try
			{
				comm.ExecuteNonQuery();
				f = true;
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}
			finally
			{
				conn.Close();
			}
			return f;
		}
	}
}
