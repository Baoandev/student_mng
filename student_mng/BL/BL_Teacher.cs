using student_mng.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.BL
{
	public class BL_Teacher
	{
		DBMain db = null;
		public BL_Teacher()
		{
			db = new DBMain();
		}
		public DataSet DangNhap(string maGiaoVien)
		{

			string sqlString = "SELECT * FROM TeacherAccount WHERE username = '" + maGiaoVien + "'";

			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}

	}
}
