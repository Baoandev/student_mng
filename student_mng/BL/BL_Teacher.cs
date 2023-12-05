using student_mng.DB;
using student_mng.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_mng.BL
{
	public class BL_Teacher
	{
		DBMain db = null;
		public string TaiKhoan { get; private set; }

		public BL_Teacher()
		{
			db = new DBMain();
		}
		public DataSet DangNhap(string taikhoan)
		{

			string sqlString = "SELECT * FROM Teacher WHERE username = '" + taikhoan + "'";

			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
			
		}
		
		public DataSet TimSinhVien(string maLop, string maSv)
		{

			string sqlString = $"EXECUTE Proc_LaySinhVienTuCourse '{maLop}', '{maSv}'";
			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}

		public DataSet TimListSinhVien(string maLop)
		{
			string sqlString = $"EXECUTE Proc_LayListSinhVienTrongCourse '{maLop}'";
			return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
		}
		
		public bool ChamDiem(Grade gr)
		{
			db.OpenConnect();
			SqlCommand cmd = new SqlCommand("EXEC Proc_ChamDiem @courseId,@studentId,@grade", db.OpenConnect());
			cmd.Parameters.AddWithValue("@courseId", gr.MaLop);
			cmd.Parameters.AddWithValue("@studentId", gr.MaSv);
			cmd.Parameters.AddWithValue("@grade", gr.Diem);
			int rowsAffected = cmd.ExecuteNonQuery();
			db.CloseConnect();
			return rowsAffected > 0;
		}
		public DataTable layMaLop()
		{
			DataSet ds = new DataSet();
			ds = db.ExecuteQueryDataSet("SELECT courseId FROM Course", CommandType.Text);
			return ds.Tables[0];
		}
		public DataTable ThongTinLop(string maGv)
		{
			DataTable dt = new DataTable();
			string query = "SELECT courseId FROM Course WHERE teacherId = '" + maGv + "'";
			dt = db.ExecuteQueryDataSet(query, CommandType.Text).Tables[0];
			return dt;
		}
	}
}
