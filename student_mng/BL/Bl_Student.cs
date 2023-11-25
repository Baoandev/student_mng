using student_mng.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.BL
{
	public class Bl_Student
	{
		DBMain db = null;
		public Bl_Student()
		{
			db = new DBMain();
		}
		public DataSet DangNhap(string maHocSinh)
		{

			string sqlString = "SELECT * FROM StudentAccount WHERE username = '" + maHocSinh + "'";

			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}

	}
}
