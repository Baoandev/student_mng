using student_mng.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.BL
{
	public class BL_Admin
	{
		DBMain db = null;
		public BL_Admin()
		{
			db = new DBMain();
		}
		public DataSet DangNhap(string admin)
		{

			string sqlString = "SELECT * FROM AdminAccount WHERE username = '" + admin + "'";

			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}
	}
}
