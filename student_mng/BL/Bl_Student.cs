using student_mng.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

			string sqlString = "SELECT * FROM Student WHERE username = '" + maHocSinh + "'";

			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}

		public DataSet LayDataMonHoc()
		{
			return db.ExecuteQueryDataSet("select * from Course", CommandType.Text);
		}

		public bool DangKiMon(string maLop, string maSv,string diem, ref string err)
		{
			string sqlString = "Insert Into Attending Values(" + "'" +
			maLop + "',N'" +
			maSv + "',N'" +
			diem + "')";
			return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
		}

		public DataSet LayLopTuMaSV(string maSv)
		{
			string sqlString = $"EXECUTE Proc_GetCoursesByStudentId '{maSv}'";
			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}
		
		
	}
}
