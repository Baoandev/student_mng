using student_mng.DB;
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
