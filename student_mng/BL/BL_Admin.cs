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

		public bool ThemSinhVien(Student stu)
		{
			db.OpenConnect();
			SqlCommand cmd = new SqlCommand("EXEC Proc_InsertStudentData @username,@password,@fullname,@birthday,@sex,@phone,@address", db.OpenConnect());

			cmd.Parameters.AddWithValue("@username", stu.Username);
			cmd.Parameters.AddWithValue("@password", stu.Password);
			cmd.Parameters.AddWithValue("@fullname", stu.FullName);
			cmd.Parameters.AddWithValue("@birthday", stu.Birthday);
			cmd.Parameters.AddWithValue("@sex", stu.Sex);
			cmd.Parameters.AddWithValue("@phone", stu.Phone);
			cmd.Parameters.AddWithValue("@address", stu.Address);

			int rowsAffected = cmd.ExecuteNonQuery();
			db.CloseConnect();
			return rowsAffected > 0;
		}
	}
}
