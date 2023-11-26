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

		/*public DataTable ThongTinSinhVien(string maLop, string maSv)
		{
			DataTable dt = new DataTable();
			string query = $"EXECUTE Proc_GetStudentInfoByStudentAndCourse '{maLop}', '{maSv}'";
			dt = db.ExecuteQueryDataSet(query, CommandType.Text).Tables[0];
			return dt;
		}*/
		public DataSet TimSinhVien(string maLop, string maSv)
		{

			string sqlString = $"EXECUTE Proc_GetStudentInfoByStudentAndCourse '{maLop}', '{maSv}'";
			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}

		public DataSet TimListSinhVien(string maLop)
		{

			string sqlString = $"EXECUTE Proc_GetStudentsInCourse '{maLop}'";
			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}
	}
}
