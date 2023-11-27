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
		public bool ChamDiem(string maLop, string maSv,int diem, ref string err )
		{
			string sqlString = "Insert Into Attending Values(" + "'" +
			maLop + "',N'" +
			maSv + "',N'" +
			diem + "')";
			return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
		}
	}
}
