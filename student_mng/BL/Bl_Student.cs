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

		public Student LaySinhVien(string maSinhVien) 
		{
            string sqlString = "SELECT * FROM Student WHERE studentId = '" + maSinhVien + "'";

            DataSet ds =  db.ExecuteQueryDataSet(sqlString, CommandType.Text);
			DataTable dtStudent = ds.Tables[0];
			if (dtStudent.Rows.Count > 0)
			{
				Student stu = new Student();
                string id = dtStudent.Rows[0][0].ToString();
                string username = dtStudent.Rows[0][1].ToString();
                string mk = dtStudent.Rows[0][2].ToString();
                string fullName = dtStudent.Rows[0][3].ToString();
                string birthday = dtStudent.Rows[0][4].ToString();
                string sex = dtStudent.Rows[0][5].ToString();
                string phone = dtStudent.Rows[0][6].ToString();
                string address = dtStudent.Rows[0][7].ToString();

                stu.StudentId = id;
                stu.Username = username;
                stu.Password = mk;
                stu.FullName = fullName;
                stu.Birthday = DateTime.Parse(birthday);
                stu.Sex = sex;
                stu.Phone = phone;
                stu.Address = address;
				return stu;
            }
            return null;
		}
	}
}
