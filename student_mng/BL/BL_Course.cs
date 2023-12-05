using student_mng.DB;
using student_mng.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.BL
{
	public class BL_Course
	{
		DBMain db = null;
		public BL_Course()
		{
			db = new DBMain();
		}
		public bool ThemMonHoc(Course cou)
		{
			db.OpenConnect();
			SqlCommand cmd = new SqlCommand("EXEC Proc_ThemMonHoc @TenMonHoc,@IdGiaoVien,@NgayBatDau,@NgayKetThuc", db.OpenConnect());
			cmd.Parameters.AddWithValue("@TenMonHoc", cou.CourseName);
			cmd.Parameters.AddWithValue("@IdGiaoVien", cou.TeacherId);
			cmd.Parameters.AddWithValue("@NgayBatDau", cou.NgayBatDau);
			cmd.Parameters.AddWithValue("@NgayKetThuc", cou.NgayKetThuc);
			int rowsAffected = cmd.ExecuteNonQuery();
			db.CloseConnect();
			return rowsAffected > 0;
		}
		public bool XoaMonHoc(ref string err, string maMonHoc)
		{
			string sqlString = "Delete From Course Where courseId='" + maMonHoc + "'";
			return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
		}
		public bool XoaMon(ref string err, string maMonHoc)
		{
			string sqlString = "Delete From Attending Where courseId='" + maMonHoc + "'";
			return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
		}
		public DataSet TimMonHocTheoMaGiangVien(string maGV)
		{
			string sqlString = "SELECT * FROM Course  WHERE teacherId = '" + maGV + "'";
			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}
		public DataTable layTenMonHoc()
		{
			DataSet ds = new DataSet();
			ds = db.ExecuteQueryDataSet("SELECT courseName FROM Course", CommandType.Text);
			return ds.Tables[0];
		}
		public DataTable layMaGiangVien()
		{
			DataSet ds = new DataSet();
			ds = db.ExecuteQueryDataSet("SELECT teacherId FROM Course", CommandType.Text);
			return ds.Tables[0];
		}
	}
}
