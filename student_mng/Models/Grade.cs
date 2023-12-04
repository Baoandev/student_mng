using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Grade
	{
		private string maLop;
		private string maSv;
		private int diem;

		public string MaLop { get => maLop; set => maLop = value; }
		public string MaSv { get => maSv; set => maSv = value; }
		public int Diem { get => diem; set => diem = value; }
	}
}
